using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KutuphaneTakipUygulamasi
{
    // Ana Menü Formu (frmMain) Giriş sonrası kullanıcının yönlendirildiği paneldir.
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /* Form ekrana gelirken, giriş ekranında (frmLogin) 'Session' sınıfına kaydedilen 
         aktif kullanıcı bilgilerini form üzerindeki etiketlere (Label) yazdırır.*/
        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUserId.Text = Session.ActiveUserId.ToString();
            lblRoleName.Text = Session.ActiveRoleName.ToString();
            lblUserName.Text = Session.ActiveUserName.ToString();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            frmBooks books = new frmBooks();
            books.Show();
            this.Hide();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            frmMembers members = new frmMembers();
            members.Show();
            this.Hide();
        }

        private void btnLoans_Click(object sender, EventArgs e)
        {
            frmBookLoans loans = new frmBookLoans();
            loans.Show();
            this.Hide();
        }
    }
}
