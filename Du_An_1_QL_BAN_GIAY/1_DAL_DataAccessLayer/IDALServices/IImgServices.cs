using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IDALServices
{
 public   interface IImgServices
    {
        string add(Image image);
        string update(Image image);
        List<Image> Getlst();
        void GetlstFromDB();
    }
}
