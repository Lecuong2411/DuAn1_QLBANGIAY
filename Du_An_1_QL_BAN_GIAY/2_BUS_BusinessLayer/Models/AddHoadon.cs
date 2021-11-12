using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;

namespace _2_BUS_BusinessLayer.Models
{
  public   class AddHoadon
    {
        public ChiTietSanPham   chiTietSanPham { get; set; }
        public HoaDonChiTiet hoaDonChiTiet { get; set; }
        public HoaDon hoaDon { get; set; }
        public KhachHang khachHang { get; set; }
        public NhanVien nhanVien { get; set; }
    }
}
