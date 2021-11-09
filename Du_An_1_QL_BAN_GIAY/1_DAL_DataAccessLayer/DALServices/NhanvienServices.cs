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
   public class NhanvienServices:INhanvienServices
    {
        DBContext _dbContext;
        List<NhanVien> _lstnhanViens;
        public NhanvienServices()
        {
            _dbContext = new DBContext();
            _lstnhanViens = new List<NhanVien>();
            GetlstFromDB();
        }
        public string add(NhanVien nhanVien)
        {
            _dbContext.NhanViens.Add(nhanVien);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Thêm dữ liệu thành công";
        }

        public List<NhanVien> Getlst()
        {
            return _lstnhanViens;
        }

        public void GetlstFromDB()
        {
            _lstnhanViens = _dbContext.NhanViens.ToList();
        }

        public string update(NhanVien nhanVien)
        {
            _dbContext.NhanViens.Update(nhanVien);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Cập nhật dữ liệu thành công";
        }
    }
}
