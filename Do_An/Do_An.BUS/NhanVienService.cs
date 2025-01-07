using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An.DAL;

namespace Do_An.BUS
{
    public class NhanVienService
    {
        MinicontextDB context = new MinicontextDB();
        public List<NhanVien> GetAllNhanViens()
        {
            return context.NhanViens.ToList();
        }

        public NhanVien FindByID(string maNV)
        {
            
            return context.NhanViens.FirstOrDefault(p => p.MaNV == maNV);
        }

        public void AddNhanVien(NhanVien nhanVien)
        {
           
        }
        public void UpdateNhanVien(NhanVien nhanVien)
        {

        }
        public void DeleteNhanVien(string maNV)
        {
            context.NhanViens.Remove(FindByID(maNV));
        }
    }
}
