using System.Collections.Generic;
using _1_DAL_DataAccessLayer.Models;

namespace _2_BUS_BusinessLayer.IService
{
    public interface IBUS_VoucherService
    {
        public string add(Voucher voucher);
        public string update(Voucher voucher);
        public string delete(Voucher voucher);
        public List<Voucher> ListvVouchers();
    }
}