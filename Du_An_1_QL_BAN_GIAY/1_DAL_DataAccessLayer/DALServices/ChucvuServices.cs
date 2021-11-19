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
  public  class ChucvuServices :IChucvuServices
    {
        DBContext _dbContext;
        List<ChucVu> _lstchucVus;
        public ChucvuServices()
        {
            _dbContext = new DBContext();
            _lstchucVus = new List<ChucVu>();
            GetlstFromDB();
        }
        public string add(ChucVu chucVu)
        {
            _dbContext.ChucVus.Add(chucVu);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Thêm dữ liệu thành công";
        }

        public List<ChucVu> Getlst()
        {
            return _lstchucVus;
        }

        public void GetlstFromDB()
        {
            _lstchucVus = _dbContext.ChucVus.ToList();
        }

        public string update(ChucVu chucVu)
        {
            _dbContext.ChucVus.Update(chucVu);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Cập nhật dữ liệu thành công";
        }
    }
}
