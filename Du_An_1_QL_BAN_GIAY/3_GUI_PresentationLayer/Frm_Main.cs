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
    public partial class Frm_Main : Form
    {
        private I_Login login;
        public static string mail;
        Frm_trangchu frm_Trangchu = new Frm_trangchu();
        Frm_banhang frm_Banhang = new Frm_banhang();
        Frm_sanpham frm_Sanpham = new Frm_sanpham();
        Frm_Thongke frm_Thongke = new Frm_Thongke();
        Frm_Nhanvien frm_Nhanvien = new Frm_Nhanvien();
        FrmDanhSachHoaDonBanHang frmDanhSachHoaDonBanHang = new FrmDanhSachHoaDonBanHang();
        private Button corenbutton;
        private Random Random;
        private int tempindex;
        private Form GetForm;
        public Frm_Main()
        {
            InitializeComponent();
            login = new Login();
            btn_close.Visible = false;
            timer1.Enabled = true;
            timer1.Start();
            label2.Text = DateTime.Now.ToLongDateString() + "\n" + DateTime.Now.ToLongTimeString();
           
        }



        private void Actionbutton(object btnsender)
        {
            if (btnsender!=null)
            {
                if (corenbutton!=(Button)btnsender)
                {
                    corenbutton = (Button)btnsender;
                    corenbutton.ForeColor = Color.White;
                    btn_close.Visible = true;

                }  
            }
        }
      private void openchilForm(Form chilform,object btnsender)
        {
            if (GetForm!=null)
            {
                GetForm.Close();
            }
            Actionbutton(btnsender);
            GetForm = chilform;
            chilform.TopLevel = false;
            chilform.FormBorderStyle = FormBorderStyle.None;
            chilform.Dock = DockStyle.Fill;
            this.pal_destop.Controls.Add(chilform);
            this.pal_destop.Tag = chilform;
            chilform.BringToFront();
            chilform.Show();
            lbl_tille.Text = chilform.Text;
        }

     
        private void btn_banhang_Click(object sender, EventArgs e)
        {

            openchilForm(new Frm_banhang(), sender);
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            openchilForm(new FrmDanhSachHoaDonBanHang(), sender);
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            openchilForm(new Frm_sanpham(), sender);
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            openchilForm(new Frm_Nhanvien(), sender);
        }

        private void btn_voucher_Click(object sender, EventArgs e)
        {
            openchilForm(new Frm_Vouchers(), sender);
        }

        private void btn_khuyenmai_Click(object sender, EventArgs e)
        {
            openchilForm(new Frm_KhuyenMai(), sender);
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            openchilForm(new Frm_Thongke(), sender);
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Login a = new Frm_Login();
            a.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (GetForm != null)
                GetForm.Close();
            Reset();
        }
        private void Reset()
        {
            lbl_tille.Text = "HOME";
            corenbutton = null;
            btn_close.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString() + "\n" + DateTime.Now.ToLongTimeString();
           
        }
        public void trangthai()
        {


            btn_banhang.Enabled = true;
            btn_hoadon.Enabled = true;
            btn_khuyenmai.Enabled = true;
            btn_nhanvien.Enabled = true;
            btn_sanpham.Enabled = true;
            btn_thongke.Enabled = true;
            btn_voucher.Enabled = true;
            btn_dangxuat.Enabled = true;
            if (login.layVaitro(Frm_Main.mail) == 1)
            {
                btn_khuyenmai.Visible = false;
                btn_nhanvien.Visible = false;
                btn_voucher.Visible = false;
            }

        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            trangthai();
        }
    }
}
