
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_danhsachhoadonbanhang)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_danhsachhoadonbanhang
            // 
            this.dtgv_danhsachhoadonbanhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_danhsachhoadonbanhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_danhsachhoadonbanhang.Location = new System.Drawing.Point(12, 113);
            this.dtgv_danhsachhoadonbanhang.Name = "dtgv_danhsachhoadonbanhang";
            this.dtgv_danhsachhoadonbanhang.RowTemplate.Height = 25;
            this.dtgv_danhsachhoadonbanhang.Size = new System.Drawing.Size(776, 325);
            this.dtgv_danhsachhoadonbanhang.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phiếu nhập :";
            // 
            // txt_maphieunhap
            // 
            this.txt_maphieunhap.Location = new System.Drawing.Point(128, 48);
            this.txt_maphieunhap.Name = "txt_maphieunhap";
            this.txt_maphieunhap.PlaceholderText = "nhập mã phiếu nhập";
            this.txt_maphieunhap.Size = new System.Drawing.Size(134, 23);
            this.txt_maphieunhap.TabIndex = 2;
            this.txt_maphieunhap.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_maphieunhap_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày tạo phiếu :";
            // 
            // dtp_ngaythang
            // 
            this.dtp_ngaythang.Location = new System.Drawing.Point(393, 45);
            this.dtp_ngaythang.Name = "dtp_ngaythang";
            this.dtp_ngaythang.Size = new System.Drawing.Size(182, 23);
            this.dtp_ngaythang.TabIndex = 4;
            this.dtp_ngaythang.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(628, 32);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(75, 23);
            this.btn_timkiem.TabIndex = 5;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            // 
            // btn_danhsach
            // 
            this.btn_danhsach.Location = new System.Drawing.Point(628, 61);
            this.btn_danhsach.Name = "btn_danhsach";
            this.btn_danhsach.Size = new System.Drawing.Size(75, 23);
            this.btn_danhsach.TabIndex = 6;
            this.btn_danhsach.Text = "Danh Sách";
            this.btn_danhsach.UseVisualStyleBackColor = true;
            this.btn_danhsach.Click += new System.EventHandler(this.btn_danhsach_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(25, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(139, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giờ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmDanhSachHoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_danhsach);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.dtp_ngaythang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_maphieunhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv_danhsachhoadonbanhang);
            this.Name = "FrmDanhSachHoaDonBanHang";
            this.Text = "FrmDanhSachHoaDonBanHang";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_danhsachhoadonbanhang)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}