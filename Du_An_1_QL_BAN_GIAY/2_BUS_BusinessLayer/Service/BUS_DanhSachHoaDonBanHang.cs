using System;
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
        private List<Danhsachhoadonbanhang> _dshdbh;
        private INhanvienServices _chunangnv;
        private IHoadonServices _chucnanghd;
        private IKhachhangServices _chucnangkhachhang;

        public BUS_DanhSachHoaDonBanHang()
        {
            _hd = new List<HoaDon>();
            _kh = new List<KhachHang>();
            _nv = new List<NhanVien>();
            _chucnanghd = new HoadonServices();
            _chucnangkhachhang = new KhachhangServices();
            _chunangnv = new NhanvienServices();
            _dshdbh = new List<Danhsachhoadonbanhang>();
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
            var tame = (from a in _kh
                join b in _hd on a.MaKh equals b.MaKh
                join c in _nv on b.MaNv equals c.MaNv
                select new
                {
                    KhachHang = a,
                    HoaDon = b,
                    NhanVien = c
                }).ToList();
            tame.ForEach(x =>
                {
                    Danhsachhoadonbanhang A = new Danhsachhoadonbanhang();
                    A.hoadon = x.HoaDon;
                    A.KhachHang = x.KhachHang;
                    A.NhanVien = x.NhanVien;
                    _dshdbh.Add(A);
                });


        }

        public List<Danhsachhoadonbanhang> loatdatatk(string sdt)
        {
            return _dshdbh.Where(c => c.KhachHang.Sdt.StartsWith(sdt)).ToList();
        }
    }
}
