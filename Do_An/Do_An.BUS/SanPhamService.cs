using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An.DAL;

namespace DoAn.BUS
{
    public class SanPhamService
    {
        
        public void AddSanPham(SanPham sanPham)
        {
            MinicontextDB context = new MinicontextDB();
            if ((sanPham.MaSP == null) ||( sanPham.MaSP == null))
                throw new Exception("Mã sản phẩm không hợp lệ.");
            if (string.IsNullOrEmpty(sanPham.TenSP))
                throw new Exception("Tên sản phẩm không được để trống.");
            if (sanPham.Gia == null || sanPham.Gia <= 0)
                throw new Exception("Giá sản phẩm phải lớn hơn 0.");

            context.SanPhams.Add(sanPham);
            context.SaveChanges();           
        }


        public void UpdateSanPham(SanPham sanPham)
        {
            MinicontextDB context = new MinicontextDB();
            // Validation checks (if needed)
            if (sanPham.MaSP == null)
                throw new Exception("Mã sản phẩm không hợp lệ.");
           

            context.SanPhams.AddOrUpdate(sanPham);
            context.SaveChanges();

           
        }

        // Delete a product by ID
        public void DeleteSanPham(string maSp)
        {
            MinicontextDB context = new MinicontextDB();
            
            SanPham sp = context.SanPhams.FirstOrDefault(p => p.MaSP == maSp);
            if (sp != null)
            {
                context.SanPhams.Remove(sp);
                context.SaveChanges();
            }
           
            
        }
        

        // Get all products
        public List<SanPham> GetAllSanPhams()
        {
            MinicontextDB context = new MinicontextDB();
            return context.SanPhams.ToList();            
        }

        public SanPham FindByID(string maSP)
        {
            MinicontextDB context = new MinicontextDB();
            return context.SanPhams.FirstOrDefault(p => p.MaSP == maSP);
        }

        // Search products
        public List<SanPham> SearchSanPhams(string searchText)
        {
            MinicontextDB context = new MinicontextDB();
            return context.SanPhams
                     .Where(sp => sp.TenSP.Contains(searchText) || sp.MaSP.ToString().Contains(searchText) ||
                                  sp.Gia.ToString().Contains(searchText) || sp.SoLuongTon.ToString().Contains(searchText)).Include("LoaiSP")
                     .ToList();
        }

        // Get all product categories (LoaiSP)
        //public List<LoaiSP> GetLoaiSPs()
        //{
        //    return 
        //}

        public int CountSP()
        {
            MinicontextDB context = new MinicontextDB();
            return context.SanPhams.Count();
        }

        public int countSLTon()
        {
            MinicontextDB context = new MinicontextDB();
            return context.SanPhams.Sum(p => (int)p.SoLuongTon);
        }

        public SanPham FindByBarcode(string barcode)
        {
            MinicontextDB context = new MinicontextDB();
            return context.SanPhams.FirstOrDefault(p => p.BarCode == barcode);
        }

        public bool checkMaSP(string maSP)
        {
            MinicontextDB context = new MinicontextDB();
            return context.SanPhams.Any(p => p.MaSP == maSP);
        }

        
    }
}
