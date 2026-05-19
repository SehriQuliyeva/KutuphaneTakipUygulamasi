namespace KutuphaneTakipUygulamasi
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            KullaniciAdi = new TextBox();
            Sifre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(22, 101);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.CornflowerBlue;
            label1.Location = new Point(90, 83);
            label1.Name = "label1";
            label1.Size = new Size(224, 2);
            label1.TabIndex = 2;
            // 
            // label2
            // 
            label2.BackColor = Color.CornflowerBlue;
            label2.Location = new Point(90, 161);
            label2.Name = "label2";
            label2.Size = new Size(224, 2);
            label2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(111, 204);
            button1.Name = "button1";
            button1.Size = new Size(112, 45);
            button1.TabIndex = 2;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // KullaniciAdi
            // 
            KullaniciAdi.Location = new Point(90, 48);
            KullaniciAdi.Multiline = true;
            KullaniciAdi.Name = "KullaniciAdi";
            KullaniciAdi.Size = new Size(224, 32);
            KullaniciAdi.TabIndex = 0;
            // 
            // Sifre
            // 
            Sifre.Location = new Point(90, 126);
            Sifre.Multiline = true;
            Sifre.Name = "Sifre";
            Sifre.PasswordChar = '*';
            Sifre.Size = new Size(224, 32);
            Sifre.TabIndex = 1;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 289);
            Controls.Add(Sifre);
            Controls.Add(KullaniciAdi);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MaximumSize = new Size(361, 336);
            MinimumSize = new Size(361, 336);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Yap";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox KullaniciAdi;
        private TextBox Sifre;
    }
}