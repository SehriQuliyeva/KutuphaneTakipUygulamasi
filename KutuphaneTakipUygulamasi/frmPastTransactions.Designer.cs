namespace KutuphaneTakipUygulamasi
{
    partial class frmPastTransactions
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
            dgwPastTransactions = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwPastTransactions).BeginInit();
            SuspendLayout();
            // 
            // dgwPastTransactions
            // 
            dgwPastTransactions.BackgroundColor = SystemColors.Control;
            dgwPastTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwPastTransactions.Dock = DockStyle.Fill;
            dgwPastTransactions.Location = new Point(0, 0);
            dgwPastTransactions.Name = "dgwPastTransactions";
            dgwPastTransactions.RowHeadersWidth = 51;
            dgwPastTransactions.Size = new Size(917, 289);
            dgwPastTransactions.TabIndex = 0;
            // 
            // frmPastTransactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 289);
            Controls.Add(dgwPastTransactions);
            MaximizeBox = false;
            MaximumSize = new Size(935, 336);
            MinimumSize = new Size(935, 336);
            Name = "frmPastTransactions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Geçmiş İşlemler";
            Load += frmPastTransactions_Load;
            ((System.ComponentModel.ISupportInitialize)dgwPastTransactions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwPastTransactions;
    }
}