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
    public partial class frmChiTietHoaDon : Form
    {
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }
        //Biến dữ liệu chi tiết hoá đơn
        KetNoiDuLieu iiKetNoi = new KetNoiDuLieu();
        DataTable ChiTietHoaDon = new DataTable();
        DataTable HoaDon = new DataTable();
        DataTable KhachHang = new DataTable();
        int vtclick = 0;
        //Form Load
        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            HoaDon = iiKetNoi.ExcuteQuery("Select ID_HoaDon from HOADON");
            ChiTietHoaDon = iiKetNoi.ExcuteQuery("Select ID_HoaDon from CHITIETHOADON");
            KhachHang = iiKetNoi.ExcuteQuery("Select ID_KhachHang from HOADON");
            for (int i = 0; i < KhachHang.Rows.Count; i++)
            {
                cboIDKhachHang.Items.Add(KhachHang.Rows[i][0]);
            }
            KetNoiHD();
            KetNoiCTHD(0);
            HienThiHD(0);
            HienThiTextbox(0);
            cboIDKhachHang.SelectedIndex = 0;
        }
        //Hàm kết nối dữ liệu hoá đơn
        void KetNoiHD()
        {
            KetNoiDuLieu iKetNoiHD = new KetNoiDuLieu();
            HoaDon = iKetNoiHD.ExcuteQuery("select * from HOADON");
            dgvHoaDon.DataSource = HoaDon;
        }
        //Hàm Kết nối chi tiết hoá đơn
        void KetNoiCTHD(int vitrii)
        {
            KetNoiDuLieu iKetNoiCTHD = new KetNoiDuLieu();
            ChiTietHoaDon = iKetNoiCTHD.ExcuteQuery("select * from CHITIETHOADON where ID_HoaDon ='" + HoaDon.Rows[vitrii][0] + "'");
            dgvChiTietHD.DataSource = ChiTietHoaDon;
        }
        //Hàm hiển thị dữ liệu chi tiết hoá đơn
        void HienThiTextbox(int vitri)
        {
            //Sản Phẩm
            txtIDHoaDon.Text = ChiTietHoaDon.Rows[vitri][0].ToString();
            txtIDSanPham.Text = ChiTietHoaDon.Rows[vitri][1].ToString();
            txtDonGia.Text = string.Format("{0:n0}", ChiTietHoaDon.Rows[vitri][2]);

            numSoLuongSP.Value = Convert.ToInt32(ChiTietHoaDon.Rows[vitri][3]);
            txtGiamGia.Text = string.Format("{0:n0}", ChiTietHoaDon.Rows[vitri][4]);

            txtThanhTien.Text = string.Format("{0:n0}", ChiTietHoaDon.Rows[vitri][5]);

        }
        //Button Thoát
        private void picThoatChiTietHoaDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Text changed
        private void txtIDSanPham_TextChanged(object sender, EventArgs e)
        {
            if (txtIDSanPham.Text != "")
            {
                btnThemCTHD.Enabled = true;
            }
            else
                btnThemCTHD.Enabled = false;

        }

        //Kiểm tra dữ liệu ID bảng chi tiết hoá đơn
        bool KiemTraIDCTHD()
        {
            string query = "select ID_HoaDon from CHITIETHOADON";
            ChiTietHoaDon = iiKetNoi.ExcuteQuery(query);
            int size = ChiTietHoaDon.Rows.Count;
            for (int i = 0; i < size; i++)
            {
                if (txtIDHoaDon.Text != ChiTietHoaDon.Rows[i][0].ToString()&&txtIDSanPham.Text=="")
                {
                    return false;
                    break;
                }
            }
            return true;
        }
        //Hàm thêm chi tiết hoá đơn
        void ThemDLCTHD()
        {
            if (!KiemTraIDCTHD())
            {
                MessageBox.Show("ID đã tồn tại", "Thông báo");
            }
            else
            {
                DataTable ThemCTHD = new DataTable();
                string query = "insert into CHITIETHOADON values('" + txtIDHoaDon.Text + "', '" + txtIDSanPham.Text + "','"+txtDonGia.Text +"','" + numSoLuongSP.Value + "','" + txtGiamGia.Text + "', '" + txtThanhTien.Text + "')";
                ThemCTHD = iiKetNoi.ExcuteQuery(query);
                KetNoiCTHD(0);
            }
        }
        //Button thêm chi tiết hoá đơn
        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            try { 
            ThemDLCTHD();
            KetNoiHD();
            HienThiHD(0);
            KetNoiCTHD(0);
            if (ChiTietHoaDon.Rows.Count > 0)
                HienThiTextbox(0);
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
        }
        //Hàm cập nhật dữ liệu chi tiết hoá đơn
        void CapNhatDLCTHD(string query)
        {
            ChiTietHoaDon = iiKetNoi.ExcuteQuery(query);
            KetNoiCTHD(0);
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
        //Button cập nhật chi tiết hoá đơn
        private void btnCapNhatCTHD_Click(object sender, EventArgs e)
        {
            try {
            string query = "update CHITIETHOADON set[DonGia]= '" + txtDonGia.Text + "',[SoLuong] = '" + numSoLuongSP.Value + "' , [GiamGia] = '" + txtGiamGia.Text + "', [ThanhTien] = '" + txtThanhTien.Text + "' where ID_HoaDon = '" + txtIDHoaDon.Text + "'and ID_SanPham = N'" + txtIDSanPham.Text + "'";
            CapNhatDLCTHD(query);
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
        }

        //Hàm xoá dữ liệu chi tiết hoá đơn
        void XoaDLCTHD(string query)
        {
            int size = ChiTietHoaDon.Rows.Count;
            ChiTietHoaDon = iiKetNoi.ExcuteQuery(query);
            int size2 = ChiTietHoaDon.Rows.Count;
            if (size2 < size)
            {
                MessageBox.Show("Bạn đã xoá dữ liệu thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xoá dữ liệu không thành công", "Thông báo");
            }
            KetNoiCTHD(0);
            HienThiTextbox(0);
        }
        //Button xoá chi tiết hoá đơn
        private void btnXoaCTHD_Click(object sender, EventArgs e)
        {
            try { 
            if (KiemTraIDCTHD())
            {
                MessageBox.Show("Còn sản phẩm loại này", "Thông báo");
            }
            else
            {
                string query = "Delete from CHITIETHOADON where ID_HoaDon = '" + txtIDHoaDon.Text + "'";
                XoaDLCTHD(query);
            }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
        }
        //Closing Form
        private void frmChiTietHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ThoatHoi;
            ThoatHoi = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (ThoatHoi == DialogResult.No)
                e.Cancel = true;
        }

        //CellClick Chi tiết hoá đơn 
        private void dgvChiTietHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            int size = ChiTietHoaDon.Rows.Count;
            if (vitri >= 0 && vitri != size)
            {
                HienThiTextbox(vitri);
                
            }    
        }
        //CellClick hoá đơn
        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            int size = HoaDon.Rows.Count;
            if (vitri >= 0 && vitri != size)
            {
                HienThiHD(vitri);
                KetNoiCTHD(vitri);
                if(ChiTietHoaDon.Rows.Count>0)
                HienThiTextbox(0);   
            }    
        }


        // Sự kiện TextChanged
        private void txtIDHoaDonn_TextChanged(object sender, EventArgs e)
        {
            if (txtIDHoaDonn.Text != "")
            {
                btnThemHD.Enabled = true;
            }
            else
                btnThemHD.Enabled = false;
        }

        private void txtIDHoaDon_TextChanged(object sender, EventArgs e)
        {
            if (txtIDHoaDon.Text != "")
            {
                btnThemCTHD.Enabled = true;
            }
            else
                btnThemCTHD.Enabled = false;
        }
        //Kiểm tra trạng thái
        private void numTrangThaiHD_KeyUp(object sender, KeyEventArgs e)
        {
            if (numTrangThaiHD.Value > 1)
                numTrangThaiHD.Value = 1;
            else if (numTrangThaiHD.Value < 0)
                numTrangThaiHD.Value = 0;
        }


        //Hàm Hiển thị hoá đơn
        void HienThiHD(int vitri)
        {
            //Hoá đơn
            txtIDHoaDonn.Text = HoaDon.Rows[vitri][0].ToString();
            cboIDKhachHang.Text = HoaDon.Rows[vitri][1].ToString();
            txtDiaChiHD.Text = HoaDon.Rows[vitri][2].ToString();
            dtpNgayBan.Text = HoaDon.Rows[vitri][3].ToString();
            txtTongTienHD.Text = string.Format("{0:n0}",HoaDon.Rows[vitri][4]);

            numTrangThaiHD.Value = Convert.ToInt32(HoaDon.Rows[vitri][5]);
        }
        //Hàm kiểm tra ID hoá đơn
        bool KiemTraIDHD()
        {
            string query = "select ID_HoaDon from HOADON ";
            HoaDon = iiKetNoi.ExcuteQuery(query);
            int size = HoaDon.Rows.Count;
            for (int i = 0; i < size; i++)
            {
                if (txtIDHoaDonn.Text == HoaDon.Rows[i][0].ToString())
                {
                    return true;
                    break;
                }
            }
            return false;
        }
        //Hàm thêm dữ liệu hoá đơn
        void ThemDLHD()
        {
            try
            {
                if (KiemTraIDHD())
                {
                    MessageBox.Show("ID đã tồn tại", "Thông báo");
                }
                else
                {
                    string query = "insert into HOADON values('" + txtIDHoaDonn.Text + "', '" + cboIDKhachHang.Text + "', N'" + txtDiaChiHD.Text + "', '" + dtpNgayBan.Value + "', '" + txtTongTienHD.Text + "', '" + numTrangThaiHD.Value + "')";
                    iiKetNoi.ExcuteQuery(query);
                    KetNoiHD();
                }
            }catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
            
        }
        //Button thêm hoá đơn
        private void btnThemHD_Click(object sender, EventArgs e)
        {

            ThemDLHD();
            KetNoiHD();
        }
        //Hàm cập nhật dữ liệu hoá đơn
        void CapNhatDLHD()
        {
            try
            {

            string query = "update HOADON set ID_KhachHang = '" + cboIDKhachHang.Text + "', DiaChi = N'" + txtDiaChiHD.Text + "' ,NgayBan = '" + dtpNgayBan.Value + "',TongTien = '" + txtTongTienHD.Text + "', TrangThai = '" + numTrangThaiHD.Value + "' where ID_HoaDon = '" + txtIDHoaDon.Text + "'";
            HoaDon = iiKetNoi.ExcuteQuery(query);
            KetNoiHD();
            HienThiHD(0);
            if (iiKetNoi.ExcuteNonQuery(query) > 0)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công", "Thông báo");
            }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
        }
        //Button cập nhật hoá đơn
        private void btnCapNhatHD_Click(object sender, EventArgs e)
        {
            CapNhatDLHD();
        }
        //Hàm xoá dữ liệu hoá đơn
        void XoaDLHD(string query)
        {
            int size = HoaDon.Rows.Count;
            HoaDon = iiKetNoi.ExcuteQuery(query);
            int size2 = HoaDon.Rows.Count;
            if (size2 < size)
            {
                MessageBox.Show("Bạn đã xoá dữ liệu thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xoá dữ liệu không thành công", "Thông báo");
            }
            KetNoiHD();
            HienThiHD(0);
        }
        //Button xoá hoá đơn
        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            try
            {

            string query = "Delete from HOADON where ID_HoaDon = '" + txtIDHoaDon.Text + "'";
            DialogResult Thoat = MessageBox.Show("Bạn có muốn xoá không..!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (Thoat == DialogResult.Yes)
                XoaDLHD(query);
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
        }

        private void txtDiaChiHD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
