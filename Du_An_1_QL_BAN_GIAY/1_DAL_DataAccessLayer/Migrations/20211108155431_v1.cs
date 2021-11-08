using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DataAccessLayer.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChatLieu",
                columns: table => new
                {
                    MaChatLieu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChatLieu = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ChatLieu__453995BC55E5B565", x => x.MaChatLieu);
                });

            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    MaChucVu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Roles = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ChucVu__D46395333CDE69D4", x => x.MaChucVu);
                });

            migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    MaCLR = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Color__3DCE0379C5F9F66E", x => x.MaCLR);
                });

            migrationBuilder.CreateTable(
                name: "DanhMuc",
                columns: table => new
                {
                    MaDanhMuc = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenDanhMuc = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DanhMuc__B375088765BAB4C3", x => x.MaDanhMuc);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    MaKH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenKh = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SDT = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KhachHan__2725CF1E09566635", x => x.MaKH);
                });

            migrationBuilder.CreateTable(
                name: "LoaiCoGiay",
                columns: table => new
                {
                    MaCo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoaiCoGiay = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LoaiCoGi__27258E69B0EFA1FD", x => x.MaCo);
                });

            migrationBuilder.CreateTable(
                name: "NhaCungCap",
                columns: table => new
                {
                    MaNCC = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NguoiCC = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    congTyCC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    SDT = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NhaCungC__3A185DEB5433CF24", x => x.MaNCC);
                });

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    MaSize = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    ChieuDaiChan = table.Column<double>(type: "float", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Size__A787E7EDA9C6C4A4", x => x.MaSize);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenNV = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Sdt = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    GioiTinh = table.Column<int>(type: "int", nullable: true),
                    NamSinh = table.Column<int>(type: "int", nullable: true),
                    MaChucVu = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HinhAnh = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NhanVien__2725D70A5238DEC2", x => x.MaNV);
                    table.ForeignKey(
                        name: "FK__NhanVien__MaChuc__267ABA7A",
                        column: x => x.MaChucVu,
                        principalTable: "ChucVu",
                        principalColumn: "MaChucVu",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    MaSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenSP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ThuongHieu = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    MaDanhMuc = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MaNCC = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SanPham__2725081CF11B9426", x => x.MaSP);
                    table.ForeignKey(
                        name: "FK__SanPham__MaDanhM__32E0915F",
                        column: x => x.MaDanhMuc,
                        principalTable: "DanhMuc",
                        principalColumn: "MaDanhMuc",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__SanPham__MaNCC__33D4B598",
                        column: x => x.MaNCC,
                        principalTable: "NhaCungCap",
                        principalColumn: "MaNCC",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    MaHD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ThanhTien = table.Column<double>(type: "float", nullable: true),
                    TienNhan = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    MaKH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaNV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThaiHD = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HoaDon__2725A6E0FE5F1EFC", x => x.MaHD);
                    table.ForeignKey(
                        name: "FK__HoaDon__MaKH__2B3F6F97",
                        column: x => x.MaKH,
                        principalTable: "KhachHang",
                        principalColumn: "MaKH",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__HoaDon__MaNV__2C3393D0",
                        column: x => x.MaNV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietSanPham",
                columns: table => new
                {
                    MaCTSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaCo = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MaChatLieu = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MaQR = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiaBan = table.Column<double>(type: "float", nullable: false),
                    GiaNhap = table.Column<double>(type: "float", nullable: false),
                    MaSize = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaCLR = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ChiTietS__1E4FCECD9BEB1216", x => x.MaCTSP);
                    table.ForeignKey(
                        name: "FK__ChiTietSa__MaCha__3F466844",
                        column: x => x.MaChatLieu,
                        principalTable: "ChatLieu",
                        principalColumn: "MaChatLieu",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__ChiTietSa__MaCLR__412EB0B6",
                        column: x => x.MaCLR,
                        principalTable: "Color",
                        principalColumn: "MaCLR",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__ChiTietSa__MaSiz__403A8C7D",
                        column: x => x.MaSize,
                        principalTable: "Size",
                        principalColumn: "MaSize",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__ChiTietSan__MaCo__3E52440B",
                        column: x => x.MaCo,
                        principalTable: "LoaiCoGiay",
                        principalColumn: "MaCo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__ChiTietSan__MaSP__4222D4EF",
                        column: x => x.MaSP,
                        principalTable: "SanPham",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "history",
                columns: table => new
                {
                    MaHIS = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaCTSP = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MaNV = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NgayNhap = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__history__3C90C06949F39D52", x => x.MaHIS);
                    table.ForeignKey(
                        name: "FK__history__MaCTSP__44FF419A",
                        column: x => x.MaCTSP,
                        principalTable: "ChiTietSanPham",
                        principalColumn: "MaCTSP",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    MaHD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaCTSP = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DonGia = table.Column<double>(type: "float", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HoaDonCh__2725A6E061AC8FD4", x => x.MaHD);
                    table.ForeignKey(
                        name: "FK__HoaDonChi__MaCTS__4AB81AF0",
                        column: x => x.MaCTSP,
                        principalTable: "ChiTietSanPham",
                        principalColumn: "MaCTSP",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__HoaDonChiT__MaHD__4BAC3F29",
                        column: x => x.MaHD,
                        principalTable: "HoaDon",
                        principalColumn: "MaHD",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    MaImage = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaCTSP = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Images = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Images__93330B7835DD95B7", x => x.MaImage);
                    table.ForeignKey(
                        name: "FK__Images__MaCTSP__47DBAE45",
                        column: x => x.MaCTSP,
                        principalTable: "ChiTietSanPham",
                        principalColumn: "MaCTSP",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_MaChatLieu",
                table: "ChiTietSanPham",
                column: "MaChatLieu");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_MaCLR",
                table: "ChiTietSanPham",
                column: "MaCLR");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_MaCo",
                table: "ChiTietSanPham",
                column: "MaCo");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_MaSize",
                table: "ChiTietSanPham",
                column: "MaSize");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPham_MaSP",
                table: "ChiTietSanPham",
                column: "MaSP");

            migrationBuilder.CreateIndex(
                name: "IX_history_MaCTSP",
                table: "history",
                column: "MaCTSP");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaKH",
                table: "HoaDon",
                column: "MaKH");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaNV",
                table: "HoaDon",
                column: "MaNV");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_MaCTSP",
                table: "HoaDonChiTiet",
                column: "MaCTSP");

            migrationBuilder.CreateIndex(
                name: "IX_Images_MaCTSP",
                table: "Images",
                column: "MaCTSP");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_MaChucVu",
                table: "NhanVien",
                column: "MaChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaDanhMuc",
                table: "SanPham",
                column: "MaDanhMuc");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaNCC",
                table: "SanPham",
                column: "MaNCC");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "history");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "ChiTietSanPham");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "ChatLieu");

            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropTable(
                name: "Size");

            migrationBuilder.DropTable(
                name: "LoaiCoGiay");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "ChucVu");

            migrationBuilder.DropTable(
                name: "DanhMuc");

            migrationBuilder.DropTable(
                name: "NhaCungCap");
        }
    }
}
