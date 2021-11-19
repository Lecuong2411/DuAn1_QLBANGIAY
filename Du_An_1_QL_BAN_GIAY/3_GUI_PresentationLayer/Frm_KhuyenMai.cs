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

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_KhuyenMai : Form
    {
        private IQlKhuyenMai _iQlKhuyenMai;
        public Frm_KhuyenMai()
        {
            InitializeComponent();
            _iQlKhuyenMai = new QlKhuyenMai();
            load();
        }

        void load()
        {
            dgv.ColumnCount = 4;
            dgv.Columns[0].Name = "Danh mục";
            dgv.Columns[1].Name = "Tên sản phẩm";
            dgv.Columns[2].Name = "Thương hiệu";
            dgv.Columns[3].Name = "Trạng thái";
            dgv.Rows.Clear();
            foreach (var x in _iQlKhuyenMai.GetKhuyenMais())
            {
                dgv.Rows.Add(x.DanhMuc.TenDanhMuc, x.SanPham.TenSp + " " + x.ChiTietSanPham.Mota, x.SanPham.ThuongHieu,
                    x.ChiTietSanPham.TrangThai ==1 ? "Còn hàng": "Hết hàng");
            }
        }
    }
}
