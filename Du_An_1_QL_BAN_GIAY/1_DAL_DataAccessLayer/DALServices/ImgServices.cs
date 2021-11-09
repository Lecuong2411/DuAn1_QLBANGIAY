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
   public class ImgServices : IImgServices
    {
        DBContext _dbContext;
        List<Image> _lstimages;
        public ImgServices()
        {
            _dbContext = new DBContext();
            _lstimages = new List<Image>();
            GetlstFromDB();
        }
        public string add(Image image)
        {
            _dbContext.Images.Add(image);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Thêm dữ liệu thành công";
        }

        public List<Image> Getlst()
        {
            return _lstimages;
        }

        public void GetlstFromDB()
        {
            _lstimages = _dbContext.Images.ToList();
        }

        public string update(Image image)
        {
            _dbContext.Images.Update(image);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Cập nhật dữ liệu thành công";
        }
    }
}
