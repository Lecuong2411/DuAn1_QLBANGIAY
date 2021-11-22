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
        [Key,Column(Order =1)]
        [StringLength(100)]
        public string MaHd { get; set; }
        [ForeignKey("MaHd")]
        public virtual HoaDon hoaDon { get; set; }
        [Key,Column(Order =2)]
        [Required]
        public string MaCTSP { get; set; }
        [ForeignKey("MaCTSP")]    
        public virtual ChiTietSanPham chiTietSanPham { get; set; }
       
        public double? DonGia { get; set; }

        public double? Thanhtien { get; set; }
        public int? soluong { get; set; }
        public int? TrangThai { get; set; }

       
        
    }
}
