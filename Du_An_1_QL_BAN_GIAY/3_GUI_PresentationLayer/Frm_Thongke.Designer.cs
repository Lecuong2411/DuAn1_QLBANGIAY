
namespace _3_GUI_PresentationLayer
{
    partial class Frm_Thongke
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_GuiThongKe = new System.Windows.Forms.Button();
            this.cbx_Thongke = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_Gio = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_ThongKe = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Tk_TongHD = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.grid_Data = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_hangcannhap = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_thongketheothang = new System.Windows.Forms.Button();
            this.btn_GuiEmail_Tk = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Data)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_GuiThongKe
            // 
            this.btn_GuiThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(128)))), ((int)(((byte)(211)))));
            this.btn_GuiThongKe.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_GuiThongKe.ForeColor = System.Drawing.Color.White;
            this.btn_GuiThongKe.Location = new System.Drawing.Point(1729, 92);
            this.btn_GuiThongKe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_GuiThongKe.Name = "btn_GuiThongKe";
            this.btn_GuiThongKe.Size = new System.Drawing.Size(200, 53);
            this.btn_GuiThongKe.TabIndex = 5;
            this.btn_GuiThongKe.Text = "Ngày";
            this.btn_GuiThongKe.UseVisualStyleBackColor = false;
            this.btn_GuiThongKe.Click += new System.EventHandler(this.btn_GuiThongKe_Click);
            // 
            // cbx_Thongke
            // 
            this.cbx_Thongke.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_Thongke.FormattingEnabled = true;
            this.cbx_Thongke.Location = new System.Drawing.Point(1392, 92);
            this.cbx_Thongke.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbx_Thongke.Name = "cbx_Thongke";
            this.cbx_Thongke.Size = new System.Drawing.Size(313, 53);
            this.cbx_Thongke.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(1395, 13);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(587, 50);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // lbl_Gio
            // 
            this.lbl_Gio.AutoSize = true;
            this.lbl_Gio.ForeColor = System.Drawing.Color.Black;
            this.lbl_Gio.Location = new System.Drawing.Point(49, 333);
            this.lbl_Gio.Name = "lbl_Gio";
            this.lbl_Gio.Size = new System.Drawing.Size(59, 35);
            this.lbl_Gio.TabIndex = 13;
            this.lbl_Gio.Text = "Giờ:";
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(128)))), ((int)(((byte)(211)))));
            this.btn_load.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_load.ForeColor = System.Drawing.Color.White;
            this.btn_load.Location = new System.Drawing.Point(2071, 286);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(153, 71);
            this.btn_load.TabIndex = 14;
            this.btn_load.Text = "Load data";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(131)))), ((int)(((byte)(201)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_ThongKe);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 239);
            this.panel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(88, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 42);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tiền bán hàng";
            // 
            // lbl_ThongKe
            // 
            this.lbl_ThongKe.AutoSize = true;
            this.lbl_ThongKe.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ThongKe.ForeColor = System.Drawing.Color.White;
            this.lbl_ThongKe.Location = new System.Drawing.Point(88, 57);
            this.lbl_ThongKe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ThongKe.Name = "lbl_ThongKe";
            this.lbl_ThongKe.Size = new System.Drawing.Size(209, 49);
            this.lbl_ThongKe.TabIndex = 10;
            this.lbl_ThongKe.Text = ".................";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_3_GUI_PresentationLayer.Properties.Resources.dollar__2_;
            this.pictureBox1.Location = new System.Drawing.Point(-208, -121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(131)))), ((int)(((byte)(201)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbl_Tk_TongHD);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(902, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(458, 239);
            this.panel3.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(136, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 42);
            this.label2.TabIndex = 11;
            this.label2.Text = "Số đơn hàng";
            // 
            // lbl_Tk_TongHD
            // 
            this.lbl_Tk_TongHD.AutoSize = true;
            this.lbl_Tk_TongHD.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Tk_TongHD.ForeColor = System.Drawing.Color.White;
            this.lbl_Tk_TongHD.Location = new System.Drawing.Point(136, 29);
            this.lbl_Tk_TongHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Tk_TongHD.Name = "lbl_Tk_TongHD";
            this.lbl_Tk_TongHD.Size = new System.Drawing.Size(209, 49);
            this.lbl_Tk_TongHD.TabIndex = 10;
            this.lbl_Tk_TongHD.Text = ".................";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::_3_GUI_PresentationLayer.Properties.Resources.shopping_cart1;
            this.pictureBox3.Location = new System.Drawing.Point(-183, -140);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(512, 512);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // grid_Data
            // 
            this.grid_Data.BackgroundColor = System.Drawing.Color.White;
            this.grid_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Data.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid_Data.Location = new System.Drawing.Point(0, 363);
            this.grid_Data.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grid_Data.Name = "grid_Data";
            this.grid_Data.RowHeadersWidth = 51;
            this.grid_Data.RowTemplate.Height = 29;
            this.grid_Data.Size = new System.Drawing.Size(2250, 855);
            this.grid_Data.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbl_hangcannhap);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btn_thongketheothang);
            this.panel2.Controls.Add(this.btn_GuiEmail_Tk);
            this.panel2.Controls.Add(this.grid_Data);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btn_load);
            this.panel2.Controls.Add(this.lbl_Gio);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.cbx_Thongke);
            this.panel2.Controls.Add(this.btn_GuiThongKe);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2250, 1218);
            this.panel2.TabIndex = 17;
            // 
            // lbl_hangcannhap
            // 
            this.lbl_hangcannhap.AutoSize = true;
            this.lbl_hangcannhap.Location = new System.Drawing.Point(38, 273);
            this.lbl_hangcannhap.Name = "lbl_hangcannhap";
            this.lbl_hangcannhap.Size = new System.Drawing.Size(122, 35);
            this.lbl_hangcannhap.TabIndex = 17;
            this.lbl_hangcannhap.Text = "Hàng nhập";
            this.lbl_hangcannhap.Click += new System.EventHandler(this.lbl_hangcannhap_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(131)))), ((int)(((byte)(201)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(456, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(416, 239);
            this.panel4.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tiền Giảm giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(94, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 49);
            this.label5.TabIndex = 10;
            this.label5.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::_3_GUI_PresentationLayer.Properties.Resources.dollar__2_;
            this.pictureBox2.Location = new System.Drawing.Point(-209, -140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(512, 512);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // btn_thongketheothang
            // 
            this.btn_thongketheothang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(128)))), ((int)(((byte)(211)))));
            this.btn_thongketheothang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_thongketheothang.ForeColor = System.Drawing.Color.White;
            this.btn_thongketheothang.Location = new System.Drawing.Point(1936, 92);
            this.btn_thongketheothang.Name = "btn_thongketheothang";
            this.btn_thongketheothang.Size = new System.Drawing.Size(212, 53);
            this.btn_thongketheothang.TabIndex = 16;
            this.btn_thongketheothang.Text = "Tháng";
            this.btn_thongketheothang.UseVisualStyleBackColor = false;
            this.btn_thongketheothang.Click += new System.EventHandler(this.btn_thongketheothang_Click);
            // 
            // btn_GuiEmail_Tk
            // 
            this.btn_GuiEmail_Tk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(128)))), ((int)(((byte)(211)))));
            this.btn_GuiEmail_Tk.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_GuiEmail_Tk.ForeColor = System.Drawing.Color.White;
            this.btn_GuiEmail_Tk.Location = new System.Drawing.Point(1895, 286);
            this.btn_GuiEmail_Tk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_GuiEmail_Tk.Name = "btn_GuiEmail_Tk";
            this.btn_GuiEmail_Tk.Size = new System.Drawing.Size(169, 71);
            this.btn_GuiEmail_Tk.TabIndex = 15;
            this.btn_GuiEmail_Tk.Text = "Gửi mail";
            this.btn_GuiEmail_Tk.UseVisualStyleBackColor = false;
            this.btn_GuiEmail_Tk.Click += new System.EventHandler(this.btn_GuiEmail_Tk_Click);
            // 
            // Frm_Thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2263, 1220);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Frm_Thongke";
            this.Text = "Thống kê";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Data)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_GuiThongKe;
        private System.Windows.Forms.ComboBox cbx_Thongke;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_Gio;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_ThongKe;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Tk_TongHD;
        private System.Windows.Forms.DataGridView grid_Data;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_GuiEmail_Tk;
        private System.Windows.Forms.Button btn_thongketheothang;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_hangcannhap;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}