using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("ChatLieu")]
    public partial class ChatLieu
    {
        public ChatLieu()
        {
            ChiTietSanPhams = new HashSet<ChiTietSanPham>();
        }

        [Key]
        [StringLength(100)]
        public string MaChatLieu { get; set; }
        [Required]
        [Column("ChatLieu")]
        [StringLength(100)]
        public string ChatLieu1 { get; set; }
        public int TrangThai { get; set; }

        [InverseProperty(nameof(ChiTietSanPham.MaChatLieuNavigation))]
        public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; }
    }
}
