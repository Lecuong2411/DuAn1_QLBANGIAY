
namespace _3_GUI_PresentationLayer
{
    partial class Frm_banhang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_themhoadon = new System.Windows.Forms.Button();
            this.tbx_barcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_tatbarcode = new System.Windows.Forms.Button();
            this.btn_barcode = new System.Windows.Forms.Button();
            this.ptbox_barcode = new System.Windows.Forms.PictureBox();
            this.dtgview_thongtinsp = new System.Windows.Forms.DataGridView();
            this.dtgview_hoadon = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbx_camera = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbox_barcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgview_thongtinsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgview_hoadon)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btn_themhoadon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 1375);
            this.panel1.TabIndex = 0;
            // 
            // btn_themhoadon
            // 
            this.btn_themhoadon.BackColor = System.Drawing.Color.DimGray;
            this.btn_themhoadon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_themhoadon.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_themhoadon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_themhoadon.Location = new System.Drawing.Point(0, 0);
            this.btn_themhoadon.Name = "btn_themhoadon";
            this.btn_themhoadon.Size = new System.Drawing.Size(112, 41);
            this.btn_themhoadon.TabIndex = 2;
            this.btn_themhoadon.Text = "New";
            this.btn_themhoadon.UseVisualStyleBackColor = false;
            // 
            // tbx_barcode
            // 
            this.tbx_barcode.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbx_barcode.Location = new System.Drawing.Point(3, 216);
            this.tbx_barcode.Multiline = true;
            this.tbx_barcode.Name = "tbx_barcode";
            this.tbx_barcode.Size = new System.Drawing.Size(285, 41);
            this.tbx_barcode.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(493, 1170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Sản phẩm";
            // 
            // btn_tatbarcode
            // 
            this.btn_tatbarcode.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_tatbarcode.Location = new System.Drawing.Point(6, 88);
            this.btn_tatbarcode.Name = "btn_tatbarcode";
            this.btn_tatbarcode.Size = new System.Drawing.Size(282, 76);
            this.btn_tatbarcode.TabIndex = 23;
            this.btn_tatbarcode.Text = "Tắt";
            this.btn_tatbarcode.UseVisualStyleBackColor = true;
            // 
            // btn_barcode
            // 
            this.btn_barcode.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_barcode.Location = new System.Drawing.Point(6, 3);
            this.btn_barcode.Name = "btn_barcode";
            this.btn_barcode.Size = new System.Drawing.Size(282, 79);
            this.btn_barcode.TabIndex = 21;
            this.btn_barcode.Text = "Quét";
            this.btn_barcode.UseVisualStyleBackColor = true;
            this.btn_barcode.Click += new System.EventHandler(this.btn_barcode_Click);
            // 
            // ptbox_barcode
            // 
            this.ptbox_barcode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbox_barcode.Location = new System.Drawing.Point(289, 0);
            this.ptbox_barcode.Name = "ptbox_barcode";
            this.ptbox_barcode.Size = new System.Drawing.Size(1277, 257);
            this.ptbox_barcode.TabIndex = 2;
            this.ptbox_barcode.TabStop = false;
            // 
            // dtgview_thongtinsp
            // 
            this.dtgview_thongtinsp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgview_thongtinsp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgview_thongtinsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgview_thongtinsp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgview_thongtinsp.Location = new System.Drawing.Point(0, 111);
            this.dtgview_thongtinsp.Name = "dtgview_thongtinsp";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgview_thongtinsp.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgview_thongtinsp.RowHeadersWidth = 82;
            this.dtgview_thongtinsp.RowTemplate.Height = 41;
            this.dtgview_thongtinsp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgview_thongtinsp.Size = new System.Drawing.Size(1572, 494);
            this.dtgview_thongtinsp.TabIndex = 0;
            this.dtgview_thongtinsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgview_thongtinsp_CellClick);
            // 
            // dtgview_hoadon
            // 
            this.dtgview_hoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgview_hoadon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgview_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgview_hoadon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgview_hoadon.Location = new System.Drawing.Point(0, 263);
            this.dtgview_hoadon.Name = "dtgview_hoadon";
            this.dtgview_hoadon.RowHeadersWidth = 82;
            this.dtgview_hoadon.RowTemplate.Height = 41;
            this.dtgview_hoadon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgview_hoadon.Size = new System.Drawing.Size(1572, 507);
            this.dtgview_hoadon.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1684, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 1375);
            this.panel2.TabIndex = 24;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 7.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(506, 1311);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(8, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(490, 1266);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thanh toán tại cửa hàng";
            // 
            // tabPage2
            // 
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(8, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(419, 1266);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thanh toán online";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(506, 64);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thanh toán";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgview_hoadon);
            this.panel3.Controls.Add(this.btn_barcode);
            this.panel3.Controls.Add(this.ptbox_barcode);
            this.panel3.Controls.Add(this.cbx_camera);
            this.panel3.Controls.Add(this.tbx_barcode);
            this.panel3.Controls.Add(this.btn_tatbarcode);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(112, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1572, 770);
            this.panel3.TabIndex = 25;
            // 
            // cbx_camera
            // 
            this.cbx_camera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_camera.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbx_camera.FormattingEnabled = true;
            this.cbx_camera.Location = new System.Drawing.Point(3, 170);
            this.cbx_camera.Name = "cbx_camera";
            this.cbx_camera.Size = new System.Drawing.Size(285, 43);
            this.cbx_camera.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dtgview_thongtinsp);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(112, 770);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1572, 605);
            this.panel4.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1572, 108);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sản phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_banhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2190, 1375);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_banhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_banhang";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_banhang_FormClosed);
            this.Load += new System.EventHandler(this.Frm_banhang_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbox_barcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgview_thongtinsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgview_hoadon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgview_thongtinsp;
        private System.Windows.Forms.DataGridView dtgview_hoadon;
        private System.Windows.Forms.TextBox tbx_barcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_barcode;
        private System.Windows.Forms.PictureBox ptbox_barcode;
        private System.Windows.Forms.Button btn_tatbarcode;
        private System.Windows.Forms.Button btn_themhoadon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_camera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}