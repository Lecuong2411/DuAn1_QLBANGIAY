using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IDALServices
{
  public  interface IDanhmucServices
    {
        string add(DanhMuc danhMuc);
        string update(DanhMuc danhMuc);
        List<DanhMuc> Getlst();
        void GetlstFromDB();
    }
}
