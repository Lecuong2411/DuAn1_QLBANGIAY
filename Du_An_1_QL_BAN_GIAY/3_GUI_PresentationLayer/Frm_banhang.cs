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
using _2_BUS_BusinessLayer.Service;
using AForge.Video.DirectShow;
using ZXing;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.Models;
using Microsoft.VisualBasic;
using System.Threading;
using System.Drawing.Drawing2D;
using _2_BUS_BusinessLayer.Utilities;
using System.Globalization;

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
        Form _f;
        Validateform _Validateform;
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
            _Validateform = new Validateform();
            loadSpbanhang();

            loadhdchuathanhthoan();
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
                string makm = _qlSanPhamService.GetSPAll().Where(c => c.ChiTietGiamGia.MaDanhMuc == x.sanPham.MaDanhMuc).Select(c => c.ChiTietGiamGia.MaKM).FirstOrDefault();
               
                dtgview_hoadon.Rows.Add(x.sanPham.TenSp+" "+x.chiTietSanPham.Mota , x.hoaDonChiTiet.soluong,x.hoaDonChiTiet.DonGia,/*_qlSanPhamService.GetSPAll().Where(c=>c.KhuyenMai.MaKM==makm).Select(c=>c.KhuyenMai.GiamGia).FirstOrDefault()+ */" %", x.hoaDonChiTiet.Thanhtien, x.chiTietSanPham.MaQR);
               
            }
            //if (dtgview_hoadon.Rows[0].Cells[6].Value.ToString() == null)
            //{
            //    dtdelete.Visible = false;
            //    return;
            //}

            //    dtgview_hoadon.Rows[3].Cells[0].ReadOnly = false;
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
            foreach (var x in _qlSanPhamService.GetSPAll())
            {
                dtgview_thongtinsp.Rows.Add(x.ChiTietSanPham.MaQR, x.SanPham.TenSp + " " + x.ChiTietSanPham.Mota, x.SanPham.ThuongHieu, x.Size.SizeSp, x.Color.ColorSP, x.ChatLieu.ChatLieuSP, x.LoaiCoGiay.LoaiCoGiaySP, x.ChiTietSanPham.soluong);
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
                dtgview_thongtinsp.Rows.Add(x.ChiTietSanPham.MaQR, x.SanPham.TenSp + " " + x.ChiTietSanPham.Mota, x.SanPham.ThuongHieu, x.Size.SizeSp, x.Color.ColorSP, x.ChatLieu.ChatLieuSP, x.LoaiCoGiay.LoaiCoGiaySP, x.ChiTietSanPham.soluong);
            }
        }

        private void btn_barcode_Click(object sender, EventArgs e)
        {
            if (lbl_mahoadon.Text =="")
            {
                MessageBox.Show("Bạn chưa có hóa đơn để thêm sản phẩm !", "Thông báo");
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
                  var hdct = _banhangService.loadhdct().Where(c => c.MaHd == lbl_mahoadon.Text).Select(c => c.MaCTSP).FirstOrDefault();
                  var sl = _qlSanPhamService.GetSPAll().Where(c => c.ChiTietSanPham.MaQR == tbx_barcode.Text).Select(c => c.ChiTietSanPham.soluong).FirstOrDefault();
                  var giaban = _qlSanPhamService.GetSPAll().Where(c => c.ChiTietSanPham.MaQR == tbx_barcode.Text).Select(c => c.ChiTietSanPham.giaban).FirstOrDefault();
                  var updatects = _banhangService.loadspct().FirstOrDefault(c => c.MaCTSP == ctsp);
                  if (hdct == ctsp)
                  {
                      MessageBox.Show("Sản phẩm đẫ có trên hóa đơn", "Thông báo");
                      return;
                  }
                  if (sl <= 0)
                  {
                      MessageBox.Show("Sản phẩm đã hết", "Thông báo");
                      return;
                  }

                  hoaDonChiTiet.MaHd = lbl_mahoadon.Text;
                  hoaDonChiTiet.MaCTSP = ctsp;
                  hoaDonChiTiet.TrangThai = 1;
                  hoaDonChiTiet.soluong = Frm_soluong.soluong;
                  hoaDonChiTiet.DonGia = giaban;
                  hoaDonChiTiet.Thanhtien = giaban * hoaDonChiTiet.soluong;
                  updatects.soluong = sl - Frm_soluong.soluong;
                  _banhangService.addHoadonchitiet(hoaDonChiTiet);
                  _banhangService.updatectsp(updatects);
                  tongtien();
                  loadHoadon(lbl_mahoadon.Text);
                  loadSpbanhang();
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
                  
                    videoCaptureDevice.SignalToStop();
                    Thread.Sleep(1000);
                }
            }

        }

        string barcode;
       
        private void dtgview_thongtinsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int colum = e.ColumnIndex;
         
            if (lbl_mahoadon.Text == "")
            {
                MessageBox.Show("Bạn chưa có hóa đơn để thêm sản phẩm !", "Thông báo");
                return;
            }
            int RowIndex = e.RowIndex;
            if (RowIndex == _qlSanPhamService.GetSPAll().Count || RowIndex == -1) return;
             barcode = dtgview_thongtinsp.Rows[RowIndex].Cells[0].Value.ToString();
            if (e.ColumnIndex == dtgview_thongtinsp.Columns[colum].Index)
            {
                
                _f = new Form();
                _f.Text = "Nhập số lượng";
                TextBox textBox = new TextBox();
                textBox.Size = new System.Drawing.Size(284, 39);
                textBox.Location = (new Point(370, 54));
                Button button = new Button();
                Label label = new Label();
                label.Location = (new Point(42, 54));
               
                label.Size= new System.Drawing.Size(264, 32);
                button.Text = "OK";
                button.Size= new System.Drawing.Size(150, 46);
                button.Location= (new Point(100, 200));
                _f.Controls.Add(textBox);
                _f.Controls.Add(button);
                _f.Controls.Add(label);
                _f.Controls[2].Left = 10;
                _f.Controls[2].Top = 13;
                _f.Controls[0].Left = 80;
                _f.Controls[1].Left = 100;
                _f.Controls[0].Top = 10;
                _f.Controls[1].Top = 50;
                _f.Size = new System.Drawing.Size(700, 200);
                _f.StartPosition=FormStartPosition.CenterScreen;
                _f.ControlBox = false;
                button.Click += Button_Click;
                _f.ShowDialog();

            }

           

        }
        int _soluong;
        private void Button_Click(object sender, EventArgs e)
        {


       
            var giaban = _qlSanPhamService.GetSPAll().Where(c => c.ChiTietSanPham.MaQR == barcode).Select(c => c.ChiTietSanPham.giaban).FirstOrDefault();
            var sl = _qlSanPhamService.GetSPAll().Where(c => c.ChiTietSanPham.MaQR == barcode).Select(c => c.ChiTietSanPham.soluong).FirstOrDefault();
            var ctsp = _qlSanPhamService.GetSPAll().Where(c => c.ChiTietSanPham.MaQR == barcode).Select(c => c.ChiTietSanPham.MaCTSP).FirstOrDefault();
            var hdct = _banhangService.viewHoadons().Where(c => c.hoaDonChiTiet.MaHd == lbl_mahoadon.Text && c.chiTietSanPham.MaQR == barcode).Select(c => c.chiTietSanPham.MaCTSP).FirstOrDefault();
            if (sl <= 0)
            {
                MessageBox.Show("Sản phẩm đã hết", "Thông báo");
                return;
            }
            if (_f.Controls[0].Text=="")
            {
                MessageBox.Show("Yêu cầu bạn nhập số lượng");
                return;
            }
            if (Convert.ToInt32(_f.Controls[0].Text)<=0)
            {
                MessageBox.Show("Yêu cầu bạn nhập số lớn hơn 0");
                return;
            }
            if (_Validateform.checkSo(_f.Controls[0].Text))
            {

                MessageBox.Show("Yêu cầu bạn nhập số !");
                return;
            }
            _soluong = Convert.ToInt32(_f.Controls[0].Text);
            var updatects = _banhangService.loadspct().FirstOrDefault(c => c.MaCTSP == ctsp);
            if (hdct == ctsp)
            {
                //var slhdct = _banhangService.loadhdct().FirstOrDefault(c => c.MaHd == lbl_mahoadon.Text && c.MaCTSP == hdct);
                //slhdct.soluong += 1;
                //updatects.soluong -= 1;
                //slhdct.Thanhtien = slhdct.soluong * slhdct.DonGia;
                //_banhangService.updatectsp(updatects);
                //_banhangService.updatehoadonchitiet(slhdct);
                //tongtien();
                //loadHoadon(lbl_mahoadon.Text);
                //loadSpbanhang();
                MessageBox.Show("Bạn đã chọn sản phẩm");
                _f.Close();
                return;
            }
            Button button = sender as Button;


            hoaDonChiTiet.MaHd = lbl_mahoadon.Text;
            hoaDonChiTiet.MaCTSP = ctsp;
            hoaDonChiTiet.TrangThai = 1;
            hoaDonChiTiet.soluong = _soluong;
            hoaDonChiTiet.DonGia = giaban;
            hoaDonChiTiet.Thanhtien = giaban * hoaDonChiTiet.soluong;
            updatects.soluong = sl - _soluong;
            _banhangService.addHoadonchitiet(hoaDonChiTiet);
            _banhangService.updatectsp(updatects);
            tongtien();
            loadHoadon(lbl_mahoadon.Text);
            loadSpbanhang();
            _f.Close();
        }


        int hoadont = 50;
        int so = 1;
        Button button;
        string _Makhachhang;
        private void btn_themhoadon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn tạo hóa đơn ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                _Makhachhang = khachHang.MaKh;
                khachHang.TenKh = tbx_tenkh.Text;
                khachHang.Sdt = tbx_sdtkh.Text;
                hoaDon.MaHd = "HD" + _banhangService.loadhd().Count() + 10;
                hoaDon.MaNV = Frm_Login.name;
                hoaDon.MaKH = khachHang.MaKh;
                hoaDon.thoigian = DateTime.Now;
                hoaDon.TrangThaiHd = 0;
                tbx_date.Text = (hoaDon.thoigian).ToString();
                MessageBox.Show(_banhangService.addhoadon(hoaDon, khachHang), "Thông báo");
                lbl_mahoadon.Text = hoaDon.MaHd;
                loadHoadon(lbl_mahoadon.Text); 
            }
        }
      
        void buttun_click(object sender, EventArgs e)
        {
             
            Button button = sender as Button;
            loadHoadon(button.Text);
            foreach (var x in pnl_newhoadon.Controls)
            {
                button.BackColor = System.Drawing.Color.FromArgb(39, 39, 58);
            }
            lbl_mahoadon.Text = button.Text;
            tbx_magiamgia.Text = null;
            _Makhachhang = _banhangService.viewHoadons().Where(c => c.hoaDon.MaHd == lbl_mahoadon.Text).Select(c => c.hoaDon.MaKH).FirstOrDefault();
            var tenkh = _banhangService.loadkh().Where(c => c.MaKh == _Makhachhang).Select(c => c.TenKh).FirstOrDefault();
            var sdt = _banhangService.loadkh().Where(c => c.MaKh == _Makhachhang).Select(c => c.Sdt).FirstOrDefault();
            var diachi = _banhangService.loadkh().Where(c => c.MaKh == _Makhachhang).Select(c => c.Diachi).FirstOrDefault();
            tbx_tenkh.Text = tenkh;
            tbx_sdtkh.Text = sdt;
            tbx_diachi.Text = diachi;
            tongtien();
           
        }
        void loadhdchuathanhthoan()
        {
            foreach (var x in _banhangService.loadhd().Where(c=>c.TrangThaiHd==0).Select(c=>c.MaHd))
            {
                button = new Button();
                button.Text = x;
                this.pnl_newhoadon.Controls.Add(button);
                button.Width = 120;
                button.Height = 50;
                button.ForeColor = System.Drawing.Color.White;
                button.Dock = DockStyle.Top;
                button.Location = new Point(0, hoadont);
                hoadont += 50;
                so += 1;
                button.Click += new EventHandler(this.buttun_click);
            }
        }

  

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn thanh toán ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Convert.ToDouble(tbx_tienthua.Text) < 0) return;
                dtgview_hoadon.Rows.Clear();
                if (MessageBox.Show("Bạn có muốn in hóa đơn không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();
                }
                var hd = _banhangService.loadhd().FirstOrDefault(c => c.MaHd == lbl_mahoadon.Text);
                hd.TrangThaiHd = 1;
                hd.GhiChu = tbx_ghichu.Text;
                _banhangService.updatehoadon(hd);
                tbx_date.Text = null;
                tbx_tongtien.Text = null;
                tbx_khachtra.Text = null;
                tbx_tienthua.Text = null;
                tbx_ghichu.Text = null;
                tbx_magiamgia.Text = null;
                tbx_giamgia.Text = null;
                tbx_tenkh.Text = null;
                tbx_sdtkh.Text = null;
                lbl_mahoadon.Text = null;
                button.Visible = false;
                using (frm_Processing frm = new frm_Processing(thanhtoan))
                {
                    frm.ShowDialog(this);
                }
                loadhdchuathanhthoan();
               


            }

        }
       
        void thanhtoan()
        {
            for (int i = 0; i < 500; i++)
            {
                Thread.Sleep(10);
            }
        }


        private void tongtien()
        {
            var hd = _banhangService.loadhd().FirstOrDefault(c => c.MaHd == lbl_mahoadon.Text);
            var tongtien = _banhangService.viewHoadons().Where(c => c.hoaDon.MaHd == lbl_mahoadon.Text).Sum(c => c.hoaDonChiTiet.Thanhtien);
            var menhgia = _banhangService.loadVoucher().Where(c => c.Vouchers == tbx_magiamgia.Text).Select(c => c.MenhGia).FirstOrDefault();
            hd.Tongtien = tongtien - menhgia;
            _banhangService.updatehoadon(hd);
            tbx_tongtien.Text = (hd.Tongtien).ToString();
            tbx_giamgia.Text = (menhgia).ToString();
            tbx_tongtien.Text =   String.Format("{0:#,##0.##}", int.Parse(tbx_tongtien.Text)); // 0
            tbx_giamgia.Text =   String.Format("{0:#,##0.##}", int.Parse(tbx_giamgia.Text)); // 0
            tbx_tongtiendathang.Text = tbx_tongtien.Text;
            //String.Format("{0:#,##0.##}", tbx_tongtien.Text); // 0.5 - some of the formats above fail here. 
            //String.Format("{0:#,##0.##}", tbx_tongtien.Text); // 12,314
            //String.Format("{0:#,##0.##}", tbx_tongtien.Text); // 12,314.23
            //String.Format("{0:#,##0.##}", tbx_tongtien.Text); // 12,314.2
            //String.Format("{0:#,##0.##}", tbx_tongtien.Text); // 1,231,412,314.2

       
            //  string.Format(CultureInfo.InvariantCulture, "{0:N0}",int.Parse( tbx_tongtien.Text));
        }


        private void dtgview_hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var column = e.ColumnIndex;
                var Row = e.RowIndex;
                if (Row == _banhangService.viewHoadons().Count || Row == -1) return;
             
                string mahd = lbl_mahoadon.Text;
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
                        _banhangService.updatectsp(soluongctsp);
                        loadHoadon(lbl_mahoadon.Text);
                        loadSpbanhang();
                        tongtien();
                    }
                }
            }
            catch (Exception  )
            {

                return;
            }

        }
    
        private void tbx_khachtra_TextChanged(object sender, EventArgs e)
        {
            if (tbx_khachtra.Text == "" || tbx_tongtien.Text == "")
            {
                btn_thanhtoan.Enabled = false;
                return;
            }
            if (_Validateform.checkSo(tbx_khachtra.Text))
            {
                btn_thanhtoan.Enabled = false;
                return;
            }
            else
            {
                btn_thanhtoan.Enabled = true;
            }

           
            var hd = _banhangService.loadhd().FirstOrDefault(c => c.MaHd == lbl_mahoadon.Text);
            tbx_tienthua.Text = (Convert.ToDouble(tbx_khachtra.Text) - Convert.ToDouble(tbx_tongtien.Text)).ToString();
            tbx_tienthua.Text = String.Format("{0:#,##0.##}", Convert.ToDouble(tbx_tienthua.Text)); // 0
            hd.TienNhan = Convert.ToDouble(tbx_khachtra.Text);
            _banhangService.updatehoadon(hd);

        }
        int xuong = 0;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Hóa đơn", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(400, 10));
            e.Graphics.DrawString("Mã hóa đơn " + lbl_mahoadon.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(100, 40));    
            e.Graphics.DrawString("____________________________________________________________________________________________________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(0, 40));
            e.Graphics.DrawString((DateTime.Now).ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(700, 40));
            e.Graphics.DrawString("Sản phẩm", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(50, 90));
            e.Graphics.DrawString("Đơn giá", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(200, 90));
            e.Graphics.DrawString("Số lượng", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(350, 90));
            e.Graphics.DrawString("Thành tiền", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(500, 90));
            foreach (var x in _banhangService.viewHoadons().Where(c => c.hoaDon.MaHd == lbl_mahoadon.Text))
            {

            
                e.Graphics.DrawString(x.sanPham.TenSp, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(50, xuong+140));
                e.Graphics.DrawString((x.hoaDonChiTiet.DonGia).ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(200, xuong+140));
                e.Graphics.DrawString((x.hoaDonChiTiet.soluong).ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(350, xuong+140));
                e.Graphics.DrawString((x.hoaDonChiTiet.Thanhtien).ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(500, xuong+140));
                xuong += 50;
            }
            e.Graphics.DrawString("Tổng tiền : ", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(400, 140+xuong));
            e.Graphics.DrawString(tbx_tongtien.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(600, 140+xuong));
            e.Graphics.DrawString("Khách trả : ", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(400, 190+xuong));
            e.Graphics.DrawString(tbx_khachtra.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(600, 190+xuong));
            e.Graphics.DrawString("Tiền thừa :", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(400, 240+xuong));
            e.Graphics.DrawString(tbx_tienthua.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(600, 240+xuong));


        }



        private void btn_timgiamgia_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn tìm có phải không ?", "Thông báo",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {

                if (lbl_mahoadon.Text == "")
                {
                    MessageBox.Show("Bạn chưa có hóa đơn để thêm sản phẩm !", "Thông báo");
                    return;
                }
                var mavoucher = _banhangService.loadVoucher().Where(c => c.Vouchers == tbx_magiamgia.Text).Select(c => c.MaVouCher).FirstOrDefault();
                var menhgia = _banhangService.loadVoucher().Where(c => c.Vouchers == tbx_magiamgia.Text).Select(c => c.MenhGia).FirstOrDefault();
                var hd = _banhangService.loadhd().FirstOrDefault(c => c.MaHd == lbl_mahoadon.Text);
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
                        MessageBox.Show("Mã voucher chưa hoạt động hoặc đã hết hạn");
                        return;
                    }
                }
                vouchersoluong -= 1;
                voucher.SoLuong = vouchersoluong;
                _banhangService.updatehoadon(hd);
                _banhangService.updatevoucher(voucher);
                tongtien();

            }
        }
    
        private void dtgview_hoadon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var column = e.ColumnIndex;
            var Row = e.RowIndex;
            if (Row == _banhangService.viewHoadons().Count || Row == -1) return;
            if (_Validateform.checkSo(dtgview_hoadon.Rows[Row].Cells[column].Value.ToString()))
            {
                MessageBox.Show("Bạn phải nhập số để dũ liệu có thể sử lý", "Thông báo");
                return;
            }
            var barcode = dtgview_hoadon.Rows[Row].Cells[5].Value.ToString();
            var ma_ctsp = _banhangService.loadspct().Where(c => c.MaQR == barcode).Select(c => c.MaCTSP).FirstOrDefault();
            var hoadonct = _banhangService.loadhdct().FirstOrDefault(c => c.MaHd == lbl_mahoadon.Text && c.MaCTSP==ma_ctsp);
            var ctsp = _banhangService.loadspct().FirstOrDefault(c=>c.MaQR== barcode);
            hoadonct.soluong = Convert.ToInt32(dtgview_hoadon.Rows[Row].Cells[column].Value.ToString());
            ctsp.soluong -= Convert.ToInt32(dtgview_hoadon.Rows[Row].Cells[column].Value.ToString());
              ctsp.soluong += _soluonghientai;
            hoadonct.Thanhtien = hoadonct.soluong * hoadonct.DonGia;
            _banhangService.updatehoadonchitiet(hoadonct);
            _banhangService.updatectsp(ctsp);
            loadHoadon(lbl_mahoadon.Text);
            tongtien();
            loadSpbanhang();
        }
        private void tbx_timkiem_TextChanged(object sender, EventArgs e)
        {
            loadSpbanhang(tbx_timkiem.Text);
        }

        private void btn_tatbarcode_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {

                    videoCaptureDevice.SignalToStop();
                    Thread.Sleep(1000);
                }
            }
        }

        private void btn_addvoucher_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn tạo voucher ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FrmThongtinVoucher frmThongtinVoucher = new FrmThongtinVoucher();
                frmThongtinVoucher.Show();
                frmThongtinVoucher.StartPosition = FormStartPosition.CenterScreen; 
            }
        }
        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius,
                             Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
            GraphPath.CloseFigure();
            return GraphPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            using (GraphicsPath GraphPath = GetRoundPath(Rect, 50))
            {
                this.Region = new Region(GraphPath);
                using (Pen pen = new Pen(System.Drawing.Color.CadetBlue, 1.75f))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, GraphPath);
                }
            }
        }

        int _soluonghientai;
        private void dtgview_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = e.RowIndex;
            int colum = e.ColumnIndex;
            if (RowIndex == _banhangService.viewHoadons().Count(c=>c.hoaDonChiTiet.MaHd==lbl_mahoadon.Text) || RowIndex == -1) return;
            if (_Validateform.checkSo(dtgview_hoadon.Rows[RowIndex].Cells[1].Value.ToString())) return;
       
           _soluonghientai = int.Parse(dtgview_hoadon.Rows[RowIndex].Cells[1].Value.ToString());
        }

        private void tbx_khachtra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_dathang_Click(object sender, EventArgs e)
        {
            if (_Validateform.checkNull(tbx_tenkh.Text))
            {
                MessageBox.Show("Không được để trống", "Thông báo");
                return;

            } 
            if (_Validateform.checkNull(tbx_sdtkh.Text))
            {
                MessageBox.Show("Không được để trống", "Thông báo");
                return;

            }   if (_Validateform.checkNull(tbx_diachi.Text))
            {
                MessageBox.Show("Không được để trống", "Thông báo");
                return;

            }
            if (_Validateform.checkSDT(tbx_sdtkh.Text))
            {
                MessageBox.Show("yêu cầu nhập số điện thoại đúng", "Thông báo");
                return;
            }
            var kh = _banhangService.loadkh().FirstOrDefault(c => c.MaKh == _Makhachhang);
            var mhd = _banhangService.loadhd().FirstOrDefault(c => c.MaHd == lbl_mahoadon.Text);
            mhd.TienNhan = Convert.ToDouble(tbx_tongtiendathang.Text);
            kh.TenKh =tbx_tenkh.Text;
            kh.Sdt = tbx_sdtkh.Text;
            kh.Diachi = tbx_diachi.Text;

            MessageBox.Show(_banhangService.updatekhachhang(kh), "Thông báo");
            var hd = _banhangService.loadhd().FirstOrDefault(c => c.MaHd == lbl_mahoadon.Text);
            hd.TrangThaiHd = 1;
            hd.GhiChu = tbx_ghichu.Text;
            _banhangService.updatehoadon(hd);
            tbx_date.Text = null;
            tbx_tongtien.Text = null;
            tbx_diachi.Text = null;
            tbx_khachtra.Text = null;
            tbx_tienthua.Text = null;
            tbx_ghichu.Text = null;
            tbx_magiamgia.Text = null;
            tbx_giamgia.Text = null;
            tbx_tenkh.Text = null;
            tbx_sdtkh.Text = null;
            lbl_mahoadon.Text = null;
            button.Visible = false;
            dtgview_hoadon.Rows.Clear();
            tbx_tongtiendathang.Text = null;
        }
    }
}
