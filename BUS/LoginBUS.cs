using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Database;
namespace BUS
{
    public class LoginBUS
    {
        private Model1 context;
        public LoginBUS()
        { 
            context = new Model1(); 
        }
        public NhanVien Authenticate(string username, string password)
        {
            return context.NhanViens.FirstOrDefault(nv => nv.TaiKhoan == username && nv.MatKhau == password);
        }
    }
}
