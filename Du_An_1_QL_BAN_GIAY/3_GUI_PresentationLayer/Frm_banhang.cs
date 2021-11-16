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


namespace _3_GUI_PresentationLayer
{
    public partial class Frm_banhang : Form
    {
        private IBanhangService _banhangService;
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCaptureDevice;
        public Frm_banhang()
        {
            InitializeComponent();
            _banhangService = new BanhangService();
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
              //  dtgview_thongtinsp.Rows.Add(x.chiTietSanPham.MaQr, x.sanPham.TenSp, x.sanPham.ThuongHieu, x.size.Size1, x.color.Color1, x.ChatLieu.ChatLieu1, x.loaiCoGiay.LoaiCoGiay1, x.chiTietSanPham.SoLuong, x.image.Images);
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
                      //if (x.chiTietSanPham.MaQr==result.ToString())
                      //{
                      //    dtgview_hoadon.Rows.Add(x.sanPham.TenSp, x.chiTietSanPham.SoLuong);
                      //}
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
         

        }
    }
}
