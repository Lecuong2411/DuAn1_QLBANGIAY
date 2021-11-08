using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using _1_DAL_DataAccessLayer.Models;

#nullable disable

namespace _1_DAL_DataAccessLayer.Context
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChatLieu> ChatLieus { get; set; }
        public virtual DbSet<ChiTietSanPham> ChiTietSanPhams { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }
        public virtual DbSet<History> Histories { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiCoGiay> LoaiCoGiays { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-98PG69Q\\SQLEXPRESS;Initial Catalog=BANGIAYTHETHAO;Persist Security Info=True;User ID=cuonglvph13705;Password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ChatLieu>(entity =>
            {
                entity.HasKey(e => e.MaChatLieu)
                    .HasName("PK__ChatLieu__453995BC55E5B565");

                entity.Property(e => e.MaChatLieu).ValueGeneratedNever();
            });

            modelBuilder.Entity<ChiTietSanPham>(entity =>
            {
                entity.HasKey(e => e.MaCtsp)
                    .HasName("PK__ChiTietS__1E4FCECD9BEB1216");

                entity.Property(e => e.MaCtsp).ValueGeneratedNever();

                entity.HasOne(d => d.MaChatLieuNavigation)
                    .WithMany(p => p.ChiTietSanPhams)
                    .HasForeignKey(d => d.MaChatLieu)
                    .HasConstraintName("FK__ChiTietSa__MaCha__3F466844");

                entity.HasOne(d => d.MaClrNavigation)
                    .WithMany(p => p.ChiTietSanPhams)
                    .HasForeignKey(d => d.MaClr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChiTietSa__MaCLR__412EB0B6");

                entity.HasOne(d => d.MaCoNavigation)
                    .WithMany(p => p.ChiTietSanPhams)
                    .HasForeignKey(d => d.MaCo)
                    .HasConstraintName("FK__ChiTietSan__MaCo__3E52440B");

                entity.HasOne(d => d.MaSizeNavigation)
                    .WithMany(p => p.ChiTietSanPhams)
                    .HasForeignKey(d => d.MaSize)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChiTietSa__MaSiz__403A8C7D");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.ChiTietSanPhams)
                    .HasForeignKey(d => d.MaSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChiTietSan__MaSP__4222D4EF");
            });

            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.HasKey(e => e.MaChucVu)
                    .HasName("PK__ChucVu__D46395333CDE69D4");

                entity.Property(e => e.MaChucVu).ValueGeneratedNever();
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.HasKey(e => e.MaClr)
                    .HasName("PK__Color__3DCE0379C5F9F66E");

                entity.Property(e => e.MaClr).ValueGeneratedNever();
            });

            modelBuilder.Entity<DanhMuc>(entity =>
            {
                entity.HasKey(e => e.MaDanhMuc)
                    .HasName("PK__DanhMuc__B375088765BAB4C3");

                entity.Property(e => e.MaDanhMuc).ValueGeneratedNever();
            });

            modelBuilder.Entity<History>(entity =>
            {
                entity.HasKey(e => e.MaHis)
                    .HasName("PK__history__3C90C06949F39D52");

                entity.Property(e => e.MaHis).ValueGeneratedNever();

                entity.HasOne(d => d.MaCtspNavigation)
                    .WithMany(p => p.Histories)
                    .HasForeignKey(d => d.MaCtsp)
                    .HasConstraintName("FK__history__MaCTSP__44FF419A");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHd)
                    .HasName("PK__HoaDon__2725A6E0FE5F1EFC");

                entity.Property(e => e.MaHd).ValueGeneratedNever();

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaKh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__MaKH__2B3F6F97");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaNv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__MaNV__2C3393D0");
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.HasKey(e => e.MaHd)
                    .HasName("PK__HoaDonCh__2725A6E061AC8FD4");

                entity.Property(e => e.MaHd).ValueGeneratedNever();

                entity.HasOne(d => d.MaCtspNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaCtsp)
                    .HasConstraintName("FK__HoaDonChi__MaCTS__4AB81AF0");

                entity.HasOne(d => d.MaHdNavigation)
                    .WithOne(p => p.HoaDonChiTiet)
                    .HasForeignKey<HoaDonChiTiet>(d => d.MaHd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDonChiT__MaHD__4BAC3F29");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.HasKey(e => e.MaImage)
                    .HasName("PK__Images__93330B7835DD95B7");

                entity.Property(e => e.MaImage).ValueGeneratedNever();

                entity.HasOne(d => d.MaCtspNavigation)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.MaCtsp)
                    .HasConstraintName("FK__Images__MaCTSP__47DBAE45");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh)
                    .HasName("PK__KhachHan__2725CF1E09566635");

                entity.Property(e => e.MaKh).ValueGeneratedNever();

                entity.Property(e => e.Sdt).IsUnicode(false);
            });

            modelBuilder.Entity<LoaiCoGiay>(entity =>
            {
                entity.HasKey(e => e.MaCo)
                    .HasName("PK__LoaiCoGi__27258E69B0EFA1FD");

                entity.Property(e => e.MaCo).ValueGeneratedNever();
            });

            modelBuilder.Entity<NhaCungCap>(entity =>
            {
                entity.HasKey(e => e.MaNcc)
                    .HasName("PK__NhaCungC__3A185DEB5433CF24");

                entity.Property(e => e.MaNcc).ValueGeneratedNever();

                entity.Property(e => e.Sdt).IsUnicode(false);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNv)
                    .HasName("PK__NhanVien__2725D70A5238DEC2");

                entity.Property(e => e.MaNv).ValueGeneratedNever();

                entity.Property(e => e.Sdt).IsUnicode(false);

                entity.HasOne(d => d.MaChucVuNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.MaChucVu)
                    .HasConstraintName("FK__NhanVien__MaChuc__267ABA7A");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.MaSp)
                    .HasName("PK__SanPham__2725081CF11B9426");

                entity.Property(e => e.MaSp).ValueGeneratedNever();

                entity.HasOne(d => d.MaDanhMucNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaDanhMuc)
                    .HasConstraintName("FK__SanPham__MaDanhM__32E0915F");

                entity.HasOne(d => d.MaNccNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaNcc)
                    .HasConstraintName("FK__SanPham__MaNCC__33D4B598");
            });

            modelBuilder.Entity<Size>(entity =>
            {
                entity.HasKey(e => e.MaSize)
                    .HasName("PK__Size__A787E7EDA9C6C4A4");

                entity.Property(e => e.MaSize).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
