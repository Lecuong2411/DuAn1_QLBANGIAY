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
   public class HoadonServices :IHoadonServices
    {
        DBContext _dbContext;
        List<HoaDon> _lsthoaDons;
        public HoadonServices()
        {
            _dbContext = new DBContext();
            _lsthoaDons = new List<HoaDon>();
            GetlstFromDB();
        }
        public string add(HoaDon hoaDon)
        {
            _dbContext.HoaDons.Add(hoaDon);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Thêm dữ liệu thành công";
        }

        public List<HoaDon> Getlst()
        {
            return _lsthoaDons;
        }

        public void GetlstFromDB()
        {
            _lsthoaDons = _dbContext.HoaDons.ToList();
        }

        public string update(HoaDon hoaDon)
        {
            _dbContext.HoaDons.Update(hoaDon);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Cập nhật dữ liệu thành công";
        }
    }
}
