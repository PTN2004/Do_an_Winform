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
    public partial class QLNhanvien : Form
    {
        private readonly NhanVienBUS nhanVienBUS;

        public QLNhanvien()
        {
            InitializeComponent();
            nhanVienBUS = new NhanVienBUS();

        }

        private void QLNhanvien_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadChucVuCombobox();
        }
        private void LoadChucVuCombobox()
        {
            var listChucVus = nhanVienBUS.GetAllChucVus();
            cbchucvu.DataSource = listChucVus;
            cbchucvu.DisplayMember = "TenChucVu";
            cbchucvu.ValueMember = "MaChucVu";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                var newNhanVien = new NhanVien
                {
                    MaNV = int.Parse(txtManv.Text),
                    TenNV = txtTennv.Text,
                    GioiTinh = radnam.Checked ? "Nam" : "Nữ",
                    NgaySinh = datebirth.Value,
                    SDT = maskedSDT.Text,
                    DiaChi = txtDC.Text,
                    NgayVaoLam = dateworking.Value,
                    TaiKhoan = txttk.Text,
                    MatKhau = txtmk.Text,
                    ChucVu = (int)cbchucvu.SelectedValue
                };

                nhanVienBUS.AddNhanVien(newNhanVien);
                MessageBox.Show("Thêm nhân viên thành công!");
                LoadData();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
        private void LoadData()
        {
            var nhanViens = nhanVienBUS.GetAllNhanViens();
            dgvQLnv.DataSource = nhanViens.Select(nv => new
            {
                nv.MaNV,
                nv.TenNV,
                nv.GioiTinh,
                nv.NgaySinh,
                nv.SDT,
                nv.DiaChi,
                nv.NgayVaoLam,
                nv.TaiKhoan,
                nv.MatKhau,
                TenChucVu = nv.ChucVu1.TenChucVu
            }).ToList();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvQLnv.CurrentRow != null)
                {
                    int maNV = Convert.ToInt32(dgvQLnv.CurrentRow.Cells["MaNV"].Value);
                    nhanVienBUS.DeleteNhanVien(maNV);
                    MessageBox.Show("Xóa nhân viên thành công!");
                    LoadData();
                    ClearInputFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvQLnv.CurrentRow != null)
                {
                    var updatedNhanVien = new NhanVien
                    {
                        MaNV = int.Parse(txtManv.Text),
                        TenNV = txtTennv.Text,
                        GioiTinh = radnam.Checked ? "Nam" : "Nữ",
                        NgaySinh = datebirth.Value,
                        SDT = maskedSDT.Text,
                        DiaChi = txtDC.Text,
                        NgayVaoLam = dateworking.Value,
                        TaiKhoan = txttk.Text,
                        MatKhau = txtmk.Text,
                        ChucVu = (int)cbchucvu.SelectedValue
                    };

                    nhanVienBUS.UpdateNhanVien(updatedNhanVien);
                    MessageBox.Show("Cập nhật nhân viên thành công!");
                    LoadData();
                    ClearInputFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
        private void ClearInputFields()
        {
            txtManv.Clear();
            txtTennv.Clear();
            radnam.Checked = false;
            radnu.Checked = false;
            datebirth.Value = DateTime.Now;
            maskedSDT.Clear();
            txtDC.Clear();
            dateworking.Value = DateTime.Now;
            txttk.Clear();
            txtmk.Clear();
            cbchucvu.SelectedIndex = -1;
        }

        private void dgvQLnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvQLnv.Rows[e.RowIndex];

                    txtManv.Text = row.Cells["MaNV"].Value?.ToString();
                    txtTennv.Text = row.Cells["TenNV"].Value?.ToString();
                    txtDC.Text = row.Cells["DiaChi"].Value?.ToString();
                    txttk.Text = row.Cells["TaiKhoan"].Value?.ToString();
                    txtmk.Text = row.Cells["MatKhau"].Value?.ToString();
                    maskedSDT.Text = row.Cells["SDT"].Value?.ToString();

                    datebirth.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                    dateworking.Value = Convert.ToDateTime(row.Cells["NgayVaoLam"].Value);

                    string gioiTinh = row.Cells["GioiTinh"].Value?.ToString();
                    if (gioiTinh == "Nam")
                    {
                        radnam.Checked = true;
                        radnu.Checked = false;
                    }
                    else if (gioiTinh == "Nữ")
                    {
                        radnu.Checked = true;
                        radnam.Checked = false;
                    }

                    string tenChucVu = row.Cells["TenChucVu"].Value?.ToString();
                    cbchucvu.SelectedIndex = cbchucvu.FindStringExact(tenChucVu);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void QLNhanvien_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void txtSeacrh_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            dgvQLnv.DataSource = nhanVienBUS.SearchNhanVien(keyword)
                .Select(nv => new
                {
                    nv.MaNV,
                    nv.TenNV,
                    nv.GioiTinh,
                    nv.NgaySinh,
                    nv.SDT,
                    nv.DiaChi,
                    nv.NgayVaoLam,
                    nv.TaiKhoan,
                    nv.MatKhau,
                    TenChucVu = nv.ChucVu1.TenChucVu
                })
                .ToList();
        }


        private void QLNhanvien_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
