using System;
using System.Collections.Generic;
using System.Linq;
using _1_DAL_DataAccessLayer.IDALServices;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IService;
using _1_DAL_DataAccessLayer.DALServices;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.Service
{
    public class QlSanPhamService : IQlSanPhamService
    {
        private ISanphamServices _iSanphamServices;
        private ISizeServices _iSizeServices;
        private IChatlieuServices _iChatlieuServices;
        private IChitietSanPhamServices _iChitietSanPhamServices;
        private IColorServices _iColorServices;
        private IDanhmucServices _iDanhmucServices;
        private IHistoryServices _iHistoryServices;
        private IImgServices _imgServices;
        private ILoaicogiayServices _iLoaicogiayServices;
        private INhacungcapServices _iNhacungcapServices;
        private List<SanPham> _LstSanPham;
        private List<Size> _LstSize;
        private List<NhaCungCap> _lstCungCaps;
        private List<LoaiCoGiay> _lstLoaiCoGiays;
        private List<Image> _lstImages;
        private List<History> _lstHistories;
        private List<DanhMuc> _lstDanhMucs;
        private List<Color> _lstColors;
        private List<ChiTietSanPham> _lstChiTietSanPhams;
        private List<ChatLieu> _lstChatLieus;
        private List<QLSanPham> _lstQlSanPhams;
        public QlSanPhamService()
        {
            _iSanphamServices = new SanphamServices();
            _iSizeServices = new SizeServices();
            _iChatlieuServices = new ChatlieuServices();
            _iChitietSanPhamServices = new ChitietSanPhamServices();
            _iColorServices = new ColorServices();
            _iDanhmucServices = new DanhmucServices();
            _iHistoryServices = new HistoryServices();
            _imgServices = new ImgServices();
            _iLoaicogiayServices = new LoaicogiayServices();
            _iNhacungcapServices = new NhacungcapServices();
            _LstSanPham = new List<SanPham>();
            _LstSize = new List<Size>();
            _lstCungCaps = new List<NhaCungCap>();
            _lstLoaiCoGiays = new List<LoaiCoGiay>();
            _lstImages = new List<Image>();
            _lstHistories = new List<History>();
            _lstDanhMucs = new List<DanhMuc>();
            _lstColors = new List<Color>();
            _lstChiTietSanPhams = new List<ChiTietSanPham>();
            _lstChatLieus = new List<ChatLieu>();
            _lstQlSanPhams = new List<QLSanPham>();
            _lstCungCaps = _iNhacungcapServices.Getlst().ToList();
            _lstDanhMucs = _iDanhmucServices.Getlst();
            _LstSanPham = _iSanphamServices.Getlst().ToList();
            _lstColors = _iColorServices.Getlst();
            _LstSize = _iSizeServices.Getlst();
            _lstChatLieus = _iChatlieuServices.Getlst();
            _lstLoaiCoGiays = _iLoaicogiayServices.Getlst();
            _lstChiTietSanPhams = _iChitietSanPhamServices.Getlst();
            _lstHistories = _iHistoryServices.Getlst();
            _lstImages = _imgServices.Getlst();
        }
        #region San pham
        public string addSP(SanPham sanPham)
        {
            return _iSanphamServices.add(sanPham);
        }

        public string updateSP(SanPham sanPham)
        {
            return _iSanphamServices.update(sanPham);
        }

        public string RemoveSP(SanPham sanPham)
        {
            return _iSanphamServices.update(sanPham);
        }
        public List<SanPham> GetLstSP()
        {
            return _LstSanPham;
        }

        public void GetLstDBSP()
        {
        
        }

        #endregion

        #region Size

       

        public string addSize(Size sanPham)
        {
            throw new System.NotImplementedException();
        }

        public string updateSize(Size sanPham)
        {
            throw new System.NotImplementedException();
        }

        public string RemoveSize(Size sanPham)
        {
            throw new System.NotImplementedException();
        }

        public List<Size> GetLstSize()
        {
            return _LstSize;
        }


        #endregion

        #region Nha cung cap

    

        public string addNCC(NhaCungCap sanPham)
        {
            throw new System.NotImplementedException();
        }

        public string updateNCC(NhaCungCap sanPham)
        {
            throw new System.NotImplementedException();
        }

        public string RemoveNCC(NhaCungCap sanPham)
        {
            throw new System.NotImplementedException();
        }

        public List<NhaCungCap> GetLstNCC()
        {
            return _lstCungCaps;
        }

        #endregion
      
        #region Loai co Giay


        public string addLoaiCoGiay(LoaiCoGiay sanPham)
        {
            throw new System.NotImplementedException();
        }

        public string updateLoaiCoGiay(LoaiCoGiay sanPham)
        {
            throw new System.NotImplementedException();
        }

        public string RemoveLoaiCoGiay(LoaiCoGiay sanPham)
        {
            throw new System.NotImplementedException();
        }

        public List<LoaiCoGiay> GetLstLoaiCoGiay()
        {
            return _lstLoaiCoGiays;
        }

        #endregion

        #region Img


        public string addImage(Image sanPham)
        {
           _lstImages.Add(sanPham);
           return "";
        }

        public string updateImage(Image sanPham)
        {
            throw new NotImplementedException();
        }

        public string RemoveImage(Image sanPham)
        {
            throw new NotImplementedException();
        }

        public List<Image> GetLstImage()
        {
            return _lstImages;
        }

        #endregion

        #region History

      
        public string addHistory(History sanPham)
        {
            _iHistoryServices.add(sanPham);
            return "";
        }

        public string updateHistory(History sanPham)
        {
            throw new NotImplementedException();
        }

        public string RemoveHistory(History sanPham)
        {
            throw new NotImplementedException();
        }

        public List<History> GetLstHistory()
        {
            return _lstHistories;
        }

        #endregion

        #region DanhMuc

     

        public string addDanhMuc(DanhMuc sanPham)
        {
            throw new NotImplementedException();
        }

        public string updateDanhMuc(DanhMuc sanPham)
        {
            throw new NotImplementedException();
        }

        public string RemoveDanhMuc(DanhMuc sanPham)
        {
            throw new NotImplementedException();
        }

        public List<DanhMuc> GetLstDanhMuc()
        {
            return _lstDanhMucs;
        }

        #endregion

        #region Color


        public string addColor(Color sanPham)
        {
            throw new NotImplementedException();
        }

        public string updateColor(Color sanPham)
        {
            throw new NotImplementedException();
        }

        public string RemoveColor(Color sanPham)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetLstColor()
        {
            return _lstColors;
        }

        #endregion

        #region CTSanPham

      

        public string addCTSanPham(ChiTietSanPham sanPham)
        {
            _iChitietSanPhamServices.add(sanPham);
            return "";
        }

        public string updateCTSanPham(ChiTietSanPham sanPham)
        {
            _iChitietSanPhamServices.update(sanPham);
            return "";
        }

        public string RemoveCTSanPham(ChiTietSanPham sanPham)
        {
            throw new NotImplementedException();
        }

        public List<ChiTietSanPham> GetLstCTSanPham()
        {
            return _lstChiTietSanPhams;
        }

        #endregion

        #region ChatLieu

     

        public string addChatLieu(ChatLieu sanPham)
        {
            throw new NotImplementedException();
        }

        public string updateChatLieu(ChatLieu sanPham)
        {
            throw new NotImplementedException();
        }

        public string RemoveChatLieu(ChatLieu sanPham)
        {
            throw new NotImplementedException();
        }

        public List<ChatLieu> GetLstChatLieu()
        {
            return _lstChatLieus;
        }

        #endregion

        #region all

        public List<QLSanPham> GetSPAll()
        {
            _lstChiTietSanPhams = _iChitietSanPhamServices.Getlst();
            _lstQlSanPhams = (from a in _LstSanPham
                join b in _lstChiTietSanPhams on a.MaSp equals b.MaSP
                join c in _lstCungCaps on a.MaNCC equals c.MaNcc
                join e in _lstChatLieus on b.MaChatLieu equals e.MaChatLieu
                join f in _LstSize on b.MaSize equals f.MaSize
                join g in _lstLoaiCoGiays on b.MaCo equals g.MaCo
                join h in _lstColors on b.MaCLR equals h.MaClr
                join j in _lstDanhMucs on a.MaDanhMuc equals j.MaDanhMuc 
                select new QLSanPham()
                {
                    SanPham = a,
                    ChiTietSanPham = b,
                    NhaCungCap = c,
                 
                    ChatLieu = e,
                    Size = f,
                    LoaiCoGiay = g,
                    Color = h,
                    DanhMuc = j
                }).ToList();

            return _lstQlSanPhams;

        
        }
        #endregion
    }
}