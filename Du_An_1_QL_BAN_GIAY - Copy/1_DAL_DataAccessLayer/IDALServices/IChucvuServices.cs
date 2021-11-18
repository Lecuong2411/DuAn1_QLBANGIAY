using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IDALServices
{
   public interface IChucvuServices
    {
        string add(ChucVu chucVu);
        string update(ChucVu chucVu);
        List<ChucVu> Getlst();
        void GetlstFromDB();
    }
}
