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
    public partial class frmTimKiemKhachHang : Form
    {
        public frmTimKiemKhachHang()
        {
            InitializeComponent();
        }

        //Biến dữ liệu sản phẩm
        KetNoiDuLieu ketnoikh = new KetNoiDuLieu();
        DataTable khachhang = new DataTable();

        //Form_Load bảng tìm kiếm Khách Hàng
        private void frmTimKiemKhachHang_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvTimKiemKH.Columns.Count; i++)
            {
                cboKhachHang.Items.Add(dgvTimKiemKH.Columns[i].HeaderText);
            }
            cboKhachHang.SelectedIndex = 0;
            XuLyDuLieu("select * from KHACHHANG", dgvTimKiemKH);
            pnlTimKiemKH.Visible = false;
        }
        void XuLyDuLieu(string query, DataGridView DL)
        {
            khachhang = ketnoikh.ExcuteQuery(query);
            DL.DataSource = khachhang;
        }
        //hàm tìm kiếm khách hàng
        void TimKiemKH()
        {
            
            string query = "";
            for (int i = 0; i < cboKhachHang.Items.Count; i++)
            {
                if (cboKhachHang.SelectedIndex == 0)
                {
                    query = "select * from KHACHHANG where ID_KhachHang like N'%" + txtTimKiemKH.Text + "%'";
                }
                else if (cboKhachHang.SelectedIndex == 1)
                {
                    query = "select * from KHACHHANG where TenKhachHang like N'%" + txtTimKiemKH.Text + "%'";
                }
                else if (cboKhachHang.SelectedIndex == 2)
                {
                    query = "select * from KHACHHANG where NgaySinh between '" + dtpFrom.Text + "'AND'" + dtpTo.Text + "'";
                }
                else if (cboKhachHang.SelectedIndex == 3)
                {
                    query = "select * from KHACHHANG where DiaChi like N'%" + txtTimKiemKH.Text + "%'";
                }
                else
                {
                    query = "select * from KHACHHANG where SoDT like N'%" + txtTimKiemKH.Text + "%'";
                }
            }
            XuLyDuLieu(query, dgvTimKiemKH);
        }

        //Button tìm kiếm ở form tìm kiếm sản phẩm
        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
            TimKiemKH();
        }


        //Bẫy lỗi ở sự kiện KeyPress
        private void btnThoatTimKiemKH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFromKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }
        private void frmTimKiemKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ThoatHoi;
            ThoatHoi = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (ThoatHoi == DialogResult.No)
                e.Cancel = true;
        }

        private void cboKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhachHang.SelectedIndex == 2)
            {
                pnlTimKiemKH.Visible = true;
                btnTimKiemKH.Visible = true;
                txtTimKiemKH.Enabled = false;
            }
            else
            {
                txtTimKiemKH.Enabled = true;
                btnTimKiemKH.Visible = false;
                pnlTimKiemKH.Visible = false;
            }

        }


        //Button Tìm kiếm khách hàng
        private void btnTimKIemKH_Click(object sender, EventArgs e)
        {
            TimKiemKH();
        }

        //Button Tải lại danh sách khách hàng
        private void btnDatLaiKH_Click(object sender, EventArgs e)
        {
            XuLyDuLieu("select * from KHACHHANG", dgvTimKiemKH);
            txtTimKiemKH.Text = "";
            txtTimKiemKH.Focus();
        }

        //Button Thoát tìm kiếm khách hàng
        private void btnThoatTimKiemKH_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
