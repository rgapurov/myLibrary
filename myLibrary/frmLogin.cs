using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myLibrary
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            pctPassword.Image = myLibrary.Properties.Resources.pass2;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            pctPassword.Image = myLibrary.Properties.Resources.pass1;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            pctUsername.Image = myLibrary.Properties.Resources.user2;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            pctUsername.Image = myLibrary.Properties.Resources.user1;
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.FromArgb(100, 248, 249, 215);
        }

        private void btnMin_MouseHover(object sender, EventArgs e)
        {
            btnMin.ForeColor = Color.FromArgb(100, 248, 249, 215);
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            btnMin.ForeColor = Color.FromArgb(100, 196, 215, 224);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.FromArgb(100, 196, 215, 224);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.FromArgb(100, 248, 249, 215);
            btnLogin.FlatAppearance.BorderColor= Color.FromArgb(100, 248, 249, 215);
            btnLogin.Image = myLibrary.Properties.Resources.log2;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.FromArgb(100, 234, 246, 246);
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(100, 234, 246, 246);
            btnLogin.Image = myLibrary.Properties.Resources.log1;
        }
    }
}
