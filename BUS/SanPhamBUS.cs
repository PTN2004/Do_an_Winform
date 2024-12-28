using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Database;
namespace BUS
{
    public class SanPhamBUS
    {
        public void AddSanPham(SanPham sanPham)
        {
            // Business validation (e.g., check if MaSP is valid, TenSP is not empty, etc.)
            if (sanPham.MaSP <= 0)
                throw new Exception("Mã sản phẩm không hợp lệ.");
            if (string.IsNullOrEmpty(sanPham.TenSP))
                throw new Exception("Tên sản phẩm không được để trống.");
            if (sanPham.Gia == null || sanPham.Gia <= 0)
                throw new Exception("Giá sản phẩm phải lớn hơn 0.");

            // Call DAL to add the product
            using (var context = new Model1())
            {
                context.SanPhams.Add(sanPham);
                context.SaveChanges();
            }
        }

        // Update an existing product
        public void UpdateSanPham(SanPham sanPham)
        {
            // Validation checks (if needed)
            if (sanPham.MaSP <= 0)
                throw new Exception("Mã sản phẩm không hợp lệ.");

            using (var context = new Model1())
            {
                context.Entry(sanPham).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        // Delete a product by ID
        public void DeleteSanPham(int maSP)
        {
            using (var context = new Model1())
            {
                var sanPham = context.SanPhams.FirstOrDefault(sp => sp.MaSP == maSP);
                if (sanPham != null)
                {
                    context.SanPhams.Remove(sanPham);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Không tìm thấy sản phẩm để xóa.");
                }
            }
        }

        // Get all products
        public List<SanPham> GetAllSanPhams()
        {
            using (var context = new Model1())
            {
                return context.SanPhams.Include("LoaiSP").ToList();
            }
        }

        // Search products
        public List<SanPham> SearchSanPhams(string searchText)
        {
            using (var context = new Model1())
            {
                return context.SanPhams
                    .Where(sp => sp.TenSP.Contains(searchText) || sp.MaSP.ToString().Contains(searchText) ||
                                 sp.Gia.ToString().Contains(searchText) || sp.SoLuongTon.ToString().Contains(searchText))
                    .Include("LoaiSP")
                    .ToList();
            }
        }

        // Get all product categories (LoaiSP)
        public List<LoaiSP> GetLoaiSPs()
        {
            using (var context = new Model1())
            {
                return context.LoaiSPs.ToList();
            }
        }
    
    }
}
