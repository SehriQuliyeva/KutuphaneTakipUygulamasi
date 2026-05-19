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
    public partial class frmBookLoans : Form
    {
        // Kitap bilgileri kutusunun (gbxBooks) içindeki TextBox'ları kilitler
        void ChangeStatusOfBookControllers()
        {
            foreach (Control item in gbxBooks.Controls)
            {
                if (item is TextBox)
                {
                    item.Enabled = false;
                }
            }
        }
        public frmBookLoans()
        {
            InitializeComponent();
        }

        // Üye bilgileri kutusunun (gbxMembers) içindeki TextBox'ları kilitler (Salt Okunur yapar)
        void ChangeStatusOfMemberControllers()
        {
            foreach (Control item in gbxMembers.Controls)
            {
                if (item is TextBox)
                {
                    item.Enabled = false;
                }
            }
        }

        private void frmBookLoans_Load(object sender, EventArgs e)
        {
            // Aktif kitapları listele
            BringAndSearchBooks();

            // Kitap metin kutularını kilitler
            ChangeStatusOfBookControllers();
            
            // Üye metin kutularını kilitler
            ChangeStatusOfMemberControllers();
            
            // Aktif üyeleri listele
            BringAndSearchMembers();
        }
        
        private void BringAndSearchMembers()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();

                // Durumu aktif (Status = 1) olan üyeleri, isimlerine veya öğrenci numaralarına göre filtreleyerek çeker
                string query = "SELECT \r\n au.UserId, au.FirstName, au.LastName,\r\nSTRING_AGG(ar.RoleName, ', ') as Roles\r\n,au.StudentId, au.BirthDate\r\nFROM AppUsers au\r\nINNER JOIN UserRoles ur\r\nON ur.UserId = au.UserId\r\nINNER JOIN AppRoles ar\r\nON ar.RoleId = ur.RoleId\r\nWHERE au.Status = 1 GROUP BY \r\nau.UserId, au.FirstName,au.LastName,au.StudentId,au.BirthDate\r\nHAVING (au.FirstName + ' ' + au.LastName LIKE @memberName) OR (au.StudentId LIKE @studentId)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@memberName", '%' + tbxSearchMember.Text + '%');
                    cmd.Parameters.AddWithValue("@studentId", '%' + tbxSearchMember.Text + '%');
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);

                    // Sonuçları üye tablosuna yansıtır
                    dgwMembers.DataSource = dataSet.Tables[0];
                }
            }
        }

        // Sonuçları üye tablosuna yansıtır
        void BringAndSearchBooks()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();

                // Kitap adı veya Yazar adına göre arama yaparak stok miktarıyla birlikte aktif kitapları getirir
                string queryForDatas = "select Books.BookId as Id,Books.BookName as Kitap, Authors.AuthorId ,Authors.FirstName + ' ' + Authors.LastName as Yazar, Books.QuantityStocks from Books\r\ninner join BookAuthors\r\non Books.BookId = BookAuthors.BookId\r\ninner join Authors \r\non Authors.AuthorId = BookAuthors.AuthorId\r\nwhere (Books.BookName LIKE @Words OR Authors.FirstName + ' ' + Authors.LastName LIKE @Words) AND Books.Status = 1";
                using (SqlCommand cmd = new SqlCommand(queryForDatas, conn))
                {
                    cmd.Parameters.AddWithValue("@Words", '%' + tbxSearchBook.Text + '%');
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);

                    // Sonuçları kitap tablosuna yansıtır
                    dgwBooks.DataSource = dataSet.Tables[0];
                }
            }
        }

        // Kitap arama kutusuna yazı yazıldığında listeyi günceller
        private void tbxSearchBook_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearchBook.Text != string.Empty)
            {
                BringAndSearchBooks();
            }
        }

        // Seçilen kitabın ID'sini tutan global değişken
        int _selectedBookId;

        // Kitaplar listesinden bir satıra tıklandığında bilgileri sol taraftaki kilitli kutulara doldurur
        private void dgwBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedBookId = Convert.ToInt32(dgwBooks.CurrentRow.Cells[0].Value);
            tbxBookName.Text = dgwBooks.CurrentRow.Cells[1].Value.ToString();
            tbxAuthorName.Text = dgwBooks.CurrentRow.Cells[3].Value.ToString();
            tbxStock.Text = dgwBooks.CurrentRow.Cells[4].Value.ToString();
        }

        // Üye arama kutusuna yazı yazıldığında listeyi günceller
        private void tbxSearchMember_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearchMember.Text != string.Empty)
            {
                BringAndSearchMembers();
            }
        }

        // Seçilen üyenin ID'sini tutan global değişken
        int _selectedMemberId;

        // --- ÜYE SEÇİMİ ---
        // Üyeler listesinden bir satıra tıklandığında bilgileri sağ taraftaki kilitli kutulara doldurur
        private void dgwMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedMemberId = Convert.ToInt32(dgwMembers.CurrentRow.Cells[0].Value);
            tbxFirstName.Text = dgwMembers.CurrentRow.Cells[1].Value.ToString();
            tbxLastName.Text = dgwMembers.CurrentRow.Cells[2].Value.ToString();
            tbxStudentId.Text = dgwMembers.CurrentRow.Cells[4].Value.ToString();

            // Tarih verisini formatlayarak (Gün/Ay/Yıl) metin kutusuna aktarır
            DateTime birthDate = Convert.ToDateTime(dgwMembers.CurrentRow.Cells[5].Value);
            tbxBirthDate.Text = birthDate.ToString("dd/MM/yyyy");
        }

        // --- ÖDÜNÇ VERME İŞLEMİNİ TAMAMLAMA ---
        private void btnProccessDone_Click(object sender, EventArgs e)
        {
            // Önce geçerli bir üye, kitap seçilip seçilmediği ve teslim tarihinin bugünden sonra olup olmadığı kontrol edilir
            if (_selectedMemberId < 0 || _selectedBookId < 0 || dtpDueDate.Value < DateTime.Now.AddDays(1))
            {
                MessageBox.Show("Öncelikle kitap, üye ve tarih bilgilerinin doğru olduğundan emin olunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // İşlem öncesi kullanıcıya hangi kitaba hangi üyeye ödünç verileceğine dair onay penceresi açılır
                DialogResult result = MessageBox.Show($"Kaydı tamamlamak istediğinizden emin misiniz?\nKitap: {tbxBookName.Text.ToString()}\nÜye: {tbxFirstName.Text.ToString() + " " + tbxLastName.Text.ToString()}", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = SqlCon.Connect())
                    {
                        conn.Open();

                        // İşlem öncesi kullanıcıya hangi kitaba hangi üyeye ödünç verileceğine dair onay penceresi açılır
                        string insertQuery = "INSERT INTO BookLoans (UserId,BookId,LoanDate,DueDate) VALUES (@userId,@bookId,@loanDate,@dueDate)";
                        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@userId", _selectedMemberId);
                            cmd.Parameters.AddWithValue("@bookId", _selectedBookId);
                            cmd.Parameters.AddWithValue("@loanDate", DateTime.Now);

                            //DateTimePicker'dan gelen tarih
                            cmd.Parameters.AddWithValue("@dueDate", dtpDueDate.Value);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Ödünç alma işlemi tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        // --- İADE SÜRESİ GEÇENLER / TESLİM DURUMU EKRANI ---
        private void btnStateOfDue_Click(object sender, EventArgs e)
        {
            frmStateOfDue frmStateOfDue = new frmStateOfDue();

            // İade durum kontrolü formunu açar
            frmStateOfDue.ShowDialog();
        }

        // --- ÜYENİN GEÇMİŞ İŞLEMLERİ (ÖDÜNÇ GEÇMİŞİ) ---
        private void btnHistory_Click(object sender, EventArgs e)
        {
            // Geçmişi görebilmek için listeden bir üyenin seçilmiş olması şartı
            if (_selectedMemberId < 0)
            {
                MessageBox.Show("Lütfen  geçerli bir kullanıcı seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Seçili üyenin ID'sini geçmiş işlemler formuna (`frmPastTransactions`) parametre olarak göndererek açar
                frmPastTransactions pastTransactions = new frmPastTransactions(_selectedMemberId);
                pastTransactions.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }
    }
}