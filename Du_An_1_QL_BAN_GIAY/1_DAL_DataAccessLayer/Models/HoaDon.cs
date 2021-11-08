using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [Column("MaHD")]
        public Guid MaHd { get; set; }
        public double? ThanhTien { get; set; }
        public double? TienNhan { get; set; }
        [StringLength(30)]
        public string GhiChu { get; set; }
        [Column("MaKH")]
        public Guid MaKh { get; set; }
        [Column("MaNV")]
        public Guid MaNv { get; set; }
        [Column("TrangThaiHD")]
        public int TrangThaiHd { get; set; }

        [ForeignKey(nameof(MaKh))]
        [InverseProperty(nameof(KhachHang.HoaDons))]
        public virtual KhachHang MaKhNavigation { get; set; }
        [ForeignKey(nameof(MaNv))]
        [InverseProperty(nameof(NhanVien.HoaDons))]
        public virtual NhanVien MaNvNavigation { get; set; }
        [InverseProperty("MaHdNavigation")]
        public virtual HoaDonChiTiet HoaDonChiTiet { get; set; }
    }
}
