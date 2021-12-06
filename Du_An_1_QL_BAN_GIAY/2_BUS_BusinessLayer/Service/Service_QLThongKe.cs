using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.DALServices;
using _1_DAL_DataAccessLayer.IDALServices;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IService;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.Service
{
    public class Service_QLThongKe:I_QLThongKe
    {
       
        private IHoadonServices _iHoadonServices;
        private IHoadonchitietServices _iHoadonchitietServices;
        private ISanphamServices _iSanphamServices;
        private IChitietSanPhamServices _iChitietSanPhamServices;
        


        private List<DanhSachThongKe> _lstDanhSachThongKes;
        private List<HoaDon> _lstHoaDons;
        private List<HoaDonChiTiet> _lstHoaDonChiTiets;
        private List<SanPham> _lstSanPhams;
        private List<ChiTietSanPham> _lstChiTietSanPhams;
        public Service_QLThongKe()
        {
            _iHoadonServices = new HoadonServices();
            _iHoadonchitietServices = new HoadonchitietServices();
            _iSanphamServices = new SanphamServices();
            _iChitietSanPhamServices = new ChitietSanPhamServices();
            

            _lstDanhSachThongKes = new List<DanhSachThongKe>();

            _lstHoaDons = new List<HoaDon>();
            _lstHoaDonChiTiets = new List<HoaDonChiTiet>();
            _lstSanPhams = new List<SanPham>();
            _lstChiTietSanPhams = new List<ChiTietSanPham>();
        }
        

        public List<ChiTietSanPham> lstChiTietSanPham()
        {
            return _iChitietSanPhamServices.Getlst();
        }

        public List<HoaDon> LstHoaDons()
        {
            return _iHoadonServices.Getlst();
        }

        public List<DanhSachThongKe> Lst_DSThongKe()
        {
            return _lstDanhSachThongKes;
        }

        public void LoadData()
        {
            _lstHoaDons = _iHoadonServices.Getlst();
            _lstHoaDonChiTiets = _iHoadonchitietServices.Getlst();
            _lstSanPhams = _iSanphamServices.Getlst();
            _lstChiTietSanPhams = _iChitietSanPhamServices.Getlst();

            var temp = (from sp in _lstSanPhams
                join ctsp in _lstChiTietSanPhams on sp.MaSp equals ctsp.MaSP
                join hdct in _lstHoaDonChiTiets on ctsp.MaCTSP equals hdct.MaCTSP
                join hd in _lstHoaDons on hdct.MaHd equals hd.MaHd
                select new
                {

                    SanPham = sp,
                    ChiTietSanPham = ctsp,
                    hoaDonChiTiet = hdct,
                    HoaDon = hd

                }).ToList();
            temp.ForEach(x =>
            {
                DanhSachThongKe A = new DanhSachThongKe();
                A.HoaDon = x.HoaDon;
                A.hoaDonChiTiet = x.hoaDonChiTiet;
                A.SanPham = x.SanPham;
                A.ChiTietSanPham = x.ChiTietSanPham;
                _lstDanhSachThongKes.Add(A);
            });
        }

       
    }
}
