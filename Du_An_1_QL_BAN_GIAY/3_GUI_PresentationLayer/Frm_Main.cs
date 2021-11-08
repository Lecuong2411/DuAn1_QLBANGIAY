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
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            btn_main.PerformClick();
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
