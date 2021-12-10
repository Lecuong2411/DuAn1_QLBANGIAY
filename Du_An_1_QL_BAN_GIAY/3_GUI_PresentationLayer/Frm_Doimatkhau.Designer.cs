
namespace _3_GUI_PresentationLayer
{
    partial class Frm_Doimatkhau
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
            this.cbHienMK = new System.Windows.Forms.CheckBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.txtPassNew2 = new System.Windows.Forms.TextBox();
            this.txtPassNew = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbHienMK
            // 
            this.cbHienMK.AutoSize = true;
            this.cbHienMK.ForeColor = System.Drawing.Color.White;
            this.cbHienMK.Location = new System.Drawing.Point(50, 482);
            this.cbHienMK.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cbHienMK.Name = "cbHienMK";
            this.cbHienMK.Size = new System.Drawing.Size(203, 36);
            this.cbHienMK.TabIndex = 40;
            this.cbHienMK.Text = "Hiện mật khẩu";
            this.cbHienMK.UseVisualStyleBackColor = true;
            this.cbHienMK.UseWaitCursor = true;
            this.cbHienMK.CheckedChanged += new System.EventHandler(this.cbHienMK_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.Image = global::_3_GUI_PresentationLayer.Properties.Resources.icons8_close_301;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(50, 533);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(193, 90);
            this.btnThoat.TabIndex = 39;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.UseWaitCursor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDoiMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(357, 533);
            this.btnDoiMatKhau.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(247, 90);
            this.btnDoiMatKhau.TabIndex = 38;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.UseWaitCursor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // txtPassNew2
            // 
            this.txtPassNew2.Location = new System.Drawing.Point(43, 410);
            this.txtPassNew2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtPassNew2.Name = "txtPassNew2";
            this.txtPassNew2.PasswordChar = 'x';
            this.txtPassNew2.Size = new System.Drawing.Size(557, 39);
            this.txtPassNew2.TabIndex = 37;
            this.txtPassNew2.UseWaitCursor = true;
            // 
            // txtPassNew
            // 
            this.txtPassNew.Location = new System.Drawing.Point(43, 314);
            this.txtPassNew.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtPassNew.Name = "txtPassNew";
            this.txtPassNew.PasswordChar = 'x';
            this.txtPassNew.Size = new System.Drawing.Size(557, 39);
            this.txtPassNew.TabIndex = 36;
            this.txtPassNew.UseWaitCursor = true;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(43, 215);
            this.txtPass.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = 'x';
            this.txtPass.Size = new System.Drawing.Size(557, 39);
            this.txtPass.TabIndex = 31;
            this.txtPass.UseWaitCursor = true;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(43, 117);
            this.txtMail.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(557, 39);
            this.txtMail.TabIndex = 30;
            this.txtMail.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 45);
            this.label3.TabIndex = 32;
            this.label3.Text = "Mật khẩu mới :";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 361);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 45);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nhập lại mật khẩu mới :";
            this.label2.UseWaitCursor = true;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMatKhau.ForeColor = System.Drawing.Color.White;
            this.lblMatKhau.Location = new System.Drawing.Point(43, 166);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(162, 45);
            this.lblMatKhau.TabIndex = 34;
            this.lblMatKhau.Text = "Mật khẩu";
            this.lblMatKhau.UseWaitCursor = true;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMail.ForeColor = System.Drawing.Color.White;
            this.lblMail.Location = new System.Drawing.Point(43, 68);
            this.lblMail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(86, 45);
            this.lblMail.TabIndex = 35;
            this.lblMail.Text = "Mail";
            this.lblMail.UseWaitCursor = true;
            // 
            // Frm_Doimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(656, 681);
            this.Controls.Add(this.cbHienMK);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.txtPassNew2);
            this.Controls.Add(this.txtPassNew);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblMail);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frm_Doimatkhau";
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbHienMK;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.TextBox txtPassNew2;
        private System.Windows.Forms.TextBox txtPassNew;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblMail;
    }
}