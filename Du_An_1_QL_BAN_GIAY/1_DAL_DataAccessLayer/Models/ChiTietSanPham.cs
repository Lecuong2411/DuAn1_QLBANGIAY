using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("ChiTietSanPham")]
    public partial class ChiTietSanPham
    {
        public ChiTietSanPham()
        {
            Histories = new HashSet<History>();
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
            Images = new HashSet<Image>();
        }

        public Guid? MaCo { get; set; }
        public Guid? MaChatLieu { get; set; }
        [Required]
        [StringLength(30)]
        public string GhiChu { get; set; }
        [Required]
        [StringLength(30)]
        public string Mota { get; set; }
        [Required]
        [Column("MaQR")]
        [StringLength(30)]
        public string MaQr { get; set; }
        public int SoLuong { get; set; }
        public double GiaBan { get; set; }
        public double GiaNhap { get; set; }
        public Guid MaSize { get; set; }
        [Column("MaCLR")]
        public Guid MaClr { get; set; }
        [Column("MaSP")]
        public Guid MaSp { get; set; }
        [Key]
        [Column("MaCTSP")]
        public Guid MaCtsp { get; set; }

        [ForeignKey(nameof(MaChatLieu))]
        [InverseProperty(nameof(ChatLieu.ChiTietSanPhams))]
        public virtual ChatLieu MaChatLieuNavigation { get; set; }
        [ForeignKey(nameof(MaClr))]
        [InverseProperty(nameof(Color.ChiTietSanPhams))]
        public virtual Color MaClrNavigation { get; set; }
        [ForeignKey(nameof(MaCo))]
        [InverseProperty(nameof(LoaiCoGiay.ChiTietSanPhams))]
        public virtual LoaiCoGiay MaCoNavigation { get; set; }
        [ForeignKey(nameof(MaSize))]
        [InverseProperty(nameof(Size.ChiTietSanPhams))]
        public virtual Size MaSizeNavigation { get; set; }
        [ForeignKey(nameof(MaSp))]
        [InverseProperty(nameof(SanPham.ChiTietSanPhams))]
        public virtual SanPham MaSpNavigation { get; set; }
        [InverseProperty(nameof(History.MaCtspNavigation))]
        public virtual ICollection<History> Histories { get; set; }
        [InverseProperty(nameof(HoaDonChiTiet.MaCtspNavigation))]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        [InverseProperty(nameof(Image.MaCtspNavigation))]
        public virtual ICollection<Image> Images { get; set; }
    }
}
