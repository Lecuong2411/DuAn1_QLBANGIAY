using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("ChiTietSanPham")]
    public class ChiTietSanPham
    {
        [Key]
        [StringLength(100)]
        public string MaCTSP { get; set; }
        public string MaCo { get; set; }
        [ForeignKey("MaCo")]
      
        public LoaiCoGiay loaiCoGiay { get; set; }
        public string MaChatLieu { get; set; }
        [ForeignKey("MaChatLieu")]
        public ChatLieu chatLieu { get; set; }
        [StringLength(100)]
        public string GhiChu { get; set; }
        [StringLength(100)]
        public string Mota { get; set; }
        [StringLength(100)]
        public string MaQR { get; set; }
        public int soluong { get; set; }
        public int giaban { get; set; }
        public int GiaNhap { get; set; }
        public int TrangThai { get; set; }
        public string MaSize { get; set; }
        [ForeignKey("MaSize")]
        public Size size { get; set; }
        public string MaCLR { get; set; }
        [ForeignKey("MaCLR")]
        public Color color { get; set; }
        public string MaSP { get; set; }
        [ForeignKey("MaSP")]
        public SanPham sanPham { get; set; }
        public string MaPB { get; set; }
        [ForeignKey("MaPB")]
        public ProductBack productBack { get; set; }



    }
}
