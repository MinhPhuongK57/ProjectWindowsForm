using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _452_417_CDTH19E_SHOESSHOP
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }


        //Button đăng nhập
        private void btnDangNhapForm_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            //frmTrangChu form = new frmTrangChu();
            //form.ShowDialog();
            //this.Show();
            if ((txtTenDangNhap.Text == "tmp" || txtTenDangNhap.Text == "ptd") && (txtMatKhau.Text == "123456"))
            {
                this.Hide();
                frmTrangChu form = new frmTrangChu();
                form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("sai tên đăng nhập hoặc mật khẩu!!!!!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*----------------Password----------*/
        private void picEye_MouseUp(object sender, MouseEventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void picEye_MouseDown(object sender, MouseEventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = false;
        }

        private void txtMatKhau_KeyUp_1(object sender, KeyEventArgs e)
        {
            picEye.Visible = true;
            if (txtMatKhau.Text == "")
            {
                picEye.Visible = false;
            }
            //else
            //{
            //    picEye.Visible = true;
            //}
        }

        private void txtMatKhau_KeyDown_1(object sender, KeyEventArgs e)
        {
            picEye.Visible = false;
        }
        /*----------------Password----------*/

        //Xử lý textbox đăng nhập
        private void txtTenDangNhap_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                errorProvider.SetError(txtTenDangNhap, null);
            }
        }

        //Bẫy lỗi textbox đăng nhập nếu người dùng không nhập dữ liệu
        private void txtTenDangNhap_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text))
            {

                errorProvider.SetError(txtTenDangNhap, "Bạn chưa nhập dữ liệu");
                txtTenDangNhap.Focus();
            }
        }

        private void btnThoatDangNhap_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
