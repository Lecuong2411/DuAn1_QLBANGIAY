using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DataAccessLayer.Migrations
{
    public partial class vs14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhuyenMai",
                columns: table => new
                {
                    MaKM = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TenChuongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayHet = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GiamGia = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuyenMai", x => x.MaKM);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietGiamGia",
                columns: table => new
                {
                    MaCTGG = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MaKM = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    MaDanhMuc = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietGiamGia", x => x.MaCTGG);
                    table.ForeignKey(
                        name: "FK_ChiTietGiamGia_DanhMuc_MaDanhMuc",
                        column: x => x.MaDanhMuc,
                        principalTable: "DanhMuc",
                        principalColumn: "MaDanhMuc",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietGiamGia_KhuyenMai_MaKM",
                        column: x => x.MaKM,
                        principalTable: "KhuyenMai",
                        principalColumn: "MaKM",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiamGia_MaDanhMuc",
                table: "ChiTietGiamGia",
                column: "MaDanhMuc");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietGiamGia_MaKM",
                table: "ChiTietGiamGia",
                column: "MaKM");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietGiamGia");

            migrationBuilder.DropTable(
                name: "KhuyenMai");
        }
    }
}
