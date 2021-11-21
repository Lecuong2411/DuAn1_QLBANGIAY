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
            dtgview_hoadon.ColumnCount = 5;
            dtgview_hoadon.Columns[0].HeaderText = "Sản phẩm";
            dtgview_hoadon.Columns[1].HeaderText = "Số lượng";
            dtgview_hoadon.Columns[2].HeaderText = "Đơn giá";
            dtgview_hoadon.Columns[3].HeaderText = "Giảm giá";
            dtgview_hoadon.Columns[4].HeaderText = "Thành tiền";
            DataGridViewComboBoxColumn dtgvcmm = new DataGridViewComboBoxColumn();
            dtgvcmm.Name = "cmm";
            dtgvcmm.HeaderText = "Chức năng";
            dtgvcmm.Items.Add("Sửa");
            dtgvcmm.Items.Add("xóa");
            int indexcmm = 5;
            if (dtgview_hoadon.Columns["cmm"] == null)
            {
                dtgview_hoadon.Columns.Insert(indexcmm, dtgvcmm);
            }
            DataGridViewButtonColumn dtgvbt = new DataGridViewButtonColumn();
            dtgvbt.Name = "bt";
            dtgvbt.HeaderText = "Xác nhận";
            dtgvbt.Text = "Xác nhận";
            dtgvbt.UseColumnTextForButtonValue = true;
            int index = 6;
            if (dtgview_hoadon.Columns["bt"] == null)
            {
                dtgview_hoadon.Columns.Insert(index, dtgvbt);
            }
            dtgview_hoadon.Rows.Clear();
            foreach (var x in _banhangService.viewHoadons().Where(c=>c.hoaDon.MaHd==mahd))
            {
                dtgview_hoadon.Rows.Add(x.sanPham.TenSp + " " + x.chiTietSanPham.size, x.chiTietSanPham.soluong, x.hoaDonChiTiet.DonGia, "chưa có", x.hoaDon.ThanhTien);
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

        private void dtgview_thongtinsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (bn_hoadon1.Visible==false)
            {
                MessageBox.Show("Đã tạo hóa đơn đéo đâu");
                return;
            }
            int RowIndex = e.RowIndex;
            if (RowIndex == _banhangService.SanphambanViews().Count || RowIndex == -1) return;
            hoaDonChiTiet.MaHd = bn_hoadon1.Text;
            var barcode = dtgview_hoadon.Rows[RowIndex].Cells[0].Value.ToString();
            var ctsp = _banhangService.SanphambanViews().Where(c => c.chiTietSanPham.MaQR == barcode).Select(c => c.chiTietSanPham.MaCTSP).FirstOrDefault();
            hoaDonChiTiet.MaCTSP = ctsp;
            hoaDonChiTiet.TrangThai = 1;
            hoaDonChiTiet.soluong = 1;
            _banhangService.addHoadonchitiet(hoaDonChiTiet);










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
           
            khachHang.MaKh = "KH0"+_banhangService.loadkh().Count() + 12;
            khachHang.TenKh = tbx_tenkh.Text;
            khachHang.Sdt = tbx_sdtkh.Text;
            hoaDon.MaHd = "HD"+_banhangService.loadhd().Count() + 12;
            hoaDon.MaNV = "NV01";
            hoaDon.MaKH = khachHang.MaKh;
            hoaDon.thoigian = DateTime.Now;
            hoaDon.TrangThaiHd = 0;
            bn_hoadon1.Visible = true; 
            bn_hoadon1.Text = hoaDon.MaHd;
            MessageBox.Show(_banhangService.addhoadon(hoaDon,khachHang), "Thông báo");
            loadHoadon(bn_hoadon1.Text);
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
        }

        private void bn_hoadon1_Click(object sender, EventArgs e)
        {

            loadHoadon(bn_hoadon1.Text);
        }
    }
}
