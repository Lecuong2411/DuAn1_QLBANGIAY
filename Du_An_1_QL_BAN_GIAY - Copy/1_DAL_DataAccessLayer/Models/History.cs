using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("history")]
    public class History
    {

        [Key]
        [StringLength(100)]
        public string MaHis { get; set; }
        public string MaCTSP { get; set; }
        [ForeignKey("MaCTSP")]
        public ChiTietSanPham chiTietSanPham { get; set; }
        public string MaNV { get; set; }
        [ForeignKey("MaNV")]
        public NhanVien nhanVien { get; set; }
        public DateTime? NgayNhap { get; set; }

    }
}
