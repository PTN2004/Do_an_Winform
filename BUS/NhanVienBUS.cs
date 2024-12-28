using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Database;

namespace BUS
{
    public class NhanVienBUS
    {
        private readonly Model1 context;

        public NhanVienBUS()
        {
            context = new Model1();
        }

        public List<NhanVien> GetAllNhanViens()
        {
            return context.NhanViens.ToList();
        }

        public List<ChucVu> GetAllChucVus()
        {
            return context.ChucVus.ToList();
        }

        public void AddNhanVien(NhanVien nhanVien)
        {
            context.NhanViens.Add(nhanVien);
            context.SaveChanges();
        }

        public void UpdateNhanVien(NhanVien updatedNhanVien)
        {
            var existingNhanVien = context.NhanViens.FirstOrDefault(nv => nv.MaNV == updatedNhanVien.MaNV);
            if (existingNhanVien != null)
            {
                existingNhanVien.TenNV = updatedNhanVien.TenNV;
                existingNhanVien.GioiTinh = updatedNhanVien.GioiTinh;
                existingNhanVien.NgaySinh = updatedNhanVien.NgaySinh;
                existingNhanVien.SDT = updatedNhanVien.SDT;
                existingNhanVien.DiaChi = updatedNhanVien.DiaChi;
                existingNhanVien.NgayVaoLam = updatedNhanVien.NgayVaoLam;
                existingNhanVien.ChucVu = updatedNhanVien.ChucVu;
                existingNhanVien.TaiKhoan = updatedNhanVien.TaiKhoan;
                existingNhanVien.MatKhau = updatedNhanVien.MatKhau;

                context.SaveChanges();
            }
        }

        public void DeleteNhanVien(int maNV)
        {
            var nhanVien = context.NhanViens.FirstOrDefault(nv => nv.MaNV == maNV);
            if (nhanVien != null)
            {
                context.NhanViens.Remove(nhanVien);
                context.SaveChanges();
            }
        }

        public List<NhanVien> SearchNhanVien(string keyword)
        {
            keyword = keyword.ToLower();
            return context.NhanViens
                .Where(nv => nv.TenNV.ToLower().Contains(keyword) ||
                             nv.MaNV.ToString().Contains(keyword) ||
                             nv.SDT.Contains(keyword) ||
                             nv.DiaChi.ToLower().Contains(keyword))
                .ToList();
        }
    }
}
