
namespace _3_GUI_PresentationLayer
{
    partial class Frm_Login
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
            this.lal_quenPassWord = new System.Windows.Forms.LinkLabel();
            this.bnt_exit = new System.Windows.Forms.Button();
            this.bnt_login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lal_quenPassWord
            // 
            this.lal_quenPassWord.AutoSize = true;
            this.lal_quenPassWord.BackColor = System.Drawing.Color.Transparent;
            this.lal_quenPassWord.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lal_quenPassWord.ForeColor = System.Drawing.Color.Red;
            this.lal_quenPassWord.Location = new System.Drawing.Point(211, 143);
            this.lal_quenPassWord.Name = "lal_quenPassWord";
            this.lal_quenPassWord.Size = new System.Drawing.Size(92, 15);
            this.lal_quenPassWord.TabIndex = 31;
            this.lal_quenPassWord.TabStop = true;
            this.lal_quenPassWord.Text = "Quên mật khẩu";
            this.lal_quenPassWord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lal_quenPassWord_LinkClicked);
            // 
            // bnt_exit
            // 
            this.bnt_exit.BackColor = System.Drawing.Color.White;
            this.bnt_exit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bnt_exit.Image = global::_3_GUI_PresentationLayer.Properties.Resources.icons8_close_30;
            this.bnt_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_exit.Location = new System.Drawing.Point(118, 224);
            this.bnt_exit.Name = "bnt_exit";
            this.bnt_exit.Size = new System.Drawing.Size(142, 33);
            this.bnt_exit.TabIndex = 29;
            this.bnt_exit.Text = "Thoát";
            this.bnt_exit.UseVisualStyleBackColor = false;
            this.bnt_exit.Click += new System.EventHandler(this.bnt_exit_Click);
            // 
            // bnt_login
            // 
            this.bnt_login.BackColor = System.Drawing.Color.White;
            this.bnt_login.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
          
            this.bnt_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_login.Location = new System.Drawing.Point(118, 183);
            this.bnt_login.Name = "bnt_login";
            this.bnt_login.Size = new System.Drawing.Size(142, 35);
            this.bnt_login.TabIndex = 28;
            this.bnt_login.Text = "Đăng nhập";
            this.bnt_login.UseVisualStyleBackColor = false;
            this.bnt_login.Click += new System.EventHandler(this.bnt_login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(40, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mật khẩu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(64, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Email :";
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(137, 101);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '*';
            this.txt_matkhau.Size = new System.Drawing.Size(136, 23);
            this.txt_matkhau.TabIndex = 25;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(137, 44);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(136, 23);
            this.txt_email.TabIndex = 24;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.ForeColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(82, 143);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(81, 15);
            this.linkLabel1.TabIndex = 32;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Đổi mật khẩu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(342, 301);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lal_quenPassWord);
            this.Controls.Add(this.bnt_exit);
            this.Controls.Add(this.bnt_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_email);
            this.Name = "Frm_Login";
            this.Text = "Frm_Main";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lal_quenPassWord;
        private System.Windows.Forms.Button bnt_exit;
        private System.Windows.Forms.Button bnt_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}