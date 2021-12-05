
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nud_menhgia)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_namevoucher
            // 
            this.txt_namevoucher.Location = new System.Drawing.Point(162, 12);
            this.txt_namevoucher.Name = "txt_namevoucher";
            this.txt_namevoucher.Size = new System.Drawing.Size(124, 23);
            this.txt_namevoucher.TabIndex = 2;
            // 
            // dtp_nsd
            // 
            this.dtp_nsd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_nsd.Location = new System.Drawing.Point(162, 57);
            this.dtp_nsd.Name = "dtp_nsd";
            this.dtp_nsd.Size = new System.Drawing.Size(124, 23);
            this.dtp_nsd.TabIndex = 3;
            // 
            // dtp_hsd
            // 
            this.dtp_hsd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_hsd.Location = new System.Drawing.Point(162, 96);
            this.dtp_hsd.Name = "dtp_hsd";
            this.dtp_hsd.Size = new System.Drawing.Size(124, 23);
            this.dtp_hsd.TabIndex = 4;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(162, 137);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(124, 23);
            this.txt_soluong.TabIndex = 5;
            // 
            // txt_soluongdasudung
            // 
            this.txt_soluongdasudung.Location = new System.Drawing.Point(162, 185);
            this.txt_soluongdasudung.Name = "txt_soluongdasudung";
            this.txt_soluongdasudung.Size = new System.Drawing.Size(124, 23);
            this.txt_soluongdasudung.TabIndex = 6;
            // 
            // nud_menhgia
            // 
            this.nud_menhgia.Location = new System.Drawing.Point(437, 8);
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
            this.rbt_ketthuc.Location = new System.Drawing.Point(533, 57);
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
            this.rdb_hoatdong.Location = new System.Drawing.Point(437, 57);
            this.rdb_hoatdong.Name = "rdb_hoatdong";
            this.rdb_hoatdong.Size = new System.Drawing.Size(82, 19);
            this.rdb_hoatdong.TabIndex = 9;
            this.rdb_hoatdong.TabStop = true;
            this.rdb_hoatdong.Text = "Hoạt động";
            this.rdb_hoatdong.UseVisualStyleBackColor = true;
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(437, 108);
            this.txt_ghichu.Multiline = true;
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(165, 102);
            this.txt_ghichu.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên Voucher :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ghi chú :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Trạng thái :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mệnh giá :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Số lượng đã sử dụng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Số lượng :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ngày kết thúc :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Ngày bắt đầu :";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add.Image = global::_3_GUI_PresentationLayer.Properties.Resources.icons8_plus___30;
            this.btn_add.Location = new System.Drawing.Point(30, 60);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(54, 37);
            this.btn_add.TabIndex = 19;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_fix
            // 
            this.btn_fix.BackColor = System.Drawing.Color.White;
            this.btn_fix.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_fix.Image = global::_3_GUI_PresentationLayer.Properties.Resources.technical_wrench;
            this.btn_fix.Location = new System.Drawing.Point(90, 17);
            this.btn_fix.Name = "btn_fix";
            this.btn_fix.Size = new System.Drawing.Size(55, 37);
            this.btn_fix.TabIndex = 20;
            this.btn_fix.UseVisualStyleBackColor = false;
            this.btn_fix.Click += new System.EventHandler(this.btn_fix_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = global::_3_GUI_PresentationLayer.Properties.Resources.icons8_close_302;
            this.button1.Location = new System.Drawing.Point(90, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 37);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.btn_fix);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(459, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 100);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_ghichu);
            this.panel2.Controls.Add(this.nud_menhgia);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.rbt_ketthuc);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.rdb_hoatdong);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_soluongdasudung);
            this.panel2.Controls.Add(this.dtp_nsd);
            this.panel2.Controls.Add(this.txt_soluong);
            this.panel2.Controls.Add(this.txt_namevoucher);
            this.panel2.Controls.Add(this.dtp_hsd);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 224);
            this.panel2.TabIndex = 23;
            // 
            // FrmThongtinVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(657, 360);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmThongtinVoucher";
            this.Text = "FrmThongtinVoucher";
            this.Load += new System.EventHandler(this.FrmThongtinVoucher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_menhgia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}