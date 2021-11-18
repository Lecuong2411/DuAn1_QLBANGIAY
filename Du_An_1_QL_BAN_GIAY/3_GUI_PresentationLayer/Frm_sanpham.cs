using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IService;
using _2_BUS_BusinessLayer.Models;
using _2_BUS_BusinessLayer.Service;
using AForge.Video;
using AForge.Video.DirectShow;
using BarcodeLib;
using ZXing;
using Color = System.Drawing.Color;
using Image = System.Drawing.Image;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_sanpham : Form
    {
        private IQlSanPhamService _iQlSanPhamService;
        public static string temb;
        public static string _barcode;
        public  string _bcode;
        public Frm_sanpham()
        {
            InitializeComponent();
            _iQlSanPhamService = new QlSanPhamService();
            load();
            loadCogay();
            loadColor();
            loadSize();
            loadtsp();
            loaddanhMuc();
            trangThai();
            loadChatLieu();
        }

        private FilterInfoCollection _filterInfoCollection;
        private VideoCaptureDevice _videoCaptureDevice;

        void load()
        {
            dgrid.ColumnCount = 8;
            dgrid.Columns[0].Name = "Tên sản phẩm";
            dgrid.Columns[1].Name = "Thương hiệu";
            dgrid.Columns[2].Name = "Danh mục";
            dgrid.Columns[3].Name = "Size";
            dgrid.Columns[4].Name = "Màu";
            dgrid.Columns[5].Name = "Chất liệu";
            dgrid.Columns[6].Name = "Trạng thái";
            dgrid.Columns[7].Name = "mã";
            dgrid.Columns[7].Visible = false;
            dgrid.Rows.Clear();
            foreach (var x in _iQlSanPhamService.GetSPAll())
            {
                dgrid.Rows.Add(x.SanPham.TenSp + ' ' + x.ChiTietSanPham.Mota, x.SanPham.ThuongHieu,
<<<<<<< HEAD
                    x.DanhMuc.TenDanhMuc, x.Size.SizeSp, x.Color.ColorSP, x.ChatLieu.ChatLieuSP, x.ChiTietSanPham.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.ChiTietSanPham.MaCTSP);
=======
                    x.DanhMuc.TenDanhMuc, x.Size.SizeSp, x.Color.ColorSP, x.ChatLieu.ChatLieuSP, x.ChiTietSanPham.TrangThai == 1 ? "còn hàng" : "hết hàng", x.ChiTietSanPham.MaCTSP);
>>>>>>> parent of 2c07f85 (g)
            }
        }

        void loadChatLieu()
        {
            foreach (var x in _iQlSanPhamService.GetLstChatLieu())
            {
<<<<<<< HEAD
                txt_chatLieu.Items.Add(x.ChatLieuSP);
=======
              txt_chatLieu.Items.Add(x.ChatLieuSP);
>>>>>>> parent of 2c07f85 (g)
            }

            txt_chatLieu.SelectedIndex = 0;
        }
        void loaddanhMuc()
        {
            foreach (var x in _iQlSanPhamService.GetLstDanhMuc())
            {
                txt_danhmuc.Items.Add(x.TenDanhMuc);
            }

            txt_danhmuc.SelectedIndex = 0;
        }
        void loadtsp()
        {
            foreach (var x in _iQlSanPhamService.GetLstSP())
            {
                txt_tsp.Items.Add(x.TenSp);
            }

            txt_tsp.SelectedIndex = 0;

        }

        void loadSize()
        {
            foreach (var x in _iQlSanPhamService.GetLstSize())
            {
                cbx_size.Items.Add(x.SizeSp);
            }

            cbx_size.SelectedIndex = 0;
        }

        void loadColor()
        {
            foreach (var x in _iQlSanPhamService.GetLstColor())
            {
                cbx_mau.Items.Add(x.ColorSP);
            }

            cbx_mau.SelectedIndex = 0;
        }
        void trangThai()
        {
            cbx_trangThai.Items.Add("Còn hàng");
            cbx_trangThai.Items.Add("Còn cái nịt");
            cbx_trangThai.SelectedIndex = 0;
        }
        void loadCogay()
        {
            foreach (var x in _iQlSanPhamService.GetLstLoaiCoGiay())
            {
<<<<<<< HEAD
                cbx_coGiay.Items.Add(x.LoaiCoGiaySP);
=======
               cbx_coGiay.Items.Add(x.LoaiCoGiaySP);
>>>>>>> parent of 2c07f85 (g)
            }
            cbx_coGiay.SelectedIndex = 0;
        }
        private void Thêm_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            QLSanPham qlSanPham = new QLSanPham();
            qlSanPham.ChiTietSanPham.MaCTSP = "CTSP"+ _iQlSanPhamService.GetLstCTSanPham().Count+1;
            qlSanPham.ChiTietSanPham.MaSP = _iQlSanPhamService.GetLstSP().Where(c => c.TenSp == txt_tsp.Text).Select(c => c.MaSp).FirstOrDefault();
            qlSanPham.ChiTietSanPham.MaCLR = _iQlSanPhamService.GetLstColor().Where(c => c.ColorSP == cbx_mau.Text)
                .Select(c => c.MaClr).FirstOrDefault();
            qlSanPham.ChiTietSanPham.MaSize = _iQlSanPhamService.GetLstSize().Where(c => c.SizeSp == int.Parse(cbx_size.Text))
                .Select(c => c.MaSize).FirstOrDefault();
            qlSanPham.ChiTietSanPham.GiaNhap = Convert.ToInt32(txt_gianhap.Text);
            qlSanPham.ChiTietSanPham.giaban = Convert.ToInt32(txt_giaban.Text);
            qlSanPham.ChiTietSanPham.soluong = Convert.ToInt32(txt_soluong.Text);
            qlSanPham.ChiTietSanPham.Mota = txt_tspct.Text;
            qlSanPham.ChiTietSanPham.MaChatLieu = _iQlSanPhamService.GetLstChatLieu().Where(c => c.ChatLieuSP == txt_chatLieu.Text).
                Select(c => c.MaChatLieu).FirstOrDefault();
            qlSanPham.ChiTietSanPham.MaCo = _iQlSanPhamService.GetLstLoaiCoGiay()
                .Where(c => c.LoaiCoGiaySP == cbx_coGiay.Text).Select(c => c.MaCo).FirstOrDefault();
            qlSanPham.ChiTietSanPham.GhiChu = txt_ghi.Text;
            qlSanPham.ChiTietSanPham.MaQR = txt_barCode.Text;
            qlSanPham.ChiTietSanPham.TrangThai = (cbx_trangThai.Text == "Còn hàng" ? 1 : 0);
            _iQlSanPhamService.addCTSanPham(qlSanPham.ChiTietSanPham);
            load();
=======
            //QLSanPham qlSanPham = new QLSanPham();
            //qlSanPham.ChiTietSanPham.MaCtsp = Guid.NewGuid();
            //qlSanPham.ChiTietSanPham.MaSp = _iQlSanPhamService.GetLstSP().Where(c => c.TenSp == txt_tsp.Text).Select(c => c.MaSp).FirstOrDefault();
            //qlSanPham.ChiTietSanPham.MaClr = _iQlSanPhamService.GetLstColor().Where(c => c.Color1 == cbx_mau.Text)
            //    .Select(c => c.MaClr).FirstOrDefault();
            //qlSanPham.ChiTietSanPham.MaSize = _iQlSanPhamService.GetLstSize().Where(c => c.Size1 == int.Parse(cbx_size.Text))
            //    .Select(c => c.MaSize).FirstOrDefault();
            //qlSanPham.ChiTietSanPham.GiaNhap = Convert.ToDouble(txt_gianhap.Text);
            //qlSanPham.ChiTietSanPham.GiaBan = Convert.ToDouble(txt_giaban.Text);
            //qlSanPham.ChiTietSanPham.SoLuong = Convert.ToInt32(txt_soluong.Text);
            //qlSanPham.ChiTietSanPham.Mota = txt_tspct.Text;
            //qlSanPham.ChiTietSanPham.MaChatLieu = _iQlSanPhamService.GetLstChatLieu().Where(c => c.ChatLieu1 == txt_chatLieu.Text).
            //    Select(c => c.MaChatLieu).FirstOrDefault();
            //qlSanPham.ChiTietSanPham.MaCo = _iQlSanPhamService.GetLstLoaiCoGiay()
            //    .Where(c => c.LoaiCoGiay1 == cbx_coGiay.Text).Select(c => c.MaCo).FirstOrDefault();
            //qlSanPham.ChiTietSanPham.GhiChu = txt_ghi.Text;
            //qlSanPham.ChiTietSanPham.MaQr = txt_barCode.Text;
            //qlSanPham.ChiTietSanPham.TrangThai = (cbx_trangThai.Text == "Còn hàng" ? 1 : 0);
            //_iQlSanPhamService.addCTSanPham(qlSanPham.ChiTietSanPham);
            //load();
>>>>>>> parent of 2c07f85 (g)
        }

        private void dgrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
<<<<<<< HEAD
            int row = e.RowIndex;
            temb = dgrid.Rows[row].Cells[7].Value.ToString();
            ChiTietSanPham1.SelectedIndex = 1;
            var tembSp = _iQlSanPhamService.GetSPAll().Where(c => c.ChiTietSanPham.MaCTSP == temb).FirstOrDefault();
            txt_danhmuc.Text = tembSp.DanhMuc.TenDanhMuc;
            txt_tsp.Text = tembSp.SanPham.TenSp;
            txt_tspct.Text = tembSp.ChiTietSanPham.Mota;
            txt_giaban.Text = (tembSp.ChiTietSanPham.giaban).ToString();
            txt_gianhap.Text = (tembSp.ChiTietSanPham.GiaNhap).ToString();
            cbx_mau.Text = tembSp.Color.ColorSP;
            cbx_size.Text = tembSp.Size.SizeSp.ToString();
            txt_ghi.Text = tembSp.ChiTietSanPham.GhiChu;
            txt_barCode.Text = tembSp.ChiTietSanPham.MaQR;
            txt_chatLieu.Text = tembSp.ChatLieu.ChatLieuSP;
            txt_soluong.Text = (tembSp.ChiTietSanPham.soluong).ToString();
            cbx_coGiay.Text = tembSp.LoaiCoGiay.LoaiCoGiaySP;
            cbx_trangThai.Text = tembSp.ChiTietSanPham.TrangThai == 1 ? "Còn hàng" : "Hết hàng";
            var temb1 = _iQlSanPhamService.GetLstImage().Where(c => c.MaCTSP == temb).Select(c => c.Images).FirstOrDefault();
            if (temb1 != null) 
            {
                lbl_anh.Text = temb1;
                pic.Image = Image.FromFile(lbl_anh.Text);
            }
=======
            //int row = e.RowIndex;
            //temb = new Guid(dgrid.Rows[row].Cells[7].Value.ToString());
            //ChiTietSanPham1.SelectedIndex = 1;
            //var tembSp = _iQlSanPhamService.GetSPAll().Where(c => c.ChiTietSanPham.MaCtsp == temb).FirstOrDefault();
            //txt_danhmuc.Text = tembSp.DanhMuc.TenDanhMuc;
            //txt_tsp.Text = tembSp.SanPham.TenSp;
            //txt_tspct.Text = tembSp.ChiTietSanPham.Mota;
            //txt_giaban.Text = (tembSp.ChiTietSanPham.GiaBan).ToString();
            //txt_gianhap.Text = (tembSp.ChiTietSanPham.GiaNhap).ToString();
            //cbx_mau.Text = tembSp.Color.Color1;
            //cbx_size.Text = tembSp.Size.Size1.ToString();
            //txt_ghi.Text = tembSp.ChiTietSanPham.GhiChu;
            //txt_barCode.Text = tembSp.ChiTietSanPham.MaQr;
            //txt_chatLieu.Text = tembSp.ChatLieu.ChatLieu1;
            //txt_soluong.Text = (tembSp.ChiTietSanPham.SoLuong).ToString();
            //cbx_coGiay.Text = tembSp.LoaiCoGiay.LoaiCoGiay1;
            //cbx_trangThai.Text = tembSp.ChiTietSanPham.TrangThai == 1 ? "Còn hàng" : "Hết hàng";
            //var temb1 = _iQlSanPhamService.GetLstImage().Where(c => c.MaCTSP == temb).Select(c => c.Images).FirstOrDefault();
            //if (temb1 != null)
            //{
            //    lbl_anh.Text = temb1;
            //    pic.Image = Image.FromFile(lbl_anh.Text);
            //}
>>>>>>> parent of 2c07f85 (g)
        }

        private void button1_Click(object sender, EventArgs e)
        {

            _barcode = txt_barCode.Text;
            Frm_BarCode frmBarCode = new Frm_BarCode();
            frmBarCode.Show();
        }

        private void Frm_sanpham_Load(object sender, EventArgs e)
        {
            _filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo x in _filterInfoCollection)
            {
                cbx_webcam.Items.Add(x.Name);
                cbx_webcam.SelectedIndex = 0;
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            _videoCaptureDevice = new VideoCaptureDevice(_filterInfoCollection[cbx_webcam.SelectedIndex].MonikerString);
            _videoCaptureDevice.NewFrame += VideoCaptureDevice_name;
            _videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_name(object sender, NewFrameEventArgs eventargs)
        {
            pic_webcam.Image= (Bitmap)eventargs.Frame.Clone();
            Bitmap bitmap = (Bitmap)eventargs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                txt_barCode.Invoke(new MethodInvoker(delegate ()
                {
                    txt_barCode.Text = result.ToString();
                    _bcode = (string.Format("{0:0000000000000000000}", result.ToString()));
                    MessageBox.Show(_barcode);
                }));
            }
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            if (_videoCaptureDevice != null)
            {
               
                    _videoCaptureDevice.Stop();
                
            }
        }



        private void Sửa_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            var qlSanPham = _iQlSanPhamService.GetSPAll().Where(c => c.ChiTietSanPham.MaCTSP == temb).FirstOrDefault();
            qlSanPham.ChiTietSanPham.MaCTSP = temb;
            qlSanPham.ChiTietSanPham.MaSP = _iQlSanPhamService.GetLstSP().Where(c => c.TenSp == txt_tsp.Text).Select(c => c.MaSp).FirstOrDefault();
            qlSanPham.ChiTietSanPham.MaCLR = _iQlSanPhamService.GetLstColor().Where(c => c.ColorSP == cbx_mau.Text)
                .Select(c => c.MaClr).FirstOrDefault();
            qlSanPham.ChiTietSanPham.MaSize = _iQlSanPhamService.GetLstSize().Where(c => c.SizeSp == int.Parse(cbx_size.Text))
                .Select(c => c.MaSize).FirstOrDefault();
            qlSanPham.ChiTietSanPham.GiaNhap = Convert.ToInt32(txt_gianhap.Text);
            qlSanPham.ChiTietSanPham.giaban = Convert.ToInt32(txt_giaban.Text);
            qlSanPham.ChiTietSanPham.soluong = Convert.ToInt32(txt_soluong.Text);
            qlSanPham.ChiTietSanPham.Mota = txt_tspct.Text;
            qlSanPham.ChiTietSanPham.MaChatLieu = _iQlSanPhamService.GetLstChatLieu().Where(c => c.ChatLieuSP == txt_chatLieu.Text).
                Select(c => c.MaChatLieu).FirstOrDefault();
            qlSanPham.ChiTietSanPham.MaCo = _iQlSanPhamService.GetLstLoaiCoGiay()
                .Where(c => c.LoaiCoGiaySP == cbx_coGiay.Text).Select(c => c.MaCo).FirstOrDefault();
            qlSanPham.ChiTietSanPham.GhiChu = txt_ghi.Text;
            qlSanPham.ChiTietSanPham.MaQR = txt_barCode.Text;
            qlSanPham.ChiTietSanPham.TrangThai = (cbx_trangThai.Text == "Còn hàng" ? 1 : 0);
            _iQlSanPhamService.updateCTSanPham(qlSanPham.ChiTietSanPham);
            load();
=======
            //var qlSanPham = _iQlSanPhamService.GetSPAll().Where(c => c.ChiTietSanPham.MaCtsp == temb).FirstOrDefault();
            //qlSanPham.ChiTietSanPham.MaCtsp = Guid.NewGuid();
            //qlSanPham.ChiTietSanPham.MaSp = _iQlSanPhamService.GetLstSP().Where(c => c.TenSp == txt_tsp.Text).Select(c => c.MaSp).FirstOrDefault();
            //qlSanPham.ChiTietSanPham.MaClr = _iQlSanPhamService.GetLstColor().Where(c => c.ColorSP == cbx_mau.Text)
            //    .Select(c => c.MaClr).FirstOrDefault();
            //qlSanPham.ChiTietSanPham.MaSize = _iQlSanPhamService.GetLstSize().Where(c => c.SizeSp == int.Parse(cbx_size.Text))
            //    .Select(c => c.MaSize).FirstOrDefault();
            //qlSanPham.ChiTietSanPham.GiaNhap = Convert.ToDouble(txt_gianhap.Text);
            //qlSanPham.ChiTietSanPham.GiaBan = Convert.ToDouble(txt_giaban.Text);
            //qlSanPham.ChiTietSanPham.SoLuong = Convert.ToInt32(txt_soluong.Text);
            //qlSanPham.ChiTietSanPham.Mota = txt_tspct.Text;
            //qlSanPham.ChiTietSanPham.MaChatLieu = _iQlSanPhamService.GetLstChatLieu().Where(c => c.ChatLieuSP == txt_chatLieu.Text).
            //    Select(c => c.MaChatLieu).FirstOrDefault();
            //qlSanPham.ChiTietSanPham.MaCo = _iQlSanPhamService.GetLstLoaiCoGiay()
            //    .Where(c => c.LoaiCoGiaySP == cbx_coGiay.Text).Select(c => c.MaCo).FirstOrDefault();
            //qlSanPham.ChiTietSanPham.GhiChu = txt_ghi.Text;
            //qlSanPham.ChiTietSanPham.MaQr = txt_barCode.Text;
            //qlSanPham.ChiTietSanPham.TrangThai = (cbx_trangThai.Text == "Còn hàng" ? 1 : 0);
            //_iQlSanPhamService.updateCTSanPham(qlSanPham.ChiTietSanPham);
            //load();
>>>>>>> parent of 2c07f85 (g)
        }

        private void upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pic.Image = new Bitmap(opnfd.FileName);
                lbl_anh.Text = opnfd.FileName;
            }
        }

        private void btn_anh_Click(object sender, EventArgs e)
        {

<<<<<<< HEAD
            QLSanPham qlSanPham = new QLSanPham();
            qlSanPham.Image.TrangThai = 1;
            qlSanPham.Image.MaImage = "Img"+ _iQlSanPhamService.GetLstImage().Count+1;
            qlSanPham.Image.MaCTSP = temb;
            qlSanPham.Image.Images = lbl_anh.Text;
            _iQlSanPhamService.addImage(qlSanPham.Image);
=======
            //QLSanPham qlSanPham = new QLSanPham();
            //qlSanPham.Image.TrangThai = 1;
            //qlSanPham.Image.MaImage = Guid.NewGuid();
            //qlSanPham.Image.MaCtsp = temb;
            //qlSanPham.Image.Images = lbl_anh.Text;
            //_iQlSanPhamService.addImage(qlSanPham.Image);
>>>>>>> parent of 2c07f85 (g)

        }

        private void txt_barCode_TextChanged(object sender, EventArgs e)
        {
            Barcode barcode = new Barcode();
            Color forColor = Color.Black;
            Color backColor = Color.White;
            Image img = barcode.Encode(TYPE.CODE128A, txt_barCode.Text, forColor, backColor,
                (int) (pic_webcam.Width * 1), (int) (pic_webcam.Height * 1));
            pic_webcam.Image = img;
        }
    }
}
