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
            loadHoadon();


        }


        private void Frm_banhang_Load(object sender, EventArgs e)
        {
          
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo x in filterInfoCollection)
            {
                cbx_camera.Items.Add(x.Name);
                cbx_camera.SelectedIndex = 0;
            }
        }


        void loadHoadon()
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

            int Rowindex = e.RowIndex;
            if (Rowindex == _banhangService.SanphambanViews().Count || Rowindex == -1) return;

            var ok = _banhangService.loadnv().FirstOrDefault(c => c.MaNv == "NV01");


            khachHang.TenKh = "OK";
            khachHang.Sdt = "Không có";
            khachHang.MaKh = "KH06";
            hoaDon.MaHd = "hd06";
            hoaDon.MaKH = khachHang.MaKh;
            hoaDon.MaNV = "NV01";
            hoaDon.TrangThaiHd = 0;
            hoaDon.thoigian = DateTime.Now;
            hoaDon.MaVouCher = "VC01";
         
            hoaDonChiTiet.MaHd = hoaDon.MaHd;
            hoaDonChiTiet.MaCTSP= _banhangService.SanphambanViews().Where(c => c.sanPham.TenSp == dtgview_thongtinsp.Rows[Rowindex].Cells[1].Value.ToString()).Select(c => c.sanPham.MaSp).FirstOrDefault();
            var masp = _banhangService.SanphambanViews().Where(c => c.sanPham.TenSp == dtgview_thongtinsp.Rows[Rowindex].Cells[1].Value.ToString()).Select(c => c.sanPham.MaSp).FirstOrDefault();
            hoaDonChiTiet.DonGia = _banhangService.SanphambanViews().Where(c => c.chiTietSanPham.MaSP == masp).Select(c => c.chiTietSanPham.giaban).FirstOrDefault();
            hoaDonChiTiet.TrangThai = 1;
            hoaDonChiTiet.soluong = 2;
          
            hoaDon.ThanhTien = (hoaDonChiTiet.DonGia * hoaDonChiTiet.soluong);
            hoaDon.TienNhan = 400000;
            hoaDon.GhiChu = "OK";
            hoaDonChiTiet.hoaDon = hoaDon;
            var spct = _banhangService.loadspct().FirstOrDefault(c => c.MaCTSP == hoaDonChiTiet.MaCTSP);
            hoaDonChiTiet.chiTietSanPham = spct;//
            hoaDon.khachHang = khachHang;
            var nv = _banhangService.loadnv().FirstOrDefault(c => c.MaNv == hoaDon.MaNV);
            hoaDon.nhanVien = nhanVien;//
            hoaDon.khachHang = khachHang;
            
            hoaDon.voucher = voucher;//
             
            MessageBox.Show(_banhangService.addhoadon(hoaDonChiTiet, hoaDon, khachHang), "Thông báo");
            var tensp = dtgview_thongtinsp.Rows[Rowindex].Cells[1].Value.ToString()+ " SIZE : "+ dtgview_thongtinsp.Rows[Rowindex].Cells[3].Value.ToString();
            var soluong= 1;
         
            var chitietsp = _banhangService.SanphambanViews().Where(c => c.chiTietSanPham.MaSP == masp).Select(c => c.chiTietSanPham.giaban).FirstOrDefault();
            var dongia = chitietsp;
            var thanhtien = dongia * soluong;

            dtgview_hoadon.Rows.Add(tensp,soluong,chitietsp,0,thanhtien);

        }

        private void btn_taohoadon_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            HoaDonChiTiet hoaDonChiTiet = new HoaDonChiTiet();
            hoaDon.MaHd = "HD" + _banhangService.addHoadons().Count+2;
            NhanVien nhanVien = new NhanVien();
          
            //    hoaDon.ThanhTien=
          
        }

    
    }
}
