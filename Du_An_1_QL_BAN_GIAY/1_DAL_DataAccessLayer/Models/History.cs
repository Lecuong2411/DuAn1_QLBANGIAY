using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("history")]
    public partial class History
    {
        [Column("MaCTSP")]
        [StringLength(100)]
        public string MaCtsp { get; set; }
        [Key]
        [Column("MaHIS")]
        [StringLength(100)]
        public string MaHis { get; set; }
        [Column("MaNV")]
        [StringLength(100)]
        public string MaNv { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayNhap { get; set; }

        [ForeignKey(nameof(MaCtsp))]
        [InverseProperty(nameof(ChiTietSanPham.Histories))]
        public virtual ChiTietSanPham MaCtspNavigation { get; set; }
    }
}
