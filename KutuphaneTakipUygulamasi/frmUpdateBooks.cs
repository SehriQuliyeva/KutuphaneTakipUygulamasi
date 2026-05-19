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
    public partial class frmUpdateBooks : Form
    {
        private int _selectedBookId, _selectedAuthorId;
        public frmUpdateBooks(int selectedBookId, int selectedAuthorId)
        {
            InitializeComponent();
            _selectedBookId = selectedBookId;
            _selectedAuthorId = selectedAuthorId;
        }

        // Kitabın yeni yazarını seçebilmek için açılır kutuyu (ComboBox) tüm yazarlarla doldurur
        void ListAuthors()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();
                string queryForAuthor = "SELECT AuthorId, FirstName +' ' + LastName AS FullName FROM Authors";
                using (SqlCommand cmd = new SqlCommand(queryForAuthor, conn))
                {
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(dataReader);
                        cbxAuthorName.DataSource = dataTable;
                        cbxAuthorName.DisplayMember = "FullName";
                        cbxAuthorName.ValueMember = "AuthorId";
                    }
                }
            }
        }

        // Güncellenecek kitabın veritabanındaki kayıtlı bilgilerini çekip form elemanlarına doldurur
        void BringOtherDatas()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();
                string queryForDatas = "SELECT * FROM Books WHERE BookId = @bookId";
                using (SqlCommand cmd = new SqlCommand(queryForDatas, conn))
                {
                    cmd.Parameters.AddWithValue("@bookId", _selectedBookId);
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {

                        // Eğer kitap kaydı bulunduysa form nesnelerini doldur
                        if (dataReader.Read())
                        {
                            tbxBookName.Text = dataReader["BookName"].ToString();
                            numStock.Value = Convert.ToInt16(dataReader["QuantityStocks"]);

                            // Kitabın aktiflik/silinme durumunu kontrol et
                            bool isDeleted = Convert.ToBoolean(dataReader["Status"]);

                            // Status = true (1) ise aktif, false (0) ise silinmiş/pasif kabul edilir
                            if (isDeleted == true)
                            {
                                rbNotDeleted.Checked = true;// Silinmemiş (Aktif) RadioButton'ı seç
                            }
                            else
                            {
                                rbDeleted.Checked = true;// Silinmiş (Pasif) RadioButton'ı seç
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bir hata oluştu");
                        }
                    }
                }
            }
        }

        // Kullanıcının form üzerinde yaptığı değişiklikleri veritabanına kaydeder
        void UpdateDatas()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                bool isUpdated = false;// Yazar güncellemesinin durumunu takip eden kontrol değişkeni
                conn.Open();

                // 1. ADIM: Kitap ve Yazar ilişkisini tutan ara tabloyu (BookAuthors) güncelle
                string queryForAuthors = "UPDATE BookAuthors SET AuthorId =@authorId WHERE BookID = @bookId";

                using (SqlCommand cmd = new SqlCommand(queryForAuthors, conn))
                {
                    cmd.Parameters.AddWithValue("@authorId", cbxAuthorName.SelectedValue);
                    cmd.Parameters.AddWithValue("@bookId", _selectedBookId);
                    cmd.ExecuteNonQuery();

                    isUpdated = true;
                }

                // Kitabın kendi tablosundaki (Books) ad, stok ve durum bilgilerini güncelle
                string queryForUpdate = " UPDATE Books SET BookName = @bookName, QuantityStocks = @stock, Status = @status WHERE BookId = @bookId";

                using (SqlCommand cmd = new SqlCommand(queryForUpdate, conn))
                {
                    cmd.Parameters.AddWithValue("@bookName", tbxBookName.Text);
                    cmd.Parameters.AddWithValue("@stock", Convert.ToInt16(numStock.Value));
                    cmd.Parameters.AddWithValue("@bookId", _selectedBookId);

                    // Silinmiş seçeneği işaretliyse Status alanını false (0), değilse true (1) yap
                    if (rbDeleted.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@status", false);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@status", true);
                    }

                    // Eğer ilk adımdaki yazar güncellemesi yapıldıysa Books tablosunu da güncelle
                    if (isUpdated == true)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Veriler başarıyla güncellendi.");
                    }
                }
            }
        }
        private void frmUpdateBooks_Load(object sender, EventArgs e)
        {
            ListAuthors();

            // Kitabın mevcut yazarını combobox üzerinde otomatik olarak seçili getir
            cbxAuthorName.SelectedValue = _selectedAuthorId;

            // Kitabın diğer verilerini (Ad, stok, durum) alanlara doldur
            BringOtherDatas();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDatas();
        }
    }
}
