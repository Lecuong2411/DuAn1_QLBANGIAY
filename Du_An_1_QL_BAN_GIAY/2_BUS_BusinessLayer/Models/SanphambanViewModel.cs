using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;

namespace _2_BUS_BusinessLayer.Models
{
    public class SanphambanViewModel
    {
        //public int Ma { get; set; }
        //public string Ten { get; set; }
        //public int Size { get; set; }
        //public string Thuonghieu { get; set; }
        //public int Soluong { get; set; }
        //public string Mausac { get; set; }
        //public string Loaicogiay { get; set; }
        //public float Giaban { get; set; }
        //public string Img { get; set; }

        //public SanphambanViewModel(int ma, string ten, int size, string thuonghieu, int soluong, string mausac, string loaicogiay, float giaban, string img)
        //{
        //    Ma = ma;
        //    Ten = ten;
        //    Size = size;
        //    Thuonghieu = thuonghieu;
        //    Soluong = soluong;
        //    Mausac = mausac;
        //    Loaicogiay = loaicogiay;
        //    Giaban = giaban;
        //    Img = img;
        //}
        public SanPham  sanPham { get; set; }
        public NhaCungCap nhaCungCap { get; set; }
        public ChiTietSanPham chiTietSanPham { get; set; }
        public Image image { get; set; }
        public ChatLieu ChatLieu { get; set; }
        public Size size { get; set; }
        public LoaiCoGiay loaiCoGiay { get; set; }
        public Color color { get; set; }
        public DanhMuc danhMuc { get; set; }

    }
}
