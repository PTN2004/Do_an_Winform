using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraWaitForm;
using Do_An.BUS;

namespace Do_An.GUI
{
    public partial class frmLogin : Form

    {
        bool isShow = false;
        LoginService loginService = new LoginService();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_MouseDown(object sender, MouseEventArgs e)
        {
            txtUserName.Text = "";
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            txtUserName.ForeColor = Color.Black;
        }

        private void txtPass_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.ForeColor = Color.Black;
            txtPass.PasswordChar = '*';
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            
            if (!isShow)
            {               
                txtPass.PasswordChar = '\0';  
            }
            else
            {               
                txtPass.PasswordChar = '*'; 
            }
            isShow = !isShow;
            iconPictureBox1.IconChar = isShow ? FontAwesome.Sharp.IconChar.Eye : FontAwesome.Sharp.IconChar.EyeSlash;

        }

        private void txtPass_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.Text = "";
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim(); // Lấy tài khoản từ textbox
            string password = txtPass.Text.Trim(); // Lấy mật khẩu từ textbox
            var user = loginService.Authenticate(username, password);

            if (user != null) // Nếu đăng nhập thành công
            {
                string role = user.ChucVu?.TenChucVu; // Lấy tên chức vụ từ ChucVu1

                if (role == "Admin")
                {
                    MessageBox.Show("Đăng nhập thành công với quyền Admin!");
                    frm_main mainForm = new frm_main(user);
                    mainForm.Show();
                    this.Hide(); // Ẩn form đăng nhập
                }
                else if (role == "Nhân viên bán hàng")
                {
                    MessageBox.Show("Đăng nhập thành công với quyền Nhân viên bán hàng!");
                    frm_main mainForm = new frm_main(user);
                    mainForm.Show();
                    this.Hide(); // Ẩn form đăng nhập
                }
                else
                {
                    MessageBox.Show("Chức vụ không xác định!");
                    
                }
               
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!","Thông báo", MessageBoxButtons.OK);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
