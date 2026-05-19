using System;
using System.Collections.Generic;
using System.ComponentModel;
// Kitap doğrulama kuralları için (FluentValidation)
using KutuphaneTakipUygulamasi.Tools.FluentValidation.Books;
// Kitap nesne modelleri (DTO/Entity) için
using KutuphaneTakipUygulamasi.Objects.Books;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KutuphaneTakipUygulamasi
{
    public partial class frmBooks : Form
    {
        public frmBooks()
        {
            InitializeComponent();
        }

        // Kitap adı veya Yazar adına göre arama yapar, sadece aktif (Status = 1) olanları getirir.
        void BringAndSearchDatas()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();
                // SQL Sorgusu: Books, BookAuthors ve Authors tablolarını JOIN ederek kitap ve yazar bilgilerini birleştirir.
                string queryForDatas = "select Books.BookId as Id,Books.BookName as Kitap, Authors.AuthorId ,Authors.FirstName + ' ' + Authors.LastName as Yazar from Books\r\ninner join BookAuthors\r\non Books.BookId = BookAuthors.BookId\r\ninner join Authors \r\non Authors.AuthorId = BookAuthors.AuthorId\r\nwhere (Books.BookName LIKE @Words OR Authors.FirstName + ' ' + Authors.LastName LIKE @Words) AND Books.Status = 1";
                using (SqlCommand cmd = new SqlCommand(queryForDatas, conn))
                {
                    // LIKE '%aranan kelime%' yapısı ile dinamik filtreleme sağlar
                    cmd.Parameters.AddWithValue("@Words", '%' + tbxSearchBook.Text + '%');
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);

                    // Çekilen verileri DataGridView'e bağlar
                    dgwBooks.DataSource = dataSet.Tables[0];
                }
            }
        }

        // Yeni kitap eklerken yazar seçebilmemiz için Combobox'ı (Açılır Kutu) veritabanındaki yazarlarla doldurur.
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
                        
                        // Arka planda tutulacak olan ID değeri
                        cbxAuthorName.ValueMember = "AuthorId";
                    }
                }
            }
        }
        private void frmBooks_Load(object sender, EventArgs e)
        {
            BringAndSearchDatas();

            // Yazar listesini combobox'a doldur
            ListAuthors();

            // Güncelleme alanındaki metin kutularını başlangıçta kilitler 
            tbxIUpdateAuthorsName.Enabled = false;
            tbxUpdateBooksName.Enabled = false;
        }

        // Arama kutusundaki metin her değiştiğinde (yazı yazıldığında/silindiğinde) tetiklenir
        private void tbxSearchBook_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearchBook.Text != string.Empty)
            {
                BringAndSearchDatas();
            }
        }

        // Seçilen kitap ve yazar ID'lerini hafızada tutmak için global değişkenler
        int _selectedBookId;
        int _selectedAuthorId;

        // Silme butonuna tıklandığında veriyi veritabanından tamamen yok etmez, durumunu pasif (Status = 0) yapar.
        private void button2_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan silme işlemi için onay istenir
            DialogResult res = MessageBox.Show("Bu veriyi silmek istediğinizden emin misiniz? ", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                using (SqlConnection conn = SqlCon.Connect())
                {
                    conn.Open();
                    string queryForDelete = "UPDATE Books SET Status = 0 WHERE BookId = @bookId";
                    using (SqlCommand cmd = new SqlCommand(queryForDelete, conn))
                    {
                        cmd.Parameters.AddWithValue("bookId", _selectedBookId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Veri başarıyla silindi.", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        // Tablodaki bir kitaba tıklandığında, o satırdaki bilgileri güncelleme metin kutularına aktarır ve ID'leri hafızaya alır.
        private void dgwBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedBookId = Convert.ToInt32(dgwBooks.CurrentRow.Cells[0].Value);
            tbxUpdateBooksName.Text = dgwBooks.CurrentRow.Cells[1].Value.ToString();
            _selectedAuthorId = Convert.ToInt32(dgwBooks.CurrentRow.Cells[2].Value);
            tbxIUpdateAuthorsName.Text = dgwBooks.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Güncelleme formunu açar ve seçili Kitap ile Yazar ID'sini o forma parametre olarak gönderir
            frmUpdateBooks updateBooks = new frmUpdateBooks(_selectedBookId, _selectedAuthorId);
            // Güncelleme penceresi kapanana kadar ana formu kilitler
            updateBooks.ShowDialog();
        }

        // --- KİTAP EKLEME BUTONU VE VALİDASYON ---
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            // FluentValidation nesnesi oluşturuluyor
            var validator = new BookInsertValidator();

            // Formdan alınan veriyle yeni bir kitap nesnesi oluşturuluyor
            var insertBookObject = new InsertBook
            {
                BookName = tbxBookName.Text
            };

            // Kurallara uygunluk kontrol ediliyor (Örn: Boş mu, karakter sınırı aşılmış mı?)
            var result = validator.Validate(insertBookObject);

            if (result.IsValid)
            {
                // Bilgiler geçerliyse veritabanına ekleme metodunu çağırma
                InsertNewBook();
            }
            else
            {
                // Bilgiler geçersizse hata mesajlarını döngüyle kullanıcıya gösterir
                foreach (var error in result.Errors)
                {
                    MessageBox.Show("Hata: " + error.ErrorMessage);
                }
            }
        }

        // Hem Books tablosuna hem de ilişkili BookAuthors tablosuna aynı anda güvenli kayıt yapar.
        private void InsertNewBook()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();

                // Veri bütünlüğünü korumak için Transaction başlatıyoruz.
                // Eğer kitap eklenir ama yazar eşleşmesinde hata çıkarsa, eklenen kitap da geri alınır.
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    // Yeni kitap ekleme sorgusu. 'SELECT SCOPE_IDENTITY()' ile yeni eklenen kitabın ID'sini anlık olarak geri alırız.
                    string queryForNewBook = "INSERT INTO Books(BookName,QuantityStocks) VALUES (@bookName,@quantityStocks); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand cmd = new SqlCommand(queryForNewBook, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@bookName", tbxBookName.Text);
                        cmd.Parameters.AddWithValue("@quantityStocks", numStock.Value);

                        // Kitabı ekler ve oluşan ID'yi alır
                        int insertedBookId = Convert.ToInt32(cmd.ExecuteScalar());

                        // Kitap ile Yazarı eşleştiren ara tabloya (BookAuthors) kayıt ekleme sorgusu
                        string queryForAuthor = "INSERT INTO BookAuthors (BookId, AuthorId) VALUES (@bookId,@authorId)";
                        using (SqlCommand cmdAuthor = new SqlCommand(queryForAuthor, conn, transaction))
                        {
                            cmdAuthor.Parameters.AddWithValue("@bookId", insertedBookId);
                            cmdAuthor.Parameters.AddWithValue("@authorId", cbxAuthorName.SelectedValue);
                            cmdAuthor.ExecuteNonQuery();
                     
                            MessageBox.Show("Veri ekleme işlemi başarılı.", "Veri Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    // Tüm işlemler sorunsuzsa veritabanındaki değişiklikleri kalıcı hale getir
                    transaction.Commit();
                }

                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }
    }
}