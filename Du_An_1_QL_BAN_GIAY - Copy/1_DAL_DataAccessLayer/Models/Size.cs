using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("Size")]
    public class Size
    {

        [Key]
        [StringLength(100)]
        public string MaSize { get; set; }
        public int SizeSp { get; set; }
        public double ChieuDaiChan { get; set; }
        public int TrangThai { get; set; }


    }
}
