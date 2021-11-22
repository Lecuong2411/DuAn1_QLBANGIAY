using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("HoaDon")]
    public  class HoaDon
    {
        [Key]
        [StringLength(100)]
        public string MaHd { get; set; }
        public double? Tongtien { get; set; }
        public double? TienNhan { get; set; }
        [StringLength(100)]
        public string GhiChu { get; set; }
        public string MaKH { get; set; }
        [ForeignKey("MaKH")]
        [Required]
        public virtual KhachHang khachHang { get; set; }
        public string MaNV { get; set; }
        [ForeignKey("MaNV")]
        [Required]
        public virtual NhanVien nhanVien { get; set; }

        public string MaVouCher { get; set; }
        [ForeignKey("MaVouCher")]
        [Required]
        public virtual Voucher voucher { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime thoigian { get; set; }

        public int TrangThaiHd { get; set; }
    }
}
