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
    public partial class Frm_soluong : Form
    {
        public static int soluong =1;
        public Frm_soluong(int sl)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            soluong = int.Parse(tbx_soluong.Text);
            this.Close();
        }
    }
}
