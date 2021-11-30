
namespace _3_GUI_PresentationLayer
{
    partial class FrmDanhSachHoaDonBanHang
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
            this.dtgv_danhsachhoadonbanhang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_maphieunhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_ngaythang = new System.Windows.Forms.DateTimePicker();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_danhsach = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_xuatexcel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbb_timkiem = new System.Windows.Forms.ComboBox();
            this.btn_dsct = new System.Windows.Forms.Button();
            this.dtgv_dshdct = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_xuatExcelct = new System.Windows.Forms.Button();
            this.txt_timkiemct = new System.Windows.Forms.TextBox();
            this.dtp_ct = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_hdct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_danhsachhoadonbanhang)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dshdct)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_danhsachhoadonbanhang
            // 
            this.dtgv_danhsachhoadonbanhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_danhsachhoadonbanhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_danhsachhoadonbanhang.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtgv_danhsachhoadonbanhang.Location = new System.Drawing.Point(53, 155);
            this.dtgv_danhsachhoadonbanhang.Name = "dtgv_danhsachhoadonbanhang";
            this.dtgv_danhsachhoadonbanhang.RowTemplate.Height = 25;
            this.dtgv_danhsachhoadonbanhang.Size = new System.Drawing.Size(879, 323);
            this.dtgv_danhsachhoadonbanhang.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "  Tìm kiếm SĐT:";
            // 
            // txt_maphieunhap
            // 
            this.txt_maphieunhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_maphieunhap.Location = new System.Drawing.Point(168, 47);
            this.txt_maphieunhap.Name = "txt_maphieunhap";
            this.txt_maphieunhap.PlaceholderText = "nhập số điện thoại";
            this.txt_maphieunhap.Size = new System.Drawing.Size(191, 23);
            this.txt_maphieunhap.TabIndex = 2;
            this.txt_maphieunhap.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_maphieunhap_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(388, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày tạo phiếu :";
            // 
            // dtp_ngaythang
            // 
            this.dtp_ngaythang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtp_ngaythang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaythang.Location = new System.Drawing.Point(506, 47);
            this.dtp_ngaythang.Name = "dtp_ngaythang";
            this.dtp_ngaythang.Size = new System.Drawing.Size(112, 23);
            this.dtp_ngaythang.TabIndex = 4;
            this.dtp_ngaythang.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_timkiem.Location = new System.Drawing.Point(624, 41);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(117, 36);
            this.btn_timkiem.TabIndex = 5;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_danhsach
            // 
            this.btn_danhsach.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_danhsach.Location = new System.Drawing.Point(820, 38);
            this.btn_danhsach.Name = "btn_danhsach";
            this.btn_danhsach.Size = new System.Drawing.Size(112, 39);
            this.btn_danhsach.TabIndex = 6;
            this.btn_danhsach.Text = "Danh Sách";
            this.btn_danhsach.UseVisualStyleBackColor = true;
            this.btn_danhsach.Click += new System.EventHandler(this.btn_danhsach_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giờ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_xuatexcel
            // 
            this.btn_xuatexcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_xuatexcel.Image = global::_3_GUI_PresentationLayer.Properties.Resources.Excel_icon;
            this.btn_xuatexcel.Location = new System.Drawing.Point(858, 92);
            this.btn_xuatexcel.Name = "btn_xuatexcel";
            this.btn_xuatexcel.Size = new System.Drawing.Size(46, 39);
            this.btn_xuatexcel.TabIndex = 9;
            this.btn_xuatexcel.UseVisualStyleBackColor = true;
            this.btn_xuatexcel.Click += new System.EventHandler(this.btn_xuatexcel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(-2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(981, 533);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_danhsach);
            this.tabPage1.Controls.Add(this.dtgv_danhsachhoadonbanhang);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btn_xuatexcel);
            this.tabPage1.Controls.Add(this.txt_maphieunhap);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtp_ngaythang);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btn_timkiem);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(973, 503);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DS hóa đơn";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbb_timkiem);
            this.tabPage2.Controls.Add(this.btn_dsct);
            this.tabPage2.Controls.Add(this.dtgv_dshdct);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btn_xuatExcelct);
            this.tabPage2.Controls.Add(this.txt_timkiemct);
            this.tabPage2.Controls.Add(this.dtp_ct);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btn_hdct);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(973, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DS hóa đơn chi tiết";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbb_timkiem
            // 
            this.cbb_timkiem.FormattingEnabled = true;
            this.cbb_timkiem.Location = new System.Drawing.Point(35, 53);
            this.cbb_timkiem.Name = "cbb_timkiem";
            this.cbb_timkiem.Size = new System.Drawing.Size(121, 25);
            this.cbb_timkiem.TabIndex = 19;
            // 
            // btn_dsct
            // 
            this.btn_dsct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_dsct.Location = new System.Drawing.Point(832, 31);
            this.btn_dsct.Name = "btn_dsct";
            this.btn_dsct.Size = new System.Drawing.Size(91, 42);
            this.btn_dsct.TabIndex = 16;
            this.btn_dsct.Text = "Danh Sách";
            this.btn_dsct.UseVisualStyleBackColor = true;
            this.btn_dsct.Click += new System.EventHandler(this.btn_dsct_Click);
            // 
            // dtgv_dshdct
            // 
            this.dtgv_dshdct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgv_dshdct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_dshdct.Location = new System.Drawing.Point(26, 141);
            this.dtgv_dshdct.Name = "dtgv_dshdct";
            this.dtgv_dshdct.RowTemplate.Height = 25;
            this.dtgv_dshdct.Size = new System.Drawing.Size(915, 340);
            this.dtgv_dshdct.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(12, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Giờ";
            // 
            // btn_xuatExcelct
            // 
            this.btn_xuatExcelct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_xuatExcelct.Image = global::_3_GUI_PresentationLayer.Properties.Resources.Excel_icon;
            this.btn_xuatExcelct.Location = new System.Drawing.Point(849, 84);
            this.btn_xuatExcelct.Name = "btn_xuatExcelct";
            this.btn_xuatExcelct.Size = new System.Drawing.Size(47, 41);
            this.btn_xuatExcelct.TabIndex = 18;
            this.btn_xuatExcelct.UseVisualStyleBackColor = true;
            this.btn_xuatExcelct.Click += new System.EventHandler(this.btn_xuatExcelct_Click);
            // 
            // txt_timkiemct
            // 
            this.txt_timkiemct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_timkiemct.Location = new System.Drawing.Point(175, 53);
            this.txt_timkiemct.Name = "txt_timkiemct";
            this.txt_timkiemct.PlaceholderText = "nhập số điện thoại";
            this.txt_timkiemct.Size = new System.Drawing.Size(134, 23);
            this.txt_timkiemct.TabIndex = 12;
            this.txt_timkiemct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_timkiemct_KeyUp);
            // 
            // dtp_ct
            // 
            this.dtp_ct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtp_ct.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ct.Location = new System.Drawing.Point(478, 50);
            this.dtp_ct.Name = "dtp_ct";
            this.dtp_ct.Size = new System.Drawing.Size(107, 23);
            this.dtp_ct.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(363, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ngày tạo phiếu :";
            // 
            // btn_hdct
            // 
            this.btn_hdct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_hdct.Location = new System.Drawing.Point(610, 37);
            this.btn_hdct.Name = "btn_hdct";
            this.btn_hdct.Size = new System.Drawing.Size(133, 42);
            this.btn_hdct.TabIndex = 15;
            this.btn_hdct.Text = "Tìm kiếm";
            this.btn_hdct.UseVisualStyleBackColor = true;
            this.btn_hdct.Click += new System.EventHandler(this.btn_hdct_Click);
            // 
            // FrmDanhSachHoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 537);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmDanhSachHoaDonBanHang";
            this.Text = "FrmDanhSachHoaDonBanHang";
          
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_danhsachhoadonbanhang)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dshdct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_danhsachhoadonbanhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_maphieunhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_ngaythang;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_danhsach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_xuatexcel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_dsct;
        private System.Windows.Forms.DataGridView dtgv_dshdct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_xuatExcelct;
        private System.Windows.Forms.TextBox txt_timkiemct;
        private System.Windows.Forms.DateTimePicker dtp_ct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_hdct;
        private System.Windows.Forms.ComboBox cbb_timkiem;
    }
}