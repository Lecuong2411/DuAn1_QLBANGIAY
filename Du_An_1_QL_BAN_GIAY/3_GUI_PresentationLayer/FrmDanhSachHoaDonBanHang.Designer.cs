
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
            this.btn_xuatexsel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_danhsachhoadonbanhang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_danhsachhoadonbanhang
            // 
            this.dtgv_danhsachhoadonbanhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_danhsachhoadonbanhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_danhsachhoadonbanhang.Location = new System.Drawing.Point(12, 147);
            this.dtgv_danhsachhoadonbanhang.Name = "dtgv_danhsachhoadonbanhang";
            this.dtgv_danhsachhoadonbanhang.RowTemplate.Height = 25;
            this.dtgv_danhsachhoadonbanhang.Size = new System.Drawing.Size(776, 291);
            this.dtgv_danhsachhoadonbanhang.TabIndex = 0;
            this.dtgv_danhsachhoadonbanhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_danhsachhoadonbanhang_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phiếu nhập :";
            // 
            // txt_maphieunhap
            // 
            this.txt_maphieunhap.Location = new System.Drawing.Point(149, 53);
            this.txt_maphieunhap.Name = "txt_maphieunhap";
            this.txt_maphieunhap.PlaceholderText = "nhập mã phiếu nhập";
            this.txt_maphieunhap.Size = new System.Drawing.Size(134, 23);
            this.txt_maphieunhap.TabIndex = 2;
            this.txt_maphieunhap.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_maphieunhap_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày tạo phiếu :";
            // 
            // dtp_ngaythang
            // 
            this.dtp_ngaythang.Location = new System.Drawing.Point(414, 50);
            this.dtp_ngaythang.Name = "dtp_ngaythang";
            this.dtp_ngaythang.Size = new System.Drawing.Size(182, 23);
            this.dtp_ngaythang.TabIndex = 4;
            this.dtp_ngaythang.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(649, 37);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(75, 23);
            this.btn_timkiem.TabIndex = 5;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_danhsach
            // 
            this.btn_danhsach.Location = new System.Drawing.Point(649, 66);
            this.btn_danhsach.Name = "btn_danhsach";
            this.btn_danhsach.Size = new System.Drawing.Size(75, 23);
            this.btn_danhsach.TabIndex = 6;
            this.btn_danhsach.Text = "Danh Sách";
            this.btn_danhsach.UseVisualStyleBackColor = true;
            this.btn_danhsach.Click += new System.EventHandler(this.btn_danhsach_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giờ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_xuatexsel
            // 
            this.btn_xuatexsel.Location = new System.Drawing.Point(649, 95);
            this.btn_xuatexsel.Name = "btn_xuatexsel";
            this.btn_xuatexsel.Size = new System.Drawing.Size(75, 23);
            this.btn_xuatexsel.TabIndex = 9;
            this.btn_xuatexsel.Text = "Xuất Exsel";
            this.btn_xuatexsel.UseVisualStyleBackColor = true;
            this.btn_xuatexsel.Click += new System.EventHandler(this.btn_xuatexsel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(30, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 30);
            this.panel1.TabIndex = 10;
            // 
            // FrmDanhSachHoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_xuatexsel);
            this.Controls.Add(this.btn_danhsach);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.dtp_ngaythang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_maphieunhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv_danhsachhoadonbanhang);
            this.Name = "FrmDanhSachHoaDonBanHang";
            this.Text = "FrmDanhSachHoaDonBanHang";
            this.Load += new System.EventHandler(this.FrmDanhSachHoaDonBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_danhsachhoadonbanhang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btn_xuatexsel;
        private System.Windows.Forms.Panel panel1;
    }
}