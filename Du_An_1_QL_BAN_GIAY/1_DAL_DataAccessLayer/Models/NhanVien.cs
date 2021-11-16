using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("NhanVien")]
    public class NhanVien
    {
       

        [Key]
        [StringLength(100)]
        public string MaNv { get; set; }
        [StringLength(100)]
        public string TenNv { get; set; }
        [StringLength(100)]
        public string Sdt { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(100)]
        public string MatKhau { get; set; }
        public int? GioiTinh { get; set; }
        public int? NamSinh { get; set; }
        [ForeignKey("MaChucVu")]
        public ChucVu chucVu { get; set; }
        [StringLength(100)]
        public string HinhAnh { get; set; }
        public int TrangThai { get; set; }

    }
}
