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
    public partial class frmTimKiemHoaDon : Form
    {
        public frmTimKiemHoaDon()
        {
            InitializeComponent();
        }
        //Biến dữ liệu hoá đơn
        KetNoiDuLieu iiKetNoi = new KetNoiDuLieu();
        DataTable HoaDon = new DataTable();
        //Form_Load bảng tìm kiếm hoá đơn
        private void frmTimKiemHoaDon_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvTimKiemHD.Columns.Count; i++)
            {
                cboTimKiemHD.Items.Add(dgvTimKiemHD.Columns[i].HeaderText);
            }
            cboTimKiemHD.SelectedIndex = 0;
            XuLyDuLieu("select * from HOADON", dgvTimKiemHD);
            //pnlTimKiem.Visible = false;
        }
        //Xử lý dữ liệu kết nối bảng hoá đơn
        void XuLyDuLieu(string query, DataGridView DL)
        {
            HoaDon = iiKetNoi.ExcuteQuery(query);
            DL.DataSource = HoaDon;
        }
        private void frmTimKiemHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ThoatHoi;
            ThoatHoi = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (ThoatHoi == DialogResult.No)
                e.Cancel = true;
        }

        //Hàm tìm kiếm
        void TimKiemHD()
        {
            string query = "";
            for (int i = 0; i < cboTimKiemHD.Items.Count; i++)
            {
                if (cboTimKiemHD.SelectedIndex == 0)
                {
                    query = "select * from HOADON where ID_HoaDon like '%" + txtTimKiemHD.Text + "%'";
                }
                else if (cboTimKiemHD.SelectedIndex == 1)
                {
                    query = "select * from HOADON where ID_KhachHang like '%" + txtTimKiemHD.Text + "%'";
                }
                else if (cboTimKiemHD.SelectedIndex == 2)
                {
                    query = "select * from HOADON where DiaChi like '%" + txtTimKiemHD.Text + "%'";
                }
                else if (cboTimKiemHD.SelectedIndex == 3)
                {
                    query = "select * from HOADON where NgayBan like '%" + txtTimKiemHD.Text + "%'";
                }
                else if (cboTimKiemHD.SelectedIndex == 4)
                {
                    query = "select * from HOADON where TongTien like '%" + txtTimKiemHD.Text + "%'";
                }
                else
                {
                    query = "select * from HOADON where TrangThai like '%" + txtTimKiemHD.Text + "%'";
                }
            }
            XuLyDuLieu(query, dgvTimKiemHD);
        }

        //Button tải lại hoá đơn
        private void btnDatLaiHD_Click_1(object sender, EventArgs e)
        {
            XuLyDuLieu("select * from HOADON", dgvTimKiemHD);
            txtTimKiemHD.Text = "";
            txtTimKiemHD.Focus();
        }

        //Button Tìm kiếm hoá đơn
        private void btnTimKiemHD_Click(object sender, EventArgs e)
        {
            TimKiemHD();
        }
        //Button thoát tìm kiếm hoá đơn 
        private void btnThoatTimKiemHD_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
