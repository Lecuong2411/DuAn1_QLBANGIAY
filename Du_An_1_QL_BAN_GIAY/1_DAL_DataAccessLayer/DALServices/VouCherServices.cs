using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.DB_contexts;
using _1_DAL_DataAccessLayer.IDALServices;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.DALServices
{
    public class VouCherServices:IVouCherServices
    {
        private DBContext _context;
        private List<Voucher> _listvVouchers;

        public VouCherServices()
        {
            _context = new DBContext();
            _listvVouchers = new List<Voucher>();
            GetlstFromDB();
        }
        public string add(Voucher voucher)
        {
            _context.Vouchers.Add(voucher);
            _context.SaveChanges();
            GetlstFromDB();
            return "Thêm dữ liệu thành công";
        }

        public string update(Voucher voucher)
        {
            _context.Vouchers.Update(voucher);
            _context.SaveChanges();
            GetlstFromDB();
            return "Cập nhật dữ liệu thành công";
        }

        public List<Voucher> Getlst()
        {
            return _listvVouchers;
        }

        public void GetlstFromDB()
        {
            _listvVouchers = _context.Vouchers.ToList();
        }
    }
}
