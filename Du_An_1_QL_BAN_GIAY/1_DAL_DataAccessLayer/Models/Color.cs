using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("Color")]
    public partial class Color
    {
        public Color()
        {
            ChiTietSanPhams = new HashSet<ChiTietSanPham>();
        }

        [Key]
        [Column("MaCLR")]
        public Guid MaClr { get; set; }
        [Required]
        [Column("Color")]
        [StringLength(20)]
        public string Color1 { get; set; }
        public int TrangThai { get; set; }

        [InverseProperty(nameof(ChiTietSanPham.MaClrNavigation))]
        public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; }
    }
}
