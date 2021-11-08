using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("LoaiCoGiay")]
    public partial class LoaiCoGiay
    {
        public LoaiCoGiay()
        {
            ChiTietSanPhams = new HashSet<ChiTietSanPham>();
        }

        [Key]
        public Guid MaCo { get; set; }
        [Required]
        [Column("LoaiCoGiay")]
        [StringLength(20)]
        public string LoaiCoGiay1 { get; set; }
        public int TrangThai { get; set; }

        [InverseProperty(nameof(ChiTietSanPham.MaCoNavigation))]
        public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; }
    }
}
