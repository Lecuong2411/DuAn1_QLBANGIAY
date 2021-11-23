using System.Collections.Generic;
using System.Linq;
using _1_DAL_DataAccessLayer.Context;
using _1_DAL_DataAccessLayer.IDALServices;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.DALServices
{
    public class ChiTietGiamGiaService: IChiTietGiamGiaService
    {
        private DBContext _dbContext;
        private List<ChiTietGiamGia> lsTietGiamGias;
        public ChiTietGiamGiaService()
        {
          
            _dbContext = new DBContext();
            lsTietGiamGias = new List<ChiTietGiamGia>();
            GetlstFromDB();
        }
        public string add(ChiTietGiamGia ChiTietGiamGia)
        {
            _dbContext.Add(ChiTietGiamGia);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "";
        }

        public string update(ChiTietGiamGia ChiTietGiamGia)
        {
            _dbContext.Add(ChiTietGiamGia);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "";
        }

        public List<ChiTietGiamGia> Getlst()
        {
            return lsTietGiamGias;
        }

        public void GetlstFromDB()
        {
            lsTietGiamGias = _dbContext.ChiTietGiamGias.ToList();
        }
    }
}