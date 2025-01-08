using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Do_An.BUS;
using Do_An.DAL;
using DoAn.BUS;
using ZXing;
using ZXing.QrCode.Internal;

namespace Do_An.GUI
{
    public partial class ThanhToan : Form
    {

        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCaptureDevice;
        private SanPhamService sanPhamService = new SanPhamService();
        private HoaDonService hoaDonService = new HoaDonService();
        private CTHoaDonService ctHoaDonService = new CTHoaDonService();
        private bool canScan = true;

        public ThanhToan()
        {
            InitializeComponent();
        }

        private void dataGridView1_Resize(object sender, EventArgs e)
        {
            dgvThanhToan.AutoResizeColumns();
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            dgvThanhToan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThanhToan.AutoResizeColumns();

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            cmbListVideo.Items.Clear();

        
            if (filterInfoCollection.Count > 0)
            {
            
                foreach (FilterInfo device in filterInfoCollection)
                {
                    cmbListVideo.Items.Add(device.Name);
                }

                // Chọn camera đầu tiên làm mặc định
                cmbListVideo.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Không tìm thấy camera nào.");
            }
            lblMaHD.Text = GenerateInvoiceNumber();
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cmbPT.SelectedIndex = 0;
            lblNhanVien.Text = frm_main.nv.TenNV;
        }

        private void panelChiTiet_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
           lblSl.Text = (int.Parse(lblSl.Text) + 1).ToString();
           lblThanhTien.Text = (int.Parse(lblSl.Text) * int.Parse(lblGia.Text)).ToString();
           BindingDataGrid(txtBarCode.Text);


        }

        private void txtSearch_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
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
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cmbListVideo.SelectedIndex].MonikerString);
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
                txtBarCode.Invoke(new MethodInvoker(delegate ()
                {
                    txtBarCode.Text = result.ToString();
                    FillData(result.ToString());
                    BindingDataGrid(result.ToString());
                    ComputeTongTien();
                } 
                ));

                
            }
            picVideo.Image = bitmap;

        }

        private void BindingDataGrid(string barcode)
        {
            
            int index = GetRow(barcode);
            if (index == -1)
            {
                var i = dgvThanhToan.Rows.Add();
                AddDataGrid(i);
            }
            else
            {
                AddDataGrid(index);
            }

        }

        private int GetRow(string barcode)
        {
            SanPham sp = sanPhamService.FindByBarcode(barcode);
            if(sp != null)
            {
                foreach (DataGridViewRow row in dgvThanhToan.Rows)
                {
                    if (row.Cells[0].Value.ToString() == sp.MaSP)
                    {
                        return row.Index;
                    }
                }
            }
                

        
             return -1;
        }
        private void AddDataGrid(int index)
        {
            dgvThanhToan.Rows[index].Cells[0].Value = lblMaSp.Text;
            dgvThanhToan.Rows[index].Cells[1].Value = lblTenSP.Text;
            dgvThanhToan.Rows[index].Cells[2].Value = lblSl.Text;
            dgvThanhToan.Rows[index].Cells[3].Value = lblGia.Text;
            dgvThanhToan.Rows[index].Cells[4].Value = lblThanhTien.Text;
        }

        private void FillData(string barcode)
        {
           SanPham sp =sanPhamService.FindByBarcode(barcode);
            if (sp != null)
            {
                lblMaSp.Text = sp.MaSP;
                lblTenSP.Text = sp.TenSP;
                lblGia.Text = sp.Gia.ToString();
                lblSl.Text = "1";
                lblKhuyenMai.Text = null;
                lblThanhTien.Text = (sp.Gia * int.Parse(lblSl.Text)).ToString();

            }
        }

        private void ComputeTongTien()
        {
            int sum = 0;
            foreach (DataGridViewRow row in dgvThanhToan.Rows)
            {
                sum += int.Parse(row.Cells[4].Value.ToString());
            }
            lblTongTien.Text = sum.ToString();
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            if (videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            canScan = true; // Cho phép quét lại
            timer1.Stop();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(lblSl.Text);
            if (sl == 1)
            {
               int index = GetRow(txtBarCode.Text);
                dgvThanhToan.Rows.RemoveAt(index);
                lblSl.Text = (int.Parse(lblSl.Text) - 1).ToString();
                lblThanhTien.Text = (int.Parse(lblSl.Text) * int.Parse(lblGia.Text)).ToString();

            }
            else
            {
                lblSl.Text = (int.Parse(lblSl.Text) - 1).ToString();
                lblThanhTien.Text = (int.Parse(lblSl.Text) * int.Parse(lblGia.Text)).ToString();
                BindingDataGrid(txtBarCode.Text);
            }

        }

        public string GenerateInvoiceNumber()
        {
           
            string maSp;
            
            string prefix = "HD";
            string number = (hoaDonService.CountHoaDon()+1).ToString();
            maSp = prefix + number;
        
            return maSp;
        }

        private void dgvThanhToan_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvThanhToan_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                
                ComputeTongTien();
            }
        }

        private void dgvThanhToan_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //if (dgvThanhToan.Rows.Count >= 2)
            //{
            //    MessageBox.Show("Có thay đổi" + dgvThanhToan.Rows.Count.ToString());
            //    ComputeTongTien();
            //}
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if(cmbPT.SelectedIndex == 0)
            {
                HoaDon hd = new HoaDon();
                hd.MaHD = lblMaHD.Text;
                hd.NgayLap = DateTime.Now;
                hd.TongTien = long.Parse(lblTongTien.Text);
                hd.MaKH = null;
                hd.MaNV = frm_main.nv.MaNV;
                hoaDonService.AddHoaDon(hd);


                foreach (DataGridViewRow row in dgvThanhToan.Rows)
                {
                    ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
                    chiTietHoaDon.MaHD = hd.MaHD;
                    chiTietHoaDon.MaSP = row.Cells[0].Value.ToString();
                    chiTietHoaDon.SoLuong = int.Parse(row.Cells[2].Value.ToString());
                    ctHoaDonService.AddChiTietHoaDon(chiTietHoaDon);

                }
                MessageBox.Show("Thanh toán thành công");



            }
        }

        private void dgvThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(e.RowIndex >= 0)
            //{
            //    lblMaSp.Text = dgvThanhToan.Rows[e.RowIndex].Cells[0].Value.ToString();
            //    lblTenSP.Text = dgvThanhToan.Rows[e.RowIndex].Cells[1].Value.ToString();
            //    lblSl.Text = dgvThanhToan.Rows[e.RowIndex].Cells[2].Value.ToString();
            //    lblGia.Text = dgvThanhToan.Rows[e.RowIndex].Cells[3].Value.ToString();
            //    lblThanhTien.Text = dgvThanhToan.Rows[e.RowIndex].Cells[4].Value.ToString();
            //}
        }
    }
}
