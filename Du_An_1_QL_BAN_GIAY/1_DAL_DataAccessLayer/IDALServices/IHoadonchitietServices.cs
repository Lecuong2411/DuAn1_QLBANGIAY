using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IDALServices
{
  public  interface IHoadonchitietServices
    {
        string add(HoaDonChiTiet hoaDonChiTiet);
        string update(HoaDonChiTiet hoaDonChiTiet);
        List<HoaDonChiTiet> Getlst();
        void GetlstFromDB();
    }
}
