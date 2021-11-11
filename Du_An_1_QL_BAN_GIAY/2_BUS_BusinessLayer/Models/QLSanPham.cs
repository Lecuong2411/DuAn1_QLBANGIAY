using _1_DAL_DataAccessLayer.Models;

namespace _2_BUS_BusinessLayer.Models
{
    public class QLSanPham
    {
        public SanPham SanPham { get; set; }
        public NhaCungCap NhaCungCap { get; set; }
        public ChiTietSanPham ChiTietSanPham { get; set; }
        public Image Image { get; set; }
        public ChatLieu ChatLieu { get; set; }
        public Size Size { get; set; }
        public LoaiCoGiay LoaiCoGiay { get; set; }
        public Color Color { get; set; }
        public DanhMuc DanhMuc { get; set; }

        public QLSanPham()
        {
            SanPham = new SanPham();
            NhaCungCap = new NhaCungCap();
            ChiTietSanPham = new ChiTietSanPham();
            Image = new Image();
            ChatLieu = new ChatLieu();
            Size = new Size();
            LoaiCoGiay = new LoaiCoGiay();
            Color = new Color();
            DanhMuc = new DanhMuc();

        }
    }

}