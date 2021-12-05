
namespace _3_GUI_PresentationLayer
{
    partial class Frm_Vouchers
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
            this.label5 = new System.Windows.Forms.Label();
            this.dtgv_vorcher = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_vorcher)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(493, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "VouCher";
            // 
            // dtgv_vorcher
            // 
            this.dtgv_vorcher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_vorcher.Location = new System.Drawing.Point(115, 92);
            this.dtgv_vorcher.Name = "dtgv_vorcher";
            this.dtgv_vorcher.RowTemplate.Height = 25;
            this.dtgv_vorcher.Size = new System.Drawing.Size(856, 439);
            this.dtgv_vorcher.TabIndex = 5;
            this.dtgv_vorcher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_vorcher_CellClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            // 
            // Frm_Vouchers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1100, 666);
            this.Controls.Add(this.dtgv_vorcher);
            this.Controls.Add(this.label5);
            this.Name = "Frm_Vouchers";
            this.Text = "Frm_Voucher";
            this.Load += new System.EventHandler(this.Frm_Vouchers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_vorcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgv_vorcher;
        private System.Windows.Forms.Timer timer1;
    }
}