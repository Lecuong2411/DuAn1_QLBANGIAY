using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IDALServices
{
   public interface ILoaicogiayServices
    {
        string add(LoaiCoGiay loaiCoGiay);
        string update(LoaiCoGiay loaiCoGiay);
        List<LoaiCoGiay> Getlst();
        void GetlstFromDB();
    }
}
