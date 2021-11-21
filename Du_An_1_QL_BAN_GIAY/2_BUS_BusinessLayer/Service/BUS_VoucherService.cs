using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.DALServices;
using _1_DAL_DataAccessLayer.IDALServices;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IService;

namespace _2_BUS_BusinessLayer.Service
{
    public class BUS_VoucherService:IBUS_VoucherService
    {
        private IVouCherServices _vouCherServices;
        public BUS_VoucherService()
        {
            _vouCherServices = new VouCherServices();
        }
        public string add(Voucher voucher)
        {
            _vouCherServices.add(voucher);
            return "Thêm thành công";
        }

        public string update(Voucher voucher)
        {
            _vouCherServices.update(voucher);
            return "Sửa thành công";
        }

        public string delete(Voucher voucher)
        {
            throw new NotImplementedException();
        }

        public List<Voucher> ListvVouchers()
        {
            return _vouCherServices.Getlst();
        }
    }
}
