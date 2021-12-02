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
using Color = System.Drawing.Color;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_KhuyenMai : Form
    {
        private IQlKhuyenMai _iQlKhuyenMai;
        private List<string> _tendanhMuc;
        public Frm_KhuyenMai()
        {
            InitializeComponent();
            _iQlKhuyenMai = new QlKhuyenMai();
            _tendanhMuc = new List<string>();
            load();
            loadDanhMuc();
            rdo_hd.Checked = true;
            dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
        }


        //void load()
        //{
        //    dgv.ColumnCount = 6;
        //    dgv.Columns[0].Name = "Tên sản phẩm";
        //    dgv.Columns[1].Name = "Thương hiệu";
        //    dgv.Columns[2].Name = "Loại cổ giày";
        //    dgv.Columns[3].Name = "Chất liệu";
        //    dgv.Columns[4].Name = "Trạng thái";
        //    dgv.Columns[5].Name = "mã";
        //    dgv.Columns[5].Visible = false;
        //    DataGridViewButtonColumn DTThem = new DataGridViewButtonColumn();
        //    DTThem.Name = "btn_add";
        //    DTThem.Text = "Ẩn";
        //    DTThem.HeaderText = "";
        //    DTThem.UseColumnTextForButtonValue = true;
        //    int indexAdd = 6;
        //    if (dgv.Columns["btn_add"] == null)
        //    {
        //        dgv.Columns.Insert(indexAdd, DTThem);
        //    }
        //    DataGridViewButtonColumn DTRemove = new DataGridViewButtonColumn();
        //    DTRemove.Name = "btn_remove";
        //    DTRemove.Text = "Anti ẩn";
        //    DTRemove.HeaderText = "";
        //    DTRemove.UseColumnTextForButtonValue = true;
        //    int indexRemove = 7;
        //    if (dgv.Columns["btn_remove"] == null)
        //    {
        //        dgv.Columns.Insert(indexRemove, DTRemove);
        //    }
        //    dgv.Rows.Clear();
        //    foreach (var x in _iQlKhuyenMai.GetKhuyenMais())
        //    {
        //        dgv.Rows.Add(x.SanPham.TenSp + " " + x.ChiTietSanPham.Mota, x.SanPham.ThuongHieu,
        //            x.LoaiCoGiay.LoaiCoGiaySP, x.ChatLieu.ChatLieuSP,
        //            x.ProductBack.ProductStatus == 1 ? "Đã ẩn" : "Chưa ẩn", x.ChiTietSanPham.MaCTSP);
        //    }

        //}

        void loadDanhMuc()
        {
            cbo_danhmuc.Items.Add("Tất cả");
            foreach (var x in _iQlKhuyenMai.GetDanhMucs())
            {
                cbo_danhmuc.Items.Add(x.TenDanhMuc);
            }

            cbo_danhmuc.SelectedIndex = 0;
        }
        private int a = 30, b = 270;
        private List<string> temb;
        private List<List<string>> _temb = new List<List<string>>();
        private void btn_danhMuc_Click(object sender, EventArgs e)
        {
            foreach (var x in _iQlKhuyenMai.GetDanhMucs())
            {
                temb = new List<string>();
                Button btn = new Button() { Name = "btn" + x.TenDanhMuc, Text = x.TenDanhMuc };
                btn.Size = new System.Drawing.Size(88, 37);
                if (a >= tabPage1.Size.Width)
                {
                    a = 30;
                    b = b + 50;
                }
                temb.Add(x.TenDanhMuc);
                temb.Add("1");
                btn.Location = new Point(a, b);
                a = a + 120;
                btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                btn.BackColor = Color.WhiteSmoke;
                btn.Click += Btn_Click;
                btn.UseVisualStyleBackColor = false;
                tabPage1.Controls.Add(btn);

                _temb.Add(temb);

            }
        }

        private void btm_tao_Click(object sender, EventArgs e)
        {
            KhuyenMai_Bus khuyenMai = new KhuyenMai_Bus();
            khuyenMai.KhuyenMai.GhiChu = txt_ghichu.Text;
            khuyenMai.KhuyenMai.GiamGia = Convert.ToInt32(nud_giamgia.Text);
            khuyenMai.KhuyenMai.MaKM = "KM" + (_iQlKhuyenMai.GetlstKhuyenMais().Count + 1);
            string dateStart = string.Format("{0:yyyy-MM-dd}", dtp_start.Value);
            khuyenMai.KhuyenMai.NgayDau = Convert.ToDateTime(dateStart);
            string dateEnd = string.Format("{0:yyyy-MM-dd}", dtp_end.Value);
            khuyenMai.KhuyenMai.NgayHet = Convert.ToDateTime(dateEnd);
            khuyenMai.KhuyenMai.TenChuongTrinh = txt_tct.Text;
            khuyenMai.KhuyenMai.TrangThai = rdo_hd.Checked ? 1 : 0;
            _iQlKhuyenMai.addKM(khuyenMai.KhuyenMai);
            string tembKM = khuyenMai.KhuyenMai.MaKM;
            for (int i = 0; i < _tendanhMuc.Count; i++)
            {
                khuyenMai = new KhuyenMai_Bus();
                khuyenMai.ChiTietGiamGia.MaCTGG = "CTGG" + (_iQlKhuyenMai.GetChiTietGiamGias().Count + 1);
                khuyenMai.ChiTietGiamGia.MaDanhMuc = _iQlKhuyenMai.GetDanhMucs().Where(c => c.TenDanhMuc == _tendanhMuc[i])
                    .Select(c => c.MaDanhMuc).FirstOrDefault();
                khuyenMai.ChiTietGiamGia.MaKM = tembKM;
                _iQlKhuyenMai.addCTGG(khuyenMai.ChiTietGiamGia);
            }

            _tendanhMuc = new List<string>();
            MessageBox.Show("Tạo khuyến mại thành công");
        }

        void load()
        {
            dgv.ColumnCount = 6;
            dgv.Columns[0].Name = "Tên sản phẩm";
            dgv.Columns[1].Name = "Thương hiệu";
            dgv.Columns[2].Name = "Loại cổ giày";
            dgv.Columns[3].Name = "Chất liệu";
            dgv.Columns[4].Name = "Trạng thái";
            dgv.Columns[5].Name = "mã";
            dgv.Columns[5].Visible = false;
            DataGridViewButtonColumn DTThem = new DataGridViewButtonColumn();
            DTThem.Name = "btn_add";
            DTThem.Text = "Ẩn";
            DTThem.HeaderText = "";
            DTThem.UseColumnTextForButtonValue = true;
            int indexAdd = 6;
            if (dgv.Columns["btn_add"] == null)
            {
                dgv.Columns.Insert(indexAdd, DTThem);
            }
            DataGridViewButtonColumn DTRemove = new DataGridViewButtonColumn();
            DTRemove.Name = "btn_remove";
            DTRemove.Text = "Anti ẩn";
            DTRemove.HeaderText = "";
            DTRemove.UseColumnTextForButtonValue = true;
            int indexRemove = 7;
            if (dgv.Columns["btn_remove"] == null)
            {
                dgv.Columns.Insert(indexRemove, DTRemove);
            }
            dgv.Rows.Clear();

            if (cbo_danhmuc.Text != "Tất cả")
            {
                foreach (var x in _iQlKhuyenMai.GetKhuyenMaisSearch(cbo_danhmuc.Text))
                {
                    dgv.Rows.Add(x.SanPham.TenSp + " " + x.ChiTietSanPham.Mota, x.SanPham.ThuongHieu,
                        x.LoaiCoGiay.LoaiCoGiaySP, x.ChatLieu.ChatLieuSP,
                        x.ProductBack.ProductStatus == 1 ? "Đã ẩn" : "Chưa ẩn", x.ChiTietSanPham.MaCTSP);
                }
            }
            else
            {
                foreach (var x in _iQlKhuyenMai.GetKhuyenMais())
                {
                    dgv.Rows.Add(x.SanPham.TenSp + " " + x.ChiTietSanPham.Mota, x.SanPham.ThuongHieu,
                        x.LoaiCoGiay.LoaiCoGiaySP, x.ChatLieu.ChatLieuSP,
                        x.ProductBack.ProductStatus == 1 ? "Đã ẩn" : "Chưa ẩn", x.ChiTietSanPham.MaCTSP);
                }

            }

        }

        private void cbo_danhmuc_TextChanged(object sender, EventArgs e)
        {
        load();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int row = e.RowIndex;
            string id = dgv.Rows[row].Cells[5].Value.ToString();
            var dt = _iQlKhuyenMai.GetChiTietSanPhams().Where(c => c.MaCTSP == id).FirstOrDefault();
            if (column==dgv.Columns["btn_add"].Index)
            {
                dt.MaPB = "PB1";
                _iQlKhuyenMai.updateCTSP(dt);
            }
            if (column == dgv.Columns["btn_remove"].Index)
            {
                dt.MaPB = "PB2";
                _iQlKhuyenMai.updateCTSP(dt);
            }
            load();

        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            Button button = (sender as Button);
            int index = _temb.FindIndex(x => x.Contains(button.Text));
            if (_temb[index][1] == "1")
            {
                _tendanhMuc.Add(button.Text);
                button.BackColor = Color.DodgerBlue;
                _temb[index][1] = "2";
            }
            else
            {
                _tendanhMuc.Remove(button.Text);
                button.BackColor = Color.WhiteSmoke;
                _temb[index][1] = "1";
            }
        }
    }
}
