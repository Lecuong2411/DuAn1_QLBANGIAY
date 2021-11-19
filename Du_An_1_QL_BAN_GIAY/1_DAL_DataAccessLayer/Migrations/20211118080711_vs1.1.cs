using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DataAccessLayer.Migrations
{
    public partial class vs11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChatLieu",
                columns: table => new
                {
                    MaChatLieu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ChatLieuSP = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatLieu", x => x.MaChatLieu);
                });

            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    MaChucVu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Roles = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.MaChucVu);
                });

            migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    MaClr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ColorSP = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.MaClr);
                });

            migrationBuilder.CreateTable(
                name: "DanhMuc",
                columns: table => new
                {
                    MaDanhMuc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TenDanhMuc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc", x => x.MaDanhMuc);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    MaKh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TenKh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Sdt = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.MaKh);
                });

            migrationBuilder.CreateTable(
                name: "LoaiCoGiay",
                columns: table => new
                {
                    MaCo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LoaiCoGiaySP = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiCoGiay", x => x.MaCo);
                });

            migrationBuilder.CreateTable(
                name: "NhaCungCap",
                columns: table => new
                {
                    MaNcc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NguoiCc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CongTyCc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Sdt = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCap", x => x.MaNcc);
                });

            migrationBuilder.CreateTable(
                name: "ProductBack",
                columns: table => new
                {
                    MaPB = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProductStatus = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBack", x => x.MaPB);
                });

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    MaSize = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SizeSp = table.Column<int>(type: "int", nullable: false),
                    ChieuDaiChan = table.Column<double>(type: "float", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.MaSize);
                });

            migrationBuilder.CreateTable(
                name: "Voucher",
                columns: table => new
                {
                    MaVouCher = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Vouchers = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NSD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HSD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    SoLuongDSD = table.Column<int>(type: "int", nullable: false),
                    MenhGia = table.Column<float>(type: "real", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    GhiChu = table.Column<int>(type: "int", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voucher", x => x.MaVouCher);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNv = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TenNv = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Sdt = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MatKhau = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GioiTinh = table.Column<int>(type: "int", nullable: true),
                    NamSinh = table.Column<int>(type: "int", nullable: true),
                    MaChucVu = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    HinhAnh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MaNv);
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_MaChucVu",
                        column: x => x.MaChucVu,
                        principalTable: "ChucVu",
                        principalColumn: "MaChucVu",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    MaSp = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TenSp = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ThuongHieu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    MaDanhMuc = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    MaNCC = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.MaSp);
                    table.ForeignKey(
                        name: "FK_SanPham_DanhMuc_MaDanhMuc",
                        column: x => x.MaDanhMuc,
                        principalTable: "DanhMuc",
                        principalColumn: "MaDanhMuc",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SanPham_NhaCungCap_MaNCC",
                        column: x => x.MaNCC,
                        principalTable: "NhaCungCap",
                        principalColumn: "MaNcc",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    MaHd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ThanhTien = table.Column<double>(type: "float", nullable: true),
                    TienNhan = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MaKH = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    MaNV = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    MaVouCher = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    thoigian = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThaiHd = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.MaHd);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_MaKH",
                        column: x => x.MaKH,
                        principalTable: "KhachHang",
                        principalColumn: "MaKh",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_MaNV",
                        column: x => x.MaNV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNv",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDon_Voucher_MaVouCher",
                        column: x => x.MaVouCher,
                        principalTable: "Voucher",
                        principalColumn: "MaVouCher",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietSanPham",
                columns: table => new
                {
                    MaCTSP = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MaCo = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    MaChatLieu = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Mota = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MaQR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    soluong = table.Column<int>(type: "int", nullable: false),
                    giaban = table.Column<int>(type: "int", nullable: false),
                    GiaNhap = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    MaSize = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    MaCLR = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    MaSP = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    MaPB = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietSanPham", x => x.MaCTSP);
                    table.ForeignKey(
                        name: "FK_ChiTietSanPham_ChatLieu_MaChatLieu",
                        column: x => x.MaChatLieu,
                        principalTable: "ChatLieu",
                        principalColumn: "MaChatLieu",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietSanPham_Color_MaCLR",
                        column: x => x.MaCLR,
                        principalTable: "Color",
                        principalColumn: "MaClr",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietSanPham_LoaiCoGiay_MaCo",
                        column: x => x.MaCo,
                        principalTable: "LoaiCoGiay",
                        principalColumn: "MaCo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietSanPham_ProductBack_MaPB",
                        column: x => x.MaPB,
                        principalTable: "ProductBack",
                        principalColumn: "MaPB",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietSanPham_SanPham_MaSP",
                        column: x => x.MaSP,
                        principalTable: "SanPham",
                        principalColumn: "MaSp",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietSanPham_Size_MaSize",
                        column: x => x.MaSize,
                        principalTable: "Size",
                        principalColumn: "MaSize",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "history",
                columns: table => new
                {
                    MaHis = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MaCTSP = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    MaNV = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    NgayNhap = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_history", x => x.MaHis);
                    table.ForeignKey(
                        name: "FK_history_ChiTietSanPham_MaCTSP",
                        column: x => x.MaCTSP,
                        principalTable: "ChiTietSanPham",
                        principalColumn: "MaCTSP",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_history_NhanVien_MaNV",
                        column: x => x.MaNV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNv",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    MaHd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MaCTSP = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    DonGia = table.Column<double>(type: "float", nullable: false),
                    soluong = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => x.MaHd);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_ChiTietSanPham_MaCTSP",
                        column: x => x.MaCTSP,
                        principalTable: "ChiTietSanPham",
                        principalColumn: "MaCTSP",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_HoaDon_MaHd",
                        column: x => x.MaHd,
                        principalTable: "HoaDon",
                        principalColumn: "MaHd",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    MaImage = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MaCTSP = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Images = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.MaImage);
                    table.ForeignKey(
                        name: "FK_Images_ChiTietSanPham_MaCTSP",
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
                name: "IX_ChiTietSanPham_MaPB",
                table: "ChiTietSanPham",
                column: "MaPB");

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
                name: "IX_history_MaNV",
                table: "history",
                column: "MaNV");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaKH",
                table: "HoaDon",
                column: "MaKH");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaNV",
                table: "HoaDon",
                column: "MaNV");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaVouCher",
                table: "HoaDon",
                column: "MaVouCher");

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
                name: "Voucher");

            migrationBuilder.DropTable(
                name: "ChatLieu");

            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropTable(
                name: "LoaiCoGiay");

            migrationBuilder.DropTable(
                name: "ProductBack");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "Size");

            migrationBuilder.DropTable(
                name: "ChucVu");

            migrationBuilder.DropTable(
                name: "DanhMuc");

            migrationBuilder.DropTable(
                name: "NhaCungCap");
        }
    }
}
