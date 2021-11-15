using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("Size")]
    public partial class Size
    {
        public Size()
        {
            ChiTietSanPhams = new HashSet<ChiTietSanPham>();
        }

        [Key]
        [StringLength(100)]
        public string? MaSize { get; set; }
        [Column("Size")]
        public int Size1 { get; set; }
        public double ChieuDaiChan { get; set; }
        public int TrangThai { get; set; }

        [InverseProperty(nameof(ChiTietSanPham.MaSizeNavigation))]
        public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; }
    }
}
