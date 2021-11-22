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
            bn_hoadon1.Visible = false;
            bn_hoadon2.Visible = false;
            bn_hoadon3.Visible = false;
            bn_hoadon4.Visible = false;
            bn_hoadon5.Visible = false;
            bn_hoadon6.Visible = false;
            bn_hoadon7.Visible = false;
            bn_hoadon8.Visible = false;
            bn_hoadon9.Visible = false;
            bn_hoadon10.Visible = false;
            bn_hoadon11.Visible = false;
            bn_hoadon12.Visible = false;
            bn_hoadon13.Visible = false;
            bn_hoadon14.Visible = false;
            bn_hoadon15.Visible = false;
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
            DataGridViewButtonColumn dtupdate = new DataGridViewButtonColumn();
            dtupdate.Name = "dt_btn_update";
            dtupdate.Text = "Update";
            dtupdate.HeaderText = "";
            dtupdate.UseColumnTextForButtonValue = true;
            int indexupdate = 6;
            if (dtgview_hoadon.Columns["dt_btn_update"] == null)
            {
                dtgview_hoadon.Columns.Insert(indexupdate, dtupdate);
            }
            DataGridViewButtonColumn dtdelete = new DataGridViewButtonColumn();
            dtdelete.Name = "dt_btn_delete";
            dtdelete.HeaderText = "";
            dtdelete.Text = "Remove";
            dtdelete.UseColumnTextForButtonValue = true;
            int indexdelete = 7;
            if (dtgview_hoadon.Columns["dt_btn_delete"] == null)
            {
                dtgview_hoadon.Columns.Insert(indexdelete, dtdelete);
            }
            dtgview_hoadon.Rows.Clear();
            foreach (var x in _banhangService.viewHoadons().Where(c=>c.hoaDon.MaHd==mahd))
            {
                dtgview_hoadon.Rows.Add(x.sanPham.TenSp + " " + x.chiTietSanPham.size, x.hoaDonChiTiet.soluong, x.hoaDonChiTiet.DonGia, "chưa có", x.hoaDonChiTiet.Thanhtien,x.chiTietSanPham.MaQR);
            }
        }

        void loadSpbanhang()
        {
            dtgview_thongtinsp.ColumnCount = 9;
            dtgview_thongtinsp.Columns[0].HeaderText = "Mã";
            dtgview_thongtinsp.Columns[1].HeaderText = "Tên giày";
            dtgview_thongtinsp.Columns[2].HeaderText = "Thương hiệu";
            dtgview_thongtinsp.Columns[3].HeaderText = "Size";
            dtgview_thongtinsp.Columns[4].HeaderText = "Màu sắc";
            dtgview_thongtinsp.Columns[5].HeaderText = "Chất liệu";
            dtgview_thongtinsp.Columns[6].HeaderText = "Loại cổ giày";
            dtgview_thongtinsp.Columns[7].HeaderText = "Số lượng";
            dtgview_thongtinsp.Columns[8].HeaderText = "Đường dẫn img";
            dtgview_thongtinsp.Rows.Clear();
            foreach (var x in _banhangService.SanphambanViews())
            {
               dtgview_thongtinsp.Rows.Add(x.chiTietSanPham.MaQR, x.sanPham.TenSp, x.sanPham.ThuongHieu, x.size.SizeSp, x.color.ColorSP, x.ChatLieu.ChatLieuSP, x.loaiCoGiay.LoaiCoGiaySP, x.chiTietSanPham.soluong, x.image.Images);
            }
        }

        private void btn_barcode_Click(object sender, EventArgs e)
        {
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
                  foreach (var x in _banhangService.SanphambanViews())
                  {
                      if (x.chiTietSanPham.MaQR == result.ToString())
                      {
                          MessageBox.Show("Thành công");
                          dtgview_hoadon.Rows.Add(x.sanPham.TenSp, x.chiTietSanPham.soluong);
                      }
                  }
                  

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
        int sl= 1;
        private void dtgview_thongtinsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (bn_hoadon1.Visible==false)
            {
                MessageBox.Show("Đã tạo hóa đơn đéo đâu");
                return;
            }
            int RowIndex = e.RowIndex;
            if (RowIndex == _banhangService.SanphambanViews().Count || RowIndex == -1) return;
            var barcode = dtgview_thongtinsp.Rows[RowIndex].Cells[0].Value.ToString();
            var ctsp = _banhangService.SanphambanViews().Where(c => c.chiTietSanPham.MaQR == barcode).Select(c => c.chiTietSanPham.MaCTSP).FirstOrDefault();
            var giaban = _banhangService.SanphambanViews().Where(c => c.chiTietSanPham.MaQR == barcode).Select(c => c.chiTietSanPham.giaban).FirstOrDefault();
            hoaDonChiTiet.MaHd = bn_hoadon1.Text;
            hoaDonChiTiet.MaCTSP = ctsp;
            hoaDonChiTiet.TrangThai = 1;
            hoaDonChiTiet.soluong = sl;
            hoaDonChiTiet.DonGia = giaban;
            hoaDonChiTiet.Thanhtien = giaban * hoaDonChiTiet.soluong;  
            _banhangService.addHoadonchitiet(hoaDonChiTiet);
             tongtien();
             loadHoadon(bn_hoadon1.Text);

        }

      
        private void btn_taohoadon_Click(object sender, EventArgs e)
        {
   
        }

        //int hoadont = 45;
        //int so=1;
        private void btn_themhoadon_Click(object sender, EventArgs e)
        {
            //Button button = new Button();
            //this.panel1.Controls.Add(button);

            //button.Text = Convert.ToString(so);
            //button.Name = Convert.ToString(so);
            //button.Width = 100;
            //button.Height = 50;
            //button.Location = new Point(0, hoadont);
            //hoadont += 50;
            //so += 1;
            //loadHoadon();
            khachHang.MaKh = "KH"+_banhangService.loadkh().Count() + 10;
            khachHang.TenKh = tbx_tenkh.Text;
            khachHang.Sdt = tbx_sdtkh.Text;
            hoaDon.MaHd = "HD"+_banhangService.loadhd().Count() + 10;
            hoaDon.MaNV = "NV01";
            hoaDon.MaKH = khachHang.MaKh;
            hoaDon.thoigian = DateTime.Now;
            hoaDon.TrangThaiHd = 0;
            bn_hoadon1.Visible = true; 
            bn_hoadon1.Text = hoaDon.MaHd;
            tbx_date.Text = (hoaDon.thoigian).ToString();
            MessageBox.Show(_banhangService.addhoadon(hoaDon,khachHang), "Thông báo");
            loadHoadon(bn_hoadon1.Text);
            label10.Text = hoaDon.MaHd;
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbx_tienthua.Text)<0||tbx_tienthua.Text=="")
            {
                MessageBox.Show("yêu cầu trả đủ tiền");
                return;
            }
            bn_hoadon1.Visible = false;
            dtgview_hoadon.Rows.Clear();
            hoaDon.TrangThaiHd = 1;
            _banhangService.updatehoadon(hoaDon);
            tbx_date.Text = null;
            tbx_tongtien.Text = null;
            tbx_khachtra.Text = null;
            tbx_tienthua.Text = null;
            
        }

        private void bn_hoadon1_Click(object sender, EventArgs e)
        {

            loadHoadon(bn_hoadon1.Text);
        }
        private void tongtien()
        {
            var tongtien = _banhangService.viewHoadons().Where(c=>c.hoaDon.MaHd==bn_hoadon1.Text).Sum(c => c.hoaDonChiTiet.Thanhtien);
            hoaDon.Tongtien = tongtien;
            _banhangService.updatehoadon(hoaDon);
            tbx_tongtien.Text = (hoaDon.Tongtien).ToString();
        }


        private void dtgview_hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var column = e.ColumnIndex;
            var Row = e.RowIndex;
            string mahd =bn_hoadon1.Text;
            string qr =dtgview_hoadon.Rows[Row].Cells[5].Value.ToString();
            var mactsp = _banhangService.viewHoadons().Where(c => c.chiTietSanPham.MaQR == qr).Select(c => c.chiTietSanPham.MaCTSP).FirstOrDefault();
            if (column == dtgview_hoadon.Columns["dt_btn_delete"].Index)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Thông báo",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    _banhangService.deletedhoadonchitiet(mahd, mactsp);
                    loadHoadon(bn_hoadon1.Text);
                }
            }
            if (column == dtgview_hoadon.Columns["dt_btn_update"].Index)
            {

                if ((MessageBox.Show("Bạn có chắc muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    var hang = _banhangService.viewHoadons().FirstOrDefault(c => c.hoaDonChiTiet.MaHd == bn_hoadon1.Text);
                    hang.hoaDonChiTiet.soluong = int.Parse(dtgview_hoadon.Rows[Row].Cells["tbx_soluong"].Value.ToString());
                    hang.hoaDonChiTiet.Thanhtien = hang.hoaDonChiTiet.soluong * hang.hoaDonChiTiet.DonGia;
                    _banhangService.updatehoadonchitiet(hang.hoaDonChiTiet);
                    tongtien();
                    loadHoadon(bn_hoadon1.Text);
                }
            }

        }

        private void tbx_khachtra_TextChanged(object sender, EventArgs e)
        {
            if (tbx_khachtra.Text == ""|| tbx_tongtien.Text=="") return;
            tbx_tienthua.Text = (Convert.ToInt32(tbx_khachtra.Text) - Convert.ToInt32(tbx_tongtien.Text)).ToString();
        }

     
    }
}
