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
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }

        //Biến dữ liệu sản phẩm
        KetNoiDuLieu iiKetNoi = new KetNoiDuLieu();
        DataTable SanPham = new DataTable();

        //Form_Load bảng tìm kiếm sản phẩm
        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            for(int i = 0;i < dgvTimKiemSP.Columns.Count;i++)
            {
                cboTimKiemSP.Items.Add(dgvTimKiemSP.Columns[i].HeaderText);
            }
            cboTimKiemSP.SelectedIndex = 0;
            XuLyDuLieu("select * from SANPHAM",dgvTimKiemSP);
        }

        //Xử lý dữ liệu kết nối bảng sản phẩm
        void XuLyDuLieu(string query , DataGridView DL)
        {
            SanPham = iiKetNoi.ExcuteQuery(query);
            DL.DataSource = SanPham;
        }

        //Hàm tìm kiếm
        void TimKiemSP()
        {
            string query = "";
            for (int i = 0; i < cboTimKiemSP.Items.Count; i++)
            {
                if (cboTimKiemSP.SelectedIndex == 0)
                {
                    query = "select * from SANPHAM where ID_SanPham like '%" + txtTimKiemSP.Text + "%'";
                }
                else if (cboTimKiemSP.SelectedIndex == 1)
                {
                    query = "select * from SANPHAM where ID_LoaiSanPham like '%" + txtTimKiemSP.Text + "%'";
                }
                else if (cboTimKiemSP.SelectedIndex == 2)
                {
                    query = "select * from SANPHAM where TenSanPham like N'%" + txtTimKiemSP.Text + "%'";
                }
                else if (cboTimKiemSP.SelectedIndex == 3)
                {
                    query = "select * from SANPHAM where TrangThai like '%" + txtTimKiemSP.Text + "%'";
                }
                else 
                {
                    query = "select * from SANPHAM where ID_NCC like '%" + txtTimKiemSP.Text + "%'";
                }
            }  
            XuLyDuLieu(query, dgvTimKiemSP);
        }
        //ComboBox sự kiện SelectedIndexChanged tìm kiếm
        private void cboTimKiemSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(cboTimKiemSP.SelectedIndex > 4 && cboTimKiemSP.SelectedIndex < 8)
            //{
            //    txtTimKiemSP.Text = "";
            //}    
            //else
            //{
            //    txtTimKiemSP.Enabled = true;
            //}    
        }
        //Bẫy lỗi ở sự kiện KeyPress From To
        private void txtFrom_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;

        }
        private void txtTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void frmTimKiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ThoatHoi;
            ThoatHoi = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (ThoatHoi == DialogResult.No)
                e.Cancel = true;
        }

        //Button tìm kiếm sản phẩm
        private void btnTimKiemSP_Click_1(object sender, EventArgs e)
        {
            TimKiemSP();
        }

        //Button tải lại bảng tìm kiếm sản phẩm
        private void btnDatLaiSP_Click_1(object sender, EventArgs e)
        {
            XuLyDuLieu("select * from SANPHAM", dgvTimKiemSP);
            txtTimKiemSP.Text = "";
            txtTimKiemSP.Focus();
        }

        //Button thoát tìm kiếm sản phẩm
        private void btnThoatTimKiemSP_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
