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
   public class HistoryServices : IHistoryServices
    {
        DBContext _dbContext;
        List<History> _lsthistorys;
        public HistoryServices()
        {
            _dbContext = new DBContext();
            _lsthistorys = new List<History>();
            GetlstFromDB();
        }
        public string add(History history)
        {
            _dbContext.Histories.Add(history);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Thêm dữ liệu thành công";
        }

        public List<History> Getlst()
        {
            return _lsthistorys;
        }

        public void GetlstFromDB()
        {
            _lsthistorys = _dbContext.Histories.ToList();
        }

        public string update(History history)
        {
            _dbContext.Histories.Update(history);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Cập nhật dữ liệu thành công";
        }
    }
}
