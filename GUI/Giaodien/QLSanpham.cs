using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL.Database;
using Excel = Microsoft.Office.Interop.Excel;

namespace DOAN1.Giaodien
{
    public partial class QLSanpham : Form
    {
        private readonly SanPhamBUS sanPhamBUS;

        public QLSanpham()
        {
            InitializeComponent();
            sanPhamBUS = new SanPhamBUS();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                var sanPham = new SanPham
                {
                    MaSP = int.Parse(txtMaSP.Text),
                    TenSP = txtTenSP.Text,
                    Gia = decimal.TryParse(txtGia.Text, out decimal gia) ? gia : (decimal?)null,
                    SoLuongTon = int.TryParse(txtSLT.Text, out int soLuongTon) ? soLuongTon : (int?)null,
                    MaLoaiSP = (int)cbLoaiSP.SelectedValue
                };

                sanPhamBUS.AddSanPham(sanPham);
                MessageBox.Show("Thêm sản phẩm thành công!");
                LoadData();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void QLSanpham_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                var listLoaiSPs = sanPhamBUS.GetLoaiSPs();
                cbLoaiSP.DataSource = listLoaiSPs;
                cbLoaiSP.DisplayMember = "TenLoaiSP";
                cbLoaiSP.ValueMember = "MaLoaiSP";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải form QLSanpham: " + ex.Message);
            }
        }
        private void FillLoaiSPCombobox(List<LoaiSP> listLoaiSPs)
        {
            cbLoaiSP.DataSource = listLoaiSPs;
            cbLoaiSP.DisplayMember = "TenLoaiSP";
            cbLoaiSP.ValueMember = "MaLoaiSP";
        }

        private void dgvQLsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvQLsp.CurrentRow != null)
                {
                    int maSP = Convert.ToInt32(dgvQLsp.CurrentRow.Cells["MaSP"].Value);

                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        sanPhamBUS.DeleteSanPham(maSP);
                        MessageBox.Show("Xóa sản phẩm thành công!");
                        LoadData();
                        ClearInputFields();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void Del_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvQLsp.CurrentRow != null)
                {
                    int maSP = Convert.ToInt32(dgvQLsp.CurrentRow.Cells["MaSP"].Value);
                    sanPhamBUS.DeleteSanPham(maSP);
                    MessageBox.Show("Xóa sản phẩm thành công!");
                    LoadData();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
        private void LoadData()
        {
            try
            {
                var listSanPhams = sanPhamBUS.GetAllSanPhams().Select(sp => new
                {
                    sp.MaSP,
                    sp.TenSP,
                    sp.Gia,
                    sp.SoLuongTon,
                    TenLoaiSP = sp.LoaiSP.TenLoaiSP
                }).ToList();

                dgvQLsp.DataSource = listSanPhams;
                dgvQLsp.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
        private void ClearInputFields()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtGia.Clear();
            txtSLT.Clear();
            cbLoaiSP.SelectedIndex = -1;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text.ToLower();

                Task.Delay(300).ContinueWith(_ =>
                {
                    var filteredList = sanPhamBUS.SearchSanPhams(searchText).Select(sp => new
                    {
                        sp.MaSP,
                        sp.TenSP,
                        sp.Gia,
                        sp.SoLuongTon,
                        TenLoaiSP = sp.LoaiSP.TenLoaiSP
                    }).ToList();

                    Invoke((Action)(() =>
                    {
                        dgvQLsp.DataSource = filteredList;
                    }));
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void QLSanpham_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Excel_Click(object sender, EventArgs e)
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
                worksheet.Cells[1, 5] = "Loại Sản Phẩm";

                int rowIndex = 2;  
                foreach (var item in dgvQLsp.Rows)
                {
                    if (item is DataGridViewRow row)
                    {
                        worksheet.Cells[rowIndex, 1] = row.Cells["MaSP"].Value?.ToString();
                        worksheet.Cells[rowIndex, 2] = row.Cells["TenSP"].Value?.ToString();
                        worksheet.Cells[rowIndex, 3] = row.Cells["Gia"].Value?.ToString();
                        worksheet.Cells[rowIndex, 4] = row.Cells["SoLuongTon"].Value?.ToString();
                        worksheet.Cells[rowIndex, 5] = row.Cells["TenLoaiSP"].Value?.ToString();

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

        private void dgvQLsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvQLsp.Rows[e.RowIndex];
                    txtMaSP.Text = row.Cells["MaSP"].Value?.ToString();
                    txtTenSP.Text = row.Cells["TenSP"].Value?.ToString();
                    txtGia.Text = row.Cells["Gia"].Value?.ToString();
                    txtSLT.Text = row.Cells["SoLuongTon"].Value?.ToString();

                    string tenLoaiSP = row.Cells["TenLoaiSP"].Value?.ToString();
                    cbLoaiSP.SelectedIndex = cbLoaiSP.FindStringExact(tenLoaiSP);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
    }
}
