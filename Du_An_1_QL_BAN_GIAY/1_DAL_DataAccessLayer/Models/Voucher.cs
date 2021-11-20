using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("Voucher")]
    public class Voucher
    {
        [Key]
        [StringLength(100)]
        public string MaVouCher { get; set; }
        [StringLength(100)]
        public string Vouchers { get; set; }
        [DataType(DataType.Date)]
        public DateTime NSD { get; set; }
        [DataType(DataType.Date)]
        public DateTime HSD { get; set; }
        public int SoLuong { get; set; }
        public int SoLuongDSD { get; set; }
        public float MenhGia { get; set; }
        public int TrangThai { get; set; }
        [StringLength(100)]
        public string GhiChu { get; set; }

    }
}
