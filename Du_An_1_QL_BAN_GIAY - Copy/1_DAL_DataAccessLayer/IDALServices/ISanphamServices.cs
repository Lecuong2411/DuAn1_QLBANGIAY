using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IDALServices
{
   public interface ISanphamServices
    {
        string add(SanPham sanPham);
        string update(SanPham sanPham);
        List<SanPham> Getlst();
        void GetlstFromDB();
    }
}
