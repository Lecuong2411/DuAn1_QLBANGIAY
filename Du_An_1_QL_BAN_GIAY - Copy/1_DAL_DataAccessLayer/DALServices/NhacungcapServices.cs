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
   public class NhacungcapServices : INhacungcapServices
    {
        DBContext _dbContext;
        List<NhaCungCap> _lstnhaCungCaps;
        public NhacungcapServices()
        {
            _dbContext = new DBContext();
            _lstnhaCungCaps = new List<NhaCungCap>();
            GetlstFromDB();
        }
        public string add(NhaCungCap nhaCungCap)
        {
            _dbContext.NhaCungCaps.Add(nhaCungCap);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Thêm dữ liệu thành công";
        }

        public List<NhaCungCap> Getlst()
        {
            return _lstnhaCungCaps;
        }

        public void GetlstFromDB()
        {
            _lstnhaCungCaps = _dbContext.NhaCungCaps.ToList();
        }

        public string update(NhaCungCap nhaCungCap)
        {
            _dbContext.NhaCungCaps.Update(nhaCungCap);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Cập nhật dữ liệu thành công";
        }
    }
}
