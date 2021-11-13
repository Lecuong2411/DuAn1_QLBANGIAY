using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("KhachHang")]
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [Column("MaKH")]
        public Guid MaKh { get; set; }
        [Required]
        [StringLength(30)]
        public string TenKh { get; set; }
        [Required]
        [Column("SDT")]
        [StringLength(12)]
        public string Sdt { get; set; }

        [InverseProperty(nameof(HoaDon.MaKhNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
