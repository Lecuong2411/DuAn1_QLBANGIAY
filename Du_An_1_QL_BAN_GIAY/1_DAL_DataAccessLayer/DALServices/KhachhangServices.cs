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
   public class KhachhangServices : IKhachhangServices
    {
        DBContext _dbContext;
        List<KhachHang> _lstkhachHangs;
        public KhachhangServices()
        {
            _dbContext = new DBContext();
            _lstkhachHangs = new List<KhachHang>();
            GetlstFromDB();
        }
        public string add(KhachHang khachHang)
        {
            _dbContext.KhachHangs.Add(khachHang);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Thêm dữ liệu thành công";
        }

        public List<KhachHang> Getlst()
        {
            return _lstkhachHangs;
        }

        public void GetlstFromDB()
        {
            _lstkhachHangs = _dbContext.KhachHangs.ToList();
        }

        public string update(KhachHang khachHang)
        {
            _dbContext.KhachHangs.Update(khachHang);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Cập nhật dữ liệu thành công";
        }
    }
}
