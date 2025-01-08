using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An.DAL;

namespace Do_An.BUS
{
    public class NhanVienService
    {
        MinicontextDB contextGlobal = new MinicontextDB();
        public List<NhanVien> GetAllNhanViens()
        {
            MinicontextDB context = new MinicontextDB();
            return context.NhanViens.ToList();
        }

        public NhanVien FindByID(string maNV)
        {
            MinicontextDB context = new MinicontextDB();

            return context.NhanViens.FirstOrDefault(p => p.MaNV == maNV);
        }

        public void AddNhanVien(NhanVien nhanVien)
        {
            MinicontextDB context = new MinicontextDB();
            context.NhanViens.Add(nhanVien);
            context.SaveChanges();

        }
        public void UpdateNhanVien(NhanVien nhanVien)
        {
            MinicontextDB context = new MinicontextDB();
            context.NhanViens.AddOrUpdate(nhanVien);
            context.SaveChanges();
        }
        public void DeleteNhanVien(string maNV)
        {

            using (MinicontextDB context = new MinicontextDB())
            {
                try
                {
                    NhanVien nv = context.NhanViens.FirstOrDefault(p => p.MaNV == maNV);
                    if (nv != null)
                    {
                        context.NhanViens.Remove(nv);
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

        public int CountNhanVien()
        {
            MinicontextDB context = new MinicontextDB();
            return context.NhanViens.Count();
        }
    }
}
