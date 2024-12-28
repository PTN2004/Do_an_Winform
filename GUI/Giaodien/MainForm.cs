using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN1.Giaodien
{
    public partial class MainForm : Form
    {
        private string userRole;
        public MainForm(string role)
        {
            InitializeComponent();
            userRole = role;
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            btnNhanvien.Enabled = false;

            QLNhanvien qlNhanVienForm = new QLNhanvien();

            qlNhanVienForm.FormClosed += (s, args) =>
            {
                btnNhanvien.Enabled = true;
            };

            qlNhanVienForm.Show();
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            Dangnhap dangnhap = new Dangnhap();
            dangnhap.Show();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (userRole == "Nhân viên bán hàng")
            {
                btnNhanvien.Visible = false;
                btnThuchi.Visible = false;
            }
        }

        private void btnSanpham_Click(object sender, EventArgs e)
        {
            btnSanpham.Enabled = false;

            QLSanpham qLSanpham = new QLSanpham();

            qLSanpham.FormClosed += (s, args) =>
            {
                btnSanpham.Enabled = true;
            };

            qLSanpham.Show();

        }

        private void btnKhachang_Click(object sender, EventArgs e)
        {
            btnKhachang.Enabled = false;

            QLKhachhang qLKhachhang = new QLKhachhang();

            qLKhachhang.FormClosed += (s, args) =>
            {
                btnKhachang.Enabled = true;
            };

            qLKhachhang.Show();

        }
    }
}
