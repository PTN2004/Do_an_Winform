using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Database;
using BUS;

namespace DOAN1.Giaodien
{
    public partial class Dangnhap : Form
    {
        private LoginBUS loginBUS;

        public Dangnhap()
        {
            InitializeComponent();
            loginBUS = new LoginBUS(); // Khởi tạo BUS
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dangnhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DN_Click(object sender, EventArgs e)
        {
            {
                string username = txtUser.Text.Trim(); // Lấy tài khoản từ textbox
                string password = txtPass.Text.Trim(); // Lấy mật khẩu từ textbox

                // Gọi BUS để xác thực
                var user = loginBUS.Authenticate(username, password);

                if (user != null) // Nếu đăng nhập thành công
                {
                    string role = user.ChucVu1?.TenChucVu; // Lấy tên chức vụ từ ChucVu1

                    if (role == "Admin")
                    {
                        MessageBox.Show("Đăng nhập thành công với quyền Admin!");
                        MainForm mainForm = new MainForm("Admin");
                        mainForm.Show();
                        this.Hide(); // Ẩn form đăng nhập
                    }
                    else if (role == "Nhân viên bán hàng")
                    {
                        MessageBox.Show("Đăng nhập thành công với quyền Nhân viên bán hàng!");
                        MainForm mainForm = new MainForm("Nhân viên bán hàng");
                        mainForm.Show();
                        this.Hide(); // Ẩn form đăng nhập
                    }
                    else
                    {
                        lblMess.Text = "Chức vụ không xác định!";
                    }
                }
                else
                {
                    lblMess.Text = "Tài khoản hoặc mật khẩu không đúng!";
                }
            }
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
