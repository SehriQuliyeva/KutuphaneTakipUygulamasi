namespace KutuphaneTakipUygulamasi
{
    partial class frmBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgwBooks = new DataGridView();
            tbxSearchBook = new TextBox();
            lblSearchBook = new Label();
            tbxUpdateBooksName = new TextBox();
            lblBooksName = new Label();
            tbxIUpdateAuthorsName = new TextBox();
            lblAuthorsName = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            gbxInsertBook = new GroupBox();
            numStock = new NumericUpDown();
            label8 = new Label();
            cbxAuthorName = new ComboBox();
            label3 = new Label();
            tbxBookName = new TextBox();
            label2 = new Label();
            btnAddBook = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwBooks).BeginInit();
            gbxInsertBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            SuspendLayout();
            // 
            // dgwBooks
            // 
            dgwBooks.BackgroundColor = SystemColors.Control;
            dgwBooks.BorderStyle = BorderStyle.None;
            dgwBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwBooks.GridColor = SystemColors.Desktop;
            dgwBooks.Location = new Point(201, 246);
            dgwBooks.Name = "dgwBooks";
            dgwBooks.RowHeadersWidth = 51;
            dgwBooks.Size = new Size(574, 238);
            dgwBooks.TabIndex = 0;
            dgwBooks.CellClick += dgwBooks_CellClick;
            // 
            // tbxSearchBook
            // 
            tbxSearchBook.Font = new Font("Segoe UI", 12F);
            tbxSearchBook.Location = new Point(365, 206);
            tbxSearchBook.Name = "tbxSearchBook";
            tbxSearchBook.Size = new Size(281, 34);
            tbxSearchBook.TabIndex = 1;
            tbxSearchBook.TextChanged += tbxSearchBook_TextChanged;
            // 
            // lblSearchBook
            // 
            lblSearchBook.AutoSize = true;
            lblSearchBook.Font = new Font("Segoe UI", 12F);
            lblSearchBook.Location = new Point(262, 209);
            lblSearchBook.Name = "lblSearchBook";
            lblSearchBook.Size = new Size(97, 28);
            lblSearchBook.TabIndex = 2;
            lblSearchBook.Text = "Kitap Ara:";
            // 
            // tbxUpdateBooksName
            // 
            tbxUpdateBooksName.Font = new Font("Segoe UI", 12F);
            tbxUpdateBooksName.Location = new Point(121, 53);
            tbxUpdateBooksName.Name = "tbxUpdateBooksName";
            tbxUpdateBooksName.Size = new Size(281, 34);
            tbxUpdateBooksName.TabIndex = 3;
            // 
            // lblBooksName
            // 
            lblBooksName.AutoSize = true;
            lblBooksName.Font = new Font("Segoe UI", 12F);
            lblBooksName.Location = new Point(17, 59);
            lblBooksName.Name = "lblBooksName";
            lblBooksName.Size = new Size(97, 28);
            lblBooksName.TabIndex = 4;
            lblBooksName.Text = "Kitap Adı:";
            // 
            // tbxIUpdateAuthorsName
            // 
            tbxIUpdateAuthorsName.Font = new Font("Segoe UI", 12F);
            tbxIUpdateAuthorsName.Location = new Point(121, 103);
            tbxIUpdateAuthorsName.Name = "tbxIUpdateAuthorsName";
            tbxIUpdateAuthorsName.Size = new Size(281, 34);
            tbxIUpdateAuthorsName.TabIndex = 5;
            // 
            // lblAuthorsName
            // 
            lblAuthorsName.AutoSize = true;
            lblAuthorsName.Font = new Font("Segoe UI", 12F);
            lblAuthorsName.Location = new Point(18, 109);
            lblAuthorsName.Name = "lblAuthorsName";
            lblAuthorsName.Size = new Size(96, 28);
            lblAuthorsName.TabIndex = 6;
            lblAuthorsName.Text = "Yazar Adı:";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(132, 159);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(265, 159);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += button2_Click;
            // 
            // gbxInsertBook
            // 
            gbxInsertBook.Controls.Add(numStock);
            gbxInsertBook.Controls.Add(label8);
            gbxInsertBook.Controls.Add(cbxAuthorName);
            gbxInsertBook.Controls.Add(label3);
            gbxInsertBook.Controls.Add(tbxBookName);
            gbxInsertBook.Controls.Add(label2);
            gbxInsertBook.Location = new Point(458, 38);
            gbxInsertBook.Name = "gbxInsertBook";
            gbxInsertBook.Size = new Size(531, 155);
            gbxInsertBook.TabIndex = 8;
            gbxInsertBook.TabStop = false;
            gbxInsertBook.Text = "Yeni Kitap Kaydı";
            // 
            // numStock
            // 
            numStock.Font = new Font("Segoe UI", 12F);
            numStock.Location = new Point(212, 114);
            numStock.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numStock.Name = "numStock";
            numStock.Size = new Size(216, 34);
            numStock.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(128, 61);
            label8.Name = "label8";
            label8.Size = new Size(78, 35);
            label8.TabIndex = 25;
            label8.Text = "Yazar:";
            // 
            // cbxAuthorName
            // 
            cbxAuthorName.Font = new Font("Segoe UI", 12F);
            cbxAuthorName.FormattingEnabled = true;
            cbxAuthorName.Location = new Point(212, 63);
            cbxAuthorName.Name = "cbxAuthorName";
            cbxAuthorName.Size = new Size(216, 36);
            cbxAuthorName.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(139, 111);
            label3.Name = "label3";
            label3.Size = new Size(67, 35);
            label3.TabIndex = 23;
            label3.Text = "Stok:";
            // 
            // tbxBookName
            // 
            tbxBookName.Font = new Font("Segoe UI", 12F);
            tbxBookName.Location = new Point(212, 15);
            tbxBookName.Name = "tbxBookName";
            tbxBookName.Size = new Size(216, 34);
            tbxBookName.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(129, 13);
            label2.Name = "label2";
            label2.Size = new Size(77, 35);
            label2.TabIndex = 21;
            label2.Text = "Kitap:";
            // 
            // btnAddBook
            // 
            btnAddBook.Font = new Font("Segoe UI", 12F);
            btnAddBook.Location = new Point(833, 199);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(117, 43);
            btnAddBook.TabIndex = 9;
            btnAddBook.Text = "Kaydı Ekle";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // button2
            // 
            button2.Location = new Point(895, 7);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "ANA SAYFA";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // frmBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 495);
            Controls.Add(btnAddBook);
            Controls.Add(button2);
            Controls.Add(gbxInsertBook);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(tbxIUpdateAuthorsName);
            Controls.Add(lblAuthorsName);
            Controls.Add(tbxUpdateBooksName);
            Controls.Add(lblBooksName);
            Controls.Add(tbxSearchBook);
            Controls.Add(dgwBooks);
            Controls.Add(lblSearchBook);
            MaximizeBox = false;
            MaximumSize = new Size(1019, 542);
            MinimumSize = new Size(1019, 542);
            Name = "frmBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kitaplar";
            Load += frmBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dgwBooks).EndInit();
            gbxInsertBook.ResumeLayout(false);
            gbxInsertBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwBooks;
        private TextBox tbxSearchBook;
        private Label lblSearchBook;
        private TextBox tbxUpdateBooksName;
        private Label lblBooksName;
        private TextBox tbxIUpdateAuthorsName;
        private Label lblAuthorsName;
        private Button btnUpdate;
        private Button btnDelete;
        private GroupBox gbxInsertBook;
        private NumericUpDown numStock;
        private Label label8;
        private ComboBox cbxAuthorName;
        private Label label3;
        private TextBox tbxBookName;
        private Label label2;
        private Button btnAddBook;
        private Button button2;
    }
}