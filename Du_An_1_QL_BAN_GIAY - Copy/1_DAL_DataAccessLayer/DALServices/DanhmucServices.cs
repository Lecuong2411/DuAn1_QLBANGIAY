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
  public  class DanhmucServices : IDanhmucServices
    {
        DBContext _dbContext;
        List<DanhMuc> _lstdanhMucs;
        public DanhmucServices()
        {
            _dbContext = new DBContext();
            _lstdanhMucs = new List<DanhMuc>();
            GetlstFromDB();
        }
        public string add(DanhMuc danhMuc)
        {
            _dbContext.DanhMucs.Add(danhMuc);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Thêm dữ liệu thành công";
        }

        public List<DanhMuc> Getlst()
        {
            return _lstdanhMucs;
        }

        public void GetlstFromDB()
        {
            _lstdanhMucs = _dbContext.DanhMucs.ToList();
        }

        public string update(DanhMuc danhMuc)
        {
            _dbContext.DanhMucs.Update(danhMuc);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Cập nhật dữ liệu thành công";
        }
    }
}
