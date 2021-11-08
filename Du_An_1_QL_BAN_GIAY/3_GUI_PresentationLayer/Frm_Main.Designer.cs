
namespace _3_GUI_PresentationLayer
{
    partial class Frm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.pnl_MenuLeft = new System.Windows.Forms.Panel();
            this.fip_Menuleft = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_trangchu = new System.Windows.Forms.Button();
            this.btn_banhang = new System.Windows.Forms.Button();
            this.btn_sanpham = new System.Windows.Forms.Button();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.btn_nhanvien = new System.Windows.Forms.Button();
            this.pnl_MenuRight = new System.Windows.Forms.Panel();
            this.lbl_user = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_tieude = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.pnl_MenuLeft.SuspendLayout();
            this.fip_Menuleft.SuspendLayout();
            this.pnl_MenuRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_MenuLeft
            // 
            this.pnl_MenuLeft.BackColor = System.Drawing.Color.Gray;
            this.pnl_MenuLeft.Controls.Add(this.fip_Menuleft);
            this.pnl_MenuLeft.Controls.Add(this.pnl_MenuRight);
            this.pnl_MenuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_MenuLeft.ForeColor = System.Drawing.Color.White;
            this.pnl_MenuLeft.Location = new System.Drawing.Point(0, 67);
            this.pnl_MenuLeft.Name = "pnl_MenuLeft";
            this.pnl_MenuLeft.Size = new System.Drawing.Size(452, 934);
            this.pnl_MenuLeft.TabIndex = 0;
            // 
            // fip_Menuleft
            // 
            this.fip_Menuleft.Controls.Add(this.btn_trangchu);
            this.fip_Menuleft.Controls.Add(this.btn_banhang);
            this.fip_Menuleft.Controls.Add(this.btn_sanpham);
            this.fip_Menuleft.Controls.Add(this.btn_thongke);
            this.fip_Menuleft.Controls.Add(this.btn_nhanvien);
            this.fip_Menuleft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fip_Menuleft.Location = new System.Drawing.Point(0, 301);
            this.fip_Menuleft.Name = "fip_Menuleft";
            this.fip_Menuleft.Size = new System.Drawing.Size(452, 633);
            this.fip_Menuleft.TabIndex = 8;
            // 
            // btn_trangchu
            // 
            this.btn_trangchu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_trangchu.FlatAppearance.BorderSize = 0;
            this.btn_trangchu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_trangchu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_trangchu.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_trangchu.Image = global::_3_GUI_PresentationLayer.Properties.Resources.xxx;
            this.btn_trangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_trangchu.Location = new System.Drawing.Point(3, 3);
            this.btn_trangchu.Name = "btn_trangchu";
            this.btn_trangchu.Size = new System.Drawing.Size(449, 53);
            this.btn_trangchu.TabIndex = 5;
            this.btn_trangchu.Tag = "Trang chủ";
            this.btn_trangchu.Text = "Trang chủ";
            this.btn_trangchu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_trangchu.UseVisualStyleBackColor = false;
            this.btn_trangchu.Click += new System.EventHandler(this.MenuClick);
            // 
            // btn_banhang
            // 
            this.btn_banhang.FlatAppearance.BorderSize = 0;
            this.btn_banhang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_banhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_banhang.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_banhang.Image = global::_3_GUI_PresentationLayer.Properties.Resources.xxx;
            this.btn_banhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_banhang.Location = new System.Drawing.Point(3, 62);
            this.btn_banhang.Name = "btn_banhang";
            this.btn_banhang.Size = new System.Drawing.Size(449, 53);
            this.btn_banhang.TabIndex = 4;
            this.btn_banhang.Tag = "Bán hàng";
            this.btn_banhang.Text = "Bán hàng";
            this.btn_banhang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_banhang.UseVisualStyleBackColor = false;
            this.btn_banhang.Click += new System.EventHandler(this.MenuClick);
            // 
            // btn_sanpham
            // 
            this.btn_sanpham.FlatAppearance.BorderSize = 0;
            this.btn_sanpham.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_sanpham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sanpham.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sanpham.Image = global::_3_GUI_PresentationLayer.Properties.Resources.xxx;
            this.btn_sanpham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sanpham.Location = new System.Drawing.Point(3, 121);
            this.btn_sanpham.Name = "btn_sanpham";
            this.btn_sanpham.Size = new System.Drawing.Size(449, 53);
            this.btn_sanpham.TabIndex = 7;
            this.btn_sanpham.Tag = "Sản Phẩm";
            this.btn_sanpham.Text = "Sản Phẩm";
            this.btn_sanpham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sanpham.UseVisualStyleBackColor = true;
            this.btn_sanpham.Click += new System.EventHandler(this.MenuClick);
            // 
            // btn_thongke
            // 
            this.btn_thongke.FlatAppearance.BorderSize = 0;
            this.btn_thongke.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_thongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thongke.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_thongke.Image = global::_3_GUI_PresentationLayer.Properties.Resources.xxx;
            this.btn_thongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thongke.Location = new System.Drawing.Point(3, 180);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(449, 53);
            this.btn_thongke.TabIndex = 6;
            this.btn_thongke.Tag = "Thống kê";
            this.btn_thongke.Text = "Thống kê";
            this.btn_thongke.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thongke.UseVisualStyleBackColor = true;
            this.btn_thongke.Click += new System.EventHandler(this.MenuClick);
            // 
            // btn_nhanvien
            // 
            this.btn_nhanvien.FlatAppearance.BorderSize = 0;
            this.btn_nhanvien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_nhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nhanvien.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_nhanvien.Image = global::_3_GUI_PresentationLayer.Properties.Resources.xxx;
            this.btn_nhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhanvien.Location = new System.Drawing.Point(3, 239);
            this.btn_nhanvien.Name = "btn_nhanvien";
            this.btn_nhanvien.Size = new System.Drawing.Size(449, 53);
            this.btn_nhanvien.TabIndex = 8;
            this.btn_nhanvien.Tag = "Nhân viên";
            this.btn_nhanvien.Text = "Nhân viên";
            this.btn_nhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nhanvien.UseVisualStyleBackColor = true;
            this.btn_nhanvien.Click += new System.EventHandler(this.MenuClick);
            // 
            // pnl_MenuRight
            // 
            this.pnl_MenuRight.Controls.Add(this.lbl_user);
            this.pnl_MenuRight.Controls.Add(this.pictureBox4);
            this.pnl_MenuRight.Controls.Add(this.btn_help);
            this.pnl_MenuRight.Controls.Add(this.btn_min);
            this.pnl_MenuRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_MenuRight.Location = new System.Drawing.Point(0, 0);
            this.pnl_MenuRight.Name = "pnl_MenuRight";
            this.pnl_MenuRight.Size = new System.Drawing.Size(452, 301);
            this.pnl_MenuRight.TabIndex = 2;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_user.Location = new System.Drawing.Point(222, 210);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(138, 55);
            this.lbl_user.TabIndex = 6;
            this.lbl_user.Text = "label1";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(57, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(395, 165);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // btn_help
            // 
            this.btn_help.FlatAppearance.BorderSize = 0;
            this.btn_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_help.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_help.Location = new System.Drawing.Point(-3, 65);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(54, 53);
            this.btn_help.TabIndex = 3;
            this.btn_help.Tag = "Trợ giúp";
            this.btn_help.Text = "?";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.MenuClick);
            // 
            // btn_min
            // 
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_min.Location = new System.Drawing.Point(0, 3);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(54, 53);
            this.btn_min.TabIndex = 2;
            this.btn_min.Text = "☰";
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // pnl_Top
            // 
            this.pnl_Top.Controls.Add(this.label1);
            this.pnl_Top.Controls.Add(this.lbl_tieude);
            this.pnl_Top.Controls.Add(this.pictureBox2);
            this.pnl_Top.Controls.Add(this.pictureBox1);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(1853, 67);
            this.pnl_Top.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1721, 2);
            this.label1.TabIndex = 2;
            // 
            // lbl_tieude
            // 
            this.lbl_tieude.AutoSize = true;
            this.lbl_tieude.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_tieude.Location = new System.Drawing.Point(3, 3);
            this.lbl_tieude.Name = "lbl_tieude";
            this.lbl_tieude.Size = new System.Drawing.Size(123, 55);
            this.lbl_tieude.TabIndex = 5;
            this.lbl_tieude.Text = "Main";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1721, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::_3_GUI_PresentationLayer.Properties.Resources.xxx;
            this.pictureBox1.Location = new System.Drawing.Point(1787, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnl_main
            // 
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(452, 67);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1401, 934);
            this.pnl_main.TabIndex = 2;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1853, 1001);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.pnl_MenuLeft);
            this.Controls.Add(this.pnl_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.pnl_MenuLeft.ResumeLayout(false);
            this.fip_Menuleft.ResumeLayout(false);
            this.pnl_MenuRight.ResumeLayout(false);
            this.pnl_MenuRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_MenuLeft;
      
        private System.Windows.Forms.Button btn_sanpham;
        private System.Windows.Forms.Button btn_thongke;
        private System.Windows.Forms.Button btn_trangchu;
        private System.Windows.Forms.Button btn_banhang;
        private System.Windows.Forms.Panel pnl_MenuRight;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tieude;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.FlowLayoutPanel fip_Menuleft;
        private System.Windows.Forms.Button btn_nhanvien;
        private System.Windows.Forms.Panel pnl_main;
    }
}

