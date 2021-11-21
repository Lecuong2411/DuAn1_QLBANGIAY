
namespace _3_GUI_PresentationLayer
{
    partial class FrmThongtinVoucher
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
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_namevoucher = new System.Windows.Forms.TextBox();
            this.dtp_nsd = new System.Windows.Forms.DateTimePicker();
            this.dtp_hsd = new System.Windows.Forms.DateTimePicker();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_soluongdasudung = new System.Windows.Forms.TextBox();
            this.nud_menhgia = new System.Windows.Forms.NumericUpDown();
            this.rbt_ketthuc = new System.Windows.Forms.RadioButton();
            this.rdb_hoatdong = new System.Windows.Forms.RadioButton();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_fix = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_menhgia)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(553, 305);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Đóng";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_namevoucher
            // 
            this.txt_namevoucher.Location = new System.Drawing.Point(157, 40);
            this.txt_namevoucher.Name = "txt_namevoucher";
            this.txt_namevoucher.Size = new System.Drawing.Size(124, 23);
            this.txt_namevoucher.TabIndex = 2;
            // 
            // dtp_nsd
            // 
            this.dtp_nsd.Location = new System.Drawing.Point(157, 85);
            this.dtp_nsd.Name = "dtp_nsd";
            this.dtp_nsd.Size = new System.Drawing.Size(124, 23);
            this.dtp_nsd.TabIndex = 3;
            // 
            // dtp_hsd
            // 
            this.dtp_hsd.Location = new System.Drawing.Point(157, 124);
            this.dtp_hsd.Name = "dtp_hsd";
            this.dtp_hsd.Size = new System.Drawing.Size(124, 23);
            this.dtp_hsd.TabIndex = 4;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(157, 165);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(124, 23);
            this.txt_soluong.TabIndex = 5;
            // 
            // txt_soluongdasudung
            // 
            this.txt_soluongdasudung.Location = new System.Drawing.Point(157, 213);
            this.txt_soluongdasudung.Name = "txt_soluongdasudung";
            this.txt_soluongdasudung.Size = new System.Drawing.Size(124, 23);
            this.txt_soluongdasudung.TabIndex = 6;
            // 
            // nud_menhgia
            // 
            this.nud_menhgia.Location = new System.Drawing.Point(434, 34);
            this.nud_menhgia.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nud_menhgia.Name = "nud_menhgia";
            this.nud_menhgia.Size = new System.Drawing.Size(165, 23);
            this.nud_menhgia.TabIndex = 7;
            // 
            // rbt_ketthuc
            // 
            this.rbt_ketthuc.AutoSize = true;
            this.rbt_ketthuc.Location = new System.Drawing.Point(530, 83);
            this.rbt_ketthuc.Name = "rbt_ketthuc";
            this.rbt_ketthuc.Size = new System.Drawing.Size(69, 19);
            this.rbt_ketthuc.TabIndex = 8;
            this.rbt_ketthuc.TabStop = true;
            this.rbt_ketthuc.Text = "Kết thúc";
            this.rbt_ketthuc.UseVisualStyleBackColor = true;
            // 
            // rdb_hoatdong
            // 
            this.rdb_hoatdong.AutoSize = true;
            this.rdb_hoatdong.Location = new System.Drawing.Point(434, 83);
            this.rdb_hoatdong.Name = "rdb_hoatdong";
            this.rdb_hoatdong.Size = new System.Drawing.Size(82, 19);
            this.rdb_hoatdong.TabIndex = 9;
            this.rdb_hoatdong.TabStop = true;
            this.rdb_hoatdong.Text = "Hoạt động";
            this.rdb_hoatdong.UseVisualStyleBackColor = true;
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(434, 134);
            this.txt_ghichu.Multiline = true;
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(165, 102);
            this.txt_ghichu.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên Voucher :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ghi chú :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Trạng thái :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mệnh giá :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Số lượng đã sử dụng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Số lượng :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ngày kết thúc :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Ngày bắt đầu :";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(553, 276);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 19;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_fix
            // 
            this.btn_fix.Location = new System.Drawing.Point(461, 305);
            this.btn_fix.Name = "btn_fix";
            this.btn_fix.Size = new System.Drawing.Size(75, 23);
            this.btn_fix.TabIndex = 20;
            this.btn_fix.Text = "Sửa";
            this.btn_fix.UseVisualStyleBackColor = true;
            this.btn_fix.Click += new System.EventHandler(this.btn_fix_Click);
            // 
            // FrmThongtinVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 350);
            this.Controls.Add(this.btn_fix);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ghichu);
            this.Controls.Add(this.rdb_hoatdong);
            this.Controls.Add(this.rbt_ketthuc);
            this.Controls.Add(this.nud_menhgia);
            this.Controls.Add(this.txt_soluongdasudung);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.dtp_hsd);
            this.Controls.Add(this.dtp_nsd);
            this.Controls.Add(this.txt_namevoucher);
            this.Controls.Add(this.btn_close);
            this.Name = "FrmThongtinVoucher";
            this.Text = "FrmThongtinVoucher";
            ((System.ComponentModel.ISupportInitialize)(this.nud_menhgia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txt_namevoucher;
        private System.Windows.Forms.DateTimePicker dtp_nsd;
        private System.Windows.Forms.DateTimePicker dtp_hsd;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_soluongdasudung;
        private System.Windows.Forms.NumericUpDown nud_menhgia;
        private System.Windows.Forms.RadioButton rbt_ketthuc;
        private System.Windows.Forms.RadioButton rdb_hoatdong;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_fix;
    }
}