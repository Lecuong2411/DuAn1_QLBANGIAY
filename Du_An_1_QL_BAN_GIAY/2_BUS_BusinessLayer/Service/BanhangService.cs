using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS_BusinessLayer.IService;
using _2_BUS_BusinessLayer.Models;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.IDALServices;
using _1_DAL_DataAccessLayer.DALServices;

namespace _2_BUS_BusinessLayer.Service
{
    public class BanhangService : IBanhangService
    {
        private ISanphamServices _sanphamServices;
        private IChitietSanPhamServices _chitietSanPhamServices;
        private INhacungcapServices _nhacungcapServices;
        private IImgServices _imgServices;
        private IChatlieuServices _chatlieuServices;
        private ISizeServices _SizeServices;
        private ILoaicogiayServices _loaicogiayServices;
        private IColorServices _colorServices;
        private IDanhmucServices _danhmucServices;
        private IHoadonchitietServices _hoadonchitietServices;
        private INhanvienServices _nhanvienServices;
        private IKhachhangServices _khachhangServices;
        private IHoadonServices _hoadonServices;

        private List<SanphambanViewModel> _lstSanphambanViews;
        private List<AddHoadon> _lstaddHoadons;

        private List<SanPham> _lstsanPhams;
        private List<ChiTietSanPham> _lstChiTietSanPhams;
        private List<NhaCungCap> _lstnhaCungCaps;
        private List<Image> _lstimages;
        private List<ChatLieu> _lstchatLieus;
        private List<Size> _lstSizes;
        private List<LoaiCoGiay> _lstloaiCoGiays;
        private List<Color> _lstcolors;
        private List<DanhMuc> _lstdanhMucs;
        private List<HoaDonChiTiet> _lsthoaDonChiTiets;
        private List<NhanVien> _lstnhanViens;
        private List<KhachHang> _lstkhachHangs;
        private List<HoaDon> _lsthoaDons;






        public BanhangService()
        {
            _sanphamServices = new SanphamServices();
            _chitietSanPhamServices = new ChitietSanPhamServices();
            _nhacungcapServices = new NhacungcapServices();
            _imgServices = new ImgServices();
            _chatlieuServices = new ChatlieuServices();
            _SizeServices = new SizeServices();
            _loaicogiayServices = new LoaicogiayServices();
            _colorServices = new ColorServices();
            _danhmucServices = new DanhmucServices();
            _hoadonchitietServices = new HoadonchitietServices();
            _nhanvienServices = new NhanvienServices();
            _khachhangServices = new KhachhangServices();
            _hoadonServices = new HoadonServices();
           

            _lstSanphambanViews = new List<SanphambanViewModel>();
            _lstaddHoadons = new List<AddHoadon>();

            _lstsanPhams = _sanphamServices.Getlst();
            _lstChiTietSanPhams = _chitietSanPhamServices.Getlst();
            _lstnhaCungCaps = _nhacungcapServices.Getlst();
            _lstimages = _imgServices.Getlst();
            _lstchatLieus = _chatlieuServices.Getlst();
            _lstSizes = _SizeServices.Getlst();
            _lstloaiCoGiays = _loaicogiayServices.Getlst();
            _lstcolors = _colorServices.Getlst();
            _lstdanhMucs = _danhmucServices.Getlst();
            _lsthoaDonChiTiets = _hoadonchitietServices.Getlst();
            _lstnhanViens = _nhanvienServices.Getlst();
            _lstkhachHangs = _khachhangServices.Getlst();
            _lsthoaDons = _hoadonServices.Getlst();

        }

        #region loaddata

     

        public List<SanPham> loadsp()
        {
            return _lstsanPhams;
        }  
        public List<ChiTietSanPham> loadspct()
        {
            return _lstChiTietSanPhams;
        } 
        public List<NhanVien> loadnv()
        {
            return _lstnhanViens;
        }
        public List<KhachHang> loadkh()
        {
            return _lstkhachHangs;
        }
        public List<HoaDon> loadhd()
        {
            return _lsthoaDons;
        } public List<HoaDonChiTiet> loadhdct()
        {
            return _lsthoaDonChiTiets;
        }

        #endregion



        public List<AddHoadon> addHoadons()
        {
             

            return _lstaddHoadons;
        }

        public List<SanphambanViewModel> SanphambanViews()
        {

            _lstSanphambanViews = (from a in _lstsanPhams
                                   join b in _lstChiTietSanPhams on a.MaSp equals b.MaSP
                                   join c in _lstnhaCungCaps on a.MaNCC equals c.MaNcc
                                   join d in _lstimages on b.MaCTSP equals d.MaCTSP
                                   join e in _lstchatLieus on b.MaChatLieu equals e.MaChatLieu
                                   join f in _lstSizes on b.MaSize equals f.MaSize
                                   join g in _lstloaiCoGiays on b.MaCo equals g.MaCo
                                   join h in _lstcolors on b.MaCLR equals h.MaClr
                                   join q in _lstdanhMucs on a.MaDanhMuc equals q.MaDanhMuc
                                   select new SanphambanViewModel()
                                   {
                                       sanPham = a,
                                       chiTietSanPham = b,
                                       nhaCungCap = c,
                                       image = d,
                                       ChatLieu = e,
                                       size = f,
                                       loaiCoGiay = g,
                                       color = h,
                                       danhMuc = q
                                   }).ToList();

            return _lstSanphambanViews;
        }

        public string addhoadon(HoaDonChiTiet hoaDonChiTiet, HoaDon hoaDon, KhachHang khachHang)
        {
            _hoadonServices.add(hoaDon);
            _hoadonchitietServices.add(hoaDonChiTiet);
            _khachhangServices.add(khachHang);
            return "thành công";
        }
    }
}
