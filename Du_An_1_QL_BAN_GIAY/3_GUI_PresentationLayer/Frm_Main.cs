﻿using System;
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
        private Button corenbutton;
        private Random Random;
        private int tempindex;
        private Form GetForm;
        public Frm_Main()
        {
            InitializeComponent();
            btn_close.Visible = false;
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
            openchilForm(new FrmThongtinVoucher(), sender);
        }

        private void btn_khuyenmai_Click(object sender, EventArgs e)
        {
            openchilForm(new Frm_KhuyenMai(), sender);
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
           
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
    }
}
