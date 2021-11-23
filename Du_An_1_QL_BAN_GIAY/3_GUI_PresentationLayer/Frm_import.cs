using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS_BusinessLayer.IService;
using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Service;
using Microsoft.Office.Interop.Excel;


namespace _3_GUI_PresentationLayer
{
    public partial class Frm_import : Form
    {
        private QLSanPham _qlSanPham = new QLSanPham();
        private IQlSanPhamService _iQlSanPhamService ;
        public Frm_import()
        {
            InitializeComponent();
            _iQlSanPhamService = new QlSanPhamService();
        }

        private void btn_importExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
            Microsoft.Office.Interop.Excel.Range xlRange;
            int xlRow;
            openFD.Filter = "Excel Office |*.xls; *.xlsx";
            openFD.ShowDialog();
            string strFileName = openFD.FileName;
            if (strFileName != "")
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkbook = xlApp.Workbooks.Open(strFileName);
                //Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(pathExcel, null,false);
                xlWorksheet = xlWorkbook.Worksheets["Sheet1"];
                xlRange = xlWorksheet.UsedRange;
                int i = 0;
                for (xlRow  = 2; xlRow <= xlRange.Rows.Count; xlRow++)
                {
                    if (xlRange.Cells[xlRow,1].Text != null)
                    {
                        i++;
                        dgv.Rows.Add(xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text,
                            xlRange.Cells[xlRow, 3].Text, xlRange.Cells[xlRow, 4].Text,
                            xlRange.Cells[xlRow, 5].Text, xlRange.Cells[xlRow, 6].Text,
                            xlRange.Cells[xlRow, 7].Text, xlRange.Cells[xlRow, 8].Text,
                            xlRange.Cells[xlRow, 9].Text, xlRange.Cells[xlRow, 10].Text,
                            xlRange.Cells[xlRow, 11].Text, xlRange.Cells[xlRow, 12].Text);
                    }
                  
                }
                xlWorkbook.Close();
                xlApp.Quit();
            }

        }

      
        private void btn_save_Click(object sender, EventArgs e)
        {
         
            if (dgv.Rows.Count !=0)
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    _iQlSanPhamService = new QlSanPhamService();
                    _qlSanPham.ChiTietSanPham.MaCTSP ="SPCT"+(_iQlSanPhamService.GetLstCTSanPham().Count+1);
                    _qlSanPham.ChiTietSanPham.MaSP = _iQlSanPhamService.GetLstSP().Where(c => c.TenSp == dgv.Rows[i].Cells[0].Value.ToString()).Select(c => c.MaSp).FirstOrDefault();
                    _qlSanPham.ChiTietSanPham.MaCLR = _iQlSanPhamService.GetLstColor().Where(c => c.ColorSP == dgv.Rows[i].Cells[1].Value.ToString())
                        .Select(c => c.MaClr).FirstOrDefault();
                    _qlSanPham.ChiTietSanPham.MaSize = _iQlSanPhamService.GetLstSize().Where(c => c.SizeSp == int.Parse(dgv.Rows[i].Cells[2].Value.ToString()))
                        .Select(c => c.MaSize).FirstOrDefault();
                    _qlSanPham.ChiTietSanPham.GiaNhap = int.Parse(dgv.Rows[i].Cells[3].Value.ToString());
                    _qlSanPham.ChiTietSanPham.giaban = int.Parse(dgv.Rows[i].Cells[4].Value.ToString());
                    _qlSanPham.ChiTietSanPham.soluong = int.Parse(dgv.Rows[i].Cells[5].Value.ToString());
                    _qlSanPham.ChiTietSanPham.MaQR = dgv.Rows[i].Cells[6].Value.ToString();
                    _qlSanPham.ChiTietSanPham.Mota = dgv.Rows[i].Cells[7].Value.ToString();
                    _qlSanPham.ChiTietSanPham.GhiChu = dgv.Rows[i].Cells[8].Value.ToString();
                    _qlSanPham.ChiTietSanPham.MaChatLieu = _iQlSanPhamService.GetLstChatLieu().Where(c => c.ChatLieuSP == dgv.Rows[i].Cells[9].Value.ToString()).
                        Select(c => c.MaChatLieu).FirstOrDefault();
                    _qlSanPham.ChiTietSanPham.MaCo = _iQlSanPhamService.GetLstLoaiCoGiay()
                        .Where(c => c.LoaiCoGiaySP == dgv.Rows[i].Cells[10].Value.ToString()).Select(c => c.MaCo).FirstOrDefault();
                    _qlSanPham.ChiTietSanPham.TrangThai = dgv.Rows[i].Cells[11].Value.ToString() == "Còn hàng" ? 1 : 0;
                    _qlSanPham.ChiTietSanPham.MaPB = "PB2";
                    _iQlSanPhamService.addCTSanPham(_qlSanPham.ChiTietSanPham);
                    //History history = new History();
                    //history.MaCTSP = _qlSanPham.ChiTietSanPham.MaCTSP;
                    //history.MaHis ="His"+ _iQlSanPhamService.GetLstHistory().Count + 1;
                    //history.MaNV = "";
                    //history.NgayNhap=DateTime.Now;
                    //_iQlSanPhamService.addHistory(history);

                    // chạy chương trình sẽ mở
                }

                MessageBox.Show("successful","!");
            }
        }
    }
}
