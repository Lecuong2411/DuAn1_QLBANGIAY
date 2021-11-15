using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("NhanVien")]
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [Column("MaNV")]
        [StringLength(100)]
        public string MaNv { get; set; }
        [Required]
        [Column("TenNV")]
        [StringLength(100)]
        public string TenNv { get; set; }
        [Required]
        [StringLength(100)]
        public string Sdt { get; set; }
        [Required]
        [StringLength(100)]
        public string DiaChi { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [StringLength(100)]
        public string MatKhau { get; set; }
        public int? GioiTinh { get; set; }
        public int? NamSinh { get; set; }
        [StringLength(100)]
        public string MaChucVu { get; set; }
        [StringLength(100)]
        public string HinhAnh { get; set; }
        public int TrangThai { get; set; }

        [ForeignKey(nameof(MaChucVu))]
        [InverseProperty(nameof(ChucVu.NhanViens))]
        public virtual ChucVu MaChucVuNavigation { get; set; }
        [InverseProperty(nameof(HoaDon.MaNvNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
