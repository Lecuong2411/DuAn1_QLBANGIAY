﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS_BusinessLayer.IService;
using _2_BUS_BusinessLayer.Service;
using AForge.Video.DirectShow;
using ZXing;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.Models;
using Microsoft.VisualBasic;



namespace _3_GUI_PresentationLayer
{
    public partial class Frm_banhang : Form
    {
        private IBanhangService _banhangService;
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCaptureDevice;
        KhachHang khachHang;
        HoaDon hoaDon;
        ChiTietSanPham chiTietSanPham;
        HoaDonChiTiet hoaDonChiTiet;
        NhanVien nhanVien;
        Voucher voucher;
        private IQlSanPhamService _qlSanPhamService;

        public Frm_banhang()
        {
            InitializeComponent();
            _banhangService = new BanhangService();
            khachHang = new KhachHang();
            hoaDon = new HoaDon();
            hoaDonChiTiet = new HoaDonChiTiet();
            chiTietSanPham = new ChiTietSanPham();
            nhanVien = new NhanVien();
            voucher = new Voucher();
            _qlSanPhamService = new QlSanPhamService();
            loadSpbanhang();


        }


        private void Frm_banhang_Load(object sender, EventArgs e)
        {


            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo x in filterInfoCollection)
            {
                cbx_camera.Items.Add(x.Name);
                cbx_camera.SelectedIndex = 0;
            }


            btn_thanhtoan.Enabled = false;

        }


        void loadHoadon(string mahd)
        {
            dtgview_hoadon.ColumnCount = 6;
            dtgview_hoadon.Columns[0].HeaderText = "Sản phẩm";
            dtgview_hoadon.Columns[1].HeaderText = "Số lượng";
            dtgview_hoadon.Columns[1].Name = "tbx_soluong";
            dtgview_hoadon.Columns[2].HeaderText = "Đơn giá";
            dtgview_hoadon.Columns[3].HeaderText = "Giảm giá";
            dtgview_hoadon.Columns[4].HeaderText = "Thành tiền";
            dtgview_hoadon.Columns[5].HeaderText = "Barcaode";
            dtgview_hoadon.Columns[5].Visible = false;
            DataGridViewButtonColumn dtdelete = new DataGridViewButtonColumn();
            dtdelete.Name = "dt_btn_delete";
            dtdelete.HeaderText = "";
            dtdelete.Text = "remove";

            dtdelete.UseColumnTextForButtonValue = true;
            int indexdelete = 6;
            if (dtgview_hoadon.Columns["dt_btn_delete"] == null)
            {
                dtgview_hoadon.Columns.Insert(indexdelete, dtdelete);
            }
            dtgview_hoadon.Rows.Clear();
            foreach (var x in _banhangService.viewHoadons().Where(c => c.hoaDon.MaHd == mahd))
            {
                dtgview_hoadon.Rows.Add(x.sanPham.TenSp + " " + x.chiTietSanPham.size, x.hoaDonChiTiet.soluong, x.hoaDonChiTiet.DonGia, "chưa có", x.hoaDonChiTiet.Thanhtien, x.chiTietSanPham.MaQR);
            }
        }

        void loadSpbanhang()
        {
            dtgview_thongtinsp.ColumnCount = 8;
            dtgview_thongtinsp.Columns[0].HeaderText = "Mã";
            dtgview_thongtinsp.Columns[1].HeaderText = "Tên giày";
            dtgview_thongtinsp.Columns[2].HeaderText = "Thương hiệu";
            dtgview_thongtinsp.Columns[3].HeaderText = "Size";
            dtgview_thongtinsp.Columns[4].HeaderText = "Màu sắc";
            dtgview_thongtinsp.Columns[5].HeaderText = "Chất liệu";
            dtgview_thongtinsp.Columns[6].HeaderText = "Loại cổ giày";
            dtgview_thongtinsp.Columns[7].HeaderText = "Số lượng";

            dtgview_thongtinsp.Rows.Clear();
            foreach (var x in _banhangService.SanphambanViews())
            {
                dtgview_thongtinsp.Rows.Add(x.chiTietSanPham.MaQR, x.sanPham.TenSp, x.sanPham.ThuongHieu, x.size.SizeSp, x.color.ColorSP, x.ChatLieu.ChatLieuSP, x.loaiCoGiay.LoaiCoGiaySP, x.chiTietSanPham.soluong);
            }
        }
        void loadSpbanhang(string tk)
        {
            dtgview_thongtinsp.ColumnCount = 8;
            dtgview_thongtinsp.Columns[0].HeaderText = "Mã";
            dtgview_thongtinsp.Columns[1].HeaderText = "Tên giày";
            dtgview_thongtinsp.Columns[2].HeaderText = "Thương hiệu";
            dtgview_thongtinsp.Columns[3].HeaderText = "Size";
            dtgview_thongtinsp.Columns[4].HeaderText = "Màu sắc";
            dtgview_thongtinsp.Columns[5].HeaderText = "Chất liệu";
            dtgview_thongtinsp.Columns[6].HeaderText = "Loại cổ giày";
            dtgview_thongtinsp.Columns[7].HeaderText = "Số lượng";

            dtgview_thongtinsp.Rows.Clear();
            foreach (var x in _qlSanPhamService.GetSPAll().Where(c => c.SanPham.TenSp.ToLower().StartsWith(tk)).ToList())
            {
                dtgview_thongtinsp.Rows.Add(x.ChiTietSanPham.MaQR, x.SanPham.TenSp, x.SanPham.ThuongHieu, x.Size.SizeSp, x.Color.ColorSP, x.ChatLieu.ChatLieuSP, x.LoaiCoGiay.LoaiCoGiaySP, x.ChiTietSanPham.soluong);
            }
        }

        private void btn_barcode_Click(object sender, EventArgs e)
        {
            if (pnl_newhoadon.Controls.Count == 0)
            {
                MessageBox.Show("Bạn phải tạo hóa đơn", "Thông báo");
                return;
            }
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbx_camera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader barcodeReader = new BarcodeReader();
            var result = barcodeReader.Decode(bitmap);
            if (result != null)
            {
                tbx_barcode.Invoke(new MethodInvoker(delegate ()
              {

                  tbx_barcode.Text = result.ToString();
                  var ctsp = _qlSanPhamService.GetSPAll().Where(c => c.ChiTietSanPham.MaQR == tbx_barcode.Text).Select(c => c.ChiTietSanPham.MaCTSP).FirstOrDefault();
                  var hdct = _banhangService.loadhdct().Where(c => c.MaHd == lbl_mahd.Text).Select(c => c.MaCTSP).FirstOrDefault();
                  if (hdct == ctsp) return;
                  var giaban = _qlSanPhamService.GetSPAll().Where(c => c.ChiTietSanPham.MaQR == tbx_barcode.Text).Select(c => c.ChiTietSanPham.giaban).FirstOrDefault();
                  hoaDonChiTiet.MaHd = lbl_mahd.Text;
                  hoaDonChiTiet.MaCTSP = ctsp;
                  hoaDonChiTiet.TrangThai = 1;
                  hoaDonChiTiet.soluong = Frm_soluong.soluong;
                  hoaDonChiTiet.DonGia = giaban;
                  hoaDonChiTiet.Thanhtien = giaban * hoaDonChiTiet.soluong;
                  _banhangService.addHoadonchitiet(hoaDonChiTiet);
                  tongtien();
                  loadHoadon(lbl_mahd.Text);
              }));
            }

            ptbox_barcode.Image = bitmap;

        }

        private void Frm_banhang_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                }
            }

        }

        private void dtgview_thongtinsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (pnl_newhoadon.Controls.Count == 0)
            {
                MessageBox.Show("Bạn phải tạo hóa đơn", "Thông báo");
                return;
            }


            int RowIndex = e.RowIndex;
            if (RowIndex == _qlSanPhamService.GetSPAll().Count || RowIndex == -1) return;

            var barcode = dtgview_thongtinsp.Rows[RowIndex].Cells[0].Value.ToString();
            var ctsp = _qlSanPhamService.GetSPAll().Where(c => c.ChiTietSanPham.MaQR == barcode).Select(c => c.ChiTietSanPham.MaCTSP).FirstOrDefault();
            var giaban = _qlSanPhamService.GetSPAll().Where(c => c.ChiTietSanPham.MaQR == barcode).Select(c => c.ChiTietSanPham.giaban).FirstOrDefault();
            var sl = _qlSanPhamService.GetSPAll().Where(c => c.ChiTietSanPham.MaQR == barcode).Select(c => c.ChiTietSanPham.soluong).FirstOrDefault();
            if (sl <= 0)
            {
                MessageBox.Show("Sản phẩm đã hết", "Thông báo");
                return;
            }
            var updatects = _banhangService.loadspct().FirstOrDefault(c => c.MaCTSP == ctsp);
            hoaDonChiTiet.MaHd = lbl_mahd.Text;
            hoaDonChiTiet.MaCTSP = ctsp;
            hoaDonChiTiet.TrangThai = 1;
            hoaDonChiTiet.soluong = Frm_soluong.soluong;
            hoaDonChiTiet.DonGia = giaban;
            hoaDonChiTiet.Thanhtien = giaban * hoaDonChiTiet.soluong;
            updatects.soluong = sl - Frm_soluong.soluong;
            _banhangService.addHoadonchitiet(hoaDonChiTiet);
            _banhangService.updatectsp(updatects);
            tongtien();
            loadHoadon(lbl_mahd.Text);
            loadSpbanhang();

        }


        int hoadont = 0;
        int so = 1;
        Button button;
        private void btn_themhoadon_Click(object sender, EventArgs e)
        {
            button = new Button();
            button.Text = "HD" + _banhangService.loadhd().Count() + 10;
            this.pnl_newhoadon.Controls.Add(button);
            button.Width = 120;
            button.Height = 50;
            button.ForeColor = System.Drawing.Color.White;
            button.Dock = DockStyle.Top;
            button.Location = new Point(0, hoadont);
            hoadont += 50;
            so += 1;
            button.Click += new EventHandler(this.buttun_click);
            khachHang.MaKh = "KH" + _banhangService.loadkh().Count() + 10;
            khachHang.TenKh = tbx_tenkh.Text;
            khachHang.Sdt = tbx_sdtkh.Text;
            hoaDon.MaHd = "HD" + _banhangService.loadhd().Count() + 10;
            hoaDon.MaNV = "NV01";
            hoaDon.MaKH = khachHang.MaKh;
            hoaDon.thoigian = DateTime.Now;
            hoaDon.TrangThaiHd = 0;
            tbx_date.Text = (hoaDon.thoigian).ToString();
            MessageBox.Show(_banhangService.addhoadon(hoaDon, khachHang), "Thông báo");
            lbl_mahd.Text = hoaDon.MaHd;
            loadHoadon(lbl_mahd.Text);
        }

        void buttun_click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            loadHoadon(button.Text);
            lbl_mahd.Text = button.Text;
            tbx_magiamgia.Text = null;
            tongtien();
        }



        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(tbx_tienthua.Text) < 0) return;
            dtgview_hoadon.Rows.Clear();
            hoaDon.TrangThaiHd = 1;
            hoaDon.GhiChu = tbx_ghichu.Text;
            _banhangService.updatehoadon(hoaDon);
            tbx_date.Text = null;
            tbx_tongtien.Text = null;
            tbx_khachtra.Text = null;
            tbx_tienthua.Text = null;
            tbx_ghichu.Text = null;
            tbx_magiamgia.Text = null;
            tbx_giamgia.Text = null;
            tbx_tenkh.Text = null;
            tbx_sdtkh.Text = null;




        }

        private void tongtien()
        {
            var hd = _banhangService.loadhd().FirstOrDefault(c => c.MaHd == lbl_mahd.Text);
            var tongtien = _banhangService.viewHoadons().Where(c => c.hoaDon.MaHd == lbl_mahd.Text).Sum(c => c.hoaDonChiTiet.Thanhtien);
            var menhgia = _banhangService.loadVoucher().Where(c => c.Vouchers == tbx_magiamgia.Text).Select(c => c.MenhGia).FirstOrDefault();
            hd.Tongtien = tongtien - menhgia;
            _banhangService.updatehoadon(hd);
            tbx_tongtien.Text = (hd.Tongtien).ToString();
            tbx_giamgia.Text = (menhgia).ToString();
        }


        private void dtgview_hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var column = e.ColumnIndex;
            var Row = e.RowIndex;
            if (Row == _banhangService.viewHoadons().Count || Row == -1) return;
            
            string mahd = lbl_mahd.Text;
            string qr = dtgview_hoadon.Rows[Row].Cells[5].Value.ToString();
            string soluong = dtgview_hoadon.Rows[Row].Cells[1].Value.ToString();
            var mactsp = _banhangService.viewHoadons().Where(c => c.chiTietSanPham.MaQR == qr).Select(c => c.chiTietSanPham.MaCTSP).FirstOrDefault();
            // var soluong = _banhangService.viewHoadons().Where(c => c.hoaDonChiTiet.MaHd == mahd && c.hoaDonChiTiet.MaCTSP == mactsp).Select(c => c.hoaDonChiTiet.soluong).FirstOrDefault();
            var soluongctsp = _banhangService.loadspct().FirstOrDefault(c => c.MaCTSP == mactsp);
            if (column == dtgview_hoadon.Columns["dt_btn_delete"].Index)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    soluongctsp.soluong = soluongctsp.soluong + int.Parse(soluong);
                    _banhangService.deletedhoadonchitiet(mahd, mactsp);
                    loadHoadon(lbl_mahd.Text);
                    loadSpbanhang();
                    tongtien();
                }
            }

        }

        private void tbx_khachtra_TextChanged(object sender, EventArgs e)
        {
            if (tbx_khachtra.Text == "" || tbx_tongtien.Text == "")
            {
                btn_thanhtoan.Enabled = false;
                return;
            }
            else
            {
                btn_thanhtoan.Enabled = true;
            }
            var hd = _banhangService.loadhd().FirstOrDefault(c => c.MaHd == lbl_mahd.Text);
            tbx_tienthua.Text = (Convert.ToDouble(tbx_khachtra.Text) - Convert.ToDouble(tbx_tongtien.Text)).ToString();
            hd.TienNhan = Convert.ToDouble(tbx_khachtra.Text);
            _banhangService.updatehoadon(hd);

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Hóa đơn " + lbl_mahd.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(185, 10));
            e.Graphics.DrawString("sale receipt", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(240, 40));
            e.Graphics.DrawString("____________________________________________________________________________________________________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(540, 40));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void btn_timgiamgia_Click(object sender, EventArgs e)
        {
            if (pnl_newhoadon.Controls.Count == 0)
            {
                MessageBox.Show("Bạn phải tạo hóa đơn", "Thông báo");
                return;
            }
            var mavoucher = _banhangService.loadVoucher().Where(c => c.Vouchers == tbx_magiamgia.Text).Select(c => c.MaVouCher).FirstOrDefault();
            var menhgia = _banhangService.loadVoucher().Where(c => c.Vouchers == tbx_magiamgia.Text).Select(c => c.MenhGia).FirstOrDefault();
            var hd = _banhangService.loadhd().FirstOrDefault(c => c.MaHd == lbl_mahd.Text);
            hd.MaVouCher = mavoucher;
            var vouchersoluong = _banhangService.loadVoucher().Where(c => c.MaVouCher == mavoucher).Select(c => c.SoLuong).FirstOrDefault();
            var voucher = _banhangService.loadVoucher().FirstOrDefault(C => C.MaVouCher == mavoucher);
            if (vouchersoluong == 0 || mavoucher == null)
            {
                MessageBox.Show("Mã voucher đã hết hoặc không tồn tại", "Thông báo");
                return;
            }
            foreach (var x in _banhangService.loadVoucher().Where(c => c.MaVouCher == mavoucher))
            {
                if (x.NSD > DateTime.Now || x.HSD < DateTime.Now || x.TrangThai == 0)
                {
                    MessageBox.Show("Mã hóa đơn chưa hoạt động hoặc đã hết hạn");
                    return;
                }
            }
            vouchersoluong -= 1;
            voucher.SoLuong = vouchersoluong;
            _banhangService.updatehoadon(hd);
            _banhangService.updatevoucher(voucher);
            tongtien();

        }

        private void dtgview_hoadon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var column = e.ColumnIndex;
            var Row = e.RowIndex;
            if (Row == _banhangService.viewHoadons().Count || Row == -1) return;
            var barcode = dtgview_hoadon.Rows[Row].Cells[5].Value.ToString();
            var hoadonct = _banhangService.loadhdct().FirstOrDefault(c => c.MaHd == lbl_mahd.Text);
            var ctsp = _banhangService.loadspct().FirstOrDefault(c=>c.MaQR== barcode);
            hoadonct.soluong = Convert.ToInt32(dtgview_hoadon.Rows[Row].Cells[1].Value.ToString());
            ctsp.soluong -= Convert.ToInt32(dtgview_hoadon.Rows[Row].Cells[1].Value.ToString());
            hoadonct.Thanhtien = hoadonct.soluong * hoadonct.DonGia;
            _banhangService.updatehoadonchitiet(hoadonct);
            _banhangService.updatectsp(ctsp);
            loadHoadon(lbl_mahd.Text);
            tongtien();
            loadSpbanhang();



        }

        private void tbx_timkiem_TextChanged(object sender, EventArgs e)
        {
            loadSpbanhang(tbx_timkiem.Text);
        }

    
    }
}
