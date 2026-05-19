using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // Veritabanı işlemleri (SQL Server) için gerekli kütüphane
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KutuphaneTakipUygulamasi
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği bilgileri değişkenlere aktarıyoruz
            string username = KullaniciAdi.Text;
            string password = Sifre.Text;

            // 1. Boşluk kontrolü (Trim() ile sağdaki/soldaki boşluklar elenir)
            // 2. İçeride boşluk karakteri olup olmadığı kontrolü (.Contains(" "))
            // 3. Karakter uzunluğu kontrolü (En az 3, en fazla 30 karakter olmalı)
            if (username.Trim().Length == 0 || password.Trim().Length == 0 || username.Contains(" ") || password.Contains(" ") || username.Length < 3 || username.Length > 30 || password.Length < 3 || password.Length > 30)
            {
                //Kullanıcıya uyarı mesajı gösterilir
                MessageBox.Show("Hatalı giriş şekli.Lütfen en az 3 karakter giriniz.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //using kullanımı işlem bittiğinde bağlantının güvenli bir şekilde kapatılmasını sağlar.
                using (SqlConnection connection = SqlCon.Connect())
                {
                    //Veritabanı bağlantısı açılır
                    connection.Open();

                    // ID, Rol ID, Rol Adı ve İsim-Soyisim bilgilerini ilişkili tablolardan (INNER JOIN) çeker.
                    string queryForLogin = "Select TOP(1) au.UserId as UserId, ur.RoleId as RoleId, ar.RoleName as RoleName, au.FirstName +' '+ au.LastName as FullName FROM AppUsers au\r\nINNER JOIN UserRoles ur\r\nON au.UserId = ur.UserId\r\nINNER JOIN AppRoles ar\r\nON ar.RoleId = ur.RoleId\r\nWHERE UserName = @username AND Password = @password";
                    using (SqlCommand cmd = new SqlCommand(queryForLogin, connection))
                    {
                        //Güvenli parametre ataması yapılır
                        cmd.Parameters.AddWithValue("@username", KullaniciAdi.Text);
                        cmd.Parameters.AddWithValue("@password", Sifre.Text);

                        //Sorguyu çalıştırır ve verileri okumak için bir SqlDataReader başlatır
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            //Giriş başarılıysa
                            if (dr.Read())
                            {
                                // Veritabanından gelen bilgileri değişkenlere atıyoruz
                                int UserId = Convert.ToInt32(dr["UserId"]);
                                int roleId = Convert.ToInt32(dr["RoleId"]);
                                string roleName = dr["RoleName"].ToString();
                                string fullName = dr["FullName"].ToString();

                                //Oturum (Session) sınıfına kullanıcının bilgilerini kaydediyoruz.
                                Session.ActiveRoleId = roleId;
                                Session.ActiveRoleName = roleName;
                                Session.ActiveUserId = UserId;
                                Session.ActiveUserName = fullName;

                                //Kullanıcıya başarılı giriş mesajı gösterilir
                                MessageBox.Show($"Hoş geldiniz, {fullName}.\n{roleId}-{roleName}", "Başarılı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Ana formu (frmMain) oluşturur, ekranda gösterir ve giriş formunu gizler
                                frmMain main = new frmMain();
                                main.Show();
                                this.Hide();
                            }
                            else
                            {
                                // Kullanıcı adı veya şifre veritabanıyla eşleşmediyse
                                MessageBox.Show("Başarısız giriş");
                            }
                        }
                    } //SqlCommand burada bellekten temizlenir
                } //Veritabanı bağlantısı (SqlConnection) burada otomatik olarak kapatılır ve temizlenir
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}