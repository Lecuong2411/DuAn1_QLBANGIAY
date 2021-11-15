using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("SanPham")]
    public partial class SanPham
    {
        public SanPham()
        {
            ChiTietSanPhams = new HashSet<ChiTietSanPham>();
        }

        [Key]
        [Column("MaSP")]
        [StringLength(100)]
        public string MaSp { get; set; }
        [Required]
        [Column("TenSP")]
        [StringLength(100)]
        public string TenSp { get; set; }
        [Required]
        [StringLength(100)]
        public string ThuongHieu { get; set; }
        public int TrangThai { get; set; }
        [StringLength(100)]
        public string MaDanhMuc { get; set; }
        [Column("MaNCC")]
        [StringLength(100)]
        public string MaNcc { get; set; }

        [ForeignKey(nameof(MaDanhMuc))]
        [InverseProperty(nameof(DanhMuc.SanPhams))]
        public virtual DanhMuc MaDanhMucNavigation { get; set; }
        [ForeignKey(nameof(MaNcc))]
        [InverseProperty(nameof(NhaCungCap.SanPhams))]
        public virtual NhaCungCap MaNccNavigation { get; set; }
        [InverseProperty(nameof(ChiTietSanPham.MaSpNavigation))]
        public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; }
    }
}
