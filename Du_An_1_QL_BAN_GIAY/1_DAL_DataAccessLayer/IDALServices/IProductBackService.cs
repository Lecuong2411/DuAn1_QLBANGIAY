using System.Collections.Generic;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.IDALServices
{
    public interface IProductBackService
    {
        string add(ProductBack productBack);
        string update(ProductBack ProductBack);
        List<ProductBack> Getlst();
        void GetlstFromDB();
    }
}