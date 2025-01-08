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
using Do_An.BUS;
using DevExpress.CodeParser;
using Excel = Microsoft.Office.Interop.Excel;

namespace Do_An.GUI
{
    public partial class Employee : Form
    {
        NhanVienService nhanVienService = new NhanVienService();
        public delegate void TruyenData(SanPham sp);
        public delegate void DeleteData(SanPham sp);
        public TruyenData truyenData;
        private int selectedRowIndex = -1;
       NhanVien nhanVien = new NhanVien();

        public Employee()
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
            ThemNV themNV = new ThemNV();
            themNV.OnEmployeeAdded += newEmployee =>
            {
               
                BindingData(nhanVienService.GetAllNhanViens());
            };
            themNV.Show();

        }

        private void Product_Load(object sender, EventArgs e)
        {
            BindingData(nhanVienService.GetAllNhanViens());
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.AutoResizeColumns();
            
            if(frm_main.nv.ChucVu.MaChucVu == "CV02")
            {
                btnAdd.BackColor = Color.Gainsboro;
                btnAdd.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;

            }   

        }

        public void BindingData(List<NhanVien> nhanVienList)
        {
            dgvProduct.Rows.Clear();
            foreach (var nhanVien in nhanVienList)
            {
               
                var index = dgvProduct.Rows.Add();
                dgvProduct.Rows[index].Cells[0].Value = nhanVien.MaNV;
                dgvProduct.Rows[index].Cells[1].Value = nhanVien.TenNV;
                dgvProduct.Rows[index].Cells[2].Value = nhanVien.GioiTinh; 
                dgvProduct.Rows[index].Cells[3].Value = nhanVien.NgaySinh;
                dgvProduct.Rows[index].Cells[4].Value = nhanVien.SDT;

                dgvProduct.Rows[index].Cells[5].Value = nhanVien.ChucVu.TenChucVu;

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
            BindingData(nhanVienService.GetAllNhanViens());
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string maSp = dgvProduct.Rows[selectedRowIndex].Cells[0].Value.ToString();
            NhanVien nv = nhanVienService.FindByID(maSp);
            EditNV view = new EditNV(nv);
            view.ProductUpdated += Reloadata;
            view.Show();



        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn xóa !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string maNV = dgvProduct.Rows[selectedRowIndex].Cells[0].Value.ToString();
                nhanVienService.DeleteNhanVien(maNV);
                BindingData(nhanVienService.GetAllNhanViens());
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string maSp = dgvProduct.Rows[selectedRowIndex].Cells[0].Value.ToString();
            NhanVien nv = nhanVienService.FindByID(maSp);
            ViewNV view = new ViewNV(nv);
            view.ProductUpdated += Reloadata;
            view.Show();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var nhanVien = nhanVienService.FindByID(dgvProduct.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (nhanVien.Avatar != null)
                {
                    pictureBox1.Image = Image.FromFile(nhanVien.Avatar);
                }
                else
                {
                    pictureBox1.Image = Image.FromFile("D:\\PhamNgocTu\\Images\\images.png");

                }
                lblTenNv.Text = nhanVien.TenNV;
                lblChucVu.Text = nhanVien.ChucVu.TenChucVu;
            }
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;

                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = workbook.Sheets[1];

                worksheet.Cells[1, 1] = "Mã NV";
                worksheet.Cells[1, 2] = "Tên NV";
                worksheet.Cells[1, 3] = "Giới tính";
                worksheet.Cells[1, 4] = "Ngày sinh";
                worksheet.Cells[1, 5] = "Số điện thoại";
                worksheet.Cells[1, 6] = "Chức vụ";

                int rowIndex = 2;
                foreach (var item in dgvProduct.Rows)
                {
                    if (item is DataGridViewRow row)
                    {
                        worksheet.Cells[rowIndex, 1] = row.Cells[0].Value?.ToString();
                        worksheet.Cells[rowIndex, 2] = row.Cells[1].Value?.ToString();
                        worksheet.Cells[rowIndex, 3] = row.Cells[2].Value?.ToString();
                        worksheet.Cells[rowIndex, 4] = row.Cells[3].Value?.ToString();
                        worksheet.Cells[rowIndex, 5] = row.Cells[4].Value?.ToString();
                        worksheet.Cells[rowIndex, 6] = row.Cells[5].Value?.ToString();


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
    }
}
