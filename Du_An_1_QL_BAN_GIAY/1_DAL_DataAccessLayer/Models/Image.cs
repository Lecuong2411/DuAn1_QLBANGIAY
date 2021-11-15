using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    public partial class Image
    {
        [Key]
        [StringLength(100)]
        public string MaImage { get; set; }
        [Column("MaCTSP")]
        [StringLength(100)]
        public string MaCtsp { get; set; }
        [StringLength(100)]
        public string Images { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(MaCtsp))]
        [InverseProperty(nameof(ChiTietSanPham.Images))]
        public virtual ChiTietSanPham MaCtspNavigation { get; set; }
    }
}
