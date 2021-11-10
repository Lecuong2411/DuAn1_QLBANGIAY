using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_Main : Form
    {
        Frm_trangchu frm_Trangchu = new Frm_trangchu();
        Frm_banhang frm_Banhang = new Frm_banhang();
        Frm_sanpham frm_Sanpham = new Frm_sanpham();
        Frm_Thongke frm_Thongke = new Frm_Thongke();
        Frm_Nhanvien frm_Nhanvien = new Frm_Nhanvien();
        FrmDanhSachHoaDonBanHang frmDanhSachHoaDonBanHang = new FrmDanhSachHoaDonBanHang();
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            btn_trangchu.PerformClick();
            foreach (Control x in fip_Menuleft.Controls)
                x.Width = fip_Menuleft.Width;
             
        }
        private void MenuClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            lbl_tieude.Text = btn.Tag.ToString();
            foreach (Control x  in fip_Menuleft.Controls)
            {
                x.BackColor = fip_Menuleft.BackColor;
                if (btn.Name!=btn_help.Name)
                {
                    btn_help.BackColor = fip_Menuleft.BackColor;
                }
                btn.BackColor = Color.DodgerBlue;

            }
            if (btn.Name == btn_trangchu.Name)
            {
                formshow(frm_Trangchu);
            }
            if (btn.Name == btn_banhang.Name)
            {
                formshow(frm_Banhang);
            }
            if (btn.Name == btn_sanpham.Name)
            {
                formshow(frm_Sanpham);
            }
            if (btn.Name == btn_thongke.Name)
            {
                formshow(frm_Thongke);
            } 
            if (btn.Name == btn_nhanvien.Name)
            {
                formshow(frm_Nhanvien);
            }
            if (btn.Name== btn_dsHoadon.Name)
            {
                formshow(frmDanhSachHoaDonBanHang);
            }



        }
        private void formshow(Form form)
        {
            pnl_main.Controls.Clear();
            form.TopLevel = false;
            pnl_main.Controls.Add(form);
         
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

     

        private void btn_min_Click(object sender, EventArgs e)
        {
            pnl_MenuLeft.Width = (pnl_MenuLeft.Width == 452) ? 55 : 452;
        }
    }
}
