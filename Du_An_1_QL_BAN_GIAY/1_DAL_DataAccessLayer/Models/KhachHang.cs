using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("KhachHang")]
    public class KhachHang
    {

        [Key]
        [StringLength(100)]
        public string MaKh { get; set; }
        [StringLength(100)]
        [Required]
        public string TenKh { get; set; }
        [StringLength(100)]
        [Required]
        public string Sdt { get; set; }
    }
}
