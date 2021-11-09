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
    class SanphamServices
    {
        DBContext _dbContext;
        List<SanPham> _lstsanPhams;
        public SanphamServices()
        {
            _dbContext = new DBContext();
            _lstsanPhams = new List<SanPham>();
            GetlstFromDB();
        }
        public string add(SanPham sanPham)
        {
            _dbContext.SanPhams.Add(sanPham);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Thêm dữ liệu thành công";
        }

        public List<SanPham> Getlst()
        {
            return _lstsanPhams;
        }

        public void GetlstFromDB()
        {
            _lstsanPhams = _dbContext.SanPhams.ToList();
        }

        public string update(SanPham sanPham)
        {
            _dbContext.SanPhams.Update(sanPham);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Cập nhật dữ liệu thành công";
        }
    }
}
