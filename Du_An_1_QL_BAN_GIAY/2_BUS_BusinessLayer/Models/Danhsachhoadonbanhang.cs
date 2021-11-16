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
        public KhachHang KhachHang { get; set; }
        public NhanVien NhanVien { get; set; }
        public HoaDonChiTiet hoaDonChiTiet { get; set; }
        public ChiTietSanPham ChiTietSanPham { get; set; }
        public SanPham SanPham { get; set; }
        public LoaiCoGiay LoaiCoGiay { get; set; }
        public ChatLieu ChatLieu { get; set; }
        public Size Size { get; set; }
        public Color Color { get; set; }

        public Danhsachhoadonbanhang()
        {
            hoadon = new HoaDon();
            KhachHang = new KhachHang();
            NhanVien = new NhanVien();
            hoaDonChiTiet = new HoaDonChiTiet();
            ChiTietSanPham = new ChiTietSanPham();
            SanPham = new SanPham();
            LoaiCoGiay = new LoaiCoGiay();
            ChatLieu = new ChatLieu();
            Size = new Size();
            Color = new Color();

        }

        public Danhsachhoadonbanhang(HoaDon hoadon, KhachHang khachHang, NhanVien nhanVien, HoaDonChiTiet hoaDonChiTiet, ChiTietSanPham chiTietSanPham, SanPham sanPham, LoaiCoGiay loaiCoGiay, ChatLieu chatLieu, Size size, Color color)
        {
            this.hoadon = hoadon;
            KhachHang = khachHang;
            NhanVien = nhanVien;
            this.hoaDonChiTiet = hoaDonChiTiet;
            ChiTietSanPham = chiTietSanPham;
            SanPham = sanPham;
            LoaiCoGiay = loaiCoGiay;
            ChatLieu = chatLieu;
            Size = size;
            Color = color;
        }
    }
}
