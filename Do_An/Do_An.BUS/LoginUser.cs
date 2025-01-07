using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An.DAL;


namespace Do_An.BUS
{
    public class LoginUser
    {
        private MinicontextDB context = new MinicontextDB();

        public NhanVien Authenticate(string username, string password)
        {
            return context.NhanViens.FirstOrDefault(nv => nv.TaiKhoan == username && nv.MatKhau == password);
        }
    }
}
