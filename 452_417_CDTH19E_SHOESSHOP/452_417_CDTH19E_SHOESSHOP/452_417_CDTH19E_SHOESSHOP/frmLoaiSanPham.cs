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
    public partial class frmLoaiSanPham : Form
    {
        public frmLoaiSanPham()
        {
            InitializeComponent();
            KetNoiLSP();
        }
        //Biến dữ liệu sản phẩm
        KetNoiDuLieu iiKetNoi = new KetNoiDuLieu();
        DataTable LoaiSanPham = new DataTable();
        void KetNoiLSP()
        {
            KetNoiDuLieu iKetNoiLSP = new KetNoiDuLieu();
            dgvLoaiSanPham.DataSource = iKetNoiLSP.ExcuteQuery("select * from LOAISANPHAM");
        }

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            btnThemLoaiSP.Enabled = false;
            LoaiSanPham = iiKetNoi.ExcuteQuery("Select ID_LoaiSanPham from LOAISANPHAM");
            HienThiTextbox(0);
        }
        void HienThiTextbox(int vitri)
        {
            //Sản Phẩm
            LoaiSanPham = iiKetNoi.ExcuteQuery("select * from LOAISANPHAM");
            txtIDLoaiSanPham.Text = LoaiSanPham.Rows[vitri][0].ToString();
            txtTenLoaiSP.Text = LoaiSanPham.Rows[vitri][1].ToString();
            numTrangThaiLSP.Value = Convert.ToInt32(LoaiSanPham.Rows[vitri][2]);
        }

        //Button Thoát
        private void btnThoatLoaiSP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Hàm kiểm tra ID Loại Sản Phẩm
        bool KiemTraIDLSP()
        {
            string query = "select ID_LoaiSanPham from LOAISANPHAM ";
            LoaiSanPham = iiKetNoi.ExcuteQuery(query);
            int size = LoaiSanPham.Rows.Count;
            for (int i = 0; i < size; i++)
            {
                if (txtIDLoaiSanPham.Text == LoaiSanPham.Rows[i][0].ToString())
                {
                    return true;
                    break;
                }
            }
            return false;
        }
        private void frmLoaiSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ThoatHoi;
            ThoatHoi = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (ThoatHoi == DialogResult.No)
                e.Cancel = true;
        }
        //Hàm thêm DL Loại Sản Phẩm
        void ThemDLLSP()
        {
            if (KiemTraIDLSP())
            {
                MessageBox.Show("ID đã tồn tại", "Thông báo");
            }
            else
            {
                DataTable ThemLSP = new DataTable();
                string query = "insert into LOAISANPHAM values('" + txtIDLoaiSanPham.Text + "', N'" + txtTenLoaiSP.Text + "', '" + numTrangThaiLSP.Value + "')";
                ThemLSP = iiKetNoi.ExcuteQuery(query);
                KetNoiLSP();
            }
        }
        //Button thêm Loại Sản Phẩm
        private void btnThemLoaiSP_Click_1(object sender, EventArgs e)
        {
            try
            {
                ThemDLLSP();
                KetNoiLSP();
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
        }
        //Hàm cập nhật DL Loại Sản Phẩm
        void CapNhatDLLSP(string query)
        {
            LoaiSanPham = iiKetNoi.ExcuteQuery(query);
            KetNoiLSP();
            HienThiTextbox(0);
            if (iiKetNoi.ExcuteNonQuery(query) > 0)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công", "Thông báo");
            }
        }
        //Button cập nhật Loại Sản Phẩm
        private void btnCapNhatLoaiSP_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "update LOAISANPHAM set[ID_LoaiSanPham] = '" + txtIDLoaiSanPham.Text + "',[TenLoai] = N'" + txtTenLoaiSP.Text + "',[TrangThai]= '" + numTrangThaiLSP.Value + "' where ID_LoaiSanPham = '" + txtIDLoaiSanPham.Text + "'";
                CapNhatDLLSP(query);
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
        }
        //Hàm xoá SL Loại Sản Phẩm
        void XoaDLLSP(string query)
        {
            int size = LoaiSanPham.Rows.Count;
            LoaiSanPham = iiKetNoi.ExcuteQuery(query);
            int size2 = LoaiSanPham.Rows.Count;
            if (size2 < size)
            {
                MessageBox.Show("Bạn đã xoá dữ liệu thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xoá dữ liệu không thành công", "Thông báo");
            }
            KetNoiLSP();
            HienThiTextbox(0);
        }
        //Button xoá Loại Sản Phẩm
        private void btnXoaLoaiLSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (KiemTraIDLSP())
            {
                MessageBox.Show("Còn sản phẩm loại này", "Thông báo");
            }
            else
            {
                string query = "Delete from LOAISANPHAM where ID_LoaiSanPham = '" + txtIDLoaiSanPham.Text + "'";
                XoaDLLSP(query);
            }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
        }

        private void dgvLoaiSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            int size = LoaiSanPham.Rows.Count;
            if (vitri >= 0 && vitri != size)
                HienThiTextbox(vitri);
        }

        private void txtIDLoaiSanPham_TextChanged_1(object sender, EventArgs e)
        {
            if (txtIDLoaiSanPham.Text != "")
            {
                btnThemLoaiSP.Enabled = true;
            }
            else
                btnThemLoaiSP.Enabled = false;
        }

        private void numTrangThaiLSP_KeyUp(object sender, KeyEventArgs e)
        {
            if (numTrangThaiLSP.Value > 1)
                numTrangThaiLSP.Value = 1;
            else if (numTrangThaiLSP.Value < 0)
                numTrangThaiLSP.Value = 0;
        }

    }
}
