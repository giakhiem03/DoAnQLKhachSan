using DoAnWinform.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinform
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            Font newFont = new Font("Arial", 16);
            txtUser.Font = newFont;
            txtPassword.Font = newFont; 
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Properties.Resources._7188242;
        }
        DBContextModel context = new DBContextModel();

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
                return;
            }
            Login dblogin = context.Login.FirstOrDefault(x => x.TenDN == txtUser.Text);
            if (dblogin != null)
            {
                if (dblogin.MatKhau == txtPassword.Text)
                {
                    MessageBox.Show("Đăng nhập thành công!!!");
                    Const.login = dblogin;
                    this.Hide();
                    frmPhong frm = new frmPhong();
                    frm.ShowDialog();
                    frm.Close();
                    MessageBox.Show("Đã đăng xuất!!!");
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu!!!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại!!!");
            }
        }

        private void picShow_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == '\0')
            {
                picHide.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                picShow.BringToFront();
                txtPassword.PasswordChar = '\0';
            }

        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8) // 8 là mã ASCII của phím Backspace
            {
                e.Handled = true; // Ngăn ký tự không hợp lệ được hiển thị trong TextBox
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8) // 8 là mã ASCII của phím Backspace
            {
                e.Handled = true; // Ngăn ký tự không hợp lệ được hiển thị trong TextBox
            }
        }
    }
}
