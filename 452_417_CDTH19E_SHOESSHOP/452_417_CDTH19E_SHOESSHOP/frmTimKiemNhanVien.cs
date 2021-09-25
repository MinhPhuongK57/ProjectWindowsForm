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
    public partial class frmTimKiemNhanVien : Form
    {
        public frmTimKiemNhanVien()
        {
            InitializeComponent();
        }

        //Biến dữ liệu sản phẩm
        KetNoiDuLieu KetNoiNV = new KetNoiDuLieu();
        DataTable NhanVien= new DataTable();

        //Form_Load bảng tìm kiếm Khách Hàng
        private void frmTimKiemNhanVien_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvTimKiemNV.Columns.Count; i++)
            {
                cboNhanVien.Items.Add(dgvTimKiemNV.Columns[i].HeaderText);
            }
            cboNhanVien.SelectedIndex = 0;
            XuLyDuLieu("select * from NhanVien", dgvTimKiemNV);
            pnlTimKiemTheoLuong.Visible = false;
        }
        void XuLyDuLieu(string query, DataGridView DL)
        {
            NhanVien = KetNoiNV.ExcuteQuery(query);
            DL.DataSource = NhanVien;
        }


        //Bẫy lỗi ở sự kiện KeyPress
        private void txtFromNV_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void frmTimKiemNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ThoatHoi;
            ThoatHoi = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (ThoatHoi == DialogResult.No)
                e.Cancel = true;
        }

        void TimKiemNV()
        {

            string query = "";
            for (int i = 0; i < cboNhanVien.Items.Count; i++)
            {
                if (cboNhanVien.SelectedIndex == 0)
                {
                    query = "select * from NHANVIEN where ID_NhanVien like N'%" + txtTimKiemNV.Text + "%'";
                }
                else if (cboNhanVien.SelectedIndex == 1)
                {
                    query = "select * from NHANVIEN where TenNhanVien like N'%" + txtTimKiemNV.Text + "%'";
                }
                else if (cboNhanVien.SelectedIndex == 2)
                {
                    query = "select * from NHANVIEN where NgaySinh between '" + dtpFrom.Text + "'AND'" + dtpTo.Text + "'";
                }
                else if (cboNhanVien.SelectedIndex == 3)
                {
                    query = "select * from NHANVIEN where SoDT like N'%" + txtTimKiemNV.Text + "%'";
                }
                else if (cboNhanVien.SelectedIndex == 4)
                {
                    query = "select * from NHANVIEN where Luong between '" + txtFromNV.Text + "'AND'" + txtToNV.Text + "'";
                }
                else if (cboNhanVien.SelectedIndex == 5)
                {
                    query = "select * from NHANVIEN where Email like N'%" + txtTimKiemNV.Text + "%'";
                }
                else if (cboNhanVien.SelectedIndex == 7)
                {
                    query = "select * from NHANVIEN where DiaChi like N'%" + txtTimKiemNV.Text + "%'";
                }
                else
                {   
                    query = "select * from NHANVIEN where TrangThai like N'%" + txtTimKiemNV.Text + "%'";
                }
            }
            XuLyDuLieu(query, dgvTimKiemNV);
        }

        //Button tìm kiếm ở form tìm kiếm sản phẩm
        private void cboNhanVien_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboNhanVien.SelectedIndex == 2)
            {
                pnlTimKiemTheoNgaySinh.Visible = true;
                txtTimKiemNV.Enabled = false;
                pnlTimKiemTheoLuong.Visible = false;
                btnTimKiemNV.Visible = true;
            }
            else if(cboNhanVien.SelectedIndex==4)
            {
                btnTimKiemNV.Visible = true;
                pnlTimKiemTheoLuong.Visible = true;
                txtTimKiemNV.Enabled = false;
                pnlTimKiemTheoNgaySinh.Visible =false;
            }
            else
            {
                btnTimKiemNV.Visible = false;
                txtTimKiemNV.Enabled = true;
                pnlTimKiemTheoLuong.Visible = false;
                pnlTimKiemTheoNgaySinh.Visible = false;
            }
        }
        private void btnTimKiemNV_Click_1(object sender, EventArgs e)
        {
            TimKiemNV();
        }

        //Button tải lại bảng nhân viên
        private void btnDatLaiNV_Click_1(object sender, EventArgs e)
        {
            XuLyDuLieu("select * from NHANVIEN", dgvTimKiemNV);
            txtTimKiemNV.Text = "";
            txtTimKiemNV.Focus();
        }
        //Button thoát tìm kiếm nhân viên
        private void btnThoatTimKiemNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
