using System.Collections.Generic;
using System.Linq;
using _1_DAL_DataAccessLayer.Context;
using _1_DAL_DataAccessLayer.IDALServices;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.DALServices
{
    public class ProductBackService: IProductBackService
    {
        private DBContext _db;
        private List<ProductBack> _lstProductBacks;

        public ProductBackService()
        {
            _db = new DBContext();
            _lstProductBacks = new List<ProductBack>();
            GetlstFromDB();
        }
        public string add(ProductBack productBack)
        {
            _db.Add(productBack);
            _db.SaveChanges();
            GetlstFromDB();
            return "";
        }

        public string update(ProductBack ProductBack)
        {
            _db.Update(ProductBack);
            _db.SaveChanges();
            GetlstFromDB();
            return "";
        }

        public List<ProductBack> Getlst()
        {
            return _lstProductBacks;
        }

        public void GetlstFromDB()
        {
            _lstProductBacks = _db.ProductBacks.ToList();
        }
    }
}