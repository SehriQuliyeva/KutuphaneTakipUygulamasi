namespace KutuphaneTakipUygulamasi
{
    partial class frmMain
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
            lblUserName = new Label();
            lblRoleName = new Label();
            lblUserId = new Label();
            btnBooks = new Button();
            btnMembers = new Button();
            btnLoans = new Button();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(68, 89);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(50, 20);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "label1";
            // 
            // lblRoleName
            // 
            lblRoleName.AutoSize = true;
            lblRoleName.Location = new Point(68, 143);
            lblRoleName.Name = "lblRoleName";
            lblRoleName.Size = new Size(50, 20);
            lblRoleName.TabIndex = 1;
            lblRoleName.Text = "label2";
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Location = new Point(68, 36);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(50, 20);
            lblUserId.TabIndex = 2;
            lblUserId.Text = "label1";
            // 
            // btnBooks
            // 
            btnBooks.Location = new Point(194, 89);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(178, 54);
            btnBooks.TabIndex = 4;
            btnBooks.Text = "Kitaplar";
            btnBooks.UseVisualStyleBackColor = true;
            btnBooks.Click += btnBooks_Click;
            // 
            // btnMembers
            // 
            btnMembers.Location = new Point(194, 19);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(178, 54);
            btnMembers.TabIndex = 3;
            btnMembers.Text = "Üyeler";
            btnMembers.UseVisualStyleBackColor = true;
            btnMembers.Click += btnMembers_Click;
            // 
            // btnLoans
            // 
            btnLoans.Location = new Point(194, 165);
            btnLoans.Name = "btnLoans";
            btnLoans.Size = new Size(178, 54);
            btnLoans.TabIndex = 5;
            btnLoans.Text = "Kitap Ödünç Alma";
            btnLoans.UseVisualStyleBackColor = true;
            btnLoans.Click += btnLoans_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 252);
            Controls.Add(btnLoans);
            Controls.Add(btnMembers);
            Controls.Add(btnBooks);
            Controls.Add(lblUserId);
            Controls.Add(lblRoleName);
            Controls.Add(lblUserName);
            MaximizeBox = false;
            MaximumSize = new Size(435, 299);
            MinimumSize = new Size(435, 299);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private Label lblRoleName;
        private Label lblUserId;
        private Button btnBooks;
        private Button btnMembers;
        private Button btnLoans;
    }
}