
namespace _3_GUI_PresentationLayer
{
    partial class Frm_KhuyenMai
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_danhMuc = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btm_tao = new System.Windows.Forms.Button();
            this.rdo_khd = new System.Windows.Forms.RadioButton();
            this.rdo_hd = new System.Windows.Forms.RadioButton();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.nud_giamgia = new System.Windows.Forms.NumericUpDown();
            this.txt_tct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_loc = new System.Windows.Forms.Button();
            this.cbo_danhmuc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_giamgia)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 481);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Turquoise;
            this.tabPage1.Controls.Add(this.btn_danhMuc);
            this.tabPage1.Controls.Add(this.btn_huy);
            this.tabPage1.Controls.Add(this.btn_sua);
            this.tabPage1.Controls.Add(this.btm_tao);
            this.tabPage1.Controls.Add(this.rdo_khd);
            this.tabPage1.Controls.Add(this.rdo_hd);
            this.tabPage1.Controls.Add(this.dtp_end);
            this.tabPage1.Controls.Add(this.dtp_start);
            this.tabPage1.Controls.Add(this.txt_ghichu);
            this.tabPage1.Controls.Add(this.nud_giamgia);
            this.tabPage1.Controls.Add(this.txt_tct);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Khuyến mại";
            // 
            // btn_danhMuc
            // 
            this.btn_danhMuc.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_danhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_danhMuc.Image = global::_3_GUI_PresentationLayer.Properties.Resources.clipboard;
            this.btn_danhMuc.Location = new System.Drawing.Point(355, 182);
            this.btn_danhMuc.Name = "btn_danhMuc";
            this.btn_danhMuc.Size = new System.Drawing.Size(50, 51);
            this.btn_danhMuc.TabIndex = 18;
            this.btn_danhMuc.UseVisualStyleBackColor = false;
            this.btn_danhMuc.Click += new System.EventHandler(this.btn_danhMuc_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_huy.ForeColor = System.Drawing.Color.White;
            this.btn_huy.Location = new System.Drawing.Point(655, 196);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(99, 37);
            this.btn_huy.TabIndex = 17;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = false;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Location = new System.Drawing.Point(540, 196);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(97, 37);
            this.btn_sua.TabIndex = 16;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btm_tao
            // 
            this.btm_tao.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btm_tao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btm_tao.ForeColor = System.Drawing.Color.White;
            this.btm_tao.Location = new System.Drawing.Point(432, 196);
            this.btm_tao.Name = "btm_tao";
            this.btm_tao.Size = new System.Drawing.Size(88, 37);
            this.btm_tao.TabIndex = 15;
            this.btm_tao.Text = "Tạo ";
            this.btm_tao.UseVisualStyleBackColor = false;
            this.btm_tao.Click += new System.EventHandler(this.btm_tao_Click);
            // 
            // rdo_khd
            // 
            this.rdo_khd.AutoSize = true;
            this.rdo_khd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdo_khd.ForeColor = System.Drawing.Color.White;
            this.rdo_khd.Location = new System.Drawing.Point(642, 162);
            this.rdo_khd.Name = "rdo_khd";
            this.rdo_khd.Size = new System.Drawing.Size(134, 21);
            this.rdo_khd.TabIndex = 12;
            this.rdo_khd.TabStop = true;
            this.rdo_khd.Text = "Không hoạt động";
            this.rdo_khd.UseVisualStyleBackColor = true;
            // 
            // rdo_hd
            // 
            this.rdo_hd.AutoSize = true;
            this.rdo_hd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdo_hd.ForeColor = System.Drawing.Color.White;
            this.rdo_hd.Location = new System.Drawing.Point(500, 162);
            this.rdo_hd.Name = "rdo_hd";
            this.rdo_hd.Size = new System.Drawing.Size(92, 21);
            this.rdo_hd.TabIndex = 11;
            this.rdo_hd.TabStop = true;
            this.rdo_hd.Text = "Hoạt động";
            this.rdo_hd.UseVisualStyleBackColor = true;
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(138, 105);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(247, 23);
            this.dtp_end.TabIndex = 10;
            // 
            // dtp_start
            // 
            this.dtp_start.Location = new System.Drawing.Point(138, 62);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(247, 23);
            this.dtp_start.TabIndex = 9;
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(496, 22);
            this.txt_ghichu.Multiline = true;
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(276, 107);
            this.txt_ghichu.TabIndex = 8;
            // 
            // nud_giamgia
            // 
            this.nud_giamgia.Location = new System.Drawing.Point(138, 148);
            this.nud_giamgia.Name = "nud_giamgia";
            this.nud_giamgia.Size = new System.Drawing.Size(247, 23);
            this.nud_giamgia.TabIndex = 7;
            // 
            // txt_tct
            // 
            this.txt_tct.Location = new System.Drawing.Point(138, 24);
            this.txt_tct.Name = "txt_tct";
            this.txt_tct.Size = new System.Drawing.Size(247, 23);
            this.txt_tct.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(417, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Trạng thái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày bắt đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày kết thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giảm giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(413, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ghi chú";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên chương trình";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Turquoise;
            this.tabPage2.Controls.Add(this.btn_loc);
            this.tabPage2.Controls.Add(this.cbo_danhmuc);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dgv);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(787, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ẩn khuyến mại";
            // 
            // btn_loc
            // 
            this.btn_loc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loc.Location = new System.Drawing.Point(722, 31);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(48, 23);
            this.btn_loc.TabIndex = 3;
            this.btn_loc.Text = "...";
            this.btn_loc.UseVisualStyleBackColor = true;
            this.btn_loc.Click += new System.EventHandler(this.btn_loc_Click);
            // 
            // cbo_danhmuc
            // 
            this.cbo_danhmuc.FormattingEnabled = true;
            this.cbo_danhmuc.Location = new System.Drawing.Point(539, 32);
            this.cbo_danhmuc.Name = "cbo_danhmuc";
            this.cbo_danhmuc.Size = new System.Drawing.Size(165, 23);
            this.cbo_danhmuc.TabIndex = 2;
            this.cbo_danhmuc.TextChanged += new System.EventHandler(this.cbo_danhmuc_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(453, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Danh mục";
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 84);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(774, 336);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // Frm_KhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(816, 502);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Frm_KhuyenMai";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_KhuyenMai";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_giamgia)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton rdo_khd;
        private System.Windows.Forms.RadioButton rdo_hd;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.NumericUpDown nud_giamgia;
        private System.Windows.Forms.TextBox txt_tct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cbo_danhmuc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_loc;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btm_tao;
        private System.Windows.Forms.Button btn_danhMuc;
    }
}