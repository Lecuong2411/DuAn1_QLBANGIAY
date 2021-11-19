using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Context;
using _1_DAL_DataAccessLayer.IDALServices;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.DALServices
{
    public class SizeServices : ISizeServices
    {
        DBContext _dbContext;
        List<Size> _lstsizes;
        public SizeServices()
        {
            _dbContext = new DBContext();
            _lstsizes = new List<Size>();
            GetlstFromDB();
        }
        public string add(Size size)
        {
            _dbContext.Sizes.Add(size);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Thêm dữ liệu thành công";
        }

        public List<Size> Getlst()
        {
            return _lstsizes;
        }

        public void GetlstFromDB()
        {
            _lstsizes = _dbContext.Sizes.ToList();
        }

        public string update(Size size)
        {
            _dbContext.Sizes.Update(size);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Cập nhật dữ liệu thành công";
        }
    }
}
