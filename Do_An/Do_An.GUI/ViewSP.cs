using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Do_An.BUS;
using Do_An.DAL;
using DoAn.BUS;

namespace Do_An.GUI
{
    public partial class ViewSP : Form
    {
        SanPhamService sanPhamService = new SanPhamService();
        LoaiSpService loaiSpService = new LoaiSpService();

        string filePath = null;
        public event Action ProductUpdated;
        SanPham sp;
        public ViewSP(SanPham sp)
        {
            InitializeComponent();
            //FillComboBox(loaiSpService.GetLoaiSP());
            

            this.sp = sp;
        }

        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ThemSP_Load(object sender, EventArgs e)
        {
            
            lblTitle.Text = "SẢN PHẨM " + sp.TenSP;
            lblMasp.Text = sp.MaSP;
            lblTenSP.Text = sp.TenSP;
            lblDVT.Text = sp.DonViTinh;
            lblSanPham.Text = sp.LoaiSP.TenLoaiSP;
            lblKho.Text = sp.SoLuongTon.ToString();
            lblGia.Text = sp.Gia.ToString();
            lblMaVach.Text = sp.BarCode;
            if (sp.ImagePath != null)
            {

                picSP.Image = Image.FromFile(sp.ImagePath);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private string UploadImage()
        {
            string filePath = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            // Kiểm tra nếu người dùng đã chọn tệp và nhấn OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn của tệp được chọn
                filePath = openFileDialog.FileName;
            }
            
            return filePath;
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Bạn muốn thoát?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes) { 
                this.Close();
             }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picSP_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdateImage_Click(object sender, EventArgs e)
        {

            filePath = UploadImage();
            if (filePath != null)
            {
                picSP.Image = Image.FromFile(filePath);
            }
            
        }
    }
}
    