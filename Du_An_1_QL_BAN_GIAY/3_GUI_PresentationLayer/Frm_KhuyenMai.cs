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
        int temb2 = 0;
        public Frm_KhuyenMai()
        {
            InitializeComponent();
            _iQlKhuyenMai = new QlKhuyenMai();
            _tendanhMuc = new List<string>();
            load();
            loadDanhMuc();
            rdo_hd.Checked = true;
            //dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            //dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
            //dgv_km.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            //dgv_km.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
        }

        void loadDanhMuc()
        {

            cbo_danhmuc.Items.Add("Tất cả");
            foreach (var x in _iQlKhuyenMai.GetDanhMucs())
            {
                cbo_danhmuc.Items.Add(x.TenDanhMuc);
            }

            cbo_danhmuc.SelectedIndex = 0;
        }

        private int a = 30, b = 800;
        private List<string> temb;
        private List<List<string>> _temb = new List<List<string>>();
        private void btn_danhMuc_Click(object sender, EventArgs e)
        {
            if (temb2 == 0)
            {
                foreach (var x in _iQlKhuyenMai.GetDanhMucs())
                {
                    temb = new List<string>();
                    Button btn = new Button() { Name = "btn" + x.TenDanhMuc, Text = x.TenDanhMuc };
                    btn.Size = new System.Drawing.Size(180, 50);
                    if (a >= tabPage1.Size.Width)
                    {
                        a = 30;
                        b = b + 50;
                    }
                    temb.Add(x.TenDanhMuc);
                    temb.Add("1");
                    btn.Location = new Point(a, b);
                    a = a + 140;
                    btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    btn.BackColor = Color.WhiteSmoke;
                    btn.Click += Btn_Click;
                    btn.UseVisualStyleBackColor = false;
                    tabPage1.Controls.Add(btn);

                    _temb.Add(temb);

                }
                temb2++;
            }
        }

        private void btm_tao_Click(object sender, EventArgs e)
        {
            try
            {
                string d = null;
                string dateStart = string.Format("{0:yyyy-MM-dd}", dtp_start.Value);
                string dateEnd = string.Format("{0:yyyy-MM-dd}", dtp_end.Value);
                if (txt_ghichu.Text != null || nud_giamgia.Text != null || txt_tct.Text != null)
                {

                    if (dtp_start.Value == dtp_end.Value)
                    {
                        MessageBox.Show("Thời gian ngày bắt đầu và ngày kết thúc đang trung nhau");
                        return;
                    }
                    foreach (var x in _tendanhMuc)
                    {
                        var a = _iQlKhuyenMai.GetLstCTSP().Where(c=>(c.KhuyenMai !=null && c.KhuyenMai.NgayDau<= dtp_start.Value && c.DanhMuc.TenDanhMuc==x && c.KhuyenMai.NgayHet>=dtp_start.Value)|| (c.KhuyenMai != null && c.KhuyenMai.NgayDau <= dtp_end.Value && c.DanhMuc.TenDanhMuc == x && c.KhuyenMai.NgayHet >= dtp_end.Value)).Select(c=>c.KhuyenMai.MaKM).FirstOrDefault();
                        var b = _iQlKhuyenMai.GetlstKhuyenMais().Where(c => c.MaKM == a).FirstOrDefault();
                        //if ((b != null && b.NgayDau <= Convert.ToDateTime(dateStart) && b.NgayHet >= Convert.ToDateTime(dateStart)) || (b != null && b.NgayDau <= Convert.ToDateTime(dateEnd) && b.NgayHet >= Convert.ToDateTime(dateEnd)))
                        //{
                        //    d = x;
                        //}
                        if (b != null)
                        {
                            d = x;
                            if (MessageBox.Show("Danh muc " + d + " đang được giảm giá\nBạn có muốn tiếp tục tạo khuyến mại trên\nnhưng bỏ danh mục này", "Thông báo", MessageBoxButtons.YesNo)==DialogResult.Yes)
                            {
                                _tendanhMuc.Remove(d);
                            }
                            else
                            {
                                txt_tct.Text = "";
                                txt_ghichu.Text = "";
                                nud_giamgia.Value = 0;
                                return;
                            }


                        }
                    }

                    //for (int i = 0; i < _tendanhMuc.Count; i++)
                    //{
                    //    if (d == _tendanhMuc[i] && d != null)
                    //    {
                    //        DialogResult dialogResult = MessageBox.Show("Danh muc " + d + " đang được giảm giá\nBạn có muốn tiếp tục tạo khuyến mại trên\nnhưng bỏ danh mục này", "Thông báo", MessageBoxButtons.YesNo);
                    //        if (dialogResult == DialogResult.Yes)
                    //        {
                    //            _tendanhMuc.Remove(d);
                    //        }
                    //        else
                    //        {
                    //            txt_tct.Text = "";
                    //            txt_ghichu.Text = "";
                    //            nud_giamgia.Value = 0;
                    //            return;
                    //        }
                    //    }

                    //}
                    KhuyenMai_Bus khuyenMai = new KhuyenMai_Bus();
                    khuyenMai.KhuyenMai.GhiChu = txt_ghichu.Text;
                    khuyenMai.KhuyenMai.GiamGia = Convert.ToInt32(nud_giamgia.Text);
                    khuyenMai.KhuyenMai.MaKM = "KM" + (_iQlKhuyenMai.GetlstKhuyenMais().Count + 1);

                    khuyenMai.KhuyenMai.NgayDau = Convert.ToDateTime(dateStart);

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
                    temb2 = 0;

                }
                else
                {
                    MessageBox.Show("Không được bỏ trống thông tin nào");
                }
            }
            catch (Exception m)
            {
                MessageBox.Show("Lỗi hệ thống");

            }
        }

        void load()
        {
            dgv.Visible = true;
            dgv_km.Visible = false;
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

            if (cbo_danhmuc.Text == "Tất cả")
            {

                foreach (var x in _iQlKhuyenMai.GetKhuyenMais())
                {
                    dgv.Rows.Add(x.SanPham.TenSp + " " + x.ChiTietSanPham.Mota, x.SanPham.ThuongHieu,
                        x.LoaiCoGiay.LoaiCoGiaySP, x.ChatLieu.ChatLieuSP,
                        x.ProductBack.MaPB == "PB1" ? "Đã ẩn" : "Chưa ẩn", x.ChiTietSanPham.MaCTSP);
                }
            }
            else
            {
                foreach (var x in _iQlKhuyenMai.GetKhuyenMaisSearch(cbo_danhmuc.Text))
                {
                    dgv.Rows.Add(x.SanPham.TenSp + " " + x.ChiTietSanPham.Mota, x.SanPham.ThuongHieu,
                        x.LoaiCoGiay.LoaiCoGiaySP, x.ChatLieu.ChatLieuSP,
                        x.ProductBack.MaPB == "PB1" ? "Đã ẩn" : "Chưa ẩn", x.ChiTietSanPham.MaCTSP);
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
            if (column == dgv.Columns["btn_add"].Index)
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
        void loadkm()
        {

            dgv.Visible = false;
            dgv_km.Visible = true;
            dgv_km.ColumnCount = 6;

            dgv_km.Columns[0].Name = "Danh mục";
            dgv_km.Columns[1].Name = "Ngày bắt đầu";
            dgv_km.Columns[2].Name = "Ngày kết thúc";
            dgv_km.Columns[3].Name = "Giảm giá";
            dgv_km.Columns[4].Name = "Trạng thái";
            dgv_km.Columns[5].Name = "mã";
            dgv_km.Columns[5].Visible = false;
            DataGridViewButtonColumn DTThem = new DataGridViewButtonColumn();
            DTThem.Name = "btn_updateKM";
            DTThem.Text = "Sửa";
            DTThem.HeaderText = "";
            DTThem.UseColumnTextForButtonValue = true;
            int indexAdd = 6;
            if (dgv_km.Columns["btn_updateKM"] == null)
            {
                dgv_km.Columns.Insert(indexAdd, DTThem);
            }
            DataGridViewButtonColumn DTRemove = new DataGridViewButtonColumn();
            DTRemove.Name = "btn_stop";
            DTRemove.Text = "Dừng";
            DTRemove.HeaderText = "";
            DTRemove.UseColumnTextForButtonValue = true;
            int indexRemove = 7;
            if (dgv_km.Columns["btn_stop"] == null)
            {
                dgv_km.Columns.Insert(indexRemove, DTRemove);
            }
            dgv_km.Rows.Clear();
            foreach (var x in _iQlKhuyenMai.GetLstCTSP2())
            {
                dgv_km.Rows.Add(x.DanhMuc.TenDanhMuc, x.KhuyenMai.NgayDau, x.KhuyenMai.NgayHet, x.KhuyenMai.GiamGia,
                    (x.KhuyenMai.NgayDau <= DateTime.Today && x.KhuyenMai.NgayHet >= DateTime.Today)
                    && x.KhuyenMai.TrangThai == 1 ? "Đang Khuyến mại" : "Không Khuyến mại"
                                        , x.KhuyenMai.MaKM);
            }
        }


        private void btn_sua_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            loadkm();
        }
        int temb3 = 0;
        private void btn_loc_Click(object sender, EventArgs e)
        {
            if (temb3 == 0)
            {
                load();
                cbo_danhmuc.Visible = true;
                label7.Visible = true;
                temb3 = 1;
            }
            else if (temb3 == 1)
            {
                cbo_danhmuc.Visible = false;
                label7.Visible = false;
                loadkm();
                temb3 = 0;
            }
        }

        private void dgv_km_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int row = e.RowIndex;
            string id = dgv_km.Rows[row].Cells[5].Value.ToString();
            var dt = _iQlKhuyenMai.GetlstKhuyenMais().Where(c => c.MaKM == id).FirstOrDefault();
            if (column == dgv_km.Columns["btn_updateKM"].Index)
            {

                if (MessageBox.Show("Bạn có chắc chắn muốn thực hiện chức năng trên", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string dateStart = string.Format("{0:yyyy-MM-dd}", dgv_km.Rows[row].Cells[1].Value);
                    dt.NgayDau = Convert.ToDateTime(dateStart);
                    string dateEnd = string.Format("{0:yyyy-MM-dd}", dgv_km.Rows[row].Cells[2].Value);
                    dt.NgayHet = Convert.ToDateTime(dateEnd);
                    dt.GiamGia = Convert.ToInt32(dgv_km.Rows[row].Cells[3].Value.ToString());
                    _iQlKhuyenMai.updateKM(dt);
                }

            }
            if (column == dgv_km.Columns["btn_stop"].Index)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn thực hiện chức năng trên", "Thông báo", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    dt.TrangThai = 0;
                    _iQlKhuyenMai.updateKM(dt);
                }

            }
            dgv.Rows.Clear();
            loadkm();
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
