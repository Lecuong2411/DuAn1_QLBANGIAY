using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("ChatLieu")]
    public class ChatLieu
    {
       
        [Key]
        [StringLength(100)]
        public string MaChatLieu { get; set; }
        [StringLength(100)]
        public string ChatLieuSP { get; set; }
        public int TrangThai { get; set; }

    }
}
