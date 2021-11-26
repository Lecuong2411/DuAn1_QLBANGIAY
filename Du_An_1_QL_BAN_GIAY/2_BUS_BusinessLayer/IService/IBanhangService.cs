using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS_BusinessLayer.Models;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.IDALServices;

namespace _2_BUS_BusinessLayer.IService
{
   public interface IBanhangService
    {
        List<SanphambanViewModel> SanphambanViews();
        List<AddHoadon> viewHoadons();
        public List<SanPham> loadsp();

        public List<ChiTietSanPham> loadspct();

        public List<NhanVien> loadnv();

        public List<KhachHang> loadkh();

        public List<HoaDon> loadhd();

        List<Voucher> loadVoucher();

        public List<HoaDonChiTiet> loadhdct();
        public string updatevoucher(Voucher voucher);
        public string updatectsp(ChiTietSanPham chiTietSanPham);
        string addhoadon(HoaDon hoaDon, KhachHang khachHang);
        string updatehoadon(HoaDon hoaDon);
        string addHoadonchitiet(HoaDonChiTiet hoaDonChiTiet);
        string updatehoadonchitiet(HoaDonChiTiet hoaDonChiTiet);
        string deletedhoadonchitiet(string hd, string msp);

    }
}
