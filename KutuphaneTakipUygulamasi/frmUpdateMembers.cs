using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Transactions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KutuphaneTakipUygulamasi
{
    public partial class frmUpdateMembers : Form
    {
        int _selectedUserId;
        public frmUpdateMembers(int selectedUserId)
        {
            InitializeComponent();
            _selectedUserId = selectedUserId;
        }

        private void frmUpdateMembers_Load(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifre metin kutularını erişilebilir (yazılabilir) yapar
            tbxUserName.Enabled = true;
            tbxPassword.Enabled = true;

            // Üyenin mevcut verilerini veritabanından getirip form alanlarına doldurur
            LoadDatas();
        }
        private void LoadDatas()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();

                // SQL Sorgusu: Seçilen kullanıcının tablodaki tüm kişisel, rol ve giriş bilgilerini gruplayarak çeker
                string query = "SELECT \r\nau.UserId, au.FirstName, au.LastName,\r\nSTRING_AGG(ar.RoleName, ', ') as Roles,\r\nau.StudentId, au.BirthDate,au.Gender,au.UserName,au.Password\r\nFROM AppUsers au\r\nINNER JOIN UserRoles ur\r\nON ur.UserId = au.UserId\r\nINNER JOIN AppRoles ar\r\nON ar.RoleId = ur.RoleId\r\nWHERE au.UserId = @userId\r\nGROUP BY \r\nau.UserId, au.FirstName,au.LastName,au.StudentId,au.BirthDate,au.Gender,au.UserName,au.Password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", _selectedUserId);
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        // Veritabanında eşleşen üye kaydı bulunduysa form nesnelerine yazdır
                        if (dr.Read())
                        {
                            tbxFirstName.Text = dr["FirstName"].ToString();
                            tbxLastName.Text = dr["LastName"].ToString();
                            tbxStudentId.Text = dr["StudentId"].ToString();
                            dtpBirthDate.Value = Convert.ToDateTime(dr["BirthDate"]);

                            // Cinsiyet bilgisini mantıksal (bool) değer olarak alıp RadioButton'ları ayarlar
                            bool gender = Convert.ToBoolean(dr["Gender"]);
                            if (gender == true)
                            {
                                rbMan.Checked = true;
                            }
                            else
                            {
                                rbWoman.Checked = true;
                            }
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();

                // Birden fazla ilişkili tablo işleminde veri kaybını/tutarsızlığını önlemek için Transaction başlatıyoruz
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    string query = "UPDATE AppUsers SET FirstName = @firstName, LastName = @lastName,StudentId = @studentId,UserName = @userName,Password = @password,BirthDate= @birthDate,Gender =@gender WHERE UserId = @userId;";

                    using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@firstName", tbxFirstName.Text);
                        cmd.Parameters.AddWithValue("@lastName", tbxLastName.Text);
                        cmd.Parameters.AddWithValue("@studentId", tbxStudentId.Text);
                        cmd.Parameters.AddWithValue("@username", tbxUserName.Text);
                        cmd.Parameters.AddWithValue("@password", tbxPassword.Text);
                        cmd.Parameters.AddWithValue("@birthDate", dtpBirthDate.Value);
                        cmd.Parameters.AddWithValue("@userId", _selectedUserId);

                        bool gender;

                        // Cinsiyet seçimine göre veritabanına true/false gönderimi
                        gender = rbMan.Checked ? true : false;
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.ExecuteNonQuery();
                        AssignRoleToUser(conn, transaction, _selectedUserId, 3);

                        // Tüm işlemler hatasız tamamlandıysa veritabanı değişikliklerini kalıcı yap
                        transaction.Commit();
                        MessageBox.Show("Kişi güncellendi.", "Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        // Güncelleme esnasında kullanıcıya rol tanımlamak/yenilemek için kullanılan yardımcı metot
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}