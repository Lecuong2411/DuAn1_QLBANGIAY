using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IDALServices
{
   public interface IChitietSanPhamServices
    {
        string add(ChiTietSanPham chiTietSanPham);
        string update(ChiTietSanPham chiTietSanPham);
        List<ChiTietSanPham> Getlst();
        void GetlstFromDB();
    }
}
