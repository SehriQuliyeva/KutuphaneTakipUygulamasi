namespace KutuphaneTakipUygulamasi
{
    partial class frmBookLoans
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
            dgwMembers = new DataGridView();
            dgwBooks = new DataGridView();
            dtpDueDate = new DateTimePicker();
            gbxMembers = new GroupBox();
            btnHistory = new Button();
            tbxBirthDate = new TextBox();
            label1 = new Label();
            tbxStudentId = new TextBox();
            tbxLastName = new TextBox();
            tbxFirstName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblBook = new Label();
            label5 = new Label();
            tbxBookName = new TextBox();
            tbxStock = new TextBox();
            gbxBooks = new GroupBox();
            tbxAuthorName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            tbxSearchBook = new TextBox();
            label9 = new Label();
            tbxSearchMember = new TextBox();
            label10 = new Label();
            label11 = new Label();
            btnProccessDone = new Button();
            btnStateOfDue = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwMembers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwBooks).BeginInit();
            gbxMembers.SuspendLayout();
            gbxBooks.SuspendLayout();
            SuspendLayout();
            // 
            // dgwMembers
            // 
            dgwMembers.BackgroundColor = SystemColors.Control;
            dgwMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwMembers.Location = new Point(606, 405);
            dgwMembers.Name = "dgwMembers";
            dgwMembers.RowHeadersWidth = 51;
            dgwMembers.Size = new Size(540, 218);
            dgwMembers.TabIndex = 0;
            dgwMembers.CellClick += dgwMembers_CellClick;
            // 
            // dgwBooks
            // 
            dgwBooks.BackgroundColor = SystemColors.Control;
            dgwBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwBooks.Location = new Point(12, 405);
            dgwBooks.Name = "dgwBooks";
            dgwBooks.RowHeadersWidth = 51;
            dgwBooks.Size = new Size(540, 218);
            dgwBooks.TabIndex = 1;
            dgwBooks.CellClick += dgwBooks_CellClick;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(142, 192);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(250, 27);
            dtpDueDate.TabIndex = 3;
            // 
            // gbxMembers
            // 
            gbxMembers.Controls.Add(btnHistory);
            gbxMembers.Controls.Add(tbxBirthDate);
            gbxMembers.Controls.Add(label1);
            gbxMembers.Controls.Add(tbxStudentId);
            gbxMembers.Controls.Add(tbxLastName);
            gbxMembers.Controls.Add(tbxFirstName);
            gbxMembers.Controls.Add(label2);
            gbxMembers.Controls.Add(label3);
            gbxMembers.Controls.Add(label4);
            gbxMembers.Location = new Point(719, 12);
            gbxMembers.Name = "gbxMembers";
            gbxMembers.Size = new Size(411, 301);
            gbxMembers.TabIndex = 37;
            gbxMembers.TabStop = false;
            gbxMembers.Text = "Üye Bilgileri";
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(91, 229);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(269, 44);
            btnHistory.TabIndex = 35;
            btnHistory.Text = "Geçmiş İşlemler";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // tbxBirthDate
            // 
            tbxBirthDate.Location = new Point(128, 173);
            tbxBirthDate.Name = "tbxBirthDate";
            tbxBirthDate.Size = new Size(250, 27);
            tbxBirthDate.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 176);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 33;
            label1.Text = "Doğum Tarihi:";
            // 
            // tbxStudentId
            // 
            tbxStudentId.Location = new Point(128, 136);
            tbxStudentId.Name = "tbxStudentId";
            tbxStudentId.Size = new Size(250, 27);
            tbxStudentId.TabIndex = 32;
            // 
            // tbxLastName
            // 
            tbxLastName.Location = new Point(128, 100);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.Size = new Size(250, 27);
            tbxLastName.TabIndex = 31;
            // 
            // tbxFirstName
            // 
            tbxFirstName.Location = new Point(128, 63);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.Size = new Size(250, 27);
            tbxFirstName.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 140);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 29;
            label2.Text = "Öğrenci No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 104);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 28;
            label3.Text = "Soyad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 67);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 27;
            label4.Text = "Ad:";
            // 
            // lblBook
            // 
            lblBook.AutoSize = true;
            lblBook.Location = new Point(26, 47);
            lblBook.Name = "lblBook";
            lblBook.Size = new Size(47, 20);
            lblBook.TabIndex = 27;
            lblBook.Text = "Kitap:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 124);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 29;
            label5.Text = "Stok:";
            // 
            // tbxBookName
            // 
            tbxBookName.Location = new Point(85, 44);
            tbxBookName.Name = "tbxBookName";
            tbxBookName.Size = new Size(250, 27);
            tbxBookName.TabIndex = 30;
            // 
            // tbxStock
            // 
            tbxStock.Location = new Point(85, 121);
            tbxStock.Name = "tbxStock";
            tbxStock.Size = new Size(250, 27);
            tbxStock.TabIndex = 32;
            // 
            // gbxBooks
            // 
            gbxBooks.Controls.Add(tbxAuthorName);
            gbxBooks.Controls.Add(label7);
            gbxBooks.Controls.Add(tbxStock);
            gbxBooks.Controls.Add(tbxBookName);
            gbxBooks.Controls.Add(label5);
            gbxBooks.Controls.Add(lblBook);
            gbxBooks.Location = new Point(57, 12);
            gbxBooks.Name = "gbxBooks";
            gbxBooks.Size = new Size(366, 167);
            gbxBooks.TabIndex = 5;
            gbxBooks.TabStop = false;
            gbxBooks.Text = "Kitap Bilgileri";
            // 
            // tbxAuthorName
            // 
            tbxAuthorName.Location = new Point(85, 84);
            tbxAuthorName.Name = "tbxAuthorName";
            tbxAuthorName.Size = new Size(250, 27);
            tbxAuthorName.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 84);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 33;
            label7.Text = "Yazar:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(50, 197);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 37;
            label6.Text = "İade Tarihi:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(12, 366);
            label8.Name = "label8";
            label8.Size = new Size(128, 28);
            label8.TabIndex = 38;
            label8.Text = "Kitap Bilgileri";
            // 
            // tbxSearchBook
            // 
            tbxSearchBook.Font = new Font("Segoe UI", 12F);
            tbxSearchBook.Location = new Point(242, 364);
            tbxSearchBook.Name = "tbxSearchBook";
            tbxSearchBook.Size = new Size(250, 34);
            tbxSearchBook.TabIndex = 34;
            tbxSearchBook.TextChanged += tbxSearchBook_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(190, 366);
            label9.Name = "label9";
            label9.Size = new Size(46, 28);
            label9.TabIndex = 33;
            label9.Text = "Ara:";
            // 
            // tbxSearchMember
            // 
            tbxSearchMember.Font = new Font("Segoe UI", 12F);
            tbxSearchMember.Location = new Point(880, 363);
            tbxSearchMember.Name = "tbxSearchMember";
            tbxSearchMember.Size = new Size(250, 34);
            tbxSearchMember.TabIndex = 40;
            tbxSearchMember.TextChanged += tbxSearchMember_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(639, 366);
            label10.Name = "label10";
            label10.Size = new Size(116, 28);
            label10.TabIndex = 41;
            label10.Text = "Üye Bilgileri";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(828, 366);
            label11.Name = "label11";
            label11.Size = new Size(46, 28);
            label11.TabIndex = 39;
            label11.Text = "Ara:";
            // 
            // btnProccessDone
            // 
            btnProccessDone.Location = new Point(480, 157);
            btnProccessDone.Name = "btnProccessDone";
            btnProccessDone.Size = new Size(193, 51);
            btnProccessDone.TabIndex = 42;
            btnProccessDone.Text = "Tamamla";
            btnProccessDone.UseVisualStyleBackColor = true;
            btnProccessDone.Click += btnProccessDone_Click;
            // 
            // btnStateOfDue
            // 
            btnStateOfDue.Location = new Point(480, 100);
            btnStateOfDue.Name = "btnStateOfDue";
            btnStateOfDue.Size = new Size(193, 51);
            btnStateOfDue.TabIndex = 43;
            btnStateOfDue.Text = "İade Durumu";
            btnStateOfDue.UseVisualStyleBackColor = true;
            btnStateOfDue.Click += btnStateOfDue_Click;
            // 
            // button1
            // 
            button1.Location = new Point(480, 44);
            button1.Name = "button1";
            button1.Size = new Size(193, 50);
            button1.TabIndex = 44;
            button1.Text = "ANA SAYFA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmBookLoans
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 635);
            Controls.Add(button1);
            Controls.Add(btnStateOfDue);
            Controls.Add(btnProccessDone);
            Controls.Add(tbxSearchMember);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(tbxSearchBook);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(gbxMembers);
            Controls.Add(gbxBooks);
            Controls.Add(dtpDueDate);
            Controls.Add(dgwBooks);
            Controls.Add(dgwMembers);
            MaximizeBox = false;
            MaximumSize = new Size(1176, 682);
            MinimumSize = new Size(1176, 682);
            Name = "frmBookLoans";
            Text = "Kitap Ödünç Alma";
            Load += frmBookLoans_Load;
            ((System.ComponentModel.ISupportInitialize)dgwMembers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwBooks).EndInit();
            gbxMembers.ResumeLayout(false);
            gbxMembers.PerformLayout();
            gbxBooks.ResumeLayout(false);
            gbxBooks.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwMembers;
        private DataGridView dgwBooks;
        private DateTimePicker dtpDueDate;
        private GroupBox gbxMembers;
        private Button btnHistory;
        private TextBox tbxBirthDate;
        private Label label1;
        private TextBox tbxStudentId;
        private TextBox tbxLastName;
        private TextBox tbxFirstName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblBook;
        private Label label5;
        private TextBox tbxBookName;
        private TextBox tbxStock;
        private GroupBox gbxBooks;
        private Label label6;
        private Label label8;
        private TextBox tbxSearchBook;
        private Label label9;
        private TextBox tbxSearchMember;
        private Label label10;
        private Label label11;
        private TextBox tbxAuthorName;
        private Label label7;
        private Button btnProccessDone;
        private Button btnStateOfDue;
        private Button button1;
    }
}