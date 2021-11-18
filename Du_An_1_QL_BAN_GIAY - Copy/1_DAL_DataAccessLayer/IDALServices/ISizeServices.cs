using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IDALServices
{
  public  interface ISizeServices
    {
        string add(Size size);
        string update(Size size);
        List<Size> Getlst();
        void GetlstFromDB();
    }
}
