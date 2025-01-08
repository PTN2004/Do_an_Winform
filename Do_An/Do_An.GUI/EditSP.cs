using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Do_An.BUS;
using Do_An.DAL;
using DoAn.BUS;
using ZXing;

namespace Do_An.GUI
{
    public partial class EditSP : Form
    {
        SanPhamService sanPhamService = new SanPhamService();
        LoaiSpService loaiSpService = new LoaiSpService();
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCaptureDevice; 
        private bool canScan = true;
        string filePath = null;
        public event Action ProductUpdated;

        public EditSP(SanPham sp)
        {
            InitializeComponent();
            FillComboBox(loaiSpService.GetLoaiSP());
            txtMaSP.Text = sp.MaSP.ToString();
            txtTenSP.Text = sp.TenSP;
            txtDoViTinh.Text = sp.DonViTinh;
           // cmbLoaiSP.SelectedValue = (int)sp.MaLoaiSP;
            txtKho.Text  = sp.SoLuongTon.ToString();
            txtGia.Text = sp.Gia.ToString();
            txtbarcode.Text = sp.BarCode;
            if(sp.ImagePath != null)
            {

                picSP.Image = Image.FromFile(sp.ImagePath);
            }
           

        }

        private void FillComboBox(List<LoaiSP> spList)
        {
            cmbLoaiSP.DataSource = spList;
            cmbLoaiSP.ValueMember = "MaLoaiSP";
            cmbLoaiSP.DisplayMember = "TenLoaiSP";
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ThemSP_Load(object sender, EventArgs e)
        {
            
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
            SanPham sanPham = new SanPham();
            MessageBox.Show(txtMaSP.Text);
            sanPham.MaSP = txtMaSP.Text;
            sanPham.TenSP = txtTenSP.Text;
            sanPham.DonViTinh = txtDoViTinh.Text;
            sanPham.Gia = int.Parse(txtGia.Text);
            sanPham.GiaNhap = int.Parse(txtGiaNhap.Text);
            sanPham.SoLuongTon = int.Parse(txtKho.Text);
            sanPham.MaLoaiSP = cmbLoaiSP.SelectedValue.ToString();
            sanPham.ImagePath = filePath;
            sanPham.BarCode = txtbarcode.Text;
            sanPhamService.UpdateSanPham(sanPham);
            ProductUpdated?.Invoke();
            MessageBox.Show("Cập nhật hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Bạn muốn thoát?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes) {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                    this.Close();
                }
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

        private void btnQuetMa_Click(object sender, EventArgs e)
        {
            if (canScan)
            {
                canScan = false; // Ngăn chặn quét liên tục
                QuetMa();

                timer1.Start(); // Kích hoạt Timer
            }
        }

        public void QuetMa()
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[2].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs e)
        {
            Bitmap bitmap = (Bitmap)e.Frame.Clone();
            BarcodeReader barcodeReader = new BarcodeReader();
            var result = barcodeReader.Decode(bitmap);
            Console.WriteLine(result);

            if (result != null)
            {
                txtbarcode.Invoke(new MethodInvoker(delegate ()
                {
                    txtbarcode.Text = result.ToString();
                   
                }
                ));
            }

        }
    }
}
    