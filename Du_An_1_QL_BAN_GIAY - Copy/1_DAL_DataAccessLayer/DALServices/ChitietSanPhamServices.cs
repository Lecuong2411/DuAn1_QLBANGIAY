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
   public class ChitietSanPhamServices : IChitietSanPhamServices
    {
        DBContext _dbContext;
        List<ChiTietSanPham> _lstchiTietSanPhams;
        public ChitietSanPhamServices()
        {
            _dbContext = new DBContext();
            _lstchiTietSanPhams = new List<ChiTietSanPham>();
            GetlstFromDB();
        }
        public string add(ChiTietSanPham chiTietSanPham)
        {
            _dbContext.ChiTietSanPhams.Add(chiTietSanPham);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Thêm dữ liệu thành công";
        }

        public List<ChiTietSanPham> Getlst()
        {
            return _lstchiTietSanPhams;
        }

        public void GetlstFromDB()
        {
            _lstchiTietSanPhams = _dbContext.ChiTietSanPhams.ToList();
        }

        public string update(ChiTietSanPham chiTietSanPham)
        {
            _dbContext.ChiTietSanPhams.Update(chiTietSanPham);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Cập nhật dữ liệu thành công";
        }
    }
}
