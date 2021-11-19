using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IDALServices
{
   public interface IKhachhangServices
    {
        string add(KhachHang khachHang);
        string update(KhachHang khachHang);
        List<KhachHang> Getlst();
        void GetlstFromDB();
    }
}
