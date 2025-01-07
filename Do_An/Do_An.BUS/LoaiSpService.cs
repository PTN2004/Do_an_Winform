using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An.DAL;

namespace Do_An.BUS
{
    public class LoaiSpService
    {

        MinicontextDB context = new MinicontextDB();

        public List<LoaiSP> GetLoaiSP()
        {
            return context.LoaiSPs.ToList();
        }
    }
}
