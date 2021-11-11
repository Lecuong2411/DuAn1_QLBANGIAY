using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_BarCode : Form
    {
      
        public Frm_BarCode()
        {
            InitializeComponent();
         load();    
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void load()
        {
            BarcodeWriter brCode = new BarcodeWriter()
            {
                Format = BarcodeFormat.CODE_128
            };
            pictureBox1.Image = brCode.Write(Frm_sanpham._barcode);
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog fileDialog = new SaveFileDialog() { Filter = "PNG|*.png"})
            {
                if (fileDialog.ShowDialog()==DialogResult.Yes)
                {
                    pictureBox1.Image.Save(fileDialog.FileName);
                }   
            }
        }
    }
}
