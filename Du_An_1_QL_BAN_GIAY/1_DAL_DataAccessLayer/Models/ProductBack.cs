using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace _1_DAL_DataAccessLayer.Models
{
    [Table("ProductBack")]
    public class ProductBack
    {
        [Key]
        [StringLength(100)]
        public string MaPB { get; set; }
        public int ProductStatus { get; set; }
        public int TrangThai { get; set; }

    }
}
