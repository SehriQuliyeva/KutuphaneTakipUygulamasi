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
    public partial class frmPastTransactions : Form
    {
        // Diğer formdan (frmBookLoans) gönderilen üye ID'sini bu form içinde kullanmak üzere hafızada tutacak değişken
        int _selectedId;
        public frmPastTransactions(int selectedId)
        {
            InitializeComponent();
            _selectedId = selectedId;
        }

        private void frmPastTransactions_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();

                // SQL Sorgusu: BookLoans (Ödünç), AppUsers (Kullanıcılar) ve Books (Kitaplar) tablolarını birleştirir.
                // Sadece constructor ile gelen `@userId` değerine ait kayıtları filtreler.
                string queryForDatas = "SELECT au.FirstName, au.LastName,au.StudentId, b.BookName, bl.LoanDate, bl.DueDate, bl.ReturnDate FROM BookLoans bl\r\nINNER JOIN AppUsers au\r\nON au.UserId = bl.UserId\r\nINNER JOIN Books b\r\nON b.BookId = bl.BookId\r\nWHERE bl.UserId = @userId";
                using (SqlCommand cmd = new SqlCommand(queryForDatas, conn))
                {
                    // Sorgudaki @userId parametresine hafızadaki üye ID'sini güvenli bir şekilde atıyoruz
                    cmd.Parameters.AddWithValue("@userId", _selectedId);

                    // Veritabanındaki verileri belleğe (DataSet) doldurmak için DataAdapter kullanıyoruz
                    SqlDataAdapter adapter =new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgwPastTransactions.DataSource = ds.Tables[0];

                    // KÜÇÜK BİR NOT: SELECT sorgularında veri okuma/doldurma işlemini zaten 'SqlDataAdapter' üstlenir.
                    // Alttaki 'cmd.ExecuteNonQuery()' satırı veritabanını boş yere tekrar yorar, projenizden silebilirsiniz.

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
