
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lal_quenPassWord
            // 
            this.lal_quenPassWord.AutoSize = true;
            this.lal_quenPassWord.BackColor = System.Drawing.Color.Transparent;
            this.lal_quenPassWord.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lal_quenPassWord.ForeColor = System.Drawing.Color.Red;
            this.lal_quenPassWord.Location = new System.Drawing.Point(37, 623);
            this.lal_quenPassWord.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lal_quenPassWord.Name = "lal_quenPassWord";
            this.lal_quenPassWord.Size = new System.Drawing.Size(188, 32);
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
            this.bnt_exit.Location = new System.Drawing.Point(386, 424);
            this.bnt_exit.Margin = new System.Windows.Forms.Padding(6);
            this.bnt_exit.Name = "bnt_exit";
            this.bnt_exit.Size = new System.Drawing.Size(264, 70);
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
            this.bnt_login.Location = new System.Drawing.Point(37, 424);
            this.bnt_login.Margin = new System.Windows.Forms.Padding(6);
            this.bnt_login.Name = "bnt_login";
            this.bnt_login.Size = new System.Drawing.Size(264, 75);
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
            this.label2.Location = new System.Drawing.Point(74, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 36);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(74, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 36);
            this.label1.TabIndex = 26;
            this.label1.Text = "Email";
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_matkhau.Location = new System.Drawing.Point(85, 274);
            this.txt_matkhau.Margin = new System.Windows.Forms.Padding(6);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '*';
            this.txt_matkhau.Size = new System.Drawing.Size(495, 32);
            this.txt_matkhau.TabIndex = 25;
            this.txt_matkhau.Text = "123";
            // 
            // txt_email
            // 
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Location = new System.Drawing.Point(74, 113);
            this.txt_email.Margin = new System.Windows.Forms.Padding(6);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(506, 32);
            this.txt_email.TabIndex = 24;
            this.txt_email.Text = "vancuong.tkt36@gmail.com";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.ForeColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(39, 562);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(167, 32);
            this.linkLabel1.TabIndex = 32;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Đổi mật khẩu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(898, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 664);
            this.panel1.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::_3_GUI_PresentationLayer.Properties.Resources.top_giay_sneaker_hot_2021_rotated;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 664);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(85, 313);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 2);
            this.panel2.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(74, 150);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(506, 2);
            this.panel4.TabIndex = 36;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1442, 664);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lal_quenPassWord);
            this.Controls.Add(this.bnt_exit);
            this.Controls.Add(this.bnt_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_email);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frm_Login";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
    }
}