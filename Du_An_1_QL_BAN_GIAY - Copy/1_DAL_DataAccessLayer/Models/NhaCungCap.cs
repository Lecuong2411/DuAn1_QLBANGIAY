using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("NhaCungCap")]
    public partial class NhaCungCap
    {
      

        [Key]
        [StringLength(100)]
        public string MaNcc { get; set; }
        [StringLength(100)]
        public string NguoiCc { get; set; }
        [StringLength(100)]
        public string CongTyCc { get; set; }
        [StringLength(100)]
        public string Sdt { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        [StringLength(100)]
        public string GhiChu { get; set; }


    }
}
