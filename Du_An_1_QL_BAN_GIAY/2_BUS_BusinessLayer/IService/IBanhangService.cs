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
        List<AddHoadon> addHoadons();

        string addhoadon(HoaDonChiTiet hoaDonChiTiet,HoaDon hoaDon,KhachHang khachHang);
        public List<SanPham> loadsp();

        public List<ChiTietSanPham> loadspct();

        public List<NhanVien> loadnv();

        public List<KhachHang> loadkh();

        public List<HoaDon> loadhd();

        public List<HoaDonChiTiet> loadhdct();
    

    }
}
