using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("HoaDonChiTiet")]
    public  class HoaDonChiTiet
    {
        [Key]
        [StringLength(100)]
        public string MaHd { get; set; }
        [ForeignKey("MaHd")]
        public HoaDon hoaDon { get; set; }
        public string MaCTSP { get; set; }
        [ForeignKey("MaCTSP")]
        public ChiTietSanPham chiTietSanPham { get; set; }
        public double DonGia { get; set; }
        public int soluong { get; set; }
        public int TrangThai { get; set; }
       
        
    }
}
