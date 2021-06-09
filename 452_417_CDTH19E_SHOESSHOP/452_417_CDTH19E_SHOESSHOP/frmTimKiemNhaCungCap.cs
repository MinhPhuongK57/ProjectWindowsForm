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
    public partial class frmTimKiemNhaCungCap : Form
    {
        public frmTimKiemNhaCungCap()
        {
            InitializeComponent();
        }
        KetNoiDuLieu KetNoiNCC= new KetNoiDuLieu();
        DataTable NhaCungCap = new DataTable();
        //Form_Load bảng tìm kiếm Nhà cung cấp
        private void frmTimKiemNhaCungCap_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvNhaCungCap.Columns.Count; i++)
            {
                cboNhaCungCap.Items.Add(dgvNhaCungCap.Columns[i].HeaderText);
            }
            cboNhaCungCap.SelectedIndex = 0;
            XuLyDuLieu("select * from NHACUNGCAP", dgvNhaCungCap);
        }
        //Xử lý dữ liệu kết nối bảng Nhà cung cấp
        void XuLyDuLieu(string query, DataGridView DL)
        {
            NhaCungCap = KetNoiNCC.ExcuteQuery(query);
            DL.DataSource = NhaCungCap;
        }
        //Hàm tìm kiếm
        void TimKiemNCC()
        {
            string query = "";
            for (int i = 0; i < cboNhaCungCap.Items.Count; i++)
            {
                if (cboNhaCungCap.SelectedIndex == 0)
                {
                    query = "select * from NHACUNGCAP where ID_NCC like N'%" + txtTimKiemNCC.Text + "%'";
                }
                else if (cboNhaCungCap.SelectedIndex == 1)
                {
                    query = "select * from NHACUNGCAP where TenNCC like N'%" + txtTimKiemNCC.Text + "%'";
                }
                else if (cboNhaCungCap.SelectedIndex == 2)
                {
                    query = "select * from NHACUNGCAP where DiaChi like N'%" + txtTimKiemNCC.Text + "%'";
                }
                else
                {
                    query = "select * from NHACUNGCAP where SoDT like N'%" + txtTimKiemNCC.Text + "%'";
                }
            }
            XuLyDuLieu(query, dgvNhaCungCap);
        }
        //Bẫy lỗi ở sự kiện KeyPress
        private void frmTimKiemNhaCungCap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ThoatHoi;
            ThoatHoi = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (ThoatHoi == DialogResult.No)
                e.Cancel = true;
        }
        //Button tải lại danh sách nhà cung cấp
        private void btnDatLaiNCC_Click_1(object sender, EventArgs e)
        {
            XuLyDuLieu("select * from NHACUNGCAP", dgvNhaCungCap);
            txtTimKiemNCC.Text = "";
            txtTimKiemNCC.Focus();
        }

        //Button Tìm kiếm nhà cung cấp
        private void btnTimKiemNCC_Click_1(object sender, EventArgs e)
        {
            TimKiemNCC();
        }

        //Button Thoát Tìm Kiếm nhà cung cấp

        private void btnThoatTimKIemNCC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
