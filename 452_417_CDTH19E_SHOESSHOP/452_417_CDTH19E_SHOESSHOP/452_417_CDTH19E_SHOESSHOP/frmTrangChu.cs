using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms;

//using WMPLib; //Xuất Excel


namespace _452_417_CDTH19E_SHOESSHOP
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
            KetNoiSP();
            KetNoiHD();
            KetNoiKH();
            KetNoiNCC();
            KetNoiNV();
        }
        KetNoiDuLieu iiKetNoi = new KetNoiDuLieu();
        DataTable LoaiSP = new DataTable();
        DataTable ChiTietSP = new DataTable();
        DataTable NhaCC = new DataTable();
        DataTable SanPham = new DataTable();
        DataTable HoaDon = new DataTable();
        DataTable KhachHang = new DataTable();
        DataTable NhaCungCap = new DataTable();
        DataTable NhanVien = new DataTable();

        //Sự kiện form Load
        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            foreach(DataGridViewColumn column in dgvNhanVien.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }    
            btnThemSP.Enabled = false;
            btnThemHD.Enabled = false;
            btnThemKH.Enabled = false;
            btnThemNCC.Enabled = false;
            btnThemNV.Enabled = false;
            LoaiSP = iiKetNoi.ExcuteQuery("Select ID_LoaiSanPham from LOAISANPHAM");
            ChiTietSP = iiKetNoi.ExcuteQuery("Select ID_ChiTietSanPham from CHITIETSANPHAM");
            NhaCC = iiKetNoi.ExcuteQuery("Select ID_NCC from NHACUNGCAP");
            HoaDon = iiKetNoi.ExcuteQuery("Select ID_HoaDon from HOADON");
            KhachHang =  iiKetNoi.ExcuteQuery("Select ID_KhachHang from KHACHHANG");
            NhaCungCap = iiKetNoi.ExcuteQuery("Select ID_NCC from NHACUNGCAP");
            NhanVien = iiKetNoi.ExcuteQuery("Select ID_NhanVien from NHANVIEN");
            for (int i =0; i < LoaiSP.Rows.Count;i++)
            {
                cboLoaiSanPham.Items.Add(LoaiSP.Rows[i][0]);
            }
            for (int i = 0; i < NhaCC.Rows.Count; i++)
            {
                cboIDNCC.Items.Add(NhaCC.Rows[i][0]);
            }
            for (int i = 0; i < HoaDon.Rows.Count; i++)
            {
                cboIDKhachHang.Items.Add(HoaDon.Rows[i][0]);
            }
            HienThiSP(0);
            HienThiHD(0);
            HienThiKH(0);
            HienThiNCC(0);
            HienThiNV(0);
            cboIDKhachHang.SelectedIndex = 0;
        }

        /*---Hàm kết nối dữ liệu---Start*/
        void KetNoiSP()
        {
            KetNoiDuLieu iKetNoiSP = new KetNoiDuLieu();
            dgvSanPham.DataSource = iKetNoiSP.ExcuteQuery("select * from SANPHAM");
        }
        void KetNoiHD()
        {
            KetNoiDuLieu iKetNoiHD = new KetNoiDuLieu();
            dgvHoaDon.DataSource = iKetNoiHD.ExcuteQuery("select * from HOADON");
        }
        void KetNoiKH()
        {
            KetNoiDuLieu iKetNoiKH = new KetNoiDuLieu();
            dgvKhachHang.DataSource = iKetNoiKH.ExcuteQuery("select * from KHACHHANG");
        }
        void KetNoiNCC()
        {
            KetNoiDuLieu iKetNoiNCC = new KetNoiDuLieu();
            dgvNhaCungCap.DataSource = iKetNoiNCC.ExcuteQuery("select * from NHACUNGCAP");
        }
        void KetNoiNV()
        {
            KetNoiDuLieu iKetNoiNV = new KetNoiDuLieu();
            dgvNhanVien.DataSource = iKetNoiNV.ExcuteQuery("select * from NHANVIEN");
        }
        /*---Hàm kết nối dữ liệu---End.*/


        //Sự kiện form closing Trang Chủ
        private void frmTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ThoatHoi;
            ThoatHoi = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (ThoatHoi == DialogResult.No)
                e.Cancel = true;
        }
        //Button thoát Sản phẩm
        private void btnThoatSP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Button thoát Hoá đơn
        private void btnThoatHD_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Button thoát Khách hàng
        private void btnThoatKH_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Button thoát Nhà cung cấp
        private void btnThoatNCC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Button thoát Nhân viên
        private void btnThoatNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /*Hàm ẩn hiện button khi nhập text : Sự kiện TextChanged*/
        private void txtIDSanPham_TextChanged(object sender, EventArgs e)
        {
            if (txtIDSanPham.Text != "")
            {
                btnThemSP.Enabled = true;
            }
            else
                btnThemSP.Enabled = false;
        }
        private void txtIDHoaDon_TextChanged(object sender, EventArgs e)
        {
            if (txtIDHoaDon.Text != "")
            {
                btnThemHD.Enabled = true;
            }
            else
                btnThemHD.Enabled = false;
        }
        private void txtIDKhachHang_TextChanged(object sender, EventArgs e)
        {
            if (txtIDKhachHang.Text != "")
            {
                btnThemKH.Enabled = true;
            }
            else
                btnThemKH.Enabled = false;
        }
        private void txtIDNCC_TextChanged(object sender, EventArgs e)
        {
            if (txtIDNCC.Text != "")
            {
                btnThemNCC.Enabled = true;
            }
            else
                btnThemNCC.Enabled = false;
        }
        private void txtIDNhanVien_TextChanged(object sender, EventArgs e)
        {
            if (txtIDNhanVien.Text != "")
            {
                btnThemNV.Enabled = true;
            }
            else
                btnThemNV.Enabled = false;
        }

        
        /*Hàm ẩn hiện button khi nhập text*/

        //Cài đặt trạng thái
        private void numTrangThaiHD_KeyUp(object sender, KeyEventArgs e)
        {
            if (numTrangThaiHD.Value > 1)
                numTrangThaiHD.Value = 1;
            else if (numTrangThaiHD.Value < 0)
                numTrangThaiHD.Value = 0;
        }
        private void numTrangThaiNCC_KeyUp(object sender, KeyEventArgs e)
        {
            if (numTrangThaiNCC.Value > 1)
                numTrangThaiNCC.Value = 1;
            else if (numTrangThaiNCC.Value < 0)
                numTrangThaiNCC.Value = 0;
        }
        private void numTrangThaiNV_KeyUp(object sender, KeyEventArgs e)
        {
            if (numTrangThaiNV.Value > 1)
                numTrangThaiNV.Value = 1;
            else if (numTrangThaiNV.Value < 0)
                numTrangThaiNV.Value = 0;
        }
        private void numTrangThaiSP_KeyUp(object sender, KeyEventArgs e)
        {
            if (numTrangThaiSP.Value > 1)
                numTrangThaiSP.Value = 1;
            else if (numTrangThaiSP.Value < 0)
                numTrangThaiSP.Value = 0;
        }

        //Bẫy lỗi kiểm tra nhập vào
        private void txtIDSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }
        private void txtSoDTNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }
        private void txtSoDTKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }
        private void txtSoDTNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }
        private void txtLuongNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }


        void HienThiSP(int vitri)
        {
            //Sản Phẩm
            SanPham = iiKetNoi.ExcuteQuery("select * from SANPHAM");
            txtIDSanPham.Text = SanPham.Rows[vitri][0].ToString();
            cboLoaiSanPham.Text = SanPham.Rows[vitri][1].ToString();
            txtTenSanPham.Text = SanPham.Rows[vitri][2].ToString();
            //numSoSP.Value = Convert.ToInt32(SanPham.Rows[vitri][3]);
            //txtGiaNhapSP.Text = SanPham.Rows[vitri][4].ToString();
            //txtGiaBanSP.Text = SanPham.Rows[vitri][5].ToString();
            numTrangThaiSP.Value = Convert.ToInt32(SanPham.Rows[vitri][3]);
            cboIDNCC.Text = SanPham.Rows[vitri][4].ToString();
        }
        void HienThiHD(int vitri)
        {
            //Hoá đơn
            HoaDon = iiKetNoi.ExcuteQuery("select * from HOADON");
            txtIDHoaDon.Text = HoaDon.Rows[vitri][0].ToString();
            cboIDKhachHang.Text = HoaDon.Rows[vitri][1].ToString();
            txtDiaChiHD.Text = HoaDon.Rows[vitri][2].ToString();
            dtpNgayBan.Text = HoaDon.Rows[vitri][3].ToString();
            txtTongTienHD.Text = HoaDon.Rows[vitri][4].ToString();
            numTrangThaiHD.Value = Convert.ToInt32(HoaDon.Rows[vitri][5]);
        }
        void HienThiKH(int vitri)
        {
            //Khách hàng
            KhachHang = iiKetNoi.ExcuteQuery("select * from KHACHHANG");
            txtIDKhachHang.Text = KhachHang.Rows[vitri][0].ToString();
            txtTenKhachHang.Text = KhachHang.Rows[vitri][1].ToString();
            dtpNgaySinhKH.Text = KhachHang.Rows[vitri][2].ToString();
            txtDiaChiKH.Text = KhachHang.Rows[vitri][3].ToString();
            txtSoDTKH.Text = KhachHang.Rows[vitri][4].ToString();
        }
        void HienThiNCC(int vitri)
        {
            //Nhà cung cấp
            NhaCungCap = iiKetNoi.ExcuteQuery("select * from NHACUNGCAP");
            txtIDNCC.Text = NhaCungCap.Rows[vitri][0].ToString();
            txtTenNCC.Text = NhaCungCap.Rows[vitri][1].ToString();
            txtDiaChiNCC.Text = NhaCungCap.Rows[vitri][2].ToString();
            txtSoDTNCC.Text = NhaCungCap.Rows[vitri][3].ToString();
            numTrangThaiNCC.Value = Convert.ToInt32(NhaCungCap.Rows[vitri][4]);
        }
        void HienThiNV(int vitri)
        {
            NhanVien = iiKetNoi.ExcuteQuery("select * from NHANVIEN");
            txtIDNhanVien.Text = NhanVien.Rows[vitri][0].ToString();
            txtTenNhanVien.Text = NhanVien.Rows[vitri][1].ToString();
            dtpNgaySinhNV.Text = NhanVien.Rows[vitri][2].ToString();
            txtSoDTNV.Text = NhanVien.Rows[vitri][3].ToString();
            txtLuongNV.Text = NhanVien.Rows[vitri][4].ToString();
            txtEmailNV.Text = NhanVien.Rows[vitri][5].ToString();
            numTrangThaiNV.Value = Convert.ToInt32(NhanVien.Rows[vitri][6]);
            txtDiaChiNV.Text = NhanVien.Rows[vitri][7].ToString();
        }

        //Mở Form Tìm kiếm
        private void TimKiemTheoHD_Click(object sender, EventArgs e)
        {
            frmTimKiemHoaDon form = new frmTimKiemHoaDon();
            form.Show();
        }
        private void tìmKiếmTheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiem form = new frmTimKiem();
            form.Show();
        }

        private void TimKiemTheoKH_Click(object sender, EventArgs e)
        {
            frmTimKiemKhachHang form = new frmTimKiemKhachHang();
            form.Show();
        }

        private void TimKiemTheoNV_Click(object sender, EventArgs e)
        {
            frmTimKiemNhanVien form = new frmTimKiemNhanVien();
            form.Show();
        }
        private void TimKiemTheoNCC_Click(object sender, EventArgs e)
        {
            frmTimKiemNhaCungCap form = new frmTimKiemNhaCungCap();
            form.Show();
        }

        /*-----------------------SẢN PHẨM----------------------*/
        //Hàm kiểm tra ID Sản Phẩm
        bool KiemTraIDSP()
        {
            string query = "select ID_SanPham from SANPHAM ";
            SanPham = iiKetNoi.ExcuteQuery(query);
            int size = SanPham.Rows.Count;
            for(int i = 0;i<size;i++)
            {
                if(txtIDSanPham.Text == SanPham.Rows[i][0].ToString())
                {
                    return true;
                    break;
                }    
            }
            return false;
        }

        //Hàm thêm dữ liệu Sản Phẩm
        void ThemDLSP()
        {
            try
            {
                if (KiemTraIDSP())
                {
                    MessageBox.Show("ID đã tồn tại", "Thông báo");
                }
                else
                {
                    string query = "insert into SANPHAM values('" + txtIDSanPham.Text + "', '" + cboLoaiSanPham.Text + "', N'" + txtTenSanPham.Text + "', '" + numTrangThaiSP.Value + "', '" + cboIDNCC.Text + "')";
                    iiKetNoi.ExcuteQuery(query);
                    KetNoiSP();
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại nè...!!!", "Thông báo");
            }
        }
            
        //Button thêm Sản Phẩm
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            try
            {
                ThemDLSP();
            KetNoiSP();
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }

        }

        //Hàm xoá dữ liệu Sản Phẩm
        void XoaDLSP(string query)
        {
            int size = SanPham.Rows.Count;
            SanPham = iiKetNoi.ExcuteQuery(query);
            int size2 = SanPham.Rows.Count;
            if(size2 < size)
            {
                MessageBox.Show("Bạn đã xoá dữ liệu thành công","Thông báo");
            }    
            else
            {
                MessageBox.Show("Xoá dữ liệu không thành công", "Thông báo");
            }    
            KetNoiSP();
            HienThiSP(0);
        }

        //Button Xoá Sản Phẩm
        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Delete from SANPHAM where ID_SanPham = '" + txtIDSanPham.Text + "'";
            DialogResult Thoat = MessageBox.Show("Bạn có muốn xoá không..!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (Thoat == DialogResult.Yes)
                XoaDLSP(query);
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
        }

        //Hàm cập nhật dữ liệu Sản Phẩm
        void CapNhatDLSP(string query)
        {
            SanPham = iiKetNoi.ExcuteQuery(query);
            KetNoiSP();
            HienThiSP(0);
            if(iiKetNoi.ExcuteNonQuery(query) > 0)
            {
                MessageBox.Show("Cập nhật thành công","Thông báo");
            }    
            else
            {
                MessageBox.Show("Cập nhật không thành công", "Thông báo");
            }    
        }

        //Button cập nhậtSản Phẩm
        private void btnCapNhatSP_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "update SANPHAM set[ID_LoaiSanPham] = '" + cboLoaiSanPham.Text + "',[TenSanPham] = N'" + txtTenSanPham.Text + "',[TrangThai] ='" + numTrangThaiSP.Value + "' where ID_SanPham = '" + txtIDSanPham.Text + "'";
                CapNhatDLSP(query);
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
        }


        //Hiển thị form tìm kiếm sản phẩm
        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiSanPham form = new frmLoaiSanPham();
            form.Show();
        }

        //CellClick DataGridView Sản Phẩm
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            int size = SanPham.Rows.Count;
            if (vitri >= 0 && vitri != size)
                HienThiSP(vitri);
        }
        /*-----------------------SẢN PHẨM----------------------*/


        /*-----------------------HOÁ ĐƠN----------------------*/

        //Hàm kiểm tra ID Hoá Đơn
        bool KiemTraIDHD()
        {
            string query = "select ID_HoaDon from HOADON ";
            HoaDon = iiKetNoi.ExcuteQuery(query);
            int size = HoaDon.Rows.Count;
            for (int i = 0; i < size; i++)
            {
                if (txtIDHoaDon.Text == HoaDon.Rows[i][0].ToString())
                {
                    return true;
                    break;
                }
            }
            return false;
        }
        //CellClick DataGridView Hoá Đơn
        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            int size = HoaDon.Rows.Count;
            if (vitri >= 0 && vitri != size)
                HienThiHD(vitri);
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
                    string query = "insert into HOADON values('" + txtIDHoaDon.Text + "', '" + cboIDKhachHang.Text + "', N'" + txtDiaChiHD.Text + "', '" + dtpNgayBan.Value + "', '" + txtTongTienHD.Text + "', '" + numTrangThaiHD.Value + "')";
                    iiKetNoi.ExcuteQuery(query);
                    KetNoiHD();
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại nè...!!!", "Thông báo");
            }
        }
        //Button thêm dữ liệu hoá đơn
        private void btnThemHD_Click(object sender, EventArgs e)
        {
            try
            {
                ThemDLHD();
            KetNoiHD();
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
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
        //Button xoá dữ liệu hoá đơn
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
        //Hàm cập nhật dữ liệu hoá đơn
        void CapNhatDLHD()
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
        //Button cập nhật dữ liệu hoá đơn
        private void btnCapNhatHD_Click(object sender, EventArgs e)
        {
            try
            {
                CapNhatDLHD();
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
        }
        /*-----------------------HOÁ ĐƠN----------------------*/


        /*-----------------------KHÁCH HÀNG----------------------*/
        //Hàm kiểm tra ID Khách hàng
        bool KiemTraIDKH()
        {
            string query = "select ID_KhachHang from KHACHHANG ";
            KhachHang = iiKetNoi.ExcuteQuery(query);
            int size = KhachHang.Rows.Count;
            for (int i = 0; i < size; i++)
            {
                if (txtIDKhachHang.Text == KhachHang.Rows[i][0].ToString())
                {
                    return true;
                    break;
                }
            }
            return false;
        }
        //CellClick DataGridView Khách hàng
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            int size = KhachHang.Rows.Count;
            if (vitri >= 0 && vitri != size)
                HienThiKH(vitri);
        }
        //Hàm thêm dữ liệu Khách hàng
        void ThemDLKH()
        {
            try
            {
                if (KiemTraIDKH())
                {
                    MessageBox.Show("ID đã tồn tại", "Thông báo");
                }
                else
                {
                    string query = "insert into KHACHHANG values('" + txtIDKhachHang.Text + "', N'" + txtTenKhachHang.Text + "',N'" + dtpNgaySinhKH.Text + "',N'" + txtDiaChiKH.Text + "', '" + txtSoDTKH.Text + "')";
                    iiKetNoi.ExcuteQuery(query);
                    KetNoiKH();
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại nè...!!!", "Thông báo");
            }
        }

        //Button thêm dữ liệu Khách hàng
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            try
            {
                ThemDLKH();
                KetNoiKH();
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
        }

        //Hàm xoá dữ liệu Khách hàng
        void XoaDLKH(string query)
        {
            int size = KhachHang.Rows.Count;
            KhachHang = iiKetNoi.ExcuteQuery(query);
            int size2 = KhachHang.Rows.Count;
            if (size2 < size)
            {
                MessageBox.Show("Bạn đã xoá dữ liệu thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xoá dữ liệu không thành công", "Thông báo");
            }
            KetNoiKH();
            HienThiKH(0);
        }
        //Button xoá dữ liệu Khách hàng
        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Delete from KHACHHANG where ID_KhachHang = '" + txtIDKhachHang.Text + "'";
                DialogResult Thoat = MessageBox.Show("Bạn có muốn xoá không..!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (Thoat == DialogResult.Yes)
                    XoaDLKH(query);
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
        }
        //Hàm cập nhật dữ liệu Khách hàng
        void CapNhatDLKH()
        {
            string query = "update KHACHHANG set ID_KhachHang = '" + txtIDKhachHang.Text + "',TenKhachHang= N'"+txtTenKhachHang.Text+"',NgaySinh = '"+dtpNgaySinhKH.Text+"', DiaChi = N'" + txtDiaChiKH.Text + "',SoDT = '"+txtSoDTKH.Text+"' where ID_KhachHang = '" + txtIDKhachHang.Text + "'";
            KhachHang = iiKetNoi.ExcuteQuery(query);
            KetNoiKH();
            HienThiKH(0);
            if (iiKetNoi.ExcuteNonQuery(query) > 0)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công", "Thông báo");
            }
        }
        //Button cập nhật dữ liệu Khách hàng
        private void btnCapNhatKH_Click(object sender, EventArgs e)
        {
            try
            {
                CapNhatDLKH();
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
        }

        /*-----------------------KHÁCH HÀNG----------------------*/

        /*-----------------------NHÀ CUNG CẤP----------------------*/

        //Hàm kiểm tra ID Nhà cung cấp
        bool KiemTraIDNCC()
        {
            string query = "select ID_NCC from NHACUNGCAP ";
            NhaCungCap = iiKetNoi.ExcuteQuery(query);
            int size = NhaCungCap.Rows.Count;
            for (int i = 0; i < size; i++)
            {
                if (txtIDNCC.Text ==NhaCungCap.Rows[i][0].ToString())
                {
                    return true;
                    break;
                }
            }
            return false;
        }
        //CellClick DataGridView Nhà cung cấp
        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            int size = NhaCungCap.Rows.Count;
            if (vitri >= 0 && vitri != size)
                HienThiNCC(vitri);
        }
        //Hàm thêm dữ liệu Nhà cung cấp
        void ThemDLNCC()
        {
            try
            {
                if (KiemTraIDNCC())
                {
                    MessageBox.Show("ID đã tồn tại", "Thông báo");
                }
                else
                {
                    string query = "insert into NHACUNGCAP values('" + txtIDNCC.Text + "', N'" + txtTenNCC.Text + "',N'" + txtDiaChiNCC.Text + "', '" + txtSoDTNCC.Text + "','" + numTrangThaiNCC.Value + "')";
                    iiKetNoi.ExcuteQuery(query);
                    KetNoiNCC();
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại nè...!!!", "Thông báo");
            }
        }
        //Button thêm dữ liệu Nhà cung cấp
        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            try
            {
                ThemDLNCC();
                KetNoiNCC();
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
        }
        //Hàm cập nhật dữ liệu Nhà cung cấp
        void CapNhatDLNCC()
        {
            string query = "update NHACUNGCAP set ID_NCC = '" + txtIDNCC.Text + "',TenNCC= N'" + txtTenNCC.Text + "', DiaChi = N'" + txtDiaChiNCC.Text + "',SoDT = '" + txtSoDTNCC.Text + "',TrangThai = '" + numTrangThaiNCC.Value +  "' where ID_NCC = '" + txtIDNCC.Text + "'";
            NhaCungCap = iiKetNoi.ExcuteQuery(query);
            KetNoiNCC();
            HienThiNCC(0);
            if (iiKetNoi.ExcuteNonQuery(query) > 0)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công", "Thông báo");
            }
        }
        //Button cập nhật dữ liệu Nhà cung cấp
        private void btnCapNhatNCC_Click(object sender, EventArgs e)
        {
            try
            {
                CapNhatDLNCC();
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
        }
        //Hàm xoá dữ liệu Nhà cung cấp
        void XoaDLNCC(string query)
        {
            int size = NhaCungCap.Rows.Count;
            NhaCungCap = iiKetNoi.ExcuteQuery(query);
            int size2 = NhaCungCap.Rows.Count;
            if (size2 < size)
            {
                MessageBox.Show("Bạn đã xoá dữ liệu thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xoá dữ liệu không thành công", "Thông báo");
            }
            KetNoiNCC();
            HienThiNCC(0);
        }
        //Button xoá dữ liệu Nhà cung cấp
        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Delete from NHACUNGCAP where ID_NCC = '" + txtIDNCC.Text + "'";
                DialogResult Thoat = MessageBox.Show("Bạn có muốn xoá không..!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (Thoat == DialogResult.Yes)
                    XoaDLNCC(query);
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
        }
        /*-----------------------NHÀ CUNG CẤP----------------------*/


        /*-----------------------NHÂN VIÊN----------------------*/

        //Hàm kiểm tra ID Nhân viên
        bool KiemTraIDNV()
        {
            string query = "select ID_NhanVien from NHANVIEN ";
            NhanVien = iiKetNoi.ExcuteQuery(query);
            int size = NhanVien.Rows.Count;
            for (int i = 0; i < size; i++)
            {
                if (txtIDNhanVien.Text == NhanVien.Rows[i][0].ToString())
                {
                    return true;
                    break;
                }
            }
            return false;
        }

        //CellClick DataGridView Nhân viên
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            int size = NhanVien.Rows.Count;
            if (vitri >= 0 && vitri != size)
                HienThiNV(vitri);
        }
        //Hàm thêm dữ liệu Nhân viên
        void ThemDLNV()
        {
            try
            {
                if (KiemTraIDNV())
                {
                    MessageBox.Show("ID đã tồn tại", "Thông báo");
                }
                else
                {
                    string query = "insert into NHANVIEN values('" + txtIDNhanVien.Text + "', N'" + txtTenNhanVien.Text + "',N'" + dtpNgaySinhNV.Value + "', '" + txtSoDTNV.Text + "','" + txtLuongNV.Text + "','" + txtEmailNV.Text + "','" + numTrangThaiNV.Value + "',N'" + txtDiaChiNV.Text + "')";
                    iiKetNoi.ExcuteQuery(query);
                    KetNoiNV();
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại nè...!!!", "Thông báo");
            }
        }
        //Button thêm Nhân viên
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            try
            {
                ThemDLNV();
                KetNoiNV();
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
        }
        //Kiểm tra Email
        int KiemTraEmail()
        {
            int flag = 0;
            DataTable EmailNV = new DataTable();
            string KtraEmail = "select Email from NHANVIEN where ID_NhanVien = '" + txtIDNhanVien.Text + "'";
            EmailNV = iiKetNoi.ExcuteQuery(KtraEmail);
            for (int i = 0; i < NhanVien.Rows.Count; i++)
            {
                if (txtEmailNV.Text == NhanVien.Rows[i][5].ToString())
                {
                    if (txtEmailNV.Text == EmailNV.Rows[0][0].ToString())
                    {
                        continue;
                    }
                    flag = 1;
                    break;
                }
            }  
            return flag;
        }
        //Hàm cập nhật dữ liệu Nhân viên
        void CapNhatDLNV()
        {
            try
            {
                if (KiemTraEmail() == 1)
                {
                    MessageBox.Show("Email đã tồn tại", "Thông báo");
                }
                else
                {
                    string query = "update NHANVIEN set ID_NhanVien = '" + txtIDNhanVien.Text + "',TenNhanVien= N'" + txtTenNhanVien.Text + "', NgaySinh = '" + dtpNgaySinhNV.Value + "',SoDT = '" + txtSoDTNV.Text + "',Luong = '" + txtLuongNV.Text + "',Email = '" + txtEmailNV.Text + "',TrangThai = '" + numTrangThaiNV.Value + "',DiaChi = N'" + txtDiaChiNV.Text + "' where ID_NhanVien = '" + txtIDNhanVien.Text + "'";
                    NhaCungCap = iiKetNoi.ExcuteQuery(query);
                    KetNoiNV();
                    HienThiNV(0);
                    if (iiKetNoi.ExcuteNonQuery(query) > 0)
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công", "Thông báo");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại nè...!!!", "Thông báo");
            }

        }
        //Button cập nhật Nhân viên
        private void btnCapNhatNV_Click(object sender, EventArgs e)
        {
            try
            {
                CapNhatDLNV();
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
        }
        //Hàm xoá dữ liệu Nhân viên
        void XoaDLNV(string query)
        {
            int size = NhanVien.Rows.Count;
            NhanVien = iiKetNoi.ExcuteQuery(query);
            int size2 = NhanVien.Rows.Count;
            if (size2 < size)
            {
                MessageBox.Show("Bạn đã xoá dữ liệu thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xoá dữ liệu không thành công", "Thông báo");
            }
            KetNoiNV();
            HienThiNV(0);
        }
        //Button xoá Nhân viên
        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Delete from NHANVIEN where ID_NhanVien = '" + txtIDNhanVien.Text + "'";
                DialogResult Thoat = MessageBox.Show("Bạn có muốn xoá không..!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (Thoat == DialogResult.Yes)
                    XoaDLNV(query);
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
        }

        /*-----------------------NHÂN VIÊN----------------------*/

        //MENUTOOLTIP
        private void mnuttThoatChuongTrinh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExitHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chiTiếtSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChiTietSanPham form = new frmChiTietSanPham();
            form.ShowDialog();
        }

        private void chiTiếtHoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChiTietHoaDon form = new frmChiTietHoaDon();
            form.ShowDialog();
        }

        //Code xuất dữ liệu vào excel
        private void ToExcel(DataGridView dataGridView1, string fileName, DataTable ds)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;

            try
            {

                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);

                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet.Name = "Danh sách sản phẩm";

                // export header
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }

                // export content
                for (int i = 0; i < ds.Rows.Count; i++)
                {
                    for (int j = 0; j < ds.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = ds.Rows[i][j].ToString();
                    }
                }

                // save workbook
                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu thành công.!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        //Button xuất dữ liệu bảng sản phẩm , khách hàng , nhà cung cấp , nhân viên
        private void btnXuatExcelSP_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFile.InitialDirectory = @"C:\Lập trình windows\ĐỒ ÁN\Excel";
            //SaveFileSanPham.Title = "Lưu file ảnh";
            SaveFile.DefaultExt = "xlsx";
            //SaveFileSanPham.Filter = "(.jpg);(.png)|.jpg;.png";
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dgvSanPham, SaveFile.FileName, SanPham);
            }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
        }

        private void btnXuatExcelKH_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFile.InitialDirectory = @"C:\Lập trình windows\ĐỒ ÁN\Excel";
                //SaveFileSanPham.Title = "Lưu file ảnh";
                SaveFile.DefaultExt = "xlsx";
                //SaveFileSanPham.Filter = "(.jpg);(.png)|.jpg;.png";
                if (SaveFile.ShowDialog() == DialogResult.OK)
                {
                    ToExcel(dgvKhachHang, SaveFile.FileName, KhachHang);
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
        }

        private void btnXuatExcelNCC_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFile.InitialDirectory = @"C:\Lập trình windows\ĐỒ ÁN\Excel";
            //SaveFileSanPham.Title = "Lưu file ảnh";
            SaveFile.DefaultExt = "xlsx";
            //SaveFileSanPham.Filter = "(.jpg);(.png)|.jpg;.png";
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dgvNhaCungCap, SaveFile.FileName, NhaCungCap);
            }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
        }

        private void btnXuatExcelNV_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFile.InitialDirectory = @"C:\Lập trình windows\ĐỒ ÁN\Excel";
                //SaveFileSanPham.Title = "Lưu file ảnh";
                SaveFile.DefaultExt = "xlsx";
                //SaveFileSanPham.Filter = "(.jpg);(.png)|.jpg;.png";
                if (SaveFile.ShowDialog() == DialogResult.OK)
                {
                    ToExcel(dgvNhanVien, SaveFile.FileName, NhanVien);
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
        }

        private void mnuttThongKe_Click(object sender, EventArgs e)
        {
            frmThongKeDoanhThu form = new frmThongKeDoanhThu();
            form.ShowDialog();
        }

        private void mnuttQuanLyHoaDon_Click(object sender, EventArgs e)
        {
            frmChiTietHoaDon form = new frmChiTietHoaDon();
            form.ShowDialog();
        }
    }
}
