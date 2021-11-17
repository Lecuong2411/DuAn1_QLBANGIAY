using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("ChiTietGiamGia")]
    public class ChiTietGiamGia
    {
        [Key]
        [StringLength(100)]
        public string MaCTGG { get; set; }
        public string MaKM { get; set; }
        [ForeignKey("MaKM")]
        public KhuyenMai  khuyenMai { get; set; } 
        public string MaDanhMuc { get; set; }
        [ForeignKey("MaDanhMuc")]
        public DanhMuc danhMuc { get; set; }
    }
}
