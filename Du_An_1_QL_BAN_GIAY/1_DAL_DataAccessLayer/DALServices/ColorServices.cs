using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.IDALServices;
using _1_DAL_DataAccessLayer.Context;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.DALServices
{
   public class ColorServices :IColorServices
    {
        DBContext _dbContext;
        List<Color> _lstcolors;
        public ColorServices()
        {
            _dbContext = new DBContext();
            _lstcolors = new List<Color>();
            GetlstFromDB();
        }
        public string add(Color color)
        {
            _dbContext.Colors.Add(color);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Thêm dữ liệu thành công";
        }

        public List<Color> Getlst()
        {
            return _lstcolors;
        }

        public void GetlstFromDB()
        {
            _lstcolors = _dbContext.Colors.ToList();
        }

        public string update(Color color)
        {
            _dbContext.Colors.Update(color);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Cập nhật dữ liệu thành công";
        }
    }
}
