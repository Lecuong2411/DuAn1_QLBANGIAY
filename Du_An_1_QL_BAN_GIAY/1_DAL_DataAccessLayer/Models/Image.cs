using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    public class Image
    {
        [Key]
        [StringLength(100)]
        public string MaImage { get; set; }
        public string MaCTSP { get; set; }
        [ForeignKey("MaCTSP")]
        public ChiTietSanPham chiTietSanPham { get; set; }
        [StringLength(100)]
        public string Images { get; set; }
        public int? TrangThai { get; set; }

    }
}
