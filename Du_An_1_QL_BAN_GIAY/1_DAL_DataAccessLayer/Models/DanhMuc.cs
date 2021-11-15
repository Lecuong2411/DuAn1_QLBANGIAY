using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("DanhMuc")]
    public partial class DanhMuc
    {
        public DanhMuc()
        {
            SanPhams = new HashSet<SanPham>();
        }

        [Key]
        [StringLength(100)]
        public string MaDanhMuc { get; set; }
        [Required]
        [StringLength(100)]
        public string TenDanhMuc { get; set; }
        [StringLength(100)]
        public string GhiChu { get; set; }
        public int TrangThai { get; set; }

        [InverseProperty(nameof(SanPham.MaDanhMucNavigation))]
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
