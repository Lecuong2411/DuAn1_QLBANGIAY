using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("NhaCungCap")]
    public partial class NhaCungCap
    {
        public NhaCungCap()
        {
            SanPhams = new HashSet<SanPham>();
        }

        [Key]
        [Column("MaNCC")]
        public Guid MaNcc { get; set; }
        [Required]
        [Column("NguoiCC")]
        [StringLength(20)]
        public string NguoiCc { get; set; }
        [Required]
        [Column("congTyCC")]
        [StringLength(25)]
        public string CongTyCc { get; set; }
        [Column("SDT")]
        [StringLength(12)]
        public string Sdt { get; set; }
        [StringLength(30)]
        public string DiaChi { get; set; }
        [StringLength(30)]
        public string GhiChu { get; set; }

        [InverseProperty(nameof(SanPham.MaNccNavigation))]
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
