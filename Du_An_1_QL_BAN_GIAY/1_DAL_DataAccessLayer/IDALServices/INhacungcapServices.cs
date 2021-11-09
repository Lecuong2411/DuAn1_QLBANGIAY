using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IDALServices
{
   public interface INhacungcapServices
    {
        string add(NhaCungCap nhaCungCap);
        string update(NhaCungCap nhaCungCap);
        List<NhaCungCap> Getlst();
        void GetlstFromDB();
    }
}
