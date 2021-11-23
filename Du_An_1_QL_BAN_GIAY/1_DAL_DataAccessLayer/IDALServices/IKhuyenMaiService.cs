using System.Collections.Generic;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.IDALServices
{
    public interface IKhuyenMaiService
    {
        string add(KhuyenMai khuyenMai);
        string update(KhuyenMai khuyenMai);
        List<KhuyenMai> Getlst();
        void GetlstFromDB();
    }
}