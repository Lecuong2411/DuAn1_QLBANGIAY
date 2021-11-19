using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using _1_DAL_DataAccessLayer.DALServices;
using _1_DAL_DataAccessLayer.IDALServices;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IService;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.Service
{
    public class QlKhuyenMai:IQlKhuyenMai
    {
        private List<KhuyenMai_Bus> _lstKhuyenMai;
        private List<SanPham> _lstSanPhams;
        private List<DanhMuc> _lstDanhMucs;
        private List<ChiTietSanPham> _lstChiTietSanPhams;
        private IDanhmucServices _danhmucServices;
        private ISanphamServices _sanphamServices;
        private IChitietSanPhamServices _chitietSanPhamServices;

        public QlKhuyenMai()
        {
            _lstKhuyenMai = new List<KhuyenMai_Bus>();
            _lstSanPhams = new List<SanPham>();
            _lstDanhMucs = new List<DanhMuc>();
            _lstChiTietSanPhams = new List<ChiTietSanPham>();
            _danhmucServices = new DanhmucServices();
            _sanphamServices = new SanphamServices();
            _chitietSanPhamServices = new ChitietSanPhamServices();
            _lstDanhMucs = _danhmucServices.Getlst();
            _lstChiTietSanPhams = _chitietSanPhamServices.Getlst();
            _lstSanPhams = _sanphamServices.Getlst();
        }
        public List<KhuyenMai_Bus> GetKhuyenMais()
        {
            _lstKhuyenMai = (from a in _lstChiTietSanPhams
                join b in _lstSanPhams on a.MaSP equals b.MaSp
                join c in _lstDanhMucs on b.MaDanhMuc equals c.MaDanhMuc
                select new KhuyenMai_Bus()
                {
                    ChiTietSanPham = a,
                    SanPham = b,
                    DanhMuc = c
                }).ToList();
            return _lstKhuyenMai;
        }

   
    }
}