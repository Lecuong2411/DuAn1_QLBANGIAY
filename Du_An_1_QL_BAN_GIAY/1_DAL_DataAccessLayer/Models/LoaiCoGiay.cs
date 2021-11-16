using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("LoaiCoGiay")]
    public  class LoaiCoGiay
    {
  

        [Key]
        [StringLength(100)]
        public string MaCo { get; set; }
        [StringLength(100)]
        public string LoaiCoGiaySP { get; set; }
        public int TrangThai { get; set; }

    }
}
