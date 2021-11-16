﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.DALServices;
using _1_DAL_DataAccessLayer.IDALServices;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IService;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.Service
{
    public class BUS_DanhSachHoaDonBanHang:IBUS_DanhSachHoaDonBanHang
    {
        private List<HoaDon> _hd;
        private List<KhachHang> _kh;
        private List<NhanVien> _nv;
        private List<HoaDonChiTiet> _hdct;
        private List<SanPham> _sp;
        private List<LoaiCoGiay> _lcg;
        private List<ChiTietSanPham> _ctsp;
        private List<ChatLieu> _cl;
        private List<Color> _clr;
        private List<Size> _sz;
        private List<Danhsachhoadonbanhang> _dshdbh;
        private INhanvienServices _chunangnv;
        private IHoadonServices _chucnanghd;
        private IKhachhangServices _chucnangkhachhang;
        private IHoadonchitietServices _hoadonchitietServices;
        private IChitietSanPhamServices _chitietSanPhamServices;
        private ISanphamServices _sanphamServices;
        private ILoaicogiayServices _loaicogiayServices;
        private IChatlieuServices _chatlieuServices;
        private IColorServices _colorServices;
        private ISizeServices _sizeServices;
        public BUS_DanhSachHoaDonBanHang()
        {
            _hd = new List<HoaDon>();
            _kh = new List<KhachHang>();
            _nv = new List<NhanVien>();
            _hdct = new List<HoaDonChiTiet>();
            _ctsp = new List<ChiTietSanPham>();
            _sp = new List<SanPham>();
            _lcg = new List<LoaiCoGiay>();
            _cl = new List<ChatLieu>();
            _clr = new List<Color>();
            _sz = new List<Size>();
            _chucnanghd = new HoadonServices();
            _chucnangkhachhang = new KhachhangServices();
            _chunangnv = new NhanvienServices();
            _dshdbh = new List<Danhsachhoadonbanhang>();
            _hoadonchitietServices = new HoadonchitietServices();
            _chitietSanPhamServices = new ChitietSanPhamServices();
            _sanphamServices = new SanphamServices();
            _loaicogiayServices = new LoaicogiayServices();
            _chatlieuServices = new ChatlieuServices();
            _colorServices = new ColorServices();
            _sizeServices = new SizeServices();
            loatdata();

        }
        public List<Danhsachhoadonbanhang> ListdDanhsachhoadonbanhang()
        {
            return _dshdbh;
        }

        public void loatdata()
        {
            _kh = _chucnangkhachhang.Getlst();
            _nv = _chunangnv.Getlst();
            _hd = _chucnanghd.Getlst();
            _hdct = _hoadonchitietServices.Getlst();
            _ctsp = _chitietSanPhamServices.Getlst();
            _sp = _sanphamServices.Getlst();
            _lcg = _loaicogiayServices.Getlst();
            _cl = _chatlieuServices.Getlst();
            _clr = _colorServices.Getlst();
            _sz = _sizeServices.Getlst();
            var tame = (from a in _kh
                        join b in _hd on a.MaKh equals b.MaKH
                        join c in _nv on b.MaNV equals c.MaNv
                        join d in _hdct on b.MaHd equals d.MaHd
                        join f in _ctsp on d.MaCTSP equals f.MaCTSP
                        join g in _sp on f.MaSP equals g.MaSp
                        join h in _lcg on f.MaCo equals h.MaCo
                        join j in _cl on f.MaChatLieu equals j.MaChatLieu
                        join k in _clr on f.MaCLR equals k.MaClr
                        join l in _sz on f.MaSize equals l.MaSize
                        select new
                        {
                            KhachHang = a,
                            HoaDon = b,
                            NhanVien = c,
                            HoaDonChiTiet = d,
                            ChiTietSanPham = f,
                            SanPham = g,
                            LoaiCoGiay = h,
                            ChatLieu = j,
                            Color = k,
                            Size = l
                        }).ToList();
            tame.ForEach(x =>
            {
                Danhsachhoadonbanhang A = new Danhsachhoadonbanhang();
                A.hoadon = x.HoaDon;
                A.KhachHang = x.KhachHang;
                A.NhanVien = x.NhanVien;
                A.hoaDonChiTiet = x.HoaDonChiTiet;
                A.ChiTietSanPham = x.ChiTietSanPham;
                A.SanPham = x.SanPham;
                A.LoaiCoGiay = x.LoaiCoGiay;
                A.ChatLieu = x.ChatLieu;
                A.Color = x.Color;
                A.Size = x.Size;
                _dshdbh.Add(A);
            });


        }

        public List<Danhsachhoadonbanhang> timkiemkh(string kh)
        {
            return _dshdbh.Where(c => c.KhachHang.TenKh.StartsWith(kh)).ToList();
        }

        public List<Danhsachhoadonbanhang> timkiemsdt(string sdt)
        {
            return _dshdbh.Where(c => c.KhachHang.Sdt.StartsWith(sdt)).ToList();
        }
    }
}
