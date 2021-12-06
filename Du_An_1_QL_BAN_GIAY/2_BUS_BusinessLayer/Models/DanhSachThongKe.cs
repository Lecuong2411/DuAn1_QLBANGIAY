using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;

namespace _2_BUS_BusinessLayer.Models
{
    public class DanhSachThongKe
    {
        public HoaDon HoaDon { get; set; }
        public HoaDonChiTiet hoaDonChiTiet { get; set; }
        public SanPham SanPham { get; set; }
        public ChiTietSanPham ChiTietSanPham { get; set; }

    public DanhSachThongKe()
        {
            HoaDon = new HoaDon();
            hoaDonChiTiet = new HoaDonChiTiet();
            SanPham = new SanPham();
            ChiTietSanPham = new ChiTietSanPham();
        }

    public DanhSachThongKe(HoaDon hoaDon, HoaDonChiTiet hoaDonChiTiet, SanPham sanPham, ChiTietSanPham chiTietSanPham)
    {
        HoaDon = hoaDon;
        this.hoaDonChiTiet = hoaDonChiTiet;
        SanPham = sanPham;
        ChiTietSanPham = chiTietSanPham;
    }

    }
}
