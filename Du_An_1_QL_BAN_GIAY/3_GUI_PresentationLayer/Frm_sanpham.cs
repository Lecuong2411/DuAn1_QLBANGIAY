using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        public string _bcode;
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
            loadanhMucSP();
            loadChatLieuSP();
            Km();
            giaBan();
        }

        private FilterInfoCollection _filterInfoCollection;
        private VideoCaptureDevice _videoCaptureDevice;

        void load()
        {
         
            dgrid.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
            dgrid.ColumnCount = 9;
            dgrid.Columns[0].Name = "Tên sản phẩm";
            dgrid.Columns[1].Name = "Thương hiệu";
            dgrid.Columns[2].Name = "Danh mục";
            dgrid.Columns[3].Name = "Size";
            dgrid.Columns[4].Name = "Màu";
            dgrid.Columns[5].Name = "Chất liệu";
            dgrid.Columns[6].Name = "Giá tiền";
            dgrid.Columns[7].Name = "Trạng thái";
            dgrid.Columns[8].Name = "mã";
            dgrid.Columns[8].Visible = false;
            dgrid.Rows.Clear();
            foreach (var x in _iQlSanPhamService.GetSPAll())
            {
                dgrid.Rows.Add(x.SanPham.TenSp + ' ' + x.ChiTietSanPham.Mota, x.SanPham.ThuongHieu,

                    x.DanhMuc.TenDanhMuc, x.Size.SizeSp, x.Color.ColorSP, x.ChatLieu.ChatLieuSP,x.ChiTietSanPham.giaban, x.ChiTietSanPham.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.ChiTietSanPham.MaCTSP);


            }
        }

        void loadChatLieu()
        {
            foreach (var x in _iQlSanPhamService.GetLstChatLieu())
            {
                txt_chatLieu.Items.Add(x.ChatLieuSP);
            }

            txt_chatLieu.SelectedIndex = 0;
        }
        void loadChatLieuSP()
        {
            cbo_chatLieu.Items.Add("Tất cả");
            foreach (var x in _iQlSanPhamService.GetLstChatLieu())
            {

               cbo_chatLieu.Items.Add(x.ChatLieuSP);

            }

            cbo_chatLieu.SelectedIndex = 0;
        }
        void loadanhMucSP()
        {
            cbo_loadDanhMuc.Items.Add("Tất cả");
            foreach (var x in _iQlSanPhamService.GetLstDanhMuc())
            {
               cbo_loadDanhMuc.Items.Add(x.TenDanhMuc);
            }

            cbo_loadDanhMuc.SelectedIndex = 0;
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

                cbx_coGiay.Items.Add(x.LoaiCoGiaySP);

                cbx_coGiay.Items.Add(x.LoaiCoGiaySP);

            }
            cbx_coGiay.SelectedIndex = 0;
        }
        private void Thêm_Click(object sender, EventArgs e)
        {

            QLSanPham qlSanPham = new QLSanPham();
            qlSanPham.ChiTietSanPham.MaCTSP = "CTSP" + (_iQlSanPhamService.GetLstCTSanPham().Count + 1);
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
            //History history = new History();
            //history.MaCTSP = qlSanPham.ChiTietSanPham.MaCTSP;
            //history.MaHis ="His"+ _iQlSanPhamService.GetLstHistory().Count + 1;
            //history.MaNV = "";
            //history.NgayNhap=DateTime.Now;
            //_iQlSanPhamService.addHistory(history);

            // chạy chương trình sẽ mở



        }

        private void dgrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int row = e.RowIndex;
            temb = dgrid.Rows[row].Cells[8].Value.ToString();
            ChiTietSanPham1.SelectedIndex = 1;
            var tembSp = _iQlSanPhamService.GetSPAllLoad().Where(c => c.ChiTietSanPham.MaCTSP == temb).FirstOrDefault();
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
            if (_iQlSanPhamService.GetLstImage().Where(c=>c.Images==temb1) !=null)
            {
                //lbl_anh.Text = temb1;
                //pic.Image = Image.FromFile(lbl_anh.Text);
            }


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
            pic_webcam.Image = (Bitmap)eventargs.Frame.Clone();
            Bitmap bitmap = (Bitmap)eventargs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                txt_barCode.Invoke(new MethodInvoker(delegate ()
                {
                    txt_barCode.Text = result.ToString();
                    _bcode = (string.Format("{0:0000000000000000000}", result.ToString()));
                }));
            }
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            if (_videoCaptureDevice != null)
            {
                _videoCaptureDevice.SignalToStop();
                Thread.Sleep(1000);
              
            }
        }



        private void Sửa_Click(object sender, EventArgs e)
        {

            var qlSanPham = _iQlSanPhamService.GetSPAllLoad().Where(c => c.ChiTietSanPham.MaCTSP == temb).FirstOrDefault();
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
            qlSanPham.ChiTietSanPham.MaPB = "PB2";
            _iQlSanPhamService.updateCTSanPham(qlSanPham.ChiTietSanPham);
            //History history = new History();
            //history.MaCTSP = temb;
            //history.MaHis ="His"+ _iQlSanPhamService.GetLstHistory().Count + 1;
            //history.MaNV = "";
            //history.NgayNhap=DateTime.Now;
            //_iQlSanPhamService.addHistory(history);

            // chạy chương trình sẽ mở
            load();
           
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

            QLSanPham qlSanPham = new QLSanPham();
            qlSanPham.Image.TrangThai = 1;
            qlSanPham.Image.MaImage = "Img" + _iQlSanPhamService.GetLstImage().Count + 1;
            qlSanPham.Image.MaCTSP = temb;
            qlSanPham.Image.Images = lbl_anh.Text;
            _iQlSanPhamService.addImage(qlSanPham.Image);
        }

        private void txt_barCode_TextChanged(object sender, EventArgs e)
        {
            //_iQlSanPhamService.GetLstCTSanPham().Where(c => c.MaQR == txt_barCode.Text) != null;
            MessageBox.Show(txt_barCode.Text);
            var result = _iQlSanPhamService.GetLstCTSanPham().Where(c => c.MaQR == txt_barCode.Text)
                .Select(c => c.MaCTSP)
                .FirstOrDefault();
            try
            {
                if (  _iQlSanPhamService.GetLstCTSanPham().Where(c => c.MaQR == txt_barCode.Text).Select(c => c.MaCTSP)
                    .FirstOrDefault() != null) 
                {

                    var dt = _iQlSanPhamService.GetLstCTSanPham().Where(c => c.MaQR == txt_barCode.Text).Select(c => c.MaCTSP).FirstOrDefault();
                    var tembSp = _iQlSanPhamService.GetSPAll().Where(c => c.ChiTietSanPham.MaCTSP == dt).FirstOrDefault();
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
                    if (_iQlSanPhamService.GetLstImage().Where(c => c.Images == temb1) != null)
                    {
                        //lbl_anh.Text = temb1;
                        //pic.Image = Image.FromFile(lbl_anh.Text);
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_import frmImport = new Frm_import();
            frmImport.Show();
        }

        private void cbo_loadDanhMuc_TextChanged(object sender, EventArgs e)
        {
            dgrid.Rows.Clear();
            if (cbo_loadDanhMuc.Text != "Tất cả")
            {
                foreach (var x in _iQlSanPhamService.GetSPAll().Where(c => c.DanhMuc.TenDanhMuc == cbo_loadDanhMuc.Text))
                {
                    dgrid.Rows.Add(x.SanPham.TenSp + ' ' + x.ChiTietSanPham.Mota, x.SanPham.ThuongHieu,

                        x.DanhMuc.TenDanhMuc, x.Size.SizeSp, x.Color.ColorSP, x.ChatLieu.ChatLieuSP, x.ChiTietSanPham.giaban, x.ChiTietSanPham.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.ChiTietSanPham.MaCTSP);
                }

            }
            else
            {
                foreach (var x in _iQlSanPhamService.GetSPAll())
                {
                    dgrid.Rows.Add(x.SanPham.TenSp + ' ' + x.ChiTietSanPham.Mota, x.SanPham.ThuongHieu,

                        x.DanhMuc.TenDanhMuc, x.Size.SizeSp, x.Color.ColorSP, x.ChatLieu.ChatLieuSP, x.ChiTietSanPham.giaban, x.ChiTietSanPham.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.ChiTietSanPham.MaCTSP);
                }
            }
        }

        private void cbo_chatLieu_TextChanged(object sender, EventArgs e)
        {
            dgrid.Rows.Clear();
            if (cbo_chatLieu.Text == "Tất cả")
            {
                foreach (var x in _iQlSanPhamService.GetSPAll())
                {
                    dgrid.Rows.Add(x.SanPham.TenSp + ' ' + x.ChiTietSanPham.Mota, x.SanPham.ThuongHieu,

                        x.DanhMuc.TenDanhMuc, x.Size.SizeSp, x.Color.ColorSP, x.ChatLieu.ChatLieuSP, x.ChiTietSanPham.giaban, x.ChiTietSanPham.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.ChiTietSanPham.MaCTSP);
                }
            }
            else
            {
                foreach (var x in _iQlSanPhamService.GetSPAll().Where(c => c.ChatLieu.ChatLieuSP == cbo_chatLieu.Text))
                {
                    dgrid.Rows.Add(x.SanPham.TenSp + ' ' + x.ChiTietSanPham.Mota, x.SanPham.ThuongHieu,

                        x.DanhMuc.TenDanhMuc, x.Size.SizeSp, x.Color.ColorSP, x.ChatLieu.ChatLieuSP, x.ChiTietSanPham.giaban, x.ChiTietSanPham.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.ChiTietSanPham.MaCTSP);
                }
            }
        }

        void Km()
        {
            cbo_dkm.Items.Add("Tất cả");
            cbo_dkm.Items.Add("Đang sale");
            cbo_dkm.Items.Add("Không sale");
            cbo_dkm.SelectedIndex = 0;
        }
        private void cbo_dkm_TextChanged(object sender, EventArgs e)
        {
            dgrid.Rows.Clear();
            if (cbo_dkm.Text == "Tất cả")
            {
                foreach (var x in _iQlSanPhamService.GetSPAll())
                {
                    dgrid.Rows.Add(x.SanPham.TenSp + ' ' + x.ChiTietSanPham.Mota, x.SanPham.ThuongHieu,

                        x.DanhMuc.TenDanhMuc, x.Size.SizeSp, x.Color.ColorSP, x.ChatLieu.ChatLieuSP, x.ChiTietSanPham.giaban, x.ChiTietSanPham.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.ChiTietSanPham.MaCTSP);
                }

            }
            else if (cbo_dkm.Text == "Đang sale")
            {
                foreach (var x in _iQlSanPhamService.GetSPAll().Where(c=>c.ProductBack.TrangThai==3))
                {
                    dgrid.Rows.Add(x.SanPham.TenSp + ' ' + x.ChiTietSanPham.Mota, x.SanPham.ThuongHieu,

                        x.DanhMuc.TenDanhMuc, x.Size.SizeSp, x.Color.ColorSP, x.ChatLieu.ChatLieuSP, x.ChiTietSanPham.giaban, x.ChiTietSanPham.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.ChiTietSanPham.MaCTSP);
                }
            }
            else if (cbo_dkm.Text == "Không sale")
            {
                foreach (var x in _iQlSanPhamService.GetSPAll().Where(c => c.ProductBack.TrangThai == 0 || c.ProductBack.TrangThai == 1))
                {
                    dgrid.Rows.Add(x.SanPham.TenSp + ' ' + x.ChiTietSanPham.Mota, x.SanPham.ThuongHieu,

                        x.DanhMuc.TenDanhMuc, x.Size.SizeSp, x.Color.ColorSP, x.ChatLieu.ChatLieuSP, x.ChiTietSanPham.giaban, x.ChiTietSanPham.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.ChiTietSanPham.MaCTSP);
                }
            }
        }

        void giaBan()
        {
            cbo_giaBan.Items.Add("Tất cả");
            cbo_giaBan.Items.Add("Từ 0-500k");
            cbo_giaBan.Items.Add("Từ 500k-1tr");
            cbo_giaBan.Items.Add("Từ 1tr-2tr");
            cbo_giaBan.Items.Add("Từ 2tr-5tr");
            cbo_giaBan.Items.Add("Trên 5tr");
            cbo_giaBan.SelectedIndex = 0;

        }

        private void cbo_giaBan_TextChanged(object sender, EventArgs e)
        {
            dgrid.Rows.Clear();
            if (cbo_giaBan.Text == "Tất cả")
            {
                foreach (var x in _iQlSanPhamService.GetSPAll())
                {
                    dgrid.Rows.Add(x.SanPham.TenSp + ' ' + x.ChiTietSanPham.Mota, x.SanPham.ThuongHieu,

                        x.DanhMuc.TenDanhMuc, x.Size.SizeSp, x.Color.ColorSP, x.ChatLieu.ChatLieuSP, x.ChiTietSanPham.giaban, x.ChiTietSanPham.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.ChiTietSanPham.MaCTSP);
                }

            }
            else if (cbo_giaBan.Text == "Từ 0-500k")
            {
                foreach (var x in _iQlSanPhamService.GetSPAll().Where(c=>c.ChiTietSanPham.giaban>0 && c.ChiTietSanPham.giaban <=500000))
                {
                    dgrid.Rows.Add(x.SanPham.TenSp + ' ' + x.ChiTietSanPham.Mota, x.SanPham.ThuongHieu,

                        x.DanhMuc.TenDanhMuc, x.Size.SizeSp, x.Color.ColorSP, x.ChatLieu.ChatLieuSP, x.ChiTietSanPham.giaban, x.ChiTietSanPham.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.ChiTietSanPham.MaCTSP);
                }
            }
            else if (cbo_giaBan.Text == "500k-1tr")
            {
                foreach (var x in _iQlSanPhamService.GetSPAll().Where(c => c.ChiTietSanPham.giaban > 500000 && c.ChiTietSanPham.giaban <= 1000000))
                {
                    dgrid.Rows.Add(x.SanPham.TenSp + ' ' + x.ChiTietSanPham.Mota, x.SanPham.ThuongHieu,

                        x.DanhMuc.TenDanhMuc, x.Size.SizeSp, x.Color.ColorSP, x.ChatLieu.ChatLieuSP, x.ChiTietSanPham.giaban, x.ChiTietSanPham.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.ChiTietSanPham.MaCTSP);
                }
            }
            else if (cbo_giaBan.Text == "Từ 1tr-2tr")
            {
                foreach (var x in _iQlSanPhamService.GetSPAll().Where(c => c.ChiTietSanPham.giaban > 1000000 && c.ChiTietSanPham.giaban <= 2000000))
                {
                    dgrid.Rows.Add(x.SanPham.TenSp + ' ' + x.ChiTietSanPham.Mota, x.SanPham.ThuongHieu,

                        x.DanhMuc.TenDanhMuc, x.Size.SizeSp, x.Color.ColorSP, x.ChatLieu.ChatLieuSP, x.ChiTietSanPham.giaban, x.ChiTietSanPham.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.ChiTietSanPham.MaCTSP);
                }
            }
            else if (cbo_giaBan.Text == "Từ 2tr-5tr")
            {
                foreach (var x in _iQlSanPhamService.GetSPAll().Where(c => c.ChiTietSanPham.giaban > 2000000 && c.ChiTietSanPham.giaban <= 5000000))
                {
                    dgrid.Rows.Add(x.SanPham.TenSp + ' ' + x.ChiTietSanPham.Mota, x.SanPham.ThuongHieu,

                        x.DanhMuc.TenDanhMuc, x.Size.SizeSp, x.Color.ColorSP, x.ChatLieu.ChatLieuSP, x.ChiTietSanPham.giaban, x.ChiTietSanPham.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.ChiTietSanPham.MaCTSP);
                }
            }
            else if (cbo_giaBan.Text == "Trên 5tr")
            {
                foreach (var x in _iQlSanPhamService.GetSPAll().Where(c => c.ChiTietSanPham.giaban > 5000000))
                {
                    dgrid.Rows.Add(x.SanPham.TenSp + ' ' + x.ChiTietSanPham.Mota, x.SanPham.ThuongHieu,

                        x.DanhMuc.TenDanhMuc, x.Size.SizeSp, x.Color.ColorSP, x.ChatLieu.ChatLieuSP, x.ChiTietSanPham.giaban, x.ChiTietSanPham.TrangThai == 1 ? "Còn hàng" : "Hết hàng", x.ChiTietSanPham.MaCTSP);
                }
            }


        }

      
    }
}
