using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS_BusinessLayer;
using _2_BUS_BusinessLayer.IService;
using _2_BUS_BusinessLayer.Service;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_Thongke : Form
    {
        private I_QLThongKe _IServiceQLThongKe;
        private IBUS_DanhSachHoaDonBanHang _service;
        private IQlSanPhamService _serviceSPham;
        public Frm_Thongke()
        {
            InitializeComponent();
            _IServiceQLThongKe = new Service_QLThongKe();
            _service = new BUS_DanhSachHoaDonBanHang();
            _serviceSPham = new QlSanPhamService();
            LoadThongTinThongKe();
            cbx_Thongke.Items.Add("DoanhThu");
            cbx_Thongke.Items.Add("TongHoaDon");
            cbx_Thongke.Items.Add("HangCanNhap");
            cbx_Thongke.Items.Add("All");
            lbl_hangcannhap.Hide();

            grid_Data.Columns[0].DefaultCellStyle.Format = "N0";
            grid_Data.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_Data.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Data.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Data.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            lbl_Gio.Text = DateTime.Now.ToLongDateString() + "\n" + DateTime.Now.ToLongTimeString();
        }

        #region Load dữ liệu

        public void LoadThongTinThongKe()
        {
            grid_Data.ColumnCount = 5;
            grid_Data.Columns[0].Name = "doanh thu";
            grid_Data.Columns[1].Name = "mã hoá đơn ";
            grid_Data.Columns[2].Name = "tên sản phẩm";
            grid_Data.Columns[3].Name = "SL sản phẩm";
            grid_Data.Columns[4].Name = "ngày tạo HĐ";
            grid_Data.Rows.Clear();
            foreach (var x in _service.loatdatachitiet())
            {
                grid_Data.Rows.Add(x.hoadon.TienNhan, x.hoadon.MaHd, x.SanPham.TenSp, x.ChiTietSanPham.soluong, x.hoadon.thoigian);
            }
        }
        public void Load()
        {
            grid_Data.ColumnCount = 4;
            grid_Data.Columns[0].Name = "doanh thu";
            grid_Data.Columns[1].Name = "Mã hoá đơn ";
            grid_Data.Columns[2].Name = "tên nhân viên";
            grid_Data.Columns[3].Name = "Số lượng";
            grid_Data.Rows.Clear();
            foreach (var x in _service.loatdatachitiet().Where(c => c.hoadon.thoigian.Day == dateTimePicker1.Value.Day && c.hoadon.thoigian.Month == dateTimePicker1.Value.Month && c.hoadon.thoigian.Year == dateTimePicker1.Value.Year))
            {
                grid_Data.Rows.Add(x.hoadon.TienNhan, x.hoadon.MaHd, x.NhanVien.TenNv, x.hoaDonChiTiet.soluong);
            }
        }
        public void LoadHangCanNhap()
        {
            grid_Data.ColumnCount = 3;
            grid_Data.Columns[0].Name = "Tên sản phẩm";
            grid_Data.Columns[1].Name = "Mã sản phẩm ";
            grid_Data.Columns[2].Name = "Số lượng";
            grid_Data.Rows.Clear();
            foreach (var x in _serviceSPham.GetSPAll().Where(c=>c.ChiTietSanPham.soluong<10))
            {
                grid_Data.Rows.Add(x.SanPham.TenSp, x.SanPham.MaSp, x.ChiTietSanPham.soluong);
            }
        }

        #endregion

        #region Untility

        void SumTongTien()
        {
            var total = 0;
            for (int i = 0; i < grid_Data.Rows.Count; i++)
            {
                total += Convert.ToInt32(grid_Data.Rows[i].Cells[0].Value);
            }

            lbl_ThongKe.Text = total + " .VNĐ";
        }

        public void GuiMail_ThongKe(string email, string soluongHD, string TongTien,DataGridView GridHangCanNhap)
        {
            try
            {
                SmtpClient emailNguon = new SmtpClient("smtp.gmail.com", 25);
                NetworkCredential cret = new NetworkCredential("levanhoc001@gmail.com", "0964046838");
                MailMessage mag = new MailMessage();
                mag.From = new MailAddress(email);
                mag.To.Add(email);
                mag.Subject = "Đang sử dụng chứcc năng Báo cáo thống kê theo ngày";
                mag.Body = "Nội dung thống kê : " + soluongHD 
                                                  + TongTien
                                                  + GridHangCanNhap;
                emailNguon.Credentials = cret;
                emailNguon.EnableSsl = true;
                emailNguon.Send(mag);

            }
            catch (Exception)
            {

                return;
            }

        }

        public void xuatExcel(string path, DataGridView Grid_DataHangCanNhap)
        {

            if (Grid_DataHangCanNhap.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
                application.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < Grid_DataHangCanNhap.Columns.Count + 1; i++)
                {
                    application.Cells[1, i] = Grid_DataHangCanNhap.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < Grid_DataHangCanNhap.Rows.Count; i++)
                {
                    for (int j = 0; j < Grid_DataHangCanNhap.Columns.Count; j++)
                    {
                        application.Cells[i + 2, j + 1] = Grid_DataHangCanNhap.Rows[i].Cells[j].Value;
                    }
                }

                application.Columns.AutoFit();
                application.Visible = true;
                application.ActiveWorkbook.SaveCopyAs(path);
                application.ActiveWorkbook.Saved = true;
            }
        }
        public void CountSLHD()
        {

            lbl_Tk_TongHD.Text = _IServiceQLThongKe.LstHoaDons().Where(c => c.TrangThaiHd == 1 && c.thoigian.Day == dateTimePicker1.Value.Day && c.thoigian.Month == dateTimePicker1.Value.Month && c.thoigian.Year == dateTimePicker1.Value.Year)
                .Select(c => c.MaHd).Count().ToString();
        }

        #endregion

        #region Button

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Gio.Text = DateTime.Now.ToLongDateString() + "\n" + DateTime.Now.ToLongTimeString();
        }

        private void btn_GuiThongKe_Click(object sender, EventArgs e)
        {
            lbl_ThongKe.Text = "0";
            for (int i = 0; i < grid_Data.Rows.Count; i++)
            {
                if (cbx_Thongke.Text == "DoanhThu")
                {
                    Load();
                    SumTongTien();
                    lbl_hangcannhap.Hide();
                    lbl_Tk_TongHD.Text = "0";
                }
                else if (cbx_Thongke.Text == "TongHoaDon")
                {
                    CountSLHD();
                    lbl_hangcannhap.Hide();
                    lbl_ThongKe.Text = "0";
                }
                else if (cbx_Thongke.Text == "HangCanNhap")
                {
                    LoadHangCanNhap();
                    lbl_hangcannhap.Show();
                    lbl_Tk_TongHD.Text = "0";
                    lbl_ThongKe.Text = "0";
                }
                else if (cbx_Thongke.Text == "All")
                {
                    Load();
                    SumTongTien();
                    CountSLHD();
                    LoadHangCanNhap();
                    lbl_hangcannhap.Show();
                }
                else
                {
                    MessageBox.Show("chọn mục cần thống kê đi ", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    cbx_Thongke.Focus();
                }
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            LoadThongTinThongKe();
        }

        #endregion

        private void btn_GuiEmail_Tk_Click(object sender, EventArgs e)
        {
            var slhd= _IServiceQLThongKe.LstHoaDons().Where(c => c.TrangThaiHd == 1 && c.thoigian.Day == dateTimePicker1.Value.Day && c.thoigian.Month == dateTimePicker1.Value.Month && c.thoigian.Year == dateTimePicker1.Value.Year)
               .Select(c => c.MaHd).Count().ToString();
           var x = 0;
           var sumDT=0;
           for (int i = 0; i < grid_Data.Rows.Count; i++)
           {
               x += Convert.ToInt32(grid_Data.Rows[i].Cells[0].Value);
           }

           sumDT = x;
        }
    }
}
