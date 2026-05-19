using FluentValidation.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KutuphaneTakipUygulamasi
{
    // Üye yönetim ve listeleme formu (frmMembers)
    public partial class frmMembers : Form
    {
        public frmMembers()
        {
            InitializeComponent();
        }

        // 'Ekle' butonuna tıklandığında hem AppUsers hem de UserRoles tablosuna güvenli (Transaction) kayıt yapar.
        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();

                // SQL Transaction başlatma.
                // Amaç: Kullanıcı eklenirken bir hata çıkarsa veya rol atanamazsa yapılan tüm işlemleri geri alıp (Rollback) veri tutarsızlığını önlemek.
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    // Kullanıcı ekleme sorgusu. 'SELECT SCOPE_IDENTITY()' ile yeni eklenen kullanıcının otomatik artan ID'sini geri alıyoruz.
                    string queryForUser = "INSERT INTO AppUsers (FirstName,LastName,StudentId,UserName,Password, BirthDate,Gender) VALUES (@firstName,@lastName,@studentId,@username,@password,@birthDate,@gender);SELECT SCOPE_IDENTITY();";
                    using (SqlCommand cmdForUser = new SqlCommand(queryForUser, conn, transaction))
                    {
                        // Formdaki kontrollerden değerleri parametre olarak ekliyoruz
                        cmdForUser.Parameters.AddWithValue("@firstName", tbxFirstName.Text);
                        cmdForUser.Parameters.AddWithValue("@lastName", tbxLastName.Text);
                        cmdForUser.Parameters.AddWithValue("@studentId", tbxStudentId.Text);
                        cmdForUser.Parameters.AddWithValue("@username", "deneme");
                        cmdForUser.Parameters.AddWithValue("@password", "deneme");
                        cmdForUser.Parameters.AddWithValue("@birthDate", dtpBirthDate.Value);

                        // Cinsiyet seçimi kontrolü (rbMan seçiliyse true, değilse false)
                        bool gender;
                        gender = rbMan.Checked ? true : false;
                        cmdForUser.Parameters.AddWithValue("@gender", gender);

                        // Sorguyu çalıştırıp yeni oluşan UserId'yi alıyoruz
                        int insertedUserId = Convert.ToInt32(cmdForUser.ExecuteScalar());

                        // Yeni kullanıcıya rol atayan yardımcı metodu çağırıyoruz (3 = Üye Rolü)
                        AssignRoleToUser(conn, transaction, insertedUserId, 3);

                        // İki işlem de sorunsuz tamamlandıysa veritabanına kalıcı olarak kaydet
                        transaction.Commit();
                        MessageBox.Show("Veriler eklendi.");
                    }
                }
                catch (Exception ex)
                {
                    // Herhangi bir adımda hata oluşursa yapılan tüm işlemleri iptal et ve geri al
                    transaction.Rollback();
                    MessageBox.Show("Hata" + ex.Message);
                }
            }
        }

        // Kullanıcıya rol atamak için kullanılan yardımcı metot (Transaction'a dahil)
        private void AssignRoleToUser(SqlConnection conn, SqlTransaction transaction, int insertedUserId, int roleId)
        {
            string queryForRole = "INSERT INTO UserRoles (RoleId,UserId) VALUES (@roleId,@userId)";
            using (SqlCommand cmdForRole = new SqlCommand(queryForRole, conn, transaction))
            {
                cmdForRole.Parameters.AddWithValue("@roleId", roleId);
                cmdForRole.Parameters.AddWithValue("@userId", insertedUserId);
                cmdForRole.ExecuteNonQuery();
            }
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            // Mevcut üyeleri listele
            BringAndSearchMemberDatas();

            // Güncelleme grup kutusunun (gbxUpdate) içindeki TextBox'ları başlangıçta kilitler
            foreach (Control item in gbxUpdate.Controls)
            {
                if (item is TextBox)
                {
                    item.Enabled = false;

                }
            }
        }

        // Veritabanından durumu aktif (Status = 1) olan üyeleri ve rollerini getirir, arama kutusuna göre filtreler.
        private void BringAndSearchMemberDatas()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();

                // STRING_AGG fonksiyonu ile bir kullanıcının birden fazla rolü varsa aralarına virgül koyarak tek satırda birleştirir.
                string query = "SELECT \r\n au.UserId, au.FirstName, au.LastName,\r\nSTRING_AGG(ar.RoleName, ', ') as Roles\r\n,au.StudentId, au.BirthDate\r\nFROM AppUsers au\r\nINNER JOIN UserRoles ur\r\nON ur.UserId = au.UserId\r\nINNER JOIN AppRoles ar\r\nON ar.RoleId = ur.RoleId\r\nWHERE au.Status = 1 GROUP BY \r\nau.UserId, au.FirstName,au.LastName,au.StudentId,au.BirthDate\r\nHAVING (au.FirstName + ' ' + au.LastName LIKE @memberName) OR (au.StudentId LIKE @studentId)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // SQL'deki LIKE '%aranan%' yapısı için parametreleri hazırlıyoruz
                    cmd.Parameters.AddWithValue("@memberName", '%' + tbxMember.Text + '%');
                    cmd.Parameters.AddWithValue("@studentId", '%' + tbxMember.Text + '%');

                    // Verileri çekip DataGridView'e doldurma işlemi
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);

                    // Tabloyu ekrandaki ızgaraya bağlama
                    dgwMembers.DataSource = dataSet.Tables[0];
                }
            }
        }

        // Arama kutusuna her harf yazıldığında veya silindiğinde tetiklenir
        private void tbxMember_TextChanged(object sender, EventArgs e)
        {
            // Eğer arama kutusu boş değilse filtrelemeyi yeniden çalıştırır
            if (!string.IsNullOrEmpty(tbxMember.Text))
            {
                BringAndSearchMemberDatas();
            }
        }

        // Seçilen kullanıcının ID'sini hafızada tutmak için global değişken
        int _selectedUserId;
        // --- TABLODAN SATIR SEÇİMİ ---
        // DataGridView'de bir hücreye tıklandığında seçili satırın bilgilerini yandaki güncelleme kutucuklarına doldurur.
        private void dgwMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sütun indekslerine göre (0: UserId, 1: FirstName, 2: LastName, vb.) verileri kutulara aktarıyoruz
            _selectedUserId = Convert.ToInt32(dgwMembers.CurrentRow.Cells[0].Value);
            tbxUpdateName.Text = dgwMembers.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateLastName.Text = dgwMembers.CurrentRow.Cells[2].Value.ToString();
            tbxUpdateStudentId.Text = dgwMembers.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateRoles.Text = dgwMembers.CurrentRow.Cells[4].Value.ToString();
        }

        // Üyeyi veritabanından tamamen silmez, durumunu pasif (Status = 0) yapar. Böylece geçmiş kayıtlar korunur.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();
                string query = "UPDATE AppUsers SET Status = 0 WHERE UserId = @userId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", _selectedUserId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seçili üye silindi.");
                    BringAndSearchMemberDatas();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // GÜNCELLEME EKRANINI AÇMA 
            frmUpdateMembers frmUpdateMembers = new frmUpdateMembers(_selectedUserId);
            frmUpdateMembers.ShowDialog();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }
    }
}
