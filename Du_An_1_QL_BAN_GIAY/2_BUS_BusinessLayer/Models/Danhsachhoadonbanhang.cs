using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;

namespace _2_BUS_BusinessLayer.Models
{
    public class Danhsachhoadonbanhang
    {
        public HoaDon hoadon { get; set; }
        public  KhachHang KhachHang { get; set; }
        public  NhanVien NhanVien { get; set; }

        public Danhsachhoadonbanhang()
        {
            hoadon = new HoaDon();
            KhachHang = new KhachHang();
            NhanVien = new NhanVien();
        }

        public Danhsachhoadonbanhang(HoaDon hoadon, KhachHang khachHang, NhanVien nhanVien)
        {
            this.hoadon = hoadon;
            KhachHang = khachHang;
            NhanVien = nhanVien;
        }
    }
}
