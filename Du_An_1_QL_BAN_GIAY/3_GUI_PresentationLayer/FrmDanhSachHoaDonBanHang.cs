using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS_BusinessLayer;
using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Service;

namespace _3_GUI_PresentationLayer
{
    public partial class FrmDanhSachHoaDonBanHang : Form
    {
        private IBUS_DanhSachHoaDonBanHang _ChucnangdanhSachHoaDonBanHang;

        public FrmDanhSachHoaDonBanHang()
        {
            InitializeComponent();
            _ChucnangdanhSachHoaDonBanHang = new BUS_DanhSachHoaDonBanHang();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public  void loatdata(List<Danhsachhoadonbanhang>danhsachhoadonbanhangs)
        {
            dtgv_danhsachhoadonbanhang.ColumnCount = 5;
            dtgv_danhsachhoadonbanhang.Columns[0].Name = "ID Hóa đơn";
            dtgv_danhsachhoadonbanhang.Columns[1].Name = "Số điện thoại khách hàng";
            dtgv_danhsachhoadonbanhang.Columns[2].Name = "Tổng tiền";
            dtgv_danhsachhoadonbanhang.Columns[3].Name = "Người lập phiếu";
            dtgv_danhsachhoadonbanhang.Columns[4].Name =  "Ngày tạo";
            dtgv_danhsachhoadonbanhang.Rows.Clear();
            danhsachhoadonbanhangs.ForEach(x =>
                {
                    dtgv_danhsachhoadonbanhang.Rows.Add(x.hoadon.MaHd, x.KhachHang.Sdt, x.hoadon.ThanhTien,
                        x.NhanVien.MaNv);
                }
                );
        }

        private void btn_danhsach_Click(object sender, EventArgs e)
        {
           loatdata(_ChucnangdanhSachHoaDonBanHang.ListdDanhsachhoadonbanhang());
        }
    }
}
