using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IDALServices
{
  public  interface IHoadonServices
    {
        string add(HoaDon hoaDon);
        string update(HoaDon hoaDon);
        List<HoaDon> Getlst();
        void GetlstFromDB();
    }
}
