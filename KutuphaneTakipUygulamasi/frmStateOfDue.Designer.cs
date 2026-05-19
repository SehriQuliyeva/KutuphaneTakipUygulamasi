namespace KutuphaneTakipUygulamasi
{
    partial class frmStateOfDue
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
            dgwCompletedReturns = new DataGridView();
            label1 = new Label();
            tbxSearchInCompleted = new TextBox();
            dgwNotCompletedReturns = new DataGridView();
            tbxSearchInNotCompleted = new TextBox();
            label3 = new Label();
            tbxDueDate = new TextBox();
            label2 = new Label();
            tbxLoanDate = new TextBox();
            tbxLastName = new TextBox();
            tbxFirstName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            gbxInformation = new GroupBox();
            label7 = new Label();
            tbxBookName = new TextBox();
            btnReturnProccesDone = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwCompletedReturns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwNotCompletedReturns).BeginInit();
            gbxInformation.SuspendLayout();
            SuspendLayout();
            // 
            // dgwCompletedReturns
            // 
            dgwCompletedReturns.BackgroundColor = SystemColors.Control;
            dgwCompletedReturns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCompletedReturns.Location = new Point(-4, 262);
            dgwCompletedReturns.Name = "dgwCompletedReturns";
            dgwCompletedReturns.RowHeadersWidth = 51;
            dgwCompletedReturns.Size = new Size(429, 188);
            dgwCompletedReturns.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 236);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 2;
            label1.Text = "İade Edilenler:";
            // 
            // tbxSearchInCompleted
            // 
            tbxSearchInCompleted.Location = new Point(118, 233);
            tbxSearchInCompleted.Name = "tbxSearchInCompleted";
            tbxSearchInCompleted.Size = new Size(125, 27);
            tbxSearchInCompleted.TabIndex = 4;
            tbxSearchInCompleted.TextChanged += tbxSearchInCompleted_TextChanged;
            // 
            // dgwNotCompletedReturns
            // 
            dgwNotCompletedReturns.BackgroundColor = SystemColors.Control;
            dgwNotCompletedReturns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwNotCompletedReturns.Location = new Point(443, 262);
            dgwNotCompletedReturns.Name = "dgwNotCompletedReturns";
            dgwNotCompletedReturns.RowHeadersWidth = 51;
            dgwNotCompletedReturns.Size = new Size(429, 188);
            dgwNotCompletedReturns.TabIndex = 5;
            dgwNotCompletedReturns.CellClick += dgwNotCompletedReturns_CellClick;
            // 
            // tbxSearchInNotCompleted
            // 
            tbxSearchInNotCompleted.Location = new Point(577, 233);
            tbxSearchInNotCompleted.Name = "tbxSearchInNotCompleted";
            tbxSearchInNotCompleted.Size = new Size(125, 27);
            tbxSearchInNotCompleted.TabIndex = 7;
            tbxSearchInNotCompleted.TextChanged += tbxSearchInNotCompleted_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(443, 236);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 6;
            label3.Text = "İade Edilmeyenler:";
            // 
            // tbxDueDate
            // 
            tbxDueDate.Location = new Point(524, 79);
            tbxDueDate.Name = "tbxDueDate";
            tbxDueDate.Size = new Size(250, 27);
            tbxDueDate.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(382, 82);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 41;
            label2.Text = "İade Alınan Tarih:";
            // 
            // tbxLoanDate
            // 
            tbxLoanDate.Location = new Point(524, 41);
            tbxLoanDate.Name = "tbxLoanDate";
            tbxLoanDate.Size = new Size(250, 27);
            tbxLoanDate.TabIndex = 40;
            // 
            // tbxLastName
            // 
            tbxLastName.Location = new Point(89, 79);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.Size = new Size(250, 27);
            tbxLastName.TabIndex = 39;
            // 
            // tbxFirstName
            // 
            tbxFirstName.Location = new Point(89, 41);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.Size = new Size(250, 27);
            tbxFirstName.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(365, 44);
            label4.Name = "label4";
            label4.Size = new Size(153, 20);
            label4.TabIndex = 37;
            label4.Text = "Kitabın Verildiği Tarih:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 82);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 36;
            label5.Text = "Soyad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 44);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 35;
            label6.Text = "Ad:";
            // 
            // gbxInformation
            // 
            gbxInformation.Controls.Add(label7);
            gbxInformation.Controls.Add(tbxBookName);
            gbxInformation.Controls.Add(btnReturnProccesDone);
            gbxInformation.Controls.Add(label6);
            gbxInformation.Controls.Add(tbxDueDate);
            gbxInformation.Controls.Add(label5);
            gbxInformation.Controls.Add(label2);
            gbxInformation.Controls.Add(label4);
            gbxInformation.Controls.Add(tbxLoanDate);
            gbxInformation.Controls.Add(tbxFirstName);
            gbxInformation.Controls.Add(tbxLastName);
            gbxInformation.Location = new Point(29, 12);
            gbxInformation.Name = "gbxInformation";
            gbxInformation.Size = new Size(812, 209);
            gbxInformation.TabIndex = 43;
            gbxInformation.TabStop = false;
            gbxInformation.Text = "groupBox1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 119);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 44;
            label7.Text = "Kitap:";
            // 
            // tbxBookName
            // 
            tbxBookName.Location = new Point(89, 116);
            tbxBookName.Name = "tbxBookName";
            tbxBookName.Size = new Size(250, 27);
            tbxBookName.TabIndex = 45;
            // 
            // btnReturnProccesDone
            // 
            btnReturnProccesDone.Location = new Point(590, 140);
            btnReturnProccesDone.Name = "btnReturnProccesDone";
            btnReturnProccesDone.Size = new Size(168, 40);
            btnReturnProccesDone.TabIndex = 43;
            btnReturnProccesDone.Text = "İade Edildi";
            btnReturnProccesDone.UseVisualStyleBackColor = true;
            btnReturnProccesDone.Click += btnReturnProccesDone_Click;
            // 
            // frmStateOfDue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 450);
            Controls.Add(gbxInformation);
            Controls.Add(tbxSearchInNotCompleted);
            Controls.Add(label3);
            Controls.Add(dgwNotCompletedReturns);
            Controls.Add(tbxSearchInCompleted);
            Controls.Add(label1);
            Controls.Add(dgwCompletedReturns);
            MaximizeBox = false;
            MaximumSize = new Size(890, 497);
            MinimumSize = new Size(890, 497);
            Name = "frmStateOfDue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "İade Durumu";
            Load += frmStateOfDue_Load;
            ((System.ComponentModel.ISupportInitialize)dgwCompletedReturns).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwNotCompletedReturns).EndInit();
            gbxInformation.ResumeLayout(false);
            gbxInformation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwCompletedReturns;
        private Label label1;
        private TextBox tbxSearchInCompleted;
        private DataGridView dgwNotCompletedReturns;
        private TextBox tbxSearchInNotCompleted;
        private Label label3;
        private TextBox tbxDueDate;
        private Label label2;
        private TextBox tbxLoanDate;
        private TextBox tbxLastName;
        private TextBox tbxFirstName;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox gbxInformation;
        private Label label7;
        private TextBox tbxBookName;
        private Button btnReturnProccesDone;
    }
}