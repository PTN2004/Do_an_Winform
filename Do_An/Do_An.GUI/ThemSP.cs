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
    public partial class ThemSP : Form
    {
        SanPhamService sanPhamService = new SanPhamService();
        LoaiSpService loaiSpService = new LoaiSpService();
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCaptureDevice;
        public delegate void AddProductHandler(SanPham newProduct);
        public event AddProductHandler OnProductAdded;
        private bool canScan = true;
        string filePath = null;

        public ThemSP()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ThemSP_Load(object sender, EventArgs e)
        {
            FillComboBox(loaiSpService.GetLoaiSP());
        }
        private void FillComboBox(List<LoaiSP> spList)
        {
            cmbLoaiSP.DataSource = spList;
            cmbLoaiSP.DisplayMember = "TenLoaiSP";
            cmbLoaiSP.ValueMember = "MaLoaiSP";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private string UploadImage()
        {
            
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
            UploadImage();
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            SanPham sanPham = new SanPham();
            sanPham.MaSP = txtMaSP.Text;
            sanPham.TenSP = txtTenSP.Text;
            sanPham.DonViTinh = txtDoViTinh.Text;
            sanPham.Gia = int.Parse(txtGiaBan.Text);
            sanPham.GiaNhap = int.Parse(txtGiaNhap.Text);
            sanPham.SoLuongTon = int.Parse(txtSoLuongNhap.Text);
            sanPham.BarCode = txtBarcode.Text;
            sanPham.MaLoaiSP = cmbLoaiSP.SelectedValue.ToString();
            sanPham.ImagePath = filePath;
            sanPhamService.AddSanPham(sanPham);

            OnProductAdded.Invoke(sanPham);
            MessageBox.Show("Thêm hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearData();
        }

        private void ClearData()
        {
            txtBarcode.Clear();
            txtDoViTinh.Clear();
            txtGiaNhap.Clear();
            txtGiaBan.Clear();
            txtSoLuongNhap.Clear();
            txtTenSP.Clear();
            txtMaSP.Clear();
            cmbLoaiSP.SelectedIndex = 0;
            picSP.Image = null;
        }


        
        private void btnClose_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Bạn có muốn ngừng thêm sản phẩm không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes) { 
                this.Close();
             }
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
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[3].MonikerString);
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
                txtBarcode.Invoke(new MethodInvoker(delegate ()
                {
                    txtBarcode.Text = result.ToString();
                    
                }
                ));


            }
            

        }


    }
}
    