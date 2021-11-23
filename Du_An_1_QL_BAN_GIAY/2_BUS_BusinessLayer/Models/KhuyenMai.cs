using _1_DAL_DataAccessLayer.Models;

namespace _2_BUS_BusinessLayer.Models
{
    public class KhuyenMai_Bus
    {
        public DanhMuc DanhMuc { get; set; }
        public SanPham SanPham { get; set; }
        public ChiTietSanPham ChiTietSanPham { get; set; }
        public ChiTietGiamGia ChiTietGiamGia { get; set; }
        public ProductBack ProductBack { get; set; }
        public KhuyenMai KhuyenMai { get; set; }
        public LoaiCoGiay LoaiCoGiay { get; set; }
        public ChatLieu ChatLieu { get; set; }

        public KhuyenMai_Bus()
        {
            DanhMuc = new DanhMuc();
            SanPham = new SanPham();
            ChiTietSanPham = new ChiTietSanPham();
            ProductBack = new ProductBack();
            ChiTietGiamGia = new ChiTietGiamGia();
            KhuyenMai = new KhuyenMai();
            LoaiCoGiay = new LoaiCoGiay();
            ChatLieu = new ChatLieu();
        }
    }
}