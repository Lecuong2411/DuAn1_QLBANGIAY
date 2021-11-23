using System.Collections.Generic;
using System.Linq;
using _1_DAL_DataAccessLayer.Context;
using _1_DAL_DataAccessLayer.IDALServices;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.DALServices
{
    
    public class KhuyenMaiService : IKhuyenMaiService
    {
        private DBContext _dbContext;
        private List<KhuyenMai> lstKhuyenMais;
        public KhuyenMaiService()
        {
            _dbContext = new DBContext();
            lstKhuyenMais = new List<KhuyenMai>();
            GetlstFromDB();
        }
        public string add(KhuyenMai khuyenMai)
        {
             _dbContext.Add(khuyenMai);
             _dbContext.SaveChanges();
             return "";
        }

        public string update(KhuyenMai khuyenMai)
        {
            _dbContext.Update(khuyenMai);
            _dbContext.SaveChanges();
            return "";
        }

        public List<KhuyenMai> Getlst()
        {
            return lstKhuyenMais;
        }

        public void GetlstFromDB()
        {
        lstKhuyenMais=   _dbContext.KhuyenMais.ToList();
        }
    }
}