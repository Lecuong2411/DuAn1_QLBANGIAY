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
  public  class HoadonchitietServices : IHoadonchitietServices
    {
        DBContext _dbContext;
        List<HoaDonChiTiet> _lsthoaDonChiTiets;
        public HoadonchitietServices()
        {
            _dbContext = new DBContext();
            _lsthoaDonChiTiets = new List<HoaDonChiTiet>();
            GetlstFromDB();
        }
        public string add(HoaDonChiTiet hoaDonChiTiet)
        {
            _dbContext.HoaDonChiTiets.Add(hoaDonChiTiet);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Thêm dữ liệu thành công";
        }

        public List<HoaDonChiTiet> Getlst()
        {
            return _lsthoaDonChiTiets;
        }

        public void GetlstFromDB()
        {
            _lsthoaDonChiTiets = _dbContext.HoaDonChiTiets.ToList();
        }

        public string update(HoaDonChiTiet hoaDonChiTiet)
        {
            _dbContext.HoaDonChiTiets.Update(hoaDonChiTiet);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Cập nhật dữ liệu thành công";
        }
    }
}
