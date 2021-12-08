using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS_BusinessLayer.IService;
using _2_BUS_BusinessLayer.Service;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_Doimatkhau : Form
    {
        private I_Login chucnangLogin;
        public Frm_Doimatkhau()
        {
            InitializeComponent();
            chucnangLogin = new Login();
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtPass.Text.Trim().Length == 0)
            {
                MessageBox.Show("bạn phải nhập mật khẩu cũ vào", "thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtPass.Focus();
                return;
            }
            else if (txtPassNew.Text.Trim().Length == 0)
            {
                MessageBox.Show("bạn phải nhập mật khẩu mới vào", "thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtPassNew.Focus();
                return;
            }
            else if (txtPassNew2.Text.Trim().Length == 0)
            {
                MessageBox.Show("bạn phải nhập mật khẩu mới vào", "thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtPassNew2.Focus();
                return;
            }
            else if (txtPassNew2.Text.Trim().Length != txtPassNew.Text.Trim().Length)
            {
                MessageBox.Show("Mật khẩu cũ và mật khẩu mới không trùng nhập lại", "thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtPassNew2.Focus();
                return;
            }
            else
            {
                if (MessageBox.Show("bạn có chắc muốn đổi mật khẩu", "thông báo", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {

                    string mkcu = chucnangLogin.BUSMahoaPassWord(txtPass.Text);
                    string mkmoi = chucnangLogin.BUSMahoaPassWord(txtPassNew.Text);
                    if (chucnangLogin.BUSupdatepassword(mkcu, mkmoi, txtMail.Text))
                    {
                        MessageBox.Show("đổi rồi đấy check lại xem");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ sai ", "thông báo");
                        txtPass.Text = null;
                        txtPassNew.Text = null;
                        txtPassNew2.Text = null;
                    }
                }
            }
        }

        private void cbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMK.Checked == true)
            {
                txtPass.PasswordChar = '\0';
                txtPassNew.PasswordChar = '\0';
                txtPassNew2.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '$';
                txtPassNew.PasswordChar = '$';
                txtPassNew2.PasswordChar = '$';
            }
        }
    }
}
