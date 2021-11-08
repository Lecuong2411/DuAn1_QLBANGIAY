using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("HoaDonChiTiet")]
    public partial class HoaDonChiTiet
    {
        [Key]
        [Column("MaHD")]
        public Guid MaHd { get; set; }
        [Column("MaCTSP")]
        public Guid? MaCtsp { get; set; }
        public double DonGia { get; set; }
        public int TrangThai { get; set; }

        [ForeignKey(nameof(MaCtsp))]
        [InverseProperty(nameof(ChiTietSanPham.HoaDonChiTiets))]
        public virtual ChiTietSanPham MaCtspNavigation { get; set; }
        [ForeignKey(nameof(MaHd))]
        [InverseProperty(nameof(HoaDon.HoaDonChiTiet))]
        public virtual HoaDon MaHdNavigation { get; set; }
    }
}
