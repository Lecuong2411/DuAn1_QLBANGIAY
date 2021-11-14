using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using _2_BUS_BusinessLayer;
using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Service;
using ClosedXML.Excel;

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
            label4.Text =DateTime.Now.ToLongDateString() +"\n" + DateTime.Now.ToLongTimeString();
            loatdata(_ChucnangdanhSachHoaDonBanHang.ListdDanhsachhoadonbanhang());
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
            dtgv_danhsachhoadonbanhang.Columns[3].Name = "Tiền nhận";
            dtgv_danhsachhoadonbanhang.Columns[4].Name = "Người lập phiếu";
            //dtgv_danhsachhoadonbanhang.Columns[5].Name = "Ngày tạo";
            DataGridViewButtonColumn dtgvbt = new DataGridViewButtonColumn();
            dtgvbt.Name = "btds";
            dtgvbt.HeaderText = "Chức năng";
            dtgvbt.Text = "reset";
            dtgvbt.UseColumnTextForButtonValue = true;
            dtgv_danhsachhoadonbanhang.Columns.Add(dtgvbt);
            dtgv_danhsachhoadonbanhang.Rows.Clear();
            danhsachhoadonbanhangs.ForEach(x =>
                {
                    dtgv_danhsachhoadonbanhang.Rows.Add(x.hoadon.MaHd, x.KhachHang.Sdt, x.hoadon.ThanhTien,
                        x.hoadon.TienNhan, x.NhanVien.TenNv);
                }
                );
        }
        public void loatdatatk(string sdt)
        {
            dtgv_danhsachhoadonbanhang.ColumnCount =5 ;
            dtgv_danhsachhoadonbanhang.Columns[0].Name = "ID Hóa đơn";
            dtgv_danhsachhoadonbanhang.Columns[1].Name = "Số điện thoại khách hàng";
            dtgv_danhsachhoadonbanhang.Columns[2].Name = "Tổng tiền";
            dtgv_danhsachhoadonbanhang.Columns[3].Name = "Tiền nhận";
            dtgv_danhsachhoadonbanhang.Columns[4].Name = "Người lập phiếu";
            //dtgv_danhsachhoadonbanhang.Columns[5].Name = "Ngày tạo";
            DataGridViewButtonColumn dtgvbt = new DataGridViewButtonColumn();
            dtgvbt.Name = "btds";
            dtgvbt.HeaderText = "Chức năng";
            dtgvbt.Text = "reset";
            dtgvbt.UseColumnTextForButtonValue = true;
            dtgv_danhsachhoadonbanhang.Columns.Add(dtgvbt);
            dtgv_danhsachhoadonbanhang.Rows.Clear();
           _ChucnangdanhSachHoaDonBanHang.loatdatatk(sdt).ForEach(x =>
                {
                    dtgv_danhsachhoadonbanhang.Rows.Add(x.hoadon.MaHd, x.KhachHang.Sdt, x.hoadon.ThanhTien,
                        x.hoadon.TienNhan,x.NhanVien.TenNv);
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

        private void FrmDanhSachHoaDonBanHang_Load(object sender, EventArgs e)
        {

        }

        private void btn_xuatexsel_Click(object sender, EventArgs e)
        {
            if (dtgv_danhsachhoadonbanhang.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelapp =
                    new Microsoft.Office.Interop.Excel.Application();
                xcelapp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dtgv_danhsachhoadonbanhang.Columns.Count + 1; i++)
                {
                       xcelapp.Cells[1, i] = dtgv_danhsachhoadonbanhang.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dtgv_danhsachhoadonbanhang.Rows.Count; i++)
                {
                    for (int j = 0; j < dtgv_danhsachhoadonbanhang.Columns.Count; j++)
                    {
                        xcelapp.Cells[i + 2, j + 1] = dtgv_danhsachhoadonbanhang.Rows[i].Cells[j].Value.ToString();
                    }
                }

                xcelapp.Columns.AutoFit();
                xcelapp.Visible = true;
            }

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {

        }

        private void dtgv_danhsachhoadonbanhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (index < 0 || index == _ChucnangdanhSachHoaDonBanHang.ListdDanhsachhoadonbanhang().Count) return;
            if (e.ColumnIndex == dtgv_danhsachhoadonbanhang.Columns["btds"].Index)
            {
                loatdata(_ChucnangdanhSachHoaDonBanHang.ListdDanhsachhoadonbanhang());
            }
        }

        //private void btn_xuatexsel_Click(object sender, EventArgs e)
        //{
        //    xuatEx(dtgv_danhsachhoadonbanhang, @"C:\", "XuatFileExcel");
        //}
        //public void xuatEx(DataGridView a,string duongDan, string tenTap)
        //{
        //    app obj = new ApplicationClass();
        //    obj.Application.Workbooks.Add(Type.Missing);
        //    obj.Columns.ColumnWidth = 25;
        //    for (int i = 1; i < a.Columns.Count+1; i++)
        //    {
        //        obj.Cells[1, i] = a.Columns[i - 1].HeaderText;
        //    }

        //    for (int i = 0; i < a.Rows.Count; i++)
        //    {
        //        for (int j = 0; j < a.Columns.Count; j++)
        //        {
        //            if (a.Rows[i].Cells[j] != null)
        //            {
        //                obj.Cells[i + 2, j + 1] = a.Rows[i].Cells[j].Value.ToString();
        //            }
        //        } 
        //    }
        //    obj.ActiveWorkbook.SaveCopyAs(duongDan+tenTap+".xlsx");
        //    obj.ActiveWorkbook.Saved = true;
        //}




    }
}
