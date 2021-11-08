using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("ChucVu")]
    public partial class ChucVu
    {
        public ChucVu()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        [Key]
        public Guid MaChucVu { get; set; }
        public int Roles { get; set; }
        public int TrangThai { get; set; }

        [InverseProperty(nameof(NhanVien.MaChucVuNavigation))]
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
