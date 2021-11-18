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
        //public int ma { get; set; }
        //public string ten { get; set; }
        //public int size { get; set; }
        //public string thuonghieu { get; set; }
        //public int soluong { get; set; }
        //public string mausac { get; set; }
        //public string loaicogiay { get; set; }
        //public float giaban { get; set; }
        //public string img { get; set; }

        //public sanphambanviewmodel(int ma, string ten, int size, string thuonghieu, int soluong, string mausac, string loaicogiay, float giaban, string img)
        //{
        //    ma = ma;
        //    ten = ten;
        //    size = size;
        //    thuonghieu = thuonghieu;
        //    soluong = soluong;
        //    mausac = mausac;
        //    loaicogiay = loaicogiay;
        //    giaban = giaban;
        //    img = img;
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
