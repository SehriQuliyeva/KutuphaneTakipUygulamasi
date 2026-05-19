namespace KutuphaneTakipUygulamasi
{
    partial class frmUpdateMembers
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
            lblUpdateRoles = new Label();
            tbxStudentId = new TextBox();
            tbxLastName = new TextBox();
            tbxFirstName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dtpBirthDate = new DateTimePicker();
            lblUserName = new Label();
            lblPassword = new Label();
            tbxPassword = new TextBox();
            tbxUserName = new TextBox();
            rbWoman = new RadioButton();
            rbMan = new RadioButton();
            btnUpdate = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblUpdateRoles
            // 
            lblUpdateRoles.AutoSize = true;
            lblUpdateRoles.Location = new Point(8, 136);
            lblUpdateRoles.Name = "lblUpdateRoles";
            lblUpdateRoles.Size = new Size(101, 20);
            lblUpdateRoles.TabIndex = 31;
            lblUpdateRoles.Text = "Doğum Tarihi:";
            // 
            // tbxStudentId
            // 
            tbxStudentId.Location = new Point(130, 95);
            tbxStudentId.Name = "tbxStudentId";
            tbxStudentId.Size = new Size(250, 27);
            tbxStudentId.TabIndex = 30;
            // 
            // tbxLastName
            // 
            tbxLastName.Location = new Point(130, 52);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.Size = new Size(250, 27);
            tbxLastName.TabIndex = 29;
            // 
            // tbxFirstName
            // 
            tbxFirstName.Location = new Point(130, 12);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.Size = new Size(250, 27);
            tbxFirstName.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 98);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 27;
            label5.Text = "Öğrenci No:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 52);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 26;
            label6.Text = "Soyad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(78, 15);
            label7.Name = "label7";
            label7.Size = new Size(31, 20);
            label7.TabIndex = 25;
            label7.Text = "Ad:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(130, 136);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(250, 27);
            dtpBirthDate.TabIndex = 32;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(14, 246);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(95, 20);
            lblUserName.TabIndex = 33;
            lblUserName.Text = "Kullanıcı Adı:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(67, 282);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(42, 20);
            lblPassword.TabIndex = 34;
            lblPassword.Text = "Şifre:";
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(130, 282);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(250, 27);
            tbxPassword.TabIndex = 36;
            // 
            // tbxUserName
            // 
            tbxUserName.Location = new Point(130, 243);
            tbxUserName.Name = "tbxUserName";
            tbxUserName.Size = new Size(250, 27);
            tbxUserName.TabIndex = 35;
            // 
            // rbWoman
            // 
            rbWoman.AutoSize = true;
            rbWoman.Location = new Point(56, 194);
            rbWoman.Name = "rbWoman";
            rbWoman.Size = new Size(68, 24);
            rbWoman.TabIndex = 33;
            rbWoman.TabStop = true;
            rbWoman.Text = "Kadın";
            rbWoman.UseVisualStyleBackColor = true;
            // 
            // rbMan
            // 
            rbMan.AutoSize = true;
            rbMan.Location = new Point(263, 194);
            rbMan.Name = "rbMan";
            rbMan.Size = new Size(65, 24);
            rbMan.TabIndex = 34;
            rbMan.TabStop = true;
            rbMan.Text = "Erkek";
            rbMan.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(122, 340);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(206, 42);
            btnUpdate.TabIndex = 39;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(122, 397);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(206, 42);
            btnCancel.TabIndex = 40;
            btnCancel.Text = "İptal Et";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmUpdateMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 461);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(rbMan);
            Controls.Add(rbWoman);
            Controls.Add(tbxUserName);
            Controls.Add(tbxPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(dtpBirthDate);
            Controls.Add(lblUpdateRoles);
            Controls.Add(tbxStudentId);
            Controls.Add(tbxLastName);
            Controls.Add(tbxFirstName);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            MaximizeBox = false;
            MaximumSize = new Size(459, 508);
            MinimumSize = new Size(459, 508);
            Name = "frmUpdateMembers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Üye Güncelle";
            Load += frmUpdateMembers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUpdateRoles;
        private TextBox tbxStudentId;
        private TextBox tbxLastName;
        private TextBox tbxFirstName;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpBirthDate;
        private Label lblUserName;
        private Label lblPassword;
        private TextBox tbxPassword;
        private TextBox tbxUserName;
        private RadioButton rbWoman;
        private RadioButton rbMan;
        private Button btnUpdate;
        private Button btnCancel;
    }
}