using System.Collections.Generic;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.IDALServices
{
    public interface IVouCherServices
    {
        string add(Voucher size);
        string update(Voucher size);
        List<Voucher> Getlst();
        void GetlstFromDB();
    }
}