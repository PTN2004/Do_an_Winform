using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Forms;
using DoAn.BUS;
using Do_An.DAL;
using System.Windows.Forms.VisualStyles;
using DevExpress.XtraRichEdit.Native;
using Excel = Microsoft.Office.Interop.Excel;

namespace Do_An.GUI
{
    public partial class Product : Form
    {
        SanPhamService sanPhamService = new SanPhamService();
        public delegate void TruyenData(SanPham sp);
        public delegate void DeleteData(SanPham sp);
        public TruyenData truyenData;
        private int selectedRowIndex = -1;
        
        public Product()
        {
            InitializeComponent();
           
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThemSP themSP = new ThemSP();
            themSP.OnProductAdded += newProduct =>
            {
               
                BindingData(sanPhamService.GetAllSanPhams());
            };
            themSP.Show();

        }

        private void Product_Load(object sender, EventArgs e)
        {
            BindingData(sanPhamService.GetAllSanPhams());
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.AutoResizeColumns();
            lblSoLuong.Text = sanPhamService.CountSP().ToString();
            lblTonKho.Text = sanPhamService.countSLTon().ToString();
            if(frm_main.nv.ChucVu.MaChucVu == "CV02")
            {
                btnAdd.BackColor = Color.Gainsboro;
                btnAdd.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;

            }   

        }

        public void BindingData(List<SanPham> sanPhamList)
        {
            dgvProduct.Rows.Clear();
            foreach (SanPham sanPham in sanPhamList)
            {
               
                var index = dgvProduct.Rows.Add();
                dgvProduct.Rows[index].Cells[1].Value = sanPham.MaSP;
                dgvProduct.Rows[index].Cells[2].Value = sanPham.TenSP;
                dgvProduct.Rows[index].Cells[3].Value = sanPham.DonViTinh;
                dgvProduct.Rows[index].Cells[4].Value = sanPham.GiaNhap;
                dgvProduct.Rows[index].Cells[5].Value = sanPham.Gia;
                dgvProduct.Rows[index].Cells[6].Value = sanPham.SoLuongTon;

            }
        }

        private void dgvProduct_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Product_Resize(object sender, EventArgs e)
        {
            
            dgvProduct.AutoResizeColumns();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvProduct_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dgvProduct_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                var hitTest = dgvProduct.HitTest(e.X, e.Y);


                if (hitTest.Type == DataGridViewHitTestType.Cell)
                {
                    // Hiển thị ContextMenuStrip tại vị trí chuột
                    materialContextMenuStrip1.Show(dgvProduct, e.Location);
                    selectedRowIndex = hitTest.RowIndex;

    }
            }
        }
        private void Reloadata()
        {
           
            // Cập nhật sản phẩm trong danh sách
            BindingData(sanPhamService.GetAllSanPhams());
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            string maSp = dgvProduct.Rows[selectedRowIndex].Cells[1].Value.ToString();
            SanPham sp = sanPhamService.FindByID(maSp);
            EditSP edit = new EditSP(sp);
            edit.ProductUpdated += Reloadata;
            edit.Show();
           
            

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn xóa !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string maSp = dgvProduct.Rows[selectedRowIndex].Cells[1].Value.ToString();
                sanPhamService.DeleteSanPham(maSp);
                BindingData(sanPhamService.GetAllSanPhams());
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string maSp = dgvProduct.Rows[selectedRowIndex].Cells[1].Value.ToString();
            SanPham sp = sanPhamService.FindByID(maSp);
            ViewSP view = new ViewSP(sp);
            view.ProductUpdated += Reloadata;
            view.Show();
        }

        private void btnXuatFile(object sender, EventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {

                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;

                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = workbook.Sheets[1];

                worksheet.Cells[1, 1] = "Mã SP";
                worksheet.Cells[1, 2] = "Tên SP";
                worksheet.Cells[1, 3] = "Giá";
                worksheet.Cells[1, 4] = "Số Lượng Tồn";
                worksheet.Cells[1, 5] = "Đơn vị tính";

                int rowIndex = 2;
                foreach (var item in dgvProduct.Rows)
                {
                    if (item is DataGridViewRow row)
                    {
                        worksheet.Cells[rowIndex, 1] = row.Cells[1].Value?.ToString();
                        worksheet.Cells[rowIndex, 2] = row.Cells[2].Value?.ToString();
                        worksheet.Cells[rowIndex, 3] = row.Cells[4].Value?.ToString();
                        worksheet.Cells[rowIndex, 4] = row.Cells[5].Value?.ToString();
                        worksheet.Cells[rowIndex, 5] = row.Cells[3].Value?.ToString();

                        rowIndex++;
                    }
                }

                worksheet.Columns.AutoFit();

                MessageBox.Show("Dữ liệu đã được xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            var listSearch = sanPhamService.SearchSanPhams(txtSearch.Text);
            BindingData(listSearch);
        }

        private void txtSearch_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}
