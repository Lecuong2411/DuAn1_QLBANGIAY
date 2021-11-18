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
   public class LoaicogiayServices : ILoaicogiayServices
    {
        DBContext _dbContext;
        List<LoaiCoGiay> _lstloaiCoGiays;
        public LoaicogiayServices()
        {
            _dbContext = new DBContext();
          _lstloaiCoGiays   = new List<LoaiCoGiay>();
           GetlstFromDB();
        }
        public string add(LoaiCoGiay loaiCoGiay)
        {
            _dbContext.LoaiCoGiays.Add(loaiCoGiay);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Thêm dữ liệu thành công";
        }

        public List<LoaiCoGiay> Getlst()
        {
            return _lstloaiCoGiays;
        }

        public void GetlstFromDB()
        {
            _lstloaiCoGiays = _dbContext.LoaiCoGiays.ToList();
        }

        public string update(LoaiCoGiay loaiCoGiay)
        {
            _dbContext.LoaiCoGiays.Update(loaiCoGiay);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Cập nhật dữ liệu thành công";
        }
    }
}
