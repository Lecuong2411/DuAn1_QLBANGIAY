using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("KhuyenMai")]
    public class KhuyenMai
    {
        [Key]
        [StringLength(100)]
        public string MaKM { get; set; }
        public string TenChuongTrinh { get; set; }
        public DateTime NgayDau { get; set; }
        public DateTime NgayHet { get; set; }
        public int GiamGia { get; set; }
        public int TrangThai { get; set; }
        [StringLength(100)]
        public string GhiChu { get; set; }
    }
}
