using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("ChucVu")]
    public class ChucVu
    {

        [Key]
        [StringLength(100)]
        public string MaChucVu { get; set; }
        public int Roles { get; set; }
        public int TrangThai { get; set; }

    }
}
