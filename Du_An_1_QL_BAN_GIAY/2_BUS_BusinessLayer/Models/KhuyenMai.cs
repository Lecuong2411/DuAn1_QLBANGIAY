using _1_DAL_DataAccessLayer.Models;

namespace _2_BUS_BusinessLayer.Models
{
    public class KhuyenMai_Bus
    {
        public DanhMuc DanhMuc { get; set; }
        public SanPham SanPham { get; set; }
        public ChiTietSanPham ChiTietSanPham { get; set; }

        public KhuyenMai_Bus()
        {
            DanhMuc = new DanhMuc();
            SanPham = new SanPham();
            ChiTietSanPham = new ChiTietSanPham();
        }
    }
}