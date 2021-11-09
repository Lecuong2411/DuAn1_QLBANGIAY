using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IDALServices
{
   public interface IHistoryServices
    {
        string add(History history);
        string update(History history);
        List<History> Getlst();
        void GetlstFromDB();
    }
}
