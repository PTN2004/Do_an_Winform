﻿using System;
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
            using (MinicontextDB context = new MinicontextDB())
            {
                try
                {
                    SanPham sp = context.SanPhams.FirstOrDefault(p => p.MaSP == maSp);
                    if (sp != null)
                    {
                        context.SanPhams.Remove(sp);
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Sản phẩm không tồn tại trong cơ sở dữ liệu.");
                    }
                }
                catch (Exception ex)
                {
                    // Ghi log lỗi hoặc xử lý lỗi phù hợp
                    throw new Exception("Đã xảy ra lỗi khi xóa sản phẩm: " + ex.Message);
                }
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
            string search = searchText.Trim();
            MinicontextDB context = new MinicontextDB();
            return context.SanPhams
                     .Where(sp => sp.TenSP.Trim().Contains(search) || sp.MaSP.ToString().Contains(search) ||
                                  sp.Gia.ToString().Contains(search) || sp.SoLuongTon.ToString().Contains(search)).Include("LoaiSP")
                     .ToList();
        }


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
