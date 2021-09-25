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
using System.Text.RegularExpressions;

//using WMPLib; //Xuất Excel


namespace _452_417_CDTH19E_SHOESSHOP
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
            KetNoiSP();
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

        public string HTChiTiet;
        //Sự kiện form Load
        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            cboTrangThaiSP.Items.Add("Không hoạt động");
            cboTrangThaiSP.Items.Add("Hoạt động");
            cboTrangThaiNCC.Items.Add("Không hoạt động");
            cboTrangThaiNCC.Items.Add("Hoạt động");
            cboTrangThaiNV.Items.Add("Không hoạt động");
            cboTrangThaiNV.Items.Add("Hoạt động");
            foreach (DataGridViewColumn column in dgvNhanVien.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }    
            btnThemSP.Enabled = false;
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
            HienThiSP(0);
            HienThiKH(0);
            HienThiNCC(0);
            HienThiNV(0);
        }

        /*---Hàm kết nối dữ liệu---Start*/
        void KetNoiSP()
        {
            KetNoiDuLieu iKetNoiSP = new KetNoiDuLieu();
            dgvSanPham.DataSource = iKetNoiSP.ExcuteQuery("select * from SANPHAM");
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

        //Bẫy lỗi kiểm tra nhập vào
        private void txtIDSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            //    e.Handled = true;
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
            cboTrangThaiSP.Text = SanPham.Rows[vitri][3].ToString();
            if (Convert.ToInt32(SanPham.Rows[vitri][3]) == 0)
            {
                cboTrangThaiSP.SelectedIndex = 0;
            }
            else
            {
                cboTrangThaiSP.SelectedIndex = 1;
            }
            cboIDNCC.Text = SanPham.Rows[vitri][4].ToString();
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
            cboTrangThaiNCC.Text = NhaCungCap.Rows[vitri][4].ToString();
            if (Convert.ToInt32(NhaCungCap.Rows[vitri][4]) == 0)
            {
                cboTrangThaiNCC.SelectedIndex = 0;
            }
            else
            {
                cboTrangThaiNCC.SelectedIndex = 1;
            }

        }
        void HienThiNV(int vitri)
        {
            NhanVien = iiKetNoi.ExcuteQuery("select * from NHANVIEN");
            txtIDNhanVien.Text = NhanVien.Rows[vitri][0].ToString();
            txtTenNhanVien.Text = NhanVien.Rows[vitri][1].ToString();
            dtpNgaySinhNV.Text = NhanVien.Rows[vitri][2].ToString();
            txtSoDTNV.Text = NhanVien.Rows[vitri][3].ToString();
            txtLuongNV.Text = string.Format("{0:n0}", NhanVien.Rows[vitri][4]);
            //txtLuongNV.Text = NhanVien.Rows[vitri][4].ToString();
            txtEmailNV.Text = NhanVien.Rows[vitri][5].ToString();
            cboTrangThaiNV.Text = NhanVien.Rows[vitri][6].ToString();
            if (Convert.ToInt32(NhanVien.Rows[vitri][6]) == 0)
            {
                cboTrangThaiNV.SelectedIndex = 0;
            }
            else
            {
                cboTrangThaiNV.SelectedIndex = 1;
            }
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
            if (KiemTraIDSP())
            {
                MessageBox.Show("ID đã tồn tại", "Thông báo");
            }
            else
            {
                string query = "insert into SANPHAM values('" + txtIDSanPham.Text + "', '" + cboLoaiSanPham.Text + "', N'" + txtTenSanPham.Text + "', '" + cboTrangThaiSP.SelectedIndex + "', '" + cboIDNCC.Text + "')";
                iiKetNoi.ExcuteQuery(query);
                KetNoiSP();
            }
        }
            
        //Button thêm Sản Phẩm
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            ThemDLSP();
            KetNoiSP();

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
            string query = "Delete from SANPHAM where ID_SanPham = '" + txtIDSanPham.Text + "'";
            DialogResult Thoat = MessageBox.Show("Bạn có muốn xoá không..!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (Thoat == DialogResult.Yes)
            XoaDLSP(query);
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
            string query = "update SANPHAM set[ID_LoaiSanPham] = '" + cboLoaiSanPham.Text + "',[TenSanPham] = N'" + txtTenSanPham.Text + "',[TrangThai] ='" + cboTrangThaiSP.SelectedIndex + "',[ID_NCC] ='" + cboIDNCC.Text + "' where ID_SanPham = '" + txtIDSanPham.Text + "'";
            CapNhatDLSP(query);
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
            if (KiemTraIDKH())
            {
                MessageBox.Show("ID đã tồn tại", "Thông báo");
            }
            else
            {
                string query = "insert into KHACHHANG values('" + txtIDKhachHang.Text + "', N'" + txtTenKhachHang.Text + "','" + dtpNgaySinhKH.Value + "',N'" + txtDiaChiKH.Text + "', '" + txtSoDTKH.Text + "')";
                iiKetNoi.ExcuteQuery(query);
                KetNoiKH();
            }
        }

        //Button thêm dữ liệu Khách hàng
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            ThemDLKH();
            KetNoiKH();
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
            string query = "Delete from KHACHHANG where ID_KhachHang = '" + txtIDKhachHang.Text + "'";
            DialogResult Thoat = MessageBox.Show("Bạn có muốn xoá không..!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (Thoat == DialogResult.Yes)
                XoaDLKH(query);
        }
        //Hàm cập nhật dữ liệu Khách hàng
        void CapNhatDLKH()
        {
            string query = "update KHACHHANG set ID_KhachHang = '" + txtIDKhachHang.Text + "',TenKhachHang= N'"+txtTenKhachHang.Text+"',NgaySinh = '"+ dtpNgaySinhKH.Value +"', DiaChi = N'" + txtDiaChiKH.Text + "',SoDT = '"+txtSoDTKH.Text+"' where ID_KhachHang = '" + txtIDKhachHang.Text + "'";
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
            CapNhatDLKH();
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
            if (KiemTraIDNCC())
            {
                MessageBox.Show("ID đã tồn tại", "Thông báo");
            }
            else
            {
                string query = "insert into NHACUNGCAP values('" + txtIDNCC.Text + "', N'" + txtTenNCC.Text + "',N'" + txtDiaChiNCC.Text + "', '" + txtSoDTNCC.Text + "','" + cboTrangThaiNCC.SelectedIndex + "')";
                iiKetNoi.ExcuteQuery(query);
                KetNoiNCC();
            }
        }
        //Button thêm dữ liệu Nhà cung cấp
        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            ThemDLNCC();
            KetNoiNCC();
        }
        //Hàm cập nhật dữ liệu Nhà cung cấp
        void CapNhatDLNCC()
        {
            string query = "update NHACUNGCAP set ID_NCC = '" + txtIDNCC.Text + "',TenNCC= N'" + txtTenNCC.Text + "', DiaChi = N'" + txtDiaChiNCC.Text + "',SoDT = '" + txtSoDTNCC.Text + "',TrangThai = '" + cboTrangThaiNCC.SelectedIndex +  "' where ID_NCC = '" + txtIDNCC.Text + "'";
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
             CapNhatDLNCC();
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
            string query = "Delete from NHACUNGCAP where ID_NCC = '" + txtIDNCC.Text + "'";
            DialogResult Thoat = MessageBox.Show("Bạn có muốn xoá không..!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (Thoat == DialogResult.Yes)
                XoaDLNCC(query);
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

        public static bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
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
            if (KiemTraIDNV()) 
            {
                MessageBox.Show("ID đã tồn tại", "Thông báo");
            }
            else if (isEmail(txtEmailNV.Text) == false)
            {
                MessageBox.Show("Vui lòng kiểm tra lại Email...!", "Thông báo");
            }
            else
            {
                string query = "insert into NHANVIEN values('" + txtIDNhanVien.Text + "', N'" + txtTenNhanVien.Text + "','" + dtpNgaySinhNV.Value + "', '" + txtSoDTNV.Text + "','" + txtLuongNV.Text + "','" + txtEmailNV.Text + "','" + cboTrangThaiNV.SelectedIndex + "',N'" + txtDiaChiNV.Text + "')";
                iiKetNoi.ExcuteQuery(query);
                KetNoiNV();
            }
        }
        //Button thêm Nhân viên
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            ThemDLNV();
            KetNoiNV();
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
                    string query = "update NHANVIEN set ID_NhanVien = '" + txtIDNhanVien.Text + "',TenNhanVien= N'" + txtTenNhanVien.Text + "', NgaySinh = '" + dtpNgaySinhNV.Value + "',SoDT = '" + txtSoDTNV.Text + "',Luong = '" + txtLuongNV.Text + "',Email = '" + txtEmailNV.Text + "',TrangThai = '" + cboTrangThaiNV.SelectedIndex + "',DiaChi = N'" + txtDiaChiNV.Text + "' where ID_NhanVien = '" + txtIDNhanVien.Text + "'";
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
            CapNhatDLNV();
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
            string query = "Delete from NHANVIEN where ID_NhanVien = '" + txtIDNhanVien.Text + "'";
            DialogResult Thoat = MessageBox.Show("Bạn có muốn xoá không..!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (Thoat == DialogResult.Yes)
                XoaDLNV(query);
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
            SaveFile.InitialDirectory = @"C:\Lập trình windows\ĐỒ ÁN\Excel";
            SaveFile.DefaultExt = "xlsx";
            //SaveFileSanPham.Filter = "(.jpg);(.png)|.jpg;.png";
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dgvSanPham, SaveFile.FileName, SanPham);
            }
        }

        private void btnXuatExcelKH_Click(object sender, EventArgs e)
        {
            SaveFile.InitialDirectory = @"C:\Lập trình windows\ĐỒ ÁN\Excel";
            SaveFile.DefaultExt = "xlsx";
            //SaveFileSanPham.Filter = "(.jpg);(.png)|.jpg;.png";
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dgvKhachHang, SaveFile.FileName, KhachHang);
            }
        }

        private void btnXuatExcelNCC_Click(object sender, EventArgs e)
        {
            SaveFile.InitialDirectory = @"C:\Lập trình windows\ĐỒ ÁN\Excel";
            SaveFile.DefaultExt = "xlsx";
            //SaveFileSanPham.Filter = "(.jpg);(.png)|.jpg;.png";
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dgvNhaCungCap, SaveFile.FileName, NhaCungCap);
            }
        }

        private void btnXuatExcelNV_Click(object sender, EventArgs e)
        {
            SaveFile.InitialDirectory = @"C:\Lập trình windows\ĐỒ ÁN\Excel";
            SaveFile.DefaultExt = "xlsx";
            //SaveFileSanPham.Filter = "(.jpg);(.png)|.jpg;.png";
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dgvNhanVien, SaveFile.FileName, NhanVien);
            }
        }

        private void mnuttQuanLyHoaDon_Click(object sender, EventArgs e)
        {
            frmChiTietHoaDon form = new frmChiTietHoaDon();
            form.ShowDialog();
        }
        public void dgvSanPham_DoubleClick(object sender, EventArgs e)
        {
            frmChiTietSanPham form = new frmChiTietSanPham();
            form.S = txtIDSanPham.Text;
            form.ShowDialog();
        }
    }
}
