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
    public partial class frmStateOfDue : Form
    {
        public frmStateOfDue()
        {
            InitializeComponent();
        }

        private void frmStateOfDue_Load(object sender, EventArgs e)
        {
            BringAndSearchCompleted();// İadesi tamamlanmış (geçmiş) kayıtları listeler
            BringAndSearchNotCompleted();// Henüz iade edilmemiş (aktif ödünç) kayıtları listeler
        }

        // Kitabını geri getirmiş olan üyelerin geçmiş kayıtlarını (bl.Status = 0) çeker.
        void BringAndSearchCompleted()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                // SQL Sorgusu: Üye, Kitap ve Ödünç tablolarını birleştirerek iadesi bitmiş kayıtları getirir.
                // Filtreleme: İsim, Öğrenci No veya Kitap Adına göre arama kutusundaki (tbxSearchInCompleted) kelimeyi arar.
                string queryForCompleted = "SELECT bl.LoanId, au.FirstName, au.LastName, au.StudentId, b.BookName, bl.LoanDate, bl.DueDate, bl.ReturnDate FROM BookLoans bl\r\nINNER JOIN AppUsers au\r\nON au.UserId = bl.UserId\r\nINNER JOIN Books b\r\nON b.BookId = bl.BookId\r\nWHERE bl.Status = 0\r\nAND (au.FirstName + ' ' + au.LastName LIKE @keyWord OR au.StudentId LIKE @keyWord OR b.BookName LIKE @keyWord)";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(queryForCompleted, conn))
                {
                    cmd.Parameters.AddWithValue("@keyWord", '%' + tbxSearchInCompleted.Text + '%');
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    dgwCompletedReturns.DataSource = dataSet.Tables[0];
                }
            }
        }

        // Kitabı hala elinde bulunduran (bl.Status = 1) üyelerin aktif ödünç kayıtlarını çeker.
        void BringAndSearchNotCompleted()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                // SQL Sorgusu: Durumu aktif (Status = 1) olan ve henüz teslim tarihi girilmemiş kayıtları listeler.
                string queryForNotCompleted = "SELECT bl.LoanId, au.FirstName, au.LastName, au.StudentId, b.BookName, bl.LoanDate, bl.DueDate FROM BookLoans bl\r\nINNER JOIN AppUsers au\r\nON au.UserId = bl.UserId\r\nINNER JOIN Books b\r\nON b.BookId = bl.BookId\r\nWHERE bl.Status = 1 \r\nAND (au.FirstName + ' ' + au.LastName LIKE @keyWord OR au.StudentId LIKE @keyWord OR b.BookName LIKE @keyWord)";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(queryForNotCompleted, conn))
                {
                    cmd.Parameters.AddWithValue("@keyWord", '%' + tbxSearchInNotCompleted.Text + '%');
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    dgwNotCompletedReturns.DataSource = dataSet.Tables[0];
                }
            }
        }

        // Tamamlanmış iadeler arama kutusuna yazı yazıldığında listeyi günceller

        private void tbxSearchInCompleted_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxSearchInCompleted.Text))
            {
                BringAndSearchCompleted();
            }
        }

        // Bekleyen iadeler arama kutusuna yazı yazıldığında listeyi günceller
        private void tbxSearchInNotCompleted_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxSearchInNotCompleted.Text))
            {
                BringAndSearchNotCompleted();
            }
        }
        // Henüz teslim edilmemiş bir kitaba tıklandığında, bilgileri detay kutucuklarına doldurur.
        private void dgwNotCompletedReturns_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedLoanId = Convert.ToInt32(dgwNotCompletedReturns.CurrentRow.Cells[0].Value);
            tbxFirstName.Text = dgwNotCompletedReturns.CurrentRow.Cells[1].Value.ToString();
            tbxLastName.Text = dgwNotCompletedReturns.CurrentRow.Cells[2].Value.ToString();
            tbxBookName.Text = dgwNotCompletedReturns.CurrentRow.Cells[4].Value.ToString();
            tbxDueDate.Text = dgwNotCompletedReturns.CurrentRow.Cells[6].Value.ToString();
            tbxLoanDate.Text = dgwNotCompletedReturns.CurrentRow.Cells[5].Value.ToString();
        }
        int _selectedLoanId;


        // 'İade Al' butonuna basıldığında kitabın durumunu pasife çekip bugünün tarihini iade tarihi olarak kaydeder.
        private void btnReturnProccesDone_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan iadeyi onaylaması istenir
            DialogResult res = MessageBox.Show("İade işlemini tamamlamak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                using (SqlConnection conn = SqlCon.Connect())
                {
                    conn.Open();

                    // Sorgu: BookLoans tablosundaki ilgili kaydın durumunu '0' (Tamamlandı) yapar ve ReturnDate alanına şimdiki zamanı yazar.
                    string doneQuery = "UPDATE BookLoans SET Status = 0, ReturnDate = @returnDate WHERE LoanId=@loanId";
                    using (SqlCommand cmd = new SqlCommand(doneQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@returnDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@loanId", _selectedLoanId);
                        cmd.ExecuteNonQuery();

                        // Veritabanı güncellendikten sonra iki tabloyu da yenileyerek son durumları listeler
                        BringAndSearchCompleted();
                        BringAndSearchNotCompleted();

                        MessageBox.Show("Öğrencinin iade işlemi tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        cmd.Parameters.AddWithValue("@keyWord", '%' + tbxSearchInNotCompleted.Text + '%');
                    }
                }
            }
        }
    }
}
