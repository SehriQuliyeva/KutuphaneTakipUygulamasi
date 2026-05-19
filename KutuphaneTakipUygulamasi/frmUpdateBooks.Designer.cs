namespace KutuphaneTakipUygulamasi
{
    partial class frmUpdateBooks
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
            tbxBookName = new TextBox();
            label2 = new Label();
            cbxAuthorName = new ComboBox();
            label8 = new Label();
            label3 = new Label();
            rbNotDeleted = new RadioButton();
            rbDeleted = new RadioButton();
            btnUpdate = new Button();
            btnCancel = new Button();
            numStock = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            SuspendLayout();
            // 
            // tbxBookName
            // 
            tbxBookName.Font = new Font("Segoe UI", 12F);
            tbxBookName.Location = new Point(110, 25);
            tbxBookName.Name = "tbxBookName";
            tbxBookName.Size = new Size(264, 34);
            tbxBookName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(27, 23);
            label2.Name = "label2";
            label2.Size = new Size(77, 35);
            label2.TabIndex = 2;
            label2.Text = "Kitap:";
            // 
            // cbxAuthorName
            // 
            cbxAuthorName.Font = new Font("Segoe UI", 12F);
            cbxAuthorName.FormattingEnabled = true;
            cbxAuthorName.Location = new Point(110, 73);
            cbxAuthorName.Name = "cbxAuthorName";
            cbxAuthorName.Size = new Size(264, 36);
            cbxAuthorName.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(26, 71);
            label8.Name = "label8";
            label8.Size = new Size(78, 35);
            label8.TabIndex = 15;
            label8.Text = "Yazar:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(37, 121);
            label3.Name = "label3";
            label3.Size = new Size(67, 35);
            label3.TabIndex = 4;
            label3.Text = "Stok:";
            // 
            // rbNotDeleted
            // 
            rbNotDeleted.AutoSize = true;
            rbNotDeleted.Font = new Font("Segoe UI", 15F);
            rbNotDeleted.Location = new Point(47, 191);
            rbNotDeleted.Name = "rbNotDeleted";
            rbNotDeleted.Size = new Size(142, 39);
            rbNotDeleted.TabIndex = 16;
            rbNotDeleted.TabStop = true;
            rbNotDeleted.Text = "Silinmedi.";
            rbNotDeleted.UseVisualStyleBackColor = true;
            // 
            // rbDeleted
            // 
            rbDeleted.AutoSize = true;
            rbDeleted.Font = new Font("Segoe UI", 15F);
            rbDeleted.Location = new Point(253, 191);
            rbDeleted.Name = "rbDeleted";
            rbDeleted.Size = new Size(107, 39);
            rbDeleted.TabIndex = 17;
            rbDeleted.TabStop = true;
            rbDeleted.Text = "Silindi.";
            rbDeleted.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 15F);
            btnUpdate.Location = new Point(75, 300);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(273, 44);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Kaydet";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 15F);
            btnCancel.Location = new Point(75, 376);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(273, 44);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "İptal et";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // numStock
            // 
            numStock.Font = new Font("Segoe UI", 12F);
            numStock.Location = new Point(110, 124);
            numStock.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numStock.Name = "numStock";
            numStock.Size = new Size(264, 34);
            numStock.TabIndex = 20;
            // 
            // frmUpdateBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 482);
            Controls.Add(numStock);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(rbDeleted);
            Controls.Add(rbNotDeleted);
            Controls.Add(label8);
            Controls.Add(cbxAuthorName);
            Controls.Add(label3);
            Controls.Add(tbxBookName);
            Controls.Add(label2);
            MaximizeBox = false;
            MaximumSize = new Size(437, 529);
            MinimumSize = new Size(437, 529);
            Name = "frmUpdateBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kitap Güncelle";
            Load += frmUpdateBooks_Load;
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbxBookName;
        private Label label2;
        private TextBox tbxQuantityStocks;
        private ComboBox cbxAuthorName;
        private Label label8;
        private Label label3;
        private RadioButton rbNotDeleted;
        private RadioButton rbDeleted;
        private Button btnUpdate;
        private Button btnCancel;
        private NumericUpDown numStock;
    }
}