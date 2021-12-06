using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IService;
using _2_BUS_BusinessLayer.Service;
using Image = System.Drawing.Image;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_Nhanvien : Form
    {
        private I_QLNhanVien I_ServiceQLNhanVien;
        private NhanVien _NhanVien;
        private ChucVu _ChucVu;
        private string Iwhenclick;
        private string checkUrlImage; // kiểm tra tình trạng annhr khi cập nhật 
        private string fileName; //tên file ảnh
        private string fileSavePath; // url Thư mục ảnh
        private string fileAddress; // url load ảnh
        public Frm_Nhanvien()
        {
            InitializeComponent();
            I_ServiceQLNhanVien = new Service_QLNhanVien();
            loadDL();
            LoadChucVu();
            cbx_TimKiem.Items.Add("TenNV");
            cbx_TimKiem.Items.Add("SDT");
        }

        #region Load dữ liệu 

        void LoadChucVu()
        {
            foreach (var x in I_ServiceQLNhanVien.GetlstChucVu())
            {
                cbx_ChucVu.Items.Add(x.Roles);
            }
            cbx_ChucVu.SelectedIndex = 0;
        }
        public void loadDL()
        {

            GridView_NV.ColumnCount = 11;
            GridView_NV.Columns[0].Name = "MaNV";
            GridView_NV.Columns[0].Visible = false;
            GridView_NV.Columns[1].Name = "Tên NV";
            GridView_NV.Columns[2].Name = "Số điện thoại";
            GridView_NV.Columns[3].Name = "Địa chỉ";
            GridView_NV.Columns[4].Name = "Email";
            GridView_NV.Columns[5].Name = "Mật khẩu";
            GridView_NV.Columns[5].Visible = false;
            GridView_NV.Columns[6].Name = "Giới tính";
            GridView_NV.Columns[7].Name = "Năm sinh";
            GridView_NV.Columns[8].Name = "Chức vụ";
            GridView_NV.Columns[9].Name = "link Ảnh";
            GridView_NV.Columns[10].Name = "Trạng thái";

            DataGridViewComboBoxColumn Grid_Cbx_Colum = new DataGridViewComboBoxColumn();
            Grid_Cbx_Colum.Name = "Cbx";
            Grid_Cbx_Colum.HeaderText = "Chức năng";
            Grid_Cbx_Colum.Items.Add("Thêm");
            Grid_Cbx_Colum.Items.Add("Sửa");
            int Index_Cbx = 11;
            if (GridView_NV.Columns["Cbx"] == null)
            {
                GridView_NV.Columns.Insert(Index_Cbx, Grid_Cbx_Colum);
            }

            DataGridViewButtonColumn Grid_btn_Colum = new DataGridViewButtonColumn();
            Grid_btn_Colum.Name = "button";
            Grid_btn_Colum.HeaderText = "Xác nhận";
            Grid_btn_Colum.Text = "Xác nhận";
            Grid_btn_Colum.UseColumnTextForButtonValue = true;
            int index_button = 12;
            if (GridView_NV.Columns["button"] == null)
            {
                GridView_NV.Columns.Insert(index_button, Grid_btn_Colum);
            }

            GridView_NV.Rows.Clear();
            foreach (var x in I_ServiceQLNhanVien.GetlstNhanVien())
            {
                GridView_NV.Rows.Add(x.MaNv, x.TenNv, x.Sdt, x.DiaChi, x.Email, x.MatKhau, x.GioiTinh == 1 ? "Nam" : "Nữ",
                    x.NamSinh,
                    I_ServiceQLNhanVien.GetlstChucVu().Where(c => c.MaChucVu == x.MaChucVu)
                        .Select(z => z.Roles == 1 ? "Nhân viên" : "Quản lý").FirstOrDefault(),
                    x.HinhAnh, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }

        }

        public void LoadTimKiem_TenNV(string tenNV)
        {
            GridView_NV.ColumnCount = 11;
            GridView_NV.Columns[0].Name = "MaNV";
            GridView_NV.Columns[1].Name = "Tên NV";
            GridView_NV.Columns[2].Name = "Số điện thoại";
            GridView_NV.Columns[3].Name = "Địa chỉ";
            GridView_NV.Columns[4].Name = "Email";
            GridView_NV.Columns[5].Name = "Mật khẩu";
            GridView_NV.Columns[6].Name = "Giới tính";
            GridView_NV.Columns[7].Name = "Năm sinh";
            GridView_NV.Columns[8].Name = "Chức vụ";
            GridView_NV.Columns[9].Name = "link Ảnh";
            GridView_NV.Columns[10].Name = "Trạng thái";
            GridView_NV.Rows.Clear();
            I_ServiceQLNhanVien.TimKiemTen_NV(tenNV).ForEach(x =>
                {
                    GridView_NV.Rows.Add(x.MaNv, x.TenNv, x.Sdt, x.DiaChi, x.Email, x.MatKhau, x.GioiTinh == 1 ? "Nam" : "Nữ",
                        x.NamSinh,
                        I_ServiceQLNhanVien.GetlstChucVu().Where(c => c.MaChucVu == x.MaChucVu)
                            .Select(z => z.Roles == 1 ? "Nhân Viên" : "Quản lý").FirstOrDefault(),
                        x.HinhAnh, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
                }
            );
        }

        public void LoadTimKiem_SdtNV(string sdt)
        {
            GridView_NV.ColumnCount = 11;
            GridView_NV.Columns[0].Name = "MaNV";
            GridView_NV.Columns[1].Name = "Tên NV";
            GridView_NV.Columns[2].Name = "Số điện thoại";
            GridView_NV.Columns[3].Name = "Địa chỉ";
            GridView_NV.Columns[4].Name = "Email";
            GridView_NV.Columns[5].Name = "Mật khẩu";
            GridView_NV.Columns[6].Name = "Giới tính";
            GridView_NV.Columns[7].Name = "Năm sinh";
            GridView_NV.Columns[8].Name = "Chức vụ";
            GridView_NV.Columns[9].Name = "link Ảnh";
            GridView_NV.Columns[10].Name = "Trạng thái";
            GridView_NV.Rows.Clear();
            I_ServiceQLNhanVien.TimKiem_SDT(sdt).ForEach(x =>
                {
                    GridView_NV.Rows.Add(x.MaNv, x.TenNv, x.Sdt, x.DiaChi, x.Email, x.MatKhau, x.GioiTinh == 1 ? "Nam" : "Nữ",
                        x.NamSinh,
                        I_ServiceQLNhanVien.GetlstChucVu().Where(c => c.MaChucVu == x.MaChucVu)
                            .Select(z => z.Roles == 1 ? "Nhân Viên" : "Quản lý").FirstOrDefault(),
                        x.HinhAnh, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
                }
            );

        }

        #endregion

        #region Untility

        public string MaHoaMK(string matkhau)
        {
            MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            encrypt = MD5.ComputeHash(encode.GetBytes(matkhau));
            StringBuilder encryptdata = new StringBuilder();
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }

            return encryptdata.ToString();
        }

        public void Sendmail(string email, string matkhau)
        {
            try
            {
                SmtpClient emailNguon = new SmtpClient("smtp.gmail.com", 25);
                NetworkCredential cret = new NetworkCredential("levanhoc001@gmail.com", "0964046838");
                MailMessage mag = new MailMessage();
                mag.From = new MailAddress(email);
                mag.To.Add(email);
                mag.Subject = "Đang sử dụng chức năng quên mật khẩu";
                mag.Body = "mật khẩu mới là : " + matkhau;
                emailNguon.Credentials = cret;
                emailNguon.EnableSsl = true;
                emailNguon.Send(mag);

            }
            catch (Exception)
            {

                return;
            }

        }

        public void clear()
        {
            txt_HoTen.Text = "";
            txt_DiaChi.Text = "";
            txt_Link_Img.Text = "";
            txt_NamSinh.Text = "";
            txt_SĐT.Text = "";
            txt_email.Text = "";
            rbt_Nam.Checked = false;
            rbt_Nu.Checked = false;
            cbx_ChucVu.SelectedIndex = 0;
        }

        public void xuatExcel(string path, DataGridView Grid_DataNhanVien)
        {

            if (Grid_DataNhanVien.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
                application.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < Grid_DataNhanVien.Columns.Count + 1; i++)
                {
                    application.Cells[1, i] = Grid_DataNhanVien.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < Grid_DataNhanVien.Rows.Count; i++)
                {
                    for (int j = 0; j < Grid_DataNhanVien.Columns.Count; j++)
                    {
                        application.Cells[i + 2, j + 1] = Grid_DataNhanVien.Rows[i].Cells[j].Value;
                    }
                }

                application.Columns.AutoFit();
                application.Visible = true;
                application.ActiveWorkbook.SaveCopyAs(path);
                application.ActiveWorkbook.Saved = true;
            }
        }

        public void ChechDuLieuVao()
        {
            if (txt_HoTen.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn chưa nhập họ và tên ");
                txt_HoTen.Focus();
            }else if (txt_email.Text.Trim().Length == 0 )
            {
                MessageBox.Show("Bạn chưa nhập email hoặc email đã được sử dụng ");
                txt_email.Focus();
                if (I_ServiceQLNhanVien.GetlstNhanVien().Any(c => c.Email == txt_email.Text))
                {
                    MessageBox.Show(" email đã được sử dụng , hãy nhập email khác ");
                }
            }
            else if (rbt_Nam.Checked==false && rbt_Nu.Checked == false)
            {
                MessageBox.Show("bạn chưa chọn giới tính ");
                rbt_Nam.Focus();
                rbt_Nu.Focus();
            }
            else if (txt_NamSinh.Text.Trim().Length == 0 )
            {
                MessageBox.Show("bạn hãy điền năm sinh đúng định dạng");
                txt_NamSinh.Focus();
            }else if (txt_SĐT.Text.Trim().Length == 0 )
            {
                MessageBox.Show("Lưu ý chưa điền sđt hoặc chưa đúng định dạng");
                txt_SĐT.Focus();
            }
            else if (txt_DiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa điền địa chỉ ");
                txt_DiaChi.Focus();
            }
            else if (chk_HoatDong.Checked==false && chk_KhongHoatDong.Checked == false)
            {
                MessageBox.Show("hãy chọn chức vụ cho nhân viên ");
                chk_HoatDong.Focus();
                
            }
            else if (txt_Link_Img.Text.Trim().Length == 0)
            {
                MessageBox.Show("thêm ảnh cho nhân viên  ");
                txt_Link_Img.Focus();
            }
            else
            {
                MessageBox.Show("điền đủ dữ liệu ");
            }
        }

        #endregion


        #region Button

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ChechDuLieuVao();
            try
            {
                _NhanVien = new NhanVien();
                var MaRole = I_ServiceQLNhanVien.GetlstChucVu().Where(c => c.Roles == Convert.ToInt32(cbx_ChucVu.Text))
                    .Select(c => c.MaChucVu).FirstOrDefault();
                _ChucVu = new ChucVu();

                _NhanVien.MaNv = "PH_" + I_ServiceQLNhanVien.GetlstNhanVien().Count + 1;
                _NhanVien.TenNv = txt_HoTen.Text;
                _NhanVien.Sdt = txt_SĐT.Text;
                _NhanVien.DiaChi = txt_DiaChi.Text;
                _NhanVien.Email = txt_email.Text;
                _NhanVien.MatKhau = MaHoaMK("Anh2002");
                _NhanVien.GioiTinh = rbt_Nam.Checked == true ? 1 : 0;
                _NhanVien.NamSinh = Convert.ToInt32(txt_NamSinh.Text);
                _NhanVien.MaChucVu = MaRole;
                _NhanVien.HinhAnh = txt_Link_Img.Text;
                _NhanVien.TrangThai = chk_HoatDong.Checked == true ? 1 : 0;
                I_ServiceQLNhanVien.AddNhanVien(_NhanVien);
                MessageBox.Show("Thêm thành công");
                Sendmail(txt_email.Text, "Anh2002");
                MessageBox.Show("Đã gửi Email mật khẩu cho nhân viên");
                File.Copy(fileAddress, fileSavePath, true);
                loadDL();
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Xác nhận clear ", "Caption", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clear();
            }
        }

        private void btn_xuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    xuatExcel(saveFileDialog.FileName, GridView_NV);
                    MessageBox.Show("Xuất file thành công");
                }
                catch (Exception x)
                {
                    MessageBox.Show("Xuất file không thành công \n " + x.Message);
                }
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát", "Caption", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void GridView_NV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 26));
                var RowIndex = e.RowIndex;
                if (RowIndex < 0 || RowIndex == I_ServiceQLNhanVien.GetlstNhanVien().Count) return;

                Iwhenclick = (string)GridView_NV.Rows[RowIndex].Cells[0].Value;
                txt_HoTen.Text = GridView_NV.Rows[RowIndex].Cells[1].Value.ToString();
                txt_SĐT.Text = GridView_NV.Rows[RowIndex].Cells[2].Value.ToString();
                txt_DiaChi.Text = GridView_NV.Rows[RowIndex].Cells[3].Value.ToString();
                txt_email.Text = GridView_NV.Rows[RowIndex].Cells[4].Value.ToString();
                if (GridView_NV.Rows[RowIndex].Cells[6].Value.ToString() == "Nam")
                {
                    rbt_Nam.Checked = true;
                }
                else
                {
                    rbt_Nu.Checked = true;
                }
                txt_NamSinh.Text = GridView_NV.Rows[RowIndex].Cells[7].Value.ToString();
                cbx_ChucVu.Text = GridView_NV.Rows[RowIndex].Cells[8].Value.ToString();
                txt_Link_Img.Text = GridView_NV.Rows[RowIndex].Cells[9].Value.ToString();
                if (GridView_NV.Rows[RowIndex].Cells[10].Value.ToString() == "Hoạt động")
                {
                    chk_HoatDong.Checked = true;
                }
                else
                {
                    chk_KhongHoatDong.Checked = true;
                }
                checkUrlImage = txt_Link_Img.Text;// giữ đường dẫn file ảnh
                ptx_HinhAnh.Image = Image.FromFile(saveDirectory + GridView_NV.Rows[RowIndex].Cells[9].Value.ToString());

                if (e.ColumnIndex == GridView_NV.Columns["Button"].Index && GridView_NV.Rows[RowIndex].Cells[11].Value.ToString() == "Thêm")
                {
                    try
                    {
                        _NhanVien = new NhanVien();
                        _ChucVu = new ChucVu();

                        _NhanVien.MaNv = "PH_" + I_ServiceQLNhanVien.GetlstNhanVien().Count + 1;
                        _NhanVien.TenNv = txt_HoTen.Text;
                        _NhanVien.Sdt = txt_SĐT.Text;
                        _NhanVien.DiaChi = txt_DiaChi.Text;
                        _NhanVien.Email = txt_email.Text;
                        _NhanVien.MatKhau = MaHoaMK("Anh2002");
                        _NhanVien.GioiTinh = rbt_Nam.Checked == true ? 1 : 0;
                        _NhanVien.NamSinh = Convert.ToInt32(txt_NamSinh.Text);
                        _NhanVien.MaChucVu = I_ServiceQLNhanVien.GetlstChucVu().FirstOrDefault(c => c.MaChucVu == cbx_ChucVu.Text).ToString();
                        _NhanVien.HinhAnh = txt_Link_Img.Text;
                        _NhanVien.TrangThai = chk_HoatDong.Checked == true ? 1 : 0;
                        I_ServiceQLNhanVien.AddNhanVien(_NhanVien);
                        MessageBox.Show("Thêm thành công");
                        Sendmail(txt_email.Text, "Anh2002");
                        MessageBox.Show("Đã gửi Email mật khẩu cho nhân viên");
                        loadDL();
                    }
                    catch (Exception o)
                    {
                        Console.WriteLine(o.Message);
                    }
                }
                else if (e.ColumnIndex == GridView_NV.Columns["Button"].Index && GridView_NV.Rows[RowIndex].Cells[11].Value.ToString() == "Sửa")
                {
                    try
                    {
                        if (MessageBox.Show("Xác nhận muôn sửa", "Caption", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            _NhanVien = new NhanVien();
                            _NhanVien = I_ServiceQLNhanVien.GetlstNhanVien().Find(c => c.MaNv == Iwhenclick);
                            _NhanVien.TenNv = txt_HoTen.Text;
                            _NhanVien.Sdt = txt_SĐT.Text;
                            _NhanVien.DiaChi = txt_DiaChi.Text;
                            _NhanVien.Email = txt_email.Text;
                            _NhanVien.GioiTinh = rbt_Nam.Checked == true ? 1 : 0;
                            _NhanVien.NamSinh = Convert.ToInt32(txt_NamSinh.Text);
                            I_ServiceQLNhanVien.UpdateNhanVien(_NhanVien);
                            MessageBox.Show("Sửa thành công");
                            loadDL();
                            clear();

                        }
                    }
                    catch (Exception p)
                    {
                        Console.WriteLine(p.Message);
                    }
                }
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
        }
        private void btn_moAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Filter = "Bitmap(.bmp)|*bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            opFile.FilterIndex = 2;
            opFile.Title = "Chọn ảnh nhân viên";
            if (opFile.ShowDialog() == DialogResult.OK)
            {
                fileAddress = opFile.FileName;
                ptx_HinhAnh.Image = Image.FromFile(fileAddress);
                fileName = Path.GetFileName(opFile.FileName);
                string saveDiretory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 26));
                fileSavePath = saveDiretory + "\\Img\\" + fileName;
                txt_Link_Img.Text = "\\Img\\" + fileName;
            }
        }

        private void txt_TimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (cbx_TimKiem.Text == "SDT")
            {
                LoadTimKiem_SdtNV(txt_TimKiem.Text);
            }
            else if (cbx_TimKiem.Text == "TenNV")
            {
                LoadTimKiem_TenNV(txt_TimKiem.Text);
            }
        }

        #endregion
    }
}
