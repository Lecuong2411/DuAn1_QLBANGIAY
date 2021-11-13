using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IDALServices
{
   public interface IColorServices
    {
        string add(Color color);
        string update(Color color);
        List<Color> Getlst();
        void GetlstFromDB();
    }
}
