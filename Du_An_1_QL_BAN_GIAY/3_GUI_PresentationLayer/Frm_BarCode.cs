using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save Image As";
            sfd.Filter = "Image file (*.jpg ,*png) | *.jpg; *.png";
            ImageFormat imageFormat = ImageFormat.Png;
            if (sfd.ShowDialog()==DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        imageFormat = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        imageFormat = ImageFormat.Bmp;
                        break;
                }
                pictureBox1.Image.Save(sfd.FileName,imageFormat);
            }
        }
    }
}
