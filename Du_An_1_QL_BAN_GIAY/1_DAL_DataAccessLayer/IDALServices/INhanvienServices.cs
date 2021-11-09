using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IDALServices
{
  public  interface INhanvienServices
    {
        string add(NhanVien nhanVien);
        string update(NhanVien nhanVien);
        List<NhanVien> Getlst();
        void GetlstFromDB();
    }
}
