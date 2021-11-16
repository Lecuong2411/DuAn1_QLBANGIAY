using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("Color")]
    public  class Color
    {
      

        [Key]
        [StringLength(100)]
        public string MaClr { get; set; }
        [StringLength(100)]
        public string ColorSP { get; set; }
        public int TrangThai { get; set; }

    }
}
