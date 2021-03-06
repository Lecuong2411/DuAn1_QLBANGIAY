using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using _1_DAL_DataAccessLayer.DALServices;
using _1_DAL_DataAccessLayer.IDALServices;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IService;
using _2_BUS_BusinessLayer.Models;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace _2_BUS_BusinessLayer.Service
{
    public class QlKhuyenMai : IQlKhuyenMai
    {
        private List<KhuyenMai_Bus> _lstKhuyenMai;
        private List<SanPham> _lstSanPhams;
        private List<DanhMuc> _lstDanhMucs;
        private List<ChiTietSanPham> _lstChiTietSanPhams;
        private List<ChiTietGiamGia> _lstChiTietGiamGias;
        private List<KhuyenMai> _lstKhuyenMais;
        private List<ProductBack> _lstProductBacks;
        private List<LoaiCoGiay> _lstLoaiCoGiayss;
        private List<ChatLieu> _lstChatLieuss;
        private IDanhmucServices _danhmucServices;
        private ISanphamServices _sanphamServices;
        private IChitietSanPhamServices _chitietSanPhamServices;
        private IKhuyenMaiService _iKhuyenMaiService;
        private IProductBackService _iProductBackService;
        private IChiTietGiamGiaService _iChiTietGiamGiaService;
        private ILoaicogiayServices _iLoaicogiayServices;
        private IChatlieuServices _iChatlieuServices;
        IChitietSanPhamServices _iChitietSanPhamServices;
        public QlKhuyenMai()
        {
            _iChitietSanPhamServices = new ChitietSanPhamServices();
            _lstLoaiCoGiayss = new List<LoaiCoGiay>();
            _lstChatLieuss = new List<ChatLieu>();
            _lstKhuyenMai = new List<KhuyenMai_Bus>();
            _lstSanPhams = new List<SanPham>();
            _lstDanhMucs = new List<DanhMuc>();
            _lstChiTietSanPhams = new List<ChiTietSanPham>();
            _lstChiTietGiamGias = new List<ChiTietGiamGia>();
            _lstKhuyenMais = new List<KhuyenMai>();
            _lstProductBacks = new List<ProductBack>();
            _danhmucServices = new DanhmucServices();
            _iChatlieuServices = new ChatlieuServices();
            _sanphamServices = new SanphamServices();
            _iLoaicogiayServices = new LoaicogiayServices();
            _iProductBackService = new ProductBackService();
            _chitietSanPhamServices = new ChitietSanPhamServices();
            _iChiTietGiamGiaService = new ChiTietGiamGiaService();
            _iKhuyenMaiService = new KhuyenMaiService();
            _lstDanhMucs = _danhmucServices.Getlst();
            _lstChiTietSanPhams = _chitietSanPhamServices.Getlst();
            _lstSanPhams = _sanphamServices.Getlst();
            _lstKhuyenMais = _iKhuyenMaiService.Getlst();
            _lstProductBacks = _iProductBackService.Getlst();
            _lstLoaiCoGiayss = _iLoaicogiayServices.Getlst();
            _lstChatLieuss = _iChatlieuServices.Getlst();
            _lstChiTietGiamGias = _iChiTietGiamGiaService.Getlst();
            _lstKhuyenMai = GetKhuyenMais();

        }


        public List<KhuyenMai_Bus> GetKhuyenMais()
        {
            _lstKhuyenMai = (from a in _lstChiTietSanPhams
                             join b in _lstSanPhams on a.MaSP equals b.MaSp
                             join c in _lstDanhMucs on b.MaDanhMuc equals c.MaDanhMuc
                             join d in _lstProductBacks on a.MaPB equals d.MaPB
                             join ff in _lstChatLieuss on a.MaChatLieu equals ff.MaChatLieu
                             join l in _lstLoaiCoGiayss on a.MaCo equals l.MaCo
                             //join f in _lstChiTietGiamGias on c.MaDanhMuc equals f.MaDanhMuc into CtggDm
                             //from f in CtggDm.DefaultIfEmpty()
                             //join n in _lstKhuyenMais on f.MaKM equals n.MaKM into KMCTKM
                             //from n in KMCTKM.DefaultIfEmpty()

                             select new KhuyenMai_Bus()
                             {
                                 ChiTietSanPham = a,
                                 SanPham = b,
                                 DanhMuc = c,
                                 ProductBack = d,
                                 //ChiTietGiamGia = f == null ? null : f,
                                 //KhuyenMai = n == null ? null : n,
                                 //KhuyenMai= (from km in _lstKhuyenMais
                                 //            join ctkm in _lstChiTietGiamGias on km.MaKM equals ctkm.MaKM
                                 //            where ctkm.MaDanhMuc == c.MaDanhMuc
                                 //            select km
                                 //    ).FirstOrDefault(),
                                 ChatLieu = ff,
                                 LoaiCoGiay = l
                             }).ToList();
            return _lstKhuyenMai;
        }
        public List<KhuyenMai_Bus> GetLstCTSP()
        {
            List<KhuyenMai_Bus> GetLstCTSP = new List<KhuyenMai_Bus>();
            GetLstCTSP = (
                          from c in _lstDanhMucs


                          //join f in _lstChiTietGiamGias on c.MaDanhMuc equals f.MaDanhMuc
                          //from f in CtggDm.DefaultIfEmpty()
                          //join n in _lstKhuyenMais on f.MaKM equals n.MaKM into KMCTKM
                          //from n in KMCTKM.DefaultIfEmpty()
                          select new KhuyenMai_Bus()
                          {
                             
                              DanhMuc = c,

                              
                              //KhuyenMai = n == null ? null : n,
                              KhuyenMai = (from km in _lstKhuyenMais
                                           join ctkm in _lstChiTietGiamGias on km.MaKM equals ctkm.MaKM
                                           where ctkm.MaDanhMuc == c.MaDanhMuc && km.NgayDau <= DateTime.Now && km.NgayHet >= DateTime.Now && km.TrangThai == 1
                                           select km
                                           
                                     ).FirstOrDefault(),
                            
                          }).ToList();
          

            //foreach (var x in _lstQlSanPhams)
            //{
            //    if (x.KhuyenMai != null && x.ChiTietSanPham.MaPB == "PB2")
            //    {
            //        var dt = _iChitietSanPhamServices.Getlst().Where(c => c.MaCTSP == x.ChiTietSanPham.MaCTSP).FirstOrDefault();
            //        x.ChiTietSanPham.giaban = (dt.giaban * (100 - x.KhuyenMai.GiamGia)) / 100;
            //        //x.ProductBack.TrangThai = 3;
            //    }
            //}
            return GetLstCTSP;
        }



        public List<KhuyenMai_Bus> GetKhuyenMaisSearch(string text)
        {
            List<KhuyenMai_Bus> _lstKhuyenMai1 = new List<KhuyenMai_Bus>();
            _lstKhuyenMai1 = (from a in _lstChiTietSanPhams
                              join b in _lstSanPhams on a.MaSP equals b.MaSp
                              join c in _lstDanhMucs on b.MaDanhMuc equals c.MaDanhMuc
                              join d in _lstProductBacks on a.MaPB equals d.MaPB
                              join ff in _lstChatLieuss on a.MaChatLieu equals ff.MaChatLieu
                              join l in _lstLoaiCoGiayss on a.MaCo equals l.MaCo
                              //join f in _lstChiTietGiamGias on c.MaDanhMuc equals f.MaDanhMuc into CtggDm
                              //from leftDM in CtggDm
                              //join n in _lstKhuyenMais on leftDM.MaKM equals n.MaKM into KMCTKM
                              //from kmcttt in KMCTKM.DefaultIfEmpty()
                              select new KhuyenMai_Bus()
                              {
                                  ChiTietSanPham = a,
                                  SanPham = b,
                                  DanhMuc = c,
                                  ProductBack = d,
                                  //ChiTietGiamGia = leftDM,
                                  //KhuyenMai = kmcttt,
                                  KhuyenMai = (from km in _lstKhuyenMais
                                               join ctkm in _lstChiTietGiamGias on km.MaKM equals ctkm.MaKM
                                               where ctkm.MaDanhMuc == c.MaDanhMuc
                                               select km
                                      ).FirstOrDefault(),
                                  ChatLieu = ff,
                                  LoaiCoGiay = l
                              }).ToList();
            return _lstKhuyenMai1.Where(x => x.DanhMuc.TenDanhMuc == text).ToList();
        }

        public string addPB(ProductBack productBack)
        {
            return _iProductBackService.add(productBack);

        }

        public string addKM(KhuyenMai khuyenMai)
        {
            return _iKhuyenMaiService.add(khuyenMai);
        }

        public string addCTGG(ChiTietGiamGia chiTietGiamGia)
        {
            _iChiTietGiamGiaService.add(chiTietGiamGia);
            _lstChiTietGiamGias = _iChiTietGiamGiaService.Getlst();
            return "";
        }

        public string updatePB(ProductBack productBack)
        {
            return _iProductBackService.update(productBack);
        }

        public string updateKM(KhuyenMai khuyenMai)
        {
            return _iKhuyenMaiService.update(khuyenMai);
        }

        public string updateCTGG(ChiTietGiamGia chiTietGiamGia)
        {
            return _iChiTietGiamGiaService.update(chiTietGiamGia);
        }

        public List<KhuyenMai> GetlstKhuyenMais()
        {
            return _lstKhuyenMais;
        }

        public List<ProductBack> GetProductBacks()
        {
            return _lstProductBacks;
        }

        public List<ChiTietGiamGia> GetChiTietGiamGias()
        {
            return _lstChiTietGiamGias;
        }

        public string updateCTSP(ChiTietSanPham chiTietSanPham)
        {
            return _chitietSanPhamServices.update(chiTietSanPham);
        }

        public List<SanPham> GetSanPhams()
        {
            return _lstSanPhams;
        }

        public List<DanhMuc> GetDanhMucs()
        {
            return _lstDanhMucs;
        }

        public List<ChiTietSanPham> GetChiTietSanPhams()
        {
            return _lstChiTietSanPhams;
        }

        public List<LoaiCoGiay> GetLoaiCoGiayss()
        {
            return _lstLoaiCoGiayss;
        }

        public List<ChatLieu> GetChatLieuss()
        {
            return _lstChatLieuss;
        }

        public List<KhuyenMai_Bus> GetLstCTSP2()
        {
            _iChiTietGiamGiaService = new ChiTietGiamGiaService();
            _iKhuyenMaiService = new KhuyenMaiService();
            _lstChiTietGiamGias = _iChiTietGiamGiaService.Getlst();
            _lstKhuyenMais = _iKhuyenMaiService.Getlst();
            List<KhuyenMai_Bus> GetLstCTSP2 = new List<KhuyenMai_Bus>();
            GetLstCTSP2 = (
                           from c in _lstDanhMucs

                           join f in _lstChiTietGiamGias on c.MaDanhMuc equals f.MaDanhMuc
                           //from f in CtggDm.DefaultIfEmpty()
                           join n in _lstKhuyenMais on f.MaKM equals n.MaKM
                           //from n in KMCTKM.DefaultIfEmpty()
                           select new KhuyenMai_Bus()
                           {

                               DanhMuc = c,
                               ChiTietGiamGia = f,
                               KhuyenMai = n
                               ,
                               //KhuyenMai = (from km in _lstKhuyenMais
                               //             join ctkm in _lstChiTietGiamGias on km.MaKM equals ctkm.MaKM
                               //             where ctkm.MaDanhMuc == c.MaDanhMuc
                               //             select km
                               //       ).FirstOrDefault(),

                           }).ToList();

            return GetLstCTSP2;
        }
    }
}