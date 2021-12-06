
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
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_Gio = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_ThongKe = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Tk_TongHD = new System.Windows.Forms.Label();
            this.grid_Data = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_hangcannhap = new System.Windows.Forms.Label();
            this.btn_GuiEmail_Tk = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Data)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_GuiThongKe
            // 
            this.btn_GuiThongKe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_GuiThongKe.Location = new System.Drawing.Point(339, 131);
            this.btn_GuiThongKe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_GuiThongKe.Name = "btn_GuiThongKe";
            this.btn_GuiThongKe.Size = new System.Drawing.Size(116, 38);
            this.btn_GuiThongKe.TabIndex = 5;
            this.btn_GuiThongKe.Text = "Input";
            this.btn_GuiThongKe.UseVisualStyleBackColor = true;
            this.btn_GuiThongKe.Click += new System.EventHandler(this.btn_GuiThongKe_Click);
            // 
            // cbx_Thongke
            // 
            this.cbx_Thongke.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_Thongke.FormattingEnabled = true;
            this.cbx_Thongke.Location = new System.Drawing.Point(101, 131);
            this.cbx_Thongke.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbx_Thongke.Name = "cbx_Thongke";
            this.cbx_Thongke.Size = new System.Drawing.Size(232, 36);
            this.cbx_Thongke.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(4, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Thông kê ngày:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(4, 97);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(329, 26);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // lbl_Gio
            // 
            this.lbl_Gio.AutoSize = true;
            this.lbl_Gio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Gio.Location = new System.Drawing.Point(386, 23);
            this.lbl_Gio.Name = "lbl_Gio";
            this.lbl_Gio.Size = new System.Drawing.Size(37, 21);
            this.lbl_Gio.TabIndex = 13;
            this.lbl_Gio.Text = "Giờ:";
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(4, 131);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(90, 36);
            this.btn_load.TabIndex = 14;
            this.btn_load.Text = "Load data";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_ThongKe);
            this.panel1.Location = new System.Drawing.Point(357, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 88);
            this.panel1.TabIndex = 11;
            // 
            // lbl_ThongKe
            // 
            this.lbl_ThongKe.AutoSize = true;
            this.lbl_ThongKe.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ThongKe.Location = new System.Drawing.Point(48, 41);
            this.lbl_ThongKe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ThongKe.Name = "lbl_ThongKe";
            this.lbl_ThongKe.Size = new System.Drawing.Size(117, 33);
            this.lbl_ThongKe.TabIndex = 10;
            this.lbl_ThongKe.Text = ".................";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MintCream;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbl_Tk_TongHD);
            this.panel3.Location = new System.Drawing.Point(72, 221);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 88);
            this.panel3.TabIndex = 12;
            // 
            // lbl_Tk_TongHD
            // 
            this.lbl_Tk_TongHD.AutoSize = true;
            this.lbl_Tk_TongHD.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Tk_TongHD.Location = new System.Drawing.Point(45, 41);
            this.lbl_Tk_TongHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Tk_TongHD.Name = "lbl_Tk_TongHD";
            this.lbl_Tk_TongHD.Size = new System.Drawing.Size(117, 33);
            this.lbl_Tk_TongHD.TabIndex = 10;
            this.lbl_Tk_TongHD.Text = ".................";
            // 
            // grid_Data
            // 
            this.grid_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Data.Location = new System.Drawing.Point(13, 358);
            this.grid_Data.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grid_Data.Name = "grid_Data";
            this.grid_Data.RowHeadersWidth = 51;
            this.grid_Data.RowTemplate.Height = 29;
            this.grid_Data.Size = new System.Drawing.Size(605, 231);
            this.grid_Data.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chức năng Thống kê";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.btn_GuiEmail_Tk);
            this.panel2.Controls.Add(this.lbl_hangcannhap);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.grid_Data);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btn_load);
            this.panel2.Controls.Add(this.lbl_Gio);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbx_Thongke);
            this.panel2.Controls.Add(this.btn_GuiThongKe);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 592);
            this.panel2.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(45, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "số lượng hoá đơn ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(69, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tổng tiền ";
            // 
            // lbl_hangcannhap
            // 
            this.lbl_hangcannhap.AutoSize = true;
            this.lbl_hangcannhap.ForeColor = System.Drawing.Color.White;
            this.lbl_hangcannhap.Location = new System.Drawing.Point(256, 334);
            this.lbl_hangcannhap.Name = "lbl_hangcannhap";
            this.lbl_hangcannhap.Size = new System.Drawing.Size(100, 21);
            this.lbl_hangcannhap.TabIndex = 12;
            this.lbl_hangcannhap.Text = "Hàng cần nhập\r\n";
            // 
            // btn_GuiEmail_Tk
            // 
            this.btn_GuiEmail_Tk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_GuiEmail_Tk.Location = new System.Drawing.Point(339, 97);
            this.btn_GuiEmail_Tk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_GuiEmail_Tk.Name = "btn_GuiEmail_Tk";
            this.btn_GuiEmail_Tk.Size = new System.Drawing.Size(116, 28);
            this.btn_GuiEmail_Tk.TabIndex = 15;
            this.btn_GuiEmail_Tk.Text = "Gửi mail";
            this.btn_GuiEmail_Tk.UseVisualStyleBackColor = true;
            this.btn_GuiEmail_Tk.Click += new System.EventHandler(this.btn_GuiEmail_Tk_Click);
            // 
            // Frm_Thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 592);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Frm_Thongke";
            this.Text = "Frm_Thongke";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Data)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_GuiThongKe;
        private System.Windows.Forms.ComboBox cbx_Thongke;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_Gio;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_ThongKe;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Tk_TongHD;
        private System.Windows.Forms.DataGridView grid_Data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_hangcannhap;
        private System.Windows.Forms.Button btn_GuiEmail_Tk;
    }
}