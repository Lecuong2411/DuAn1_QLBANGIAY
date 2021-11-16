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
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public  void loatdata(List<Danhsachhoadonbanhang>danhsachhoadonbanhangs)
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
                    dtgv_danhsachhoadonbanhang.Rows.Add(x.hoadon.MaHd, x.KhachHang.Sdt, x.hoadon.ThanhTien,
                        x.NhanVien.MaNv,x.hoadon.TienNhan);
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
           _ChucnangdanhSachHoaDonBanHang.loatdatatk(sdt).ForEach(x =>
                {
                    dtgv_danhsachhoadonbanhang.Rows.Add(x.hoadon.MaHd, x.KhachHang.Sdt, x.hoadon.ThanhTien,
                        x.NhanVien.MaNv,x.hoadon.TienNhan);
                }
            );
        }

        private void btn_danhsach_Click(object sender, EventArgs e)
        {
           loatdata(_ChucnangdanhSachHoaDonBanHang.ListdDanhsachhoadonbanhang());
        }

        private void txt_maphieunhap_KeyUp(object sender, KeyEventArgs e)
        {
            loatdatatk(txt_maphieunhap.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongDateString() + "\n" + DateTime.Now.ToLongTimeString();
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
                    xuatExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công \n " + ex.Message);
                }
            }
        }
        public void xuatExcel(string path)
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
    }
}
