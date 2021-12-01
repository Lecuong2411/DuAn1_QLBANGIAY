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
using _2_BUS_BusinessLayer.IService;
using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Service;
using Excel=Microsoft.Office.Interop.Excel;

namespace _3_GUI_PresentationLayer
{
    public partial class FrmDanhSachHoaDonBanHang : Form
    {
        private IBUS_DanhSachHoaDonBanHang _ChucnangdanhSachHoaDonBanHang;
        

        public FrmDanhSachHoaDonBanHang()
        {
            InitializeComponent();
            _ChucnangdanhSachHoaDonBanHang = new BUS_DanhSachHoaDonBanHang();
            timer1.Enabled = true;
            timer1.Start();
            label4.Text =DateTime.Now.ToLongDateString()+"\n"+ DateTime.Now.ToLongTimeString();
            label3.Text =DateTime.Now.ToLongDateString()+"\n"+ DateTime.Now.ToLongTimeString();
            cbb_timkiem.Items.Add("SĐT");
            cbb_timkiem.Items.Add("Tên khách hàng");
            cbb_timkiem.Items.Add("Tên Giày");
            cbb_timkiem.Items.Add("Người lập phiếu");
           loatdata(_ChucnangdanhSachHoaDonBanHang.loatdatahd());
            loatdatahdct(_ChucnangdanhSachHoaDonBanHang.loatdatachitiet());
            
        }

       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public void loatdatahdct(List<Danhsachhoadonbanhang> danhsachhoadonbanhangs)
        {
            dtgv_dshdct.ColumnCount = 13;
            dtgv_dshdct.Columns[0].Name = "Tên khách hàng";
            dtgv_dshdct.Columns[1].Name = "Số điện thoại khách hàng";
            dtgv_dshdct.Columns[2].Name = "Size";
            dtgv_dshdct.Columns[3].Name = "Color";
            dtgv_dshdct.Columns[4].Name = "Loại cổ giày";
            dtgv_dshdct.Columns[5].Name = "Chất liệu";
            dtgv_dshdct.Columns[6].Name = "Ghi chú";
            dtgv_dshdct.Columns[7].Name = "Tên Giày";
            dtgv_dshdct.Columns[8].Name = "Đơn Giá";
            dtgv_dshdct.Columns[9].Name = "Số lượng ";
            dtgv_dshdct.Columns[10].Name = "Tổng tiền";
            dtgv_dshdct.Columns[11].Name = "Người lập phiếu";
            dtgv_dshdct.Columns[12].Name = "Ngày bán";
            dtgv_dshdct.Rows.Clear();
            danhsachhoadonbanhangs.ForEach(x =>
            {
                dtgv_dshdct.Rows.Add(x.KhachHang.TenKh, x.KhachHang.Sdt, x.Size.SizeSp, x.Color.ColorSP,
                    x.LoaiCoGiay.LoaiCoGiaySP, x.ChatLieu.ChatLieuSP, x.ChiTietSanPham.GhiChu, x.SanPham.TenSp,
                    x.ChiTietSanPham.giaban, x.hoaDonChiTiet.soluong, x.hoadon.Tongtien, x.NhanVien.TenNv,x.hoadon.thoigian);
            });

        }
        public void loatdatahdtimkiemtg(string tg)
        {
            dtgv_dshdct.ColumnCount = 13;
            dtgv_dshdct.Columns[0].Name = "Tên khách hàng";
            dtgv_dshdct.Columns[1].Name = "Số điện thoại khách hàng";
            dtgv_dshdct.Columns[2].Name = "Size";
            dtgv_dshdct.Columns[3].Name = "Color";
            dtgv_dshdct.Columns[4].Name = "Loại cổ giày";
            dtgv_dshdct.Columns[5].Name = "Chất liệu";
            dtgv_dshdct.Columns[6].Name = "Ghi chú";
            dtgv_dshdct.Columns[7].Name = "Tên Giày";
            dtgv_dshdct.Columns[8].Name = "Đơn Giá";
            dtgv_dshdct.Columns[9].Name = "Số lượng ";
            dtgv_dshdct.Columns[10].Name = "Tổng tiền";
            dtgv_dshdct.Columns[11].Name = "Người lập phiếu";
            dtgv_dshdct.Columns[12].Name = "Ngày bán";
            dtgv_dshdct.Rows.Clear();
            _ChucnangdanhSachHoaDonBanHang.timkiemtg(tg).ForEach(x =>
            {
                dtgv_dshdct.Rows.Add(x.KhachHang.TenKh, x.KhachHang.Sdt, x.Size.SizeSp, x.Color.ColorSP,
                    x.LoaiCoGiay.LoaiCoGiaySP, x.ChatLieu.ChatLieuSP, x.ChiTietSanPham.GhiChu, x.SanPham.TenSp,
                    x.ChiTietSanPham.giaban, x.hoaDonChiTiet.soluong, x.hoadon.Tongtien, x.NhanVien.TenNv, x.hoadon.thoigian);
            });

        }
        public void loatdatahdtimkiemnguoilapphiep(string nlp)
        {
            dtgv_dshdct.ColumnCount = 13;
            dtgv_dshdct.Columns[0].Name = "Tên khách hàng";
            dtgv_dshdct.Columns[1].Name = "Số điện thoại khách hàng";
            dtgv_dshdct.Columns[2].Name = "Size";
            dtgv_dshdct.Columns[3].Name = "Color";
            dtgv_dshdct.Columns[4].Name = "Loại cổ giày";
            dtgv_dshdct.Columns[5].Name = "Chất liệu";
            dtgv_dshdct.Columns[6].Name = "Ghi chú";
            dtgv_dshdct.Columns[7].Name = "Tên Giày";
            dtgv_dshdct.Columns[8].Name = "Đơn Giá";
            dtgv_dshdct.Columns[9].Name = "Số lượng ";
            dtgv_dshdct.Columns[10].Name = "Tổng tiền";
            dtgv_dshdct.Columns[11].Name = "Người lập phiếu";
            dtgv_dshdct.Columns[12].Name = "Ngày bán";
            dtgv_dshdct.Rows.Clear();
            _ChucnangdanhSachHoaDonBanHang.timkiemnguoilapphieu(nlp).ForEach(x =>
            {
                dtgv_dshdct.Rows.Add(x.KhachHang.TenKh, x.KhachHang.Sdt, x.Size.SizeSp, x.Color.ColorSP,
                    x.LoaiCoGiay.LoaiCoGiaySP, x.ChatLieu.ChatLieuSP, x.ChiTietSanPham.GhiChu, x.SanPham.TenSp,
                    x.ChiTietSanPham.giaban, x.hoaDonChiTiet.soluong, x.hoadon.Tongtien, x.NhanVien.TenNv, x.hoadon.thoigian);
            });

        }
        public void loatdatahdtimkiemsdt(string sdt)
        {
            dtgv_dshdct.ColumnCount = 13;
            dtgv_dshdct.Columns[0].Name = "Tên khách hàng";
            dtgv_dshdct.Columns[1].Name = "Số điện thoại khách hàng";
            dtgv_dshdct.Columns[2].Name = "Size";
            dtgv_dshdct.Columns[3].Name = "Color";
            dtgv_dshdct.Columns[4].Name = "Loại cổ giày";
            dtgv_dshdct.Columns[5].Name = "Chất liệu";
            dtgv_dshdct.Columns[6].Name = "Ghi chú";
            dtgv_dshdct.Columns[7].Name = "Tên Giày";
            dtgv_dshdct.Columns[8].Name = "Đơn Giá";
            dtgv_dshdct.Columns[9].Name = "Số lượng ";
            dtgv_dshdct.Columns[10].Name = "Tổng tiền";
            dtgv_dshdct.Columns[11].Name = "Người lập phiếu";
            dtgv_dshdct.Columns[12].Name = "Ngày bán";
            dtgv_dshdct.Rows.Clear();
            _ChucnangdanhSachHoaDonBanHang.timkiemsdt(sdt).ForEach(x =>
            {
                dtgv_dshdct.Rows.Add(x.KhachHang.TenKh, x.KhachHang.Sdt, x.Size.SizeSp, x.Color.ColorSP,
                    x.LoaiCoGiay.LoaiCoGiaySP, x.ChatLieu.ChatLieuSP, x.ChiTietSanPham.GhiChu, x.SanPham.TenSp,
                    x.ChiTietSanPham.giaban, x.hoaDonChiTiet.soluong, x.hoadon.Tongtien, x.NhanVien.TenNv, x.hoadon.thoigian);
            });

        }
        public void loatdatahdtimkiemtenkh(string namkh)
        {
            dtgv_dshdct.ColumnCount = 13;
            dtgv_dshdct.Columns[0].Name = "Tên khách hàng";
            dtgv_dshdct.Columns[1].Name = "Số điện thoại khách hàng";
            dtgv_dshdct.Columns[2].Name = "Size";
            dtgv_dshdct.Columns[3].Name = "Color";
            dtgv_dshdct.Columns[4].Name = "Loại cổ giày";
            dtgv_dshdct.Columns[5].Name = "Chất liệu";
            dtgv_dshdct.Columns[6].Name = "Ghi chú";
            dtgv_dshdct.Columns[7].Name = "Tên Giày";
            dtgv_dshdct.Columns[8].Name = "Đơn Giá";
            dtgv_dshdct.Columns[9].Name = "Số lượng ";
            dtgv_dshdct.Columns[10].Name = "Tổng tiền";
            dtgv_dshdct.Columns[11].Name = "Người lập phiếu";
            dtgv_dshdct.Columns[12].Name = "Ngày bán";
            dtgv_dshdct.Rows.Clear();
            _ChucnangdanhSachHoaDonBanHang.timkiemkh(namkh).ForEach(x =>
            {
                dtgv_dshdct.Rows.Add(x.KhachHang.TenKh, x.KhachHang.Sdt, x.Size.SizeSp, x.Color.ColorSP,
                    x.LoaiCoGiay.LoaiCoGiaySP, x.ChatLieu.ChatLieuSP, x.ChiTietSanPham.GhiChu, x.SanPham.TenSp,
                    x.ChiTietSanPham.giaban, x.hoaDonChiTiet.soluong, x.hoadon.Tongtien, x.NhanVien.TenNv, x.hoadon.thoigian);
            });

        }
        public void loatdata(List<Danhsachhoadonbanhang> danhsachhoadonbanhangs)
        {
            dtgv_danhsachhoadonbanhang.ColumnCount = 6;
            dtgv_danhsachhoadonbanhang.Columns[0].Name = "ID Hóa đơn";
            dtgv_danhsachhoadonbanhang.Columns[1].Name = "Số điện thoại khách hàng";
            dtgv_danhsachhoadonbanhang.Columns[2].Name = "Tổng tiền";
            dtgv_danhsachhoadonbanhang.Columns[3].Name = "Người lập phiếu";
            dtgv_danhsachhoadonbanhang.Columns[4].Name = "Tiền nhận";
            dtgv_danhsachhoadonbanhang.Columns[5].Name = "Ngày tạo";

            dtgv_danhsachhoadonbanhang.Rows.Clear();
            danhsachhoadonbanhangs.ForEach(x =>
                {
                    dtgv_danhsachhoadonbanhang.Rows.Add(x.hoadon.MaHd, x.KhachHang.Sdt, x.hoadon.Tongtien,
                        x.NhanVien.MaNv, x.hoadon.TienNhan, x.hoadon.thoigian);
                }
                );
        }

        public void loatdatatk(string sdt)
        {
            dtgv_danhsachhoadonbanhang.ColumnCount = 6 ;
            dtgv_danhsachhoadonbanhang.Columns[0].Name = "ID Hóa đơn";
            dtgv_danhsachhoadonbanhang.Columns[1].Name = "Số điện thoại khách hàng";
            dtgv_danhsachhoadonbanhang.Columns[2].Name = "Tổng tiền";
            dtgv_danhsachhoadonbanhang.Columns[3].Name = "Người lập phiếu";
            dtgv_danhsachhoadonbanhang.Columns[4].Name = "Tiền nhận";
            dtgv_danhsachhoadonbanhang.Columns[5].Name = "Ngày tạo";
            dtgv_danhsachhoadonbanhang.Rows.Clear();
           _ChucnangdanhSachHoaDonBanHang.timkiemsdt(sdt).ForEach(x =>
                {
                    dtgv_danhsachhoadonbanhang.Rows.Add(x.hoadon.MaHd, x.KhachHang.Sdt, x.hoadon.Tongtien,
                        x.NhanVien.MaNv,x.hoadon.TienNhan, x.hoadon.thoigian);
                }
            );
        }

        private void btn_danhsach_Click(object sender, EventArgs e)
        {
           loatdata(_ChucnangdanhSachHoaDonBanHang.loatdatahd());
        }

        private void txt_maphieunhap_KeyUp(object sender, KeyEventArgs e)
        {
            loatdatatk(txt_maphieunhap.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongDateString() + "\n" + DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToLongDateString() + "\n" + DateTime.Now.ToLongTimeString();
        }

        private void btn_xuatexcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    xuatExcel(saveFileDialog.FileName,dtgv_danhsachhoadonbanhang);
                    MessageBox.Show("Xuất file thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công \n " + ex.Message);
                }
            }
        }
        public void xuatExcel(string path, DataGridView dtgv_danhsachhoadonbanhang)
        {

            if (dtgv_danhsachhoadonbanhang.Rows.Count > 0)
            {
                Excel.Application application = new Excel.Application();
                application.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dtgv_danhsachhoadonbanhang.Columns.Count + 1; i++)
                {
                    application.Cells[1, i] = dtgv_danhsachhoadonbanhang.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dtgv_danhsachhoadonbanhang.Rows.Count; i++)
                {
                    for (int j = 0; j < dtgv_danhsachhoadonbanhang.Columns.Count; j++)
                    {
                        application.Cells[i + 2, j + 1] = dtgv_danhsachhoadonbanhang.Rows[i].Cells[j].Value;
                    }
                }

                application.Columns.AutoFit();
                application.Visible = true;
                application.ActiveWorkbook.SaveCopyAs(path);
                application.ActiveWorkbook.Saved = true;
            }

        }

        private void btn_xuatExcelct_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    xuatExcel(saveFileDialog.FileName, dtgv_dshdct);
                    MessageBox.Show("Xuất file thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công \n " + ex.Message);
                }
            }
        }

        private void txt_timkiemct_KeyUp(object sender, KeyEventArgs e)
        {
            if (cbb_timkiem.Text == "SĐT")
            {
                loatdatahdtimkiemsdt(txt_timkiemct.Text);
            }
            else if (cbb_timkiem.Text == "Tên khách hàng")
            {
                loatdatahdtimkiemtenkh(txt_timkiemct.Text);
            }
            else if (cbb_timkiem.Text == "Tên Giày")
            {
                loatdatahdtimkiemtg(txt_timkiemct.Text);
            }
            else if (cbb_timkiem.Text == "Người lập phiếu")
            {
                loatdatahdtimkiemnguoilapphiep(txt_timkiemct.Text);
            }
        }

        private void btn_dsct_Click(object sender, EventArgs e)
        {
            loatdatahdct(_ChucnangdanhSachHoaDonBanHang.loatdatachitiet()); 
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            var listtkn = _ChucnangdanhSachHoaDonBanHang.loatdatahd()
                .Where(c => c.hoadon.thoigian.ToShortDateString().StartsWith(dtp_ngaythang.Text)).ToList();
            loatdata(listtkn);
        }

        private void btn_hdct_Click(object sender, EventArgs e)
        {
            var listtkn = _ChucnangdanhSachHoaDonBanHang.loatdatachitiet()
                .Where(c => c.hoadon.thoigian.ToShortDateString().StartsWith(dtp_ct.Text)).ToList();
            loatdatahdct(listtkn);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
