using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("SanPham")]
    public class SanPham
    {

        [Key]
        [StringLength(100)]
        public string MaSp { get; set; }
        [StringLength(100)]
        public string TenSp { get; set; }
        [StringLength(100)]
        public string ThuongHieu { get; set; }
        public int TrangThai { get; set; }
        public string MaDanhMuc { get; set; }
        [ForeignKey("MaDanhMuc")]
        public DanhMuc danhMuc { get; set; }
        public string MaNCC { get; set; }
        [ForeignKey("MaNCC")]
        public NhaCungCap nhaCungCap { get; set; }

       
    }
}
