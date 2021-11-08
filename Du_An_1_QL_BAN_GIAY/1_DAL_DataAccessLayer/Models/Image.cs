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
        public Guid MaImage { get; set; }
        [Column("MaCTSP")]
        public Guid? MaCtsp { get; set; }
        [StringLength(30)]
        public string Images { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(MaCtsp))]
        [InverseProperty(nameof(ChiTietSanPham.Images))]
        public virtual ChiTietSanPham MaCtspNavigation { get; set; }
    }
}
