
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
            this.dtgv_danhsachhoadonbanhang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_maphieunhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_ngaythang = new System.Windows.Forms.DateTimePicker();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_danhsach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_danhsachhoadonbanhang)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_danhsachhoadonbanhang
            // 
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
            this.txt_maphieunhap.Size = new System.Drawing.Size(107, 23);
            this.txt_maphieunhap.TabIndex = 2;
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
            this.dtp_ngaythang.Size = new System.Drawing.Size(173, 23);
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
            // 
            // FrmDanhSachHoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}