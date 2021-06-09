using System;
using System.Drawing;
using System.Windows.Forms;
namespace _452_417_CDTH19E_SHOESSHOP
{
    partial class frmTrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuttTrangChu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuttQuanLySanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuttTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimKiemTheoSP = new System.Windows.Forms.ToolStripMenuItem();
            this.TimKiemTheoHD = new System.Windows.Forms.ToolStripMenuItem();
            this.TimKiemTheoKH = new System.Windows.Forms.ToolStripMenuItem();
            this.TimKiemTheoNCC = new System.Windows.Forms.ToolStripMenuItem();
            this.TimKiemTheoNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuttQuanLyHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuttThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuttThoatChuongTrinh = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSoDTHD = new System.Windows.Forms.Label();
            this.lblDiaChiKH = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgaySinhKH = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnXuatExcelKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnThoatKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapNhatKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemKH = new Guna.UI2.WinForms.Guna2Button();
            this.txtSoDTKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiaChiKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenKhachHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDKhachHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.lblIDKhachHangKH = new System.Windows.Forms.Label();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.grpKhachHang = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblTrangThaiHD = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.dgvNhaCungCap = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.grpNhaCungCap = new Guna.UI2.WinForms.Guna2GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnXuatExcelNCC = new Guna.UI2.WinForms.Guna2Button();
            this.btnThoatNCC = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaNCC = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapNhatNCC = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemNCC = new Guna.UI2.WinForms.Guna2Button();
            this.numTrangThaiNCC = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtSoDTNCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenNCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiaChiNCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDNCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblSDTNCC = new System.Windows.Forms.Label();
            this.lblDiachiNCC = new System.Windows.Forms.Label();
            this.lblTenNCC = new System.Windows.Forms.Label();
            this.lblNCC = new System.Windows.Forms.Label();
            this.grpSanPham = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grpDanhSachSP = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.ID_SanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_LoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.btnXuatExcelSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnThoatSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapNhatSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemSP = new Guna.UI2.WinForms.Guna2Button();
            this.numTrangThaiSP = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cboLoaiSanPham = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboIDNCC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTenSanPham = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDSanPham = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTrangThaiSP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblIDSP = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.grpDanhSachHD = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp2 = new System.Windows.Forms.GroupBox();
            this.dtpNgayBan = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnThoatHD = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaHD = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapNhatHD = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemHD = new Guna.UI2.WinForms.Guna2Button();
            this.numTrangThaiHD = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtDiaChiHD = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTongTienHD = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboIDKhachHang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtIDHoaDon = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNgayBan = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblIDKhachHang = new System.Windows.Forms.Label();
            this.lblIDHoaDon = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.grpNhanVien = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.ID_NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnXuatExcelNV = new Guna.UI2.WinForms.Guna2Button();
            this.dtpNgaySinhNV = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnThoatNV = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaNV = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapNhatNV = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemNV = new Guna.UI2.WinForms.Guna2Button();
            this.numTrangThaiNV = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtDiaChiNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmailNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLuongNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoDTNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenNhanVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDNhanVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.btnExitHome = new Guna.UI2.WinForms.Guna2Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.grpKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.grpNhaCungCap.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrangThaiNCC)).BeginInit();
            this.grpSanPham.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.grpDanhSachSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.grp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrangThaiSP)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.grpDanhSachHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.grp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrangThaiHD)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.grpNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrangThaiNV)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.menuStrip1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuttTrangChu,
            this.mnuttQuanLySanPham,
            this.mnuttTimKiem,
            this.mnuttQuanLyHoaDon,
            this.mnuttThongKe,
            this.mnuttThoatChuongTrinh});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1403, 46);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuttTrangChu
            // 
            this.mnuttTrangChu.Image = global::_452_417_CDTH19E_SHOESSHOP.Properties.Resources.icons8_home_64;
            this.mnuttTrangChu.Name = "mnuttTrangChu";
            this.mnuttTrangChu.Size = new System.Drawing.Size(119, 42);
            this.mnuttTrangChu.Text = "Trang Chủ";
            // 
            // mnuttQuanLySanPham
            // 
            this.mnuttQuanLySanPham.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loạiSảnPhẩmToolStripMenuItem,
            this.chiTiếtSảnPhẩmToolStripMenuItem});
            this.mnuttQuanLySanPham.Image = global::_452_417_CDTH19E_SHOESSHOP.Properties.Resources.icons8_product_management_64;
            this.mnuttQuanLySanPham.Name = "mnuttQuanLySanPham";
            this.mnuttQuanLySanPham.Size = new System.Drawing.Size(182, 42);
            this.mnuttQuanLySanPham.Text = "Quản Lý Sản Phẩm";
            // 
            // loạiSảnPhẩmToolStripMenuItem
            // 
            this.loạiSảnPhẩmToolStripMenuItem.Name = "loạiSảnPhẩmToolStripMenuItem";
            this.loạiSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.loạiSảnPhẩmToolStripMenuItem.Text = "Loại Sản Phẩm";
            this.loạiSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.loạiSảnPhẩmToolStripMenuItem_Click);
            // 
            // chiTiếtSảnPhẩmToolStripMenuItem
            // 
            this.chiTiếtSảnPhẩmToolStripMenuItem.Name = "chiTiếtSảnPhẩmToolStripMenuItem";
            this.chiTiếtSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.chiTiếtSảnPhẩmToolStripMenuItem.Text = "Chi Tiết Sản Phẩm";
            this.chiTiếtSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtSảnPhẩmToolStripMenuItem_Click);
            // 
            // mnuttTimKiem
            // 
            this.mnuttTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimKiemTheoSP,
            this.TimKiemTheoHD,
            this.TimKiemTheoKH,
            this.TimKiemTheoNCC,
            this.TimKiemTheoNV});
            this.mnuttTimKiem.Image = global::_452_417_CDTH19E_SHOESSHOP.Properties.Resources.search;
            this.mnuttTimKiem.Name = "mnuttTimKiem";
            this.mnuttTimKiem.Size = new System.Drawing.Size(115, 42);
            this.mnuttTimKiem.Text = "Tìm Kiếm";
            // 
            // TimKiemTheoSP
            // 
            this.TimKiemTheoSP.Name = "TimKiemTheoSP";
            this.TimKiemTheoSP.Size = new System.Drawing.Size(317, 26);
            this.TimKiemTheoSP.Text = "Tìm Kiếm Theo Sản Phẩm";
            this.TimKiemTheoSP.Click += new System.EventHandler(this.tìmKiếmTheToolStripMenuItem_Click);
            // 
            // TimKiemTheoHD
            // 
            this.TimKiemTheoHD.Name = "TimKiemTheoHD";
            this.TimKiemTheoHD.Size = new System.Drawing.Size(317, 26);
            this.TimKiemTheoHD.Text = "Tìm Kiếm Theo Hoá Đơn";
            this.TimKiemTheoHD.Click += new System.EventHandler(this.TimKiemTheoHD_Click);
            // 
            // TimKiemTheoKH
            // 
            this.TimKiemTheoKH.Name = "TimKiemTheoKH";
            this.TimKiemTheoKH.Size = new System.Drawing.Size(317, 26);
            this.TimKiemTheoKH.Text = "Tìm Kiếm Theo Khách Hàng";
            this.TimKiemTheoKH.Click += new System.EventHandler(this.TimKiemTheoKH_Click);
            // 
            // TimKiemTheoNCC
            // 
            this.TimKiemTheoNCC.Name = "TimKiemTheoNCC";
            this.TimKiemTheoNCC.Size = new System.Drawing.Size(317, 26);
            this.TimKiemTheoNCC.Text = "Tìm Kiếm Theo Nhà Cung Cấp";
            this.TimKiemTheoNCC.Click += new System.EventHandler(this.TimKiemTheoNCC_Click);
            // 
            // TimKiemTheoNV
            // 
            this.TimKiemTheoNV.Name = "TimKiemTheoNV";
            this.TimKiemTheoNV.Size = new System.Drawing.Size(317, 26);
            this.TimKiemTheoNV.Text = "Tìm Kiếm Theo Nhân Viên";
            this.TimKiemTheoNV.Click += new System.EventHandler(this.TimKiemTheoNV_Click);
            // 
            // mnuttQuanLyHoaDon
            // 
            this.mnuttQuanLyHoaDon.Image = global::_452_417_CDTH19E_SHOESSHOP.Properties.Resources.bill;
            this.mnuttQuanLyHoaDon.Name = "mnuttQuanLyHoaDon";
            this.mnuttQuanLyHoaDon.Size = new System.Drawing.Size(171, 42);
            this.mnuttQuanLyHoaDon.Text = "Quản Lý Hoá Đơn";
            this.mnuttQuanLyHoaDon.Click += new System.EventHandler(this.mnuttQuanLyHoaDon_Click);
            // 
            // mnuttThongKe
            // 
            this.mnuttThongKe.Image = global::_452_417_CDTH19E_SHOESSHOP.Properties.Resources.total;
            this.mnuttThongKe.Name = "mnuttThongKe";
            this.mnuttThongKe.Size = new System.Drawing.Size(115, 42);
            this.mnuttThongKe.Text = "Thống Kê";
            this.mnuttThongKe.Click += new System.EventHandler(this.mnuttThongKe_Click);
            // 
            // mnuttThoatChuongTrinh
            // 
            this.mnuttThoatChuongTrinh.Image = global::_452_417_CDTH19E_SHOESSHOP.Properties.Resources.icons8_shutdown_16;
            this.mnuttThoatChuongTrinh.Name = "mnuttThoatChuongTrinh";
            this.mnuttThoatChuongTrinh.Size = new System.Drawing.Size(192, 42);
            this.mnuttThoatChuongTrinh.Text = "Thoát Chương Trình";
            this.mnuttThoatChuongTrinh.Click += new System.EventHandler(this.mnuttThoatChuongTrinh_Click);
            // 
            // lblSoDTHD
            // 
            this.lblSoDTHD.AutoSize = true;
            this.lblSoDTHD.Location = new System.Drawing.Point(535, 133);
            this.lblSoDTHD.Name = "lblSoDTHD";
            this.lblSoDTHD.Size = new System.Drawing.Size(107, 20);
            this.lblSoDTHD.TabIndex = 3;
            this.lblSoDTHD.Text = "Số điện thoại";
            // 
            // lblDiaChiKH
            // 
            this.lblDiaChiKH.AutoSize = true;
            this.lblDiaChiKH.Location = new System.Drawing.Point(583, 64);
            this.lblDiaChiKH.Name = "lblDiaChiKH";
            this.lblDiaChiKH.Size = new System.Drawing.Size(59, 20);
            this.lblDiaChiKH.TabIndex = 3;
            this.lblDiaChiKH.Text = "Địa chỉ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgaySinhKH);
            this.groupBox1.Controls.Add(this.btnXuatExcelKH);
            this.groupBox1.Controls.Add(this.btnThoatKH);
            this.groupBox1.Controls.Add(this.btnXoaKH);
            this.groupBox1.Controls.Add(this.btnCapNhatKH);
            this.groupBox1.Controls.Add(this.btnThemKH);
            this.groupBox1.Controls.Add(this.txtSoDTKH);
            this.groupBox1.Controls.Add(this.txtDiaChiKH);
            this.groupBox1.Controls.Add(this.txtTenKhachHang);
            this.groupBox1.Controls.Add(this.txtIDKhachHang);
            this.groupBox1.Controls.Add(this.lblSoDTHD);
            this.groupBox1.Controls.Add(this.lblDiaChiKH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblTenKhachHang);
            this.groupBox1.Controls.Add(this.lblIDKhachHangKH);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1352, 258);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách hàng";
            // 
            // dtpNgaySinhKH
            // 
            this.dtpNgaySinhKH.Animated = true;
            this.dtpNgaySinhKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtpNgaySinhKH.BorderRadius = 5;
            this.dtpNgaySinhKH.CheckedState.Parent = this.dtpNgaySinhKH;
            this.dtpNgaySinhKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNgaySinhKH.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinhKH.FillColor = System.Drawing.Color.Turquoise;
            this.dtpNgaySinhKH.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.dtpNgaySinhKH.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtpNgaySinhKH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinhKH.HoverState.Parent = this.dtpNgaySinhKH;
            this.dtpNgaySinhKH.IndicateFocus = true;
            this.dtpNgaySinhKH.Location = new System.Drawing.Point(203, 181);
            this.dtpNgaySinhKH.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinhKH.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinhKH.Name = "dtpNgaySinhKH";
            this.dtpNgaySinhKH.ShadowDecoration.Parent = this.dtpNgaySinhKH;
            this.dtpNgaySinhKH.Size = new System.Drawing.Size(295, 36);
            this.dtpNgaySinhKH.TabIndex = 38;
            this.dtpNgaySinhKH.Value = new System.DateTime(2021, 5, 29, 22, 23, 11, 26);
            // 
            // btnXuatExcelKH
            // 
            this.btnXuatExcelKH.BorderRadius = 20;
            this.btnXuatExcelKH.CheckedState.Parent = this.btnXuatExcelKH;
            this.btnXuatExcelKH.CustomImages.Parent = this.btnXuatExcelKH;
            this.btnXuatExcelKH.FillColor = System.Drawing.Color.Turquoise;
            this.btnXuatExcelKH.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcelKH.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcelKH.HoverState.Parent = this.btnXuatExcelKH;
            this.btnXuatExcelKH.Location = new System.Drawing.Point(1160, 117);
            this.btnXuatExcelKH.Name = "btnXuatExcelKH";
            this.btnXuatExcelKH.ShadowDecoration.Parent = this.btnXuatExcelKH;
            this.btnXuatExcelKH.Size = new System.Drawing.Size(138, 43);
            this.btnXuatExcelKH.TabIndex = 37;
            this.btnXuatExcelKH.Text = "Xuất Excel";
            this.btnXuatExcelKH.Click += new System.EventHandler(this.btnXuatExcelKH_Click);
            // 
            // btnThoatKH
            // 
            this.btnThoatKH.Animated = true;
            this.btnThoatKH.BorderColor = System.Drawing.Color.Transparent;
            this.btnThoatKH.BorderRadius = 20;
            this.btnThoatKH.CheckedState.Parent = this.btnThoatKH;
            this.btnThoatKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoatKH.CustomImages.Parent = this.btnThoatKH;
            this.btnThoatKH.FillColor = System.Drawing.Color.Turquoise;
            this.btnThoatKH.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.btnThoatKH.ForeColor = System.Drawing.Color.White;
            this.btnThoatKH.HoverState.Parent = this.btnThoatKH;
            this.btnThoatKH.IndicateFocus = true;
            this.btnThoatKH.Location = new System.Drawing.Point(1084, 181);
            this.btnThoatKH.Name = "btnThoatKH";
            this.btnThoatKH.ShadowDecoration.Parent = this.btnThoatKH;
            this.btnThoatKH.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.btnThoatKH.Size = new System.Drawing.Size(138, 43);
            this.btnThoatKH.TabIndex = 22;
            this.btnThoatKH.Text = "Thoát";
            this.btnThoatKH.Click += new System.EventHandler(this.btnThoatKH_Click);
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.Animated = true;
            this.btnXoaKH.BorderColor = System.Drawing.Color.Transparent;
            this.btnXoaKH.BorderRadius = 20;
            this.btnXoaKH.CheckedState.Parent = this.btnXoaKH;
            this.btnXoaKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaKH.CustomImages.Parent = this.btnXoaKH;
            this.btnXoaKH.FillColor = System.Drawing.Color.Turquoise;
            this.btnXoaKH.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.btnXoaKH.ForeColor = System.Drawing.Color.White;
            this.btnXoaKH.HoverState.Parent = this.btnXoaKH;
            this.btnXoaKH.IndicateFocus = true;
            this.btnXoaKH.Location = new System.Drawing.Point(1003, 117);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.ShadowDecoration.Parent = this.btnXoaKH;
            this.btnXoaKH.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.btnXoaKH.Size = new System.Drawing.Size(138, 43);
            this.btnXoaKH.TabIndex = 23;
            this.btnXoaKH.Text = "Xoá";
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnCapNhatKH
            // 
            this.btnCapNhatKH.Animated = true;
            this.btnCapNhatKH.BorderColor = System.Drawing.Color.Transparent;
            this.btnCapNhatKH.BorderRadius = 20;
            this.btnCapNhatKH.CheckedState.Parent = this.btnCapNhatKH;
            this.btnCapNhatKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhatKH.CustomImages.Parent = this.btnCapNhatKH;
            this.btnCapNhatKH.FillColor = System.Drawing.Color.Turquoise;
            this.btnCapNhatKH.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.btnCapNhatKH.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatKH.HoverState.Parent = this.btnCapNhatKH;
            this.btnCapNhatKH.IndicateFocus = true;
            this.btnCapNhatKH.Location = new System.Drawing.Point(1160, 48);
            this.btnCapNhatKH.Name = "btnCapNhatKH";
            this.btnCapNhatKH.ShadowDecoration.Parent = this.btnCapNhatKH;
            this.btnCapNhatKH.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.btnCapNhatKH.Size = new System.Drawing.Size(138, 43);
            this.btnCapNhatKH.TabIndex = 24;
            this.btnCapNhatKH.Text = "Cập nhật";
            this.btnCapNhatKH.Click += new System.EventHandler(this.btnCapNhatKH_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.Animated = true;
            this.btnThemKH.BorderColor = System.Drawing.Color.Transparent;
            this.btnThemKH.BorderRadius = 20;
            this.btnThemKH.CheckedState.Parent = this.btnThemKH;
            this.btnThemKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemKH.CustomImages.Parent = this.btnThemKH;
            this.btnThemKH.FillColor = System.Drawing.Color.Turquoise;
            this.btnThemKH.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.btnThemKH.ForeColor = System.Drawing.Color.White;
            this.btnThemKH.HoverState.Parent = this.btnThemKH;
            this.btnThemKH.IndicateFocus = true;
            this.btnThemKH.Location = new System.Drawing.Point(1003, 48);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.ShadowDecoration.Parent = this.btnThemKH;
            this.btnThemKH.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.btnThemKH.Size = new System.Drawing.Size(138, 43);
            this.btnThemKH.TabIndex = 25;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // txtSoDTKH
            // 
            this.txtSoDTKH.BorderRadius = 5;
            this.txtSoDTKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDTKH.DefaultText = "";
            this.txtSoDTKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoDTKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoDTKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDTKH.DisabledState.Parent = this.txtSoDTKH;
            this.txtSoDTKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDTKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDTKH.FocusedState.Parent = this.txtSoDTKH;
            this.txtSoDTKH.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDTKH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSoDTKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDTKH.HoverState.Parent = this.txtSoDTKH;
            this.txtSoDTKH.Location = new System.Drawing.Point(665, 117);
            this.txtSoDTKH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSoDTKH.Name = "txtSoDTKH";
            this.txtSoDTKH.PasswordChar = '\0';
            this.txtSoDTKH.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSoDTKH.PlaceholderText = "";
            this.txtSoDTKH.SelectedText = "";
            this.txtSoDTKH.ShadowDecoration.Parent = this.txtSoDTKH;
            this.txtSoDTKH.Size = new System.Drawing.Size(295, 36);
            this.txtSoDTKH.TabIndex = 14;
            this.txtSoDTKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDTKH_KeyPress);
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.BorderRadius = 5;
            this.txtDiaChiKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChiKH.DefaultText = "";
            this.txtDiaChiKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChiKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChiKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChiKH.DisabledState.Parent = this.txtDiaChiKH;
            this.txtDiaChiKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChiKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChiKH.FocusedState.Parent = this.txtDiaChiKH;
            this.txtDiaChiKH.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiKH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDiaChiKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChiKH.HoverState.Parent = this.txtDiaChiKH;
            this.txtDiaChiKH.Location = new System.Drawing.Point(665, 48);
            this.txtDiaChiKH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.PasswordChar = '\0';
            this.txtDiaChiKH.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDiaChiKH.PlaceholderText = "";
            this.txtDiaChiKH.SelectedText = "";
            this.txtDiaChiKH.ShadowDecoration.Parent = this.txtDiaChiKH;
            this.txtDiaChiKH.Size = new System.Drawing.Size(295, 36);
            this.txtDiaChiKH.TabIndex = 14;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.BorderRadius = 5;
            this.txtTenKhachHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKhachHang.DefaultText = "";
            this.txtTenKhachHang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKhachHang.DisabledState.Parent = this.txtTenKhachHang;
            this.txtTenKhachHang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKhachHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKhachHang.FocusedState.Parent = this.txtTenKhachHang;
            this.txtTenKhachHang.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachHang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenKhachHang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKhachHang.HoverState.Parent = this.txtTenKhachHang;
            this.txtTenKhachHang.Location = new System.Drawing.Point(203, 117);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.PasswordChar = '\0';
            this.txtTenKhachHang.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenKhachHang.PlaceholderText = "";
            this.txtTenKhachHang.SelectedText = "";
            this.txtTenKhachHang.ShadowDecoration.Parent = this.txtTenKhachHang;
            this.txtTenKhachHang.Size = new System.Drawing.Size(295, 36);
            this.txtTenKhachHang.TabIndex = 14;
            // 
            // txtIDKhachHang
            // 
            this.txtIDKhachHang.BorderRadius = 5;
            this.txtIDKhachHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDKhachHang.DefaultText = "";
            this.txtIDKhachHang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDKhachHang.DisabledState.Parent = this.txtIDKhachHang;
            this.txtIDKhachHang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDKhachHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDKhachHang.FocusedState.Parent = this.txtIDKhachHang;
            this.txtIDKhachHang.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDKhachHang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIDKhachHang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDKhachHang.HoverState.Parent = this.txtIDKhachHang;
            this.txtIDKhachHang.Location = new System.Drawing.Point(203, 48);
            this.txtIDKhachHang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIDKhachHang.Name = "txtIDKhachHang";
            this.txtIDKhachHang.PasswordChar = '\0';
            this.txtIDKhachHang.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIDKhachHang.PlaceholderText = "";
            this.txtIDKhachHang.SelectedText = "";
            this.txtIDKhachHang.ShadowDecoration.Parent = this.txtIDKhachHang;
            this.txtIDKhachHang.Size = new System.Drawing.Size(295, 36);
            this.txtIDKhachHang.TabIndex = 13;
            this.txtIDKhachHang.TextChanged += new System.EventHandler(this.txtIDKhachHang_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày sinh";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Location = new System.Drawing.Point(49, 133);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(126, 20);
            this.lblTenKhachHang.TabIndex = 0;
            this.lblTenKhachHang.Text = "Tên khách hàng";
            // 
            // lblIDKhachHangKH
            // 
            this.lblIDKhachHangKH.AutoSize = true;
            this.lblIDKhachHangKH.Location = new System.Drawing.Point(58, 64);
            this.lblIDKhachHangKH.Name = "lblIDKhachHangKH";
            this.lblIDKhachHangKH.Size = new System.Drawing.Size(117, 20);
            this.lblIDKhachHangKH.TabIndex = 0;
            this.lblIDKhachHangKH.Text = "ID Khách hàng";
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvKhachHang.Location = new System.Drawing.Point(0, 39);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersVisible = false;
            this.dgvKhachHang.RowHeadersWidth = 60;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(1352, 317);
            this.dgvKhachHang.TabIndex = 0;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_KhachHang";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Khách Hàng";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenKhachHang";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Khách Hàng";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NgaySinh";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ngày Sinh";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DiaChi";
            this.dataGridViewTextBoxColumn3.HeaderText = "Địa Chỉ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SoDT";
            this.dataGridViewTextBoxColumn4.HeaderText = "Số Điện Thoại";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.grpKhachHang);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1395, 662);
            this.tabPage4.TabIndex = 7;
            this.tabPage4.Text = "Khách hàng";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // grpKhachHang
            // 
            this.grpKhachHang.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.grpKhachHang.BorderRadius = 3;
            this.grpKhachHang.Controls.Add(this.dgvKhachHang);
            this.grpKhachHang.CustomBorderColor = System.Drawing.SystemColors.ButtonFace;
            this.grpKhachHang.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKhachHang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpKhachHang.Location = new System.Drawing.Point(22, 295);
            this.grpKhachHang.Name = "grpKhachHang";
            this.grpKhachHang.ShadowDecoration.Parent = this.grpKhachHang;
            this.grpKhachHang.Size = new System.Drawing.Size(1352, 359);
            this.grpKhachHang.TabIndex = 2;
            this.grpKhachHang.Text = "Danh sách khách hàng";
            // 
            // lblTrangThaiHD
            // 
            this.lblTrangThaiHD.AutoSize = true;
            this.lblTrangThaiHD.Location = new System.Drawing.Point(619, 195);
            this.lblTrangThaiHD.Name = "lblTrangThaiHD";
            this.lblTrangThaiHD.Size = new System.Drawing.Size(84, 20);
            this.lblTrangThaiHD.TabIndex = 3;
            this.lblTrangThaiHD.Text = "Trạng thái";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(58, 195);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(79, 20);
            this.lblTongTien.TabIndex = 3;
            this.lblTongTien.Text = "Tổng tiền";
            // 
            // dgvNhaCungCap
            // 
            this.dgvNhaCungCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhaCungCap.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaCungCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.TrangThai1});
            this.dgvNhaCungCap.Location = new System.Drawing.Point(0, 40);
            this.dgvNhaCungCap.Name = "dgvNhaCungCap";
            this.dgvNhaCungCap.ReadOnly = true;
            this.dgvNhaCungCap.RowHeadersVisible = false;
            this.dgvNhaCungCap.RowHeadersWidth = 60;
            this.dgvNhaCungCap.RowTemplate.Height = 24;
            this.dgvNhaCungCap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhaCungCap.Size = new System.Drawing.Size(1343, 302);
            this.dgvNhaCungCap.TabIndex = 0;
            this.dgvNhaCungCap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhaCungCap_CellClick);
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ID_NCC";
            this.dataGridViewTextBoxColumn13.HeaderText = "ID Nhà Cung Cấp";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "TenNCC";
            this.dataGridViewTextBoxColumn14.HeaderText = "Tên Nhà Cung Cấp";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "DiaChi";
            this.dataGridViewTextBoxColumn16.HeaderText = "Địa Chỉ";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "SoDT";
            this.dataGridViewTextBoxColumn17.HeaderText = "Số Điện Thoại";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // TrangThai1
            // 
            this.TrangThai1.DataPropertyName = "TrangThai";
            this.TrangThai1.HeaderText = "Trạng Thái";
            this.TrangThai1.MinimumWidth = 6;
            this.TrangThai1.Name = "TrangThai1";
            this.TrangThai1.ReadOnly = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.grpNhaCungCap);
            this.tabPage6.Controls.Add(this.groupBox5);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1395, 662);
            this.tabPage6.TabIndex = 8;
            this.tabPage6.Text = "Nhà Cung Cấp";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // grpNhaCungCap
            // 
            this.grpNhaCungCap.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.grpNhaCungCap.BorderRadius = 3;
            this.grpNhaCungCap.Controls.Add(this.dgvNhaCungCap);
            this.grpNhaCungCap.CustomBorderColor = System.Drawing.SystemColors.ButtonFace;
            this.grpNhaCungCap.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNhaCungCap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpNhaCungCap.Location = new System.Drawing.Point(26, 311);
            this.grpNhaCungCap.Name = "grpNhaCungCap";
            this.grpNhaCungCap.ShadowDecoration.Parent = this.grpNhaCungCap;
            this.grpNhaCungCap.Size = new System.Drawing.Size(1343, 345);
            this.grpNhaCungCap.TabIndex = 3;
            this.grpNhaCungCap.Text = "Danh sách nhà cung cấp";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnXuatExcelNCC);
            this.groupBox5.Controls.Add(this.btnThoatNCC);
            this.groupBox5.Controls.Add(this.btnXoaNCC);
            this.groupBox5.Controls.Add(this.btnCapNhatNCC);
            this.groupBox5.Controls.Add(this.btnThemNCC);
            this.groupBox5.Controls.Add(this.numTrangThaiNCC);
            this.groupBox5.Controls.Add(this.txtSoDTNCC);
            this.groupBox5.Controls.Add(this.txtTenNCC);
            this.groupBox5.Controls.Add(this.txtDiaChiNCC);
            this.groupBox5.Controls.Add(this.txtIDNCC);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.lblSDTNCC);
            this.groupBox5.Controls.Add(this.lblDiachiNCC);
            this.groupBox5.Controls.Add(this.lblTenNCC);
            this.groupBox5.Controls.Add(this.lblNCC);
            this.groupBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox5.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(26, 26);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1343, 268);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Nhà cung cấp";
            // 
            // btnXuatExcelNCC
            // 
            this.btnXuatExcelNCC.BorderRadius = 20;
            this.btnXuatExcelNCC.CheckedState.Parent = this.btnXuatExcelNCC;
            this.btnXuatExcelNCC.CustomImages.Parent = this.btnXuatExcelNCC;
            this.btnXuatExcelNCC.FillColor = System.Drawing.Color.Turquoise;
            this.btnXuatExcelNCC.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcelNCC.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcelNCC.HoverState.Parent = this.btnXuatExcelNCC;
            this.btnXuatExcelNCC.Location = new System.Drawing.Point(1122, 115);
            this.btnXuatExcelNCC.Name = "btnXuatExcelNCC";
            this.btnXuatExcelNCC.ShadowDecoration.Parent = this.btnXuatExcelNCC;
            this.btnXuatExcelNCC.Size = new System.Drawing.Size(138, 43);
            this.btnXuatExcelNCC.TabIndex = 38;
            this.btnXuatExcelNCC.Text = "Xuất Excel";
            this.btnXuatExcelNCC.Click += new System.EventHandler(this.btnXuatExcelNCC_Click);
            // 
            // btnThoatNCC
            // 
            this.btnThoatNCC.Animated = true;
            this.btnThoatNCC.BorderColor = System.Drawing.Color.Transparent;
            this.btnThoatNCC.BorderRadius = 20;
            this.btnThoatNCC.CheckedState.Parent = this.btnThoatNCC;
            this.btnThoatNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoatNCC.CustomImages.Parent = this.btnThoatNCC;
            this.btnThoatNCC.FillColor = System.Drawing.Color.Turquoise;
            this.btnThoatNCC.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.btnThoatNCC.ForeColor = System.Drawing.Color.White;
            this.btnThoatNCC.HoverState.Parent = this.btnThoatNCC;
            this.btnThoatNCC.IndicateFocus = true;
            this.btnThoatNCC.Location = new System.Drawing.Point(1046, 187);
            this.btnThoatNCC.Name = "btnThoatNCC";
            this.btnThoatNCC.ShadowDecoration.Parent = this.btnThoatNCC;
            this.btnThoatNCC.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.btnThoatNCC.Size = new System.Drawing.Size(138, 43);
            this.btnThoatNCC.TabIndex = 26;
            this.btnThoatNCC.Text = "Thoát";
            this.btnThoatNCC.Click += new System.EventHandler(this.btnThoatNCC_Click);
            // 
            // btnXoaNCC
            // 
            this.btnXoaNCC.Animated = true;
            this.btnXoaNCC.BorderColor = System.Drawing.Color.Transparent;
            this.btnXoaNCC.BorderRadius = 20;
            this.btnXoaNCC.CheckedState.Parent = this.btnXoaNCC;
            this.btnXoaNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaNCC.CustomImages.Parent = this.btnXoaNCC;
            this.btnXoaNCC.FillColor = System.Drawing.Color.Turquoise;
            this.btnXoaNCC.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.btnXoaNCC.ForeColor = System.Drawing.Color.White;
            this.btnXoaNCC.HoverState.Parent = this.btnXoaNCC;
            this.btnXoaNCC.IndicateFocus = true;
            this.btnXoaNCC.Location = new System.Drawing.Point(962, 115);
            this.btnXoaNCC.Name = "btnXoaNCC";
            this.btnXoaNCC.ShadowDecoration.Parent = this.btnXoaNCC;
            this.btnXoaNCC.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.btnXoaNCC.Size = new System.Drawing.Size(138, 43);
            this.btnXoaNCC.TabIndex = 27;
            this.btnXoaNCC.Text = "Xoá";
            this.btnXoaNCC.Click += new System.EventHandler(this.btnXoaNCC_Click);
            // 
            // btnCapNhatNCC
            // 
            this.btnCapNhatNCC.Animated = true;
            this.btnCapNhatNCC.BorderColor = System.Drawing.Color.Transparent;
            this.btnCapNhatNCC.BorderRadius = 20;
            this.btnCapNhatNCC.CheckedState.Parent = this.btnCapNhatNCC;
            this.btnCapNhatNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhatNCC.CustomImages.Parent = this.btnCapNhatNCC;
            this.btnCapNhatNCC.FillColor = System.Drawing.Color.Turquoise;
            this.btnCapNhatNCC.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.btnCapNhatNCC.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatNCC.HoverState.Parent = this.btnCapNhatNCC;
            this.btnCapNhatNCC.IndicateFocus = true;
            this.btnCapNhatNCC.Location = new System.Drawing.Point(1122, 50);
            this.btnCapNhatNCC.Name = "btnCapNhatNCC";
            this.btnCapNhatNCC.ShadowDecoration.Parent = this.btnCapNhatNCC;
            this.btnCapNhatNCC.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.btnCapNhatNCC.Size = new System.Drawing.Size(138, 43);
            this.btnCapNhatNCC.TabIndex = 28;
            this.btnCapNhatNCC.Text = "Cập nhật";
            this.btnCapNhatNCC.Click += new System.EventHandler(this.btnCapNhatNCC_Click);
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.Animated = true;
            this.btnThemNCC.BorderColor = System.Drawing.Color.Transparent;
            this.btnThemNCC.BorderRadius = 20;
            this.btnThemNCC.CheckedState.Parent = this.btnThemNCC;
            this.btnThemNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemNCC.CustomImages.Parent = this.btnThemNCC;
            this.btnThemNCC.FillColor = System.Drawing.Color.Turquoise;
            this.btnThemNCC.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.btnThemNCC.ForeColor = System.Drawing.Color.White;
            this.btnThemNCC.HoverState.Parent = this.btnThemNCC;
            this.btnThemNCC.IndicateFocus = true;
            this.btnThemNCC.Location = new System.Drawing.Point(962, 50);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.ShadowDecoration.Parent = this.btnThemNCC;
            this.btnThemNCC.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.btnThemNCC.Size = new System.Drawing.Size(138, 43);
            this.btnThemNCC.TabIndex = 29;
            this.btnThemNCC.Text = "Thêm";
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // numTrangThaiNCC
            // 
            this.numTrangThaiNCC.BackColor = System.Drawing.Color.Transparent;
            this.numTrangThaiNCC.BorderRadius = 5;
            this.numTrangThaiNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numTrangThaiNCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numTrangThaiNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numTrangThaiNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numTrangThaiNCC.DisabledState.Parent = this.numTrangThaiNCC;
            this.numTrangThaiNCC.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numTrangThaiNCC.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numTrangThaiNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numTrangThaiNCC.FocusedState.Parent = this.numTrangThaiNCC;
            this.numTrangThaiNCC.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTrangThaiNCC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numTrangThaiNCC.Location = new System.Drawing.Point(626, 122);
            this.numTrangThaiNCC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numTrangThaiNCC.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTrangThaiNCC.Name = "numTrangThaiNCC";
            this.numTrangThaiNCC.ShadowDecoration.Parent = this.numTrangThaiNCC;
            this.numTrangThaiNCC.Size = new System.Drawing.Size(124, 36);
            this.numTrangThaiNCC.TabIndex = 17;
            this.numTrangThaiNCC.UpDownButtonFillColor = System.Drawing.Color.Turquoise;
            this.numTrangThaiNCC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTrangThaiNCC.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numTrangThaiNCC_KeyUp);
            // 
            // txtSoDTNCC
            // 
            this.txtSoDTNCC.BorderRadius = 5;
            this.txtSoDTNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDTNCC.DefaultText = "";
            this.txtSoDTNCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoDTNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoDTNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDTNCC.DisabledState.Parent = this.txtSoDTNCC;
            this.txtSoDTNCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDTNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDTNCC.FocusedState.Parent = this.txtSoDTNCC;
            this.txtSoDTNCC.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDTNCC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSoDTNCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDTNCC.HoverState.Parent = this.txtSoDTNCC;
            this.txtSoDTNCC.Location = new System.Drawing.Point(215, 194);
            this.txtSoDTNCC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSoDTNCC.Name = "txtSoDTNCC";
            this.txtSoDTNCC.PasswordChar = '\0';
            this.txtSoDTNCC.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSoDTNCC.PlaceholderText = "";
            this.txtSoDTNCC.SelectedText = "";
            this.txtSoDTNCC.ShadowDecoration.Parent = this.txtSoDTNCC;
            this.txtSoDTNCC.Size = new System.Drawing.Size(270, 36);
            this.txtSoDTNCC.TabIndex = 16;
            this.txtSoDTNCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDTNCC_KeyPress);
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.BorderRadius = 5;
            this.txtTenNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNCC.DefaultText = "";
            this.txtTenNCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNCC.DisabledState.Parent = this.txtTenNCC;
            this.txtTenNCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNCC.FocusedState.Parent = this.txtTenNCC;
            this.txtTenNCC.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNCC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenNCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNCC.HoverState.Parent = this.txtTenNCC;
            this.txtTenNCC.Location = new System.Drawing.Point(215, 122);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.PasswordChar = '\0';
            this.txtTenNCC.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenNCC.PlaceholderText = "";
            this.txtTenNCC.SelectedText = "";
            this.txtTenNCC.ShadowDecoration.Parent = this.txtTenNCC;
            this.txtTenNCC.Size = new System.Drawing.Size(270, 36);
            this.txtTenNCC.TabIndex = 16;
            // 
            // txtDiaChiNCC
            // 
            this.txtDiaChiNCC.BorderRadius = 5;
            this.txtDiaChiNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChiNCC.DefaultText = "";
            this.txtDiaChiNCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChiNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChiNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChiNCC.DisabledState.Parent = this.txtDiaChiNCC;
            this.txtDiaChiNCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChiNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChiNCC.FocusedState.Parent = this.txtDiaChiNCC;
            this.txtDiaChiNCC.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiNCC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDiaChiNCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChiNCC.HoverState.Parent = this.txtDiaChiNCC;
            this.txtDiaChiNCC.Location = new System.Drawing.Point(626, 50);
            this.txtDiaChiNCC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDiaChiNCC.Name = "txtDiaChiNCC";
            this.txtDiaChiNCC.PasswordChar = '\0';
            this.txtDiaChiNCC.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDiaChiNCC.PlaceholderText = "";
            this.txtDiaChiNCC.SelectedText = "";
            this.txtDiaChiNCC.ShadowDecoration.Parent = this.txtDiaChiNCC;
            this.txtDiaChiNCC.Size = new System.Drawing.Size(270, 36);
            this.txtDiaChiNCC.TabIndex = 16;
            // 
            // txtIDNCC
            // 
            this.txtIDNCC.BorderRadius = 5;
            this.txtIDNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDNCC.DefaultText = "";
            this.txtIDNCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDNCC.DisabledState.Parent = this.txtIDNCC;
            this.txtIDNCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDNCC.FocusedState.Parent = this.txtIDNCC;
            this.txtIDNCC.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNCC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIDNCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDNCC.HoverState.Parent = this.txtIDNCC;
            this.txtIDNCC.Location = new System.Drawing.Point(215, 50);
            this.txtIDNCC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIDNCC.Name = "txtIDNCC";
            this.txtIDNCC.PasswordChar = '\0';
            this.txtIDNCC.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIDNCC.PlaceholderText = "";
            this.txtIDNCC.SelectedText = "";
            this.txtIDNCC.ShadowDecoration.Parent = this.txtIDNCC;
            this.txtIDNCC.Size = new System.Drawing.Size(270, 36);
            this.txtIDNCC.TabIndex = 16;
            this.txtIDNCC.TextChanged += new System.EventHandler(this.txtIDNCC_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(518, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "Trạng thái";
            // 
            // lblSDTNCC
            // 
            this.lblSDTNCC.AutoSize = true;
            this.lblSDTNCC.Location = new System.Drawing.Point(81, 210);
            this.lblSDTNCC.Name = "lblSDTNCC";
            this.lblSDTNCC.Size = new System.Drawing.Size(107, 20);
            this.lblSDTNCC.TabIndex = 3;
            this.lblSDTNCC.Text = "Số điện thoại";
            // 
            // lblDiachiNCC
            // 
            this.lblDiachiNCC.AutoSize = true;
            this.lblDiachiNCC.Location = new System.Drawing.Point(543, 66);
            this.lblDiachiNCC.Name = "lblDiachiNCC";
            this.lblDiachiNCC.Size = new System.Drawing.Size(59, 20);
            this.lblDiachiNCC.TabIndex = 3;
            this.lblDiachiNCC.Text = "Địa chỉ";
            // 
            // lblTenNCC
            // 
            this.lblTenNCC.AutoSize = true;
            this.lblTenNCC.Location = new System.Drawing.Point(48, 138);
            this.lblTenNCC.Name = "lblTenNCC";
            this.lblTenNCC.Size = new System.Drawing.Size(140, 20);
            this.lblTenNCC.TabIndex = 0;
            this.lblTenNCC.Text = "Tên nhà cung cấp";
            // 
            // lblNCC
            // 
            this.lblNCC.AutoSize = true;
            this.lblNCC.Location = new System.Drawing.Point(56, 66);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(132, 20);
            this.lblNCC.TabIndex = 0;
            this.lblNCC.Text = "ID Nhà cung cấp";
            // 
            // grpSanPham
            // 
            this.grpSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSanPham.Controls.Add(this.tabPage1);
            this.grpSanPham.Controls.Add(this.tabPage3);
            this.grpSanPham.Controls.Add(this.tabPage5);
            this.grpSanPham.Controls.Add(this.tabPage4);
            this.grpSanPham.Controls.Add(this.tabPage6);
            this.grpSanPham.Controls.Add(this.tabPage7);
            this.grpSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grpSanPham.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSanPham.Location = new System.Drawing.Point(0, 50);
            this.grpSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.grpSanPham.Name = "grpSanPham";
            this.grpSanPham.SelectedIndex = 0;
            this.grpSanPham.Size = new System.Drawing.Size(1403, 695);
            this.grpSanPham.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.grpSanPham.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::_452_417_CDTH19E_SHOESSHOP.Properties.Resources._1611116667_50_hinh_nen_mau_xanh_dep_danh_cho_may_tinh;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1395, 662);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Màn hình chính";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.Font = new System.Drawing.Font("Roboto", 34.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightCyan;
            this.label9.Location = new System.Drawing.Point(4, 588);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(529, 70);
            this.label9.TabIndex = 1;
            this.label9.Text = "QUẢN LÝ BÁN GIÀY";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.grpDanhSachSP);
            this.tabPage3.Controls.Add(this.grp1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1395, 662);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sản phẩm";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grpDanhSachSP
            // 
            this.grpDanhSachSP.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.grpDanhSachSP.BorderRadius = 3;
            this.grpDanhSachSP.Controls.Add(this.dgvSanPham);
            this.grpDanhSachSP.CustomBorderColor = System.Drawing.SystemColors.ButtonFace;
            this.grpDanhSachSP.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDanhSachSP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpDanhSachSP.Location = new System.Drawing.Point(25, 314);
            this.grpDanhSachSP.Name = "grpDanhSachSP";
            this.grpDanhSachSP.ShadowDecoration.Parent = this.grpDanhSachSP;
            this.grpDanhSachSP.Size = new System.Drawing.Size(1347, 340);
            this.grpDanhSachSP.TabIndex = 1;
            this.grpDanhSachSP.Text = "Danh sách sản phẩm";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_SanPham,
            this.ID_NCC,
            this.ID_LoaiSanPham,
            this.TenSanPham,
            this.TrangThai});
            this.dgvSanPham.Location = new System.Drawing.Point(0, 40);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.RowHeadersWidth = 60;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(1347, 300);
            this.dgvSanPham.TabIndex = 1;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // ID_SanPham
            // 
            this.ID_SanPham.DataPropertyName = "ID_SanPham";
            this.ID_SanPham.HeaderText = "ID Sản Phẩm";
            this.ID_SanPham.MinimumWidth = 6;
            this.ID_SanPham.Name = "ID_SanPham";
            this.ID_SanPham.ReadOnly = true;
            // 
            // ID_NCC
            // 
            this.ID_NCC.DataPropertyName = "ID_NCC";
            this.ID_NCC.HeaderText = "ID Nhà Cung Cấp";
            this.ID_NCC.MinimumWidth = 6;
            this.ID_NCC.Name = "ID_NCC";
            this.ID_NCC.ReadOnly = true;
            // 
            // ID_LoaiSanPham
            // 
            this.ID_LoaiSanPham.DataPropertyName = "ID_LoaiSanPham";
            this.ID_LoaiSanPham.HeaderText = "ID Loại Sản Phẩm";
            this.ID_LoaiSanPham.MinimumWidth = 6;
            this.ID_LoaiSanPham.Name = "ID_LoaiSanPham";
            this.ID_LoaiSanPham.ReadOnly = true;
            // 
            // TenSanPham
            // 
            this.TenSanPham.DataPropertyName = "TenSanPham";
            this.TenSanPham.HeaderText = "Tên sản phẩm";
            this.TenSanPham.MinimumWidth = 6;
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.btnXuatExcelSP);
            this.grp1.Controls.Add(this.btnThoatSP);
            this.grp1.Controls.Add(this.btnXoaSP);
            this.grp1.Controls.Add(this.btnCapNhatSP);
            this.grp1.Controls.Add(this.btnThemSP);
            this.grp1.Controls.Add(this.numTrangThaiSP);
            this.grp1.Controls.Add(this.cboLoaiSanPham);
            this.grp1.Controls.Add(this.cboIDNCC);
            this.grp1.Controls.Add(this.txtTenSanPham);
            this.grp1.Controls.Add(this.txtIDSanPham);
            this.grp1.Controls.Add(this.lblTrangThaiSP);
            this.grp1.Controls.Add(this.label1);
            this.grp1.Controls.Add(this.label4);
            this.grp1.Controls.Add(this.lblTenSP);
            this.grp1.Controls.Add(this.lblIDSP);
            this.grp1.Cursor = System.Windows.Forms.Cursors.Default;
            this.grp1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp1.Location = new System.Drawing.Point(25, 22);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(1347, 272);
            this.grp1.TabIndex = 0;
            this.grp1.TabStop = false;
            this.grp1.Text = "Sản phẩm";
            // 
            // btnXuatExcelSP
            // 
            this.btnXuatExcelSP.BorderRadius = 20;
            this.btnXuatExcelSP.CheckedState.Parent = this.btnXuatExcelSP;
            this.btnXuatExcelSP.CustomImages.Parent = this.btnXuatExcelSP;
            this.btnXuatExcelSP.FillColor = System.Drawing.Color.Turquoise;
            this.btnXuatExcelSP.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcelSP.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcelSP.HoverState.Parent = this.btnXuatExcelSP;
            this.btnXuatExcelSP.Location = new System.Drawing.Point(1157, 132);
            this.btnXuatExcelSP.Name = "btnXuatExcelSP";
            this.btnXuatExcelSP.ShadowDecoration.Parent = this.btnXuatExcelSP;
            this.btnXuatExcelSP.Size = new System.Drawing.Size(138, 43);
            this.btnXuatExcelSP.TabIndex = 18;
            this.btnXuatExcelSP.Text = "Xuất Excel";
            this.btnXuatExcelSP.Click += new System.EventHandler(this.btnXuatExcelSP_Click);
            // 
            // btnThoatSP
            // 
            this.btnThoatSP.Animated = true;
            this.btnThoatSP.BorderColor = System.Drawing.Color.Transparent;
            this.btnThoatSP.BorderRadius = 20;
            this.btnThoatSP.CheckedState.Parent = this.btnThoatSP;
            this.btnThoatSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoatSP.CustomImages.Parent = this.btnThoatSP;
            this.btnThoatSP.FillColor = System.Drawing.Color.Turquoise;
            this.btnThoatSP.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.btnThoatSP.ForeColor = System.Drawing.Color.White;
            this.btnThoatSP.HoverState.Parent = this.btnThoatSP;
            this.btnThoatSP.IndicateFocus = true;
            this.btnThoatSP.Location = new System.Drawing.Point(1076, 205);
            this.btnThoatSP.Name = "btnThoatSP";
            this.btnThoatSP.ShadowDecoration.Parent = this.btnThoatSP;
            this.btnThoatSP.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.btnThoatSP.Size = new System.Drawing.Size(138, 43);
            this.btnThoatSP.TabIndex = 17;
            this.btnThoatSP.Text = "Thoát";
            this.btnThoatSP.Click += new System.EventHandler(this.btnThoatSP_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Animated = true;
            this.btnXoaSP.BorderColor = System.Drawing.Color.Transparent;
            this.btnXoaSP.BorderRadius = 20;
            this.btnXoaSP.CheckedState.Parent = this.btnXoaSP;
            this.btnXoaSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaSP.CustomImages.Parent = this.btnXoaSP;
            this.btnXoaSP.FillColor = System.Drawing.Color.Turquoise;
            this.btnXoaSP.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.btnXoaSP.ForeColor = System.Drawing.Color.White;
            this.btnXoaSP.HoverState.Parent = this.btnXoaSP;
            this.btnXoaSP.IndicateFocus = true;
            this.btnXoaSP.Location = new System.Drawing.Point(998, 132);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.ShadowDecoration.Parent = this.btnXoaSP;
            this.btnXoaSP.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.btnXoaSP.Size = new System.Drawing.Size(138, 43);
            this.btnXoaSP.TabIndex = 17;
            this.btnXoaSP.Text = "Xoá";
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnCapNhatSP
            // 
            this.btnCapNhatSP.Animated = true;
            this.btnCapNhatSP.BorderColor = System.Drawing.Color.Transparent;
            this.btnCapNhatSP.BorderRadius = 20;
            this.btnCapNhatSP.CheckedState.Parent = this.btnCapNhatSP;
            this.btnCapNhatSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhatSP.CustomImages.Parent = this.btnCapNhatSP;
            this.btnCapNhatSP.FillColor = System.Drawing.Color.Turquoise;
            this.btnCapNhatSP.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.btnCapNhatSP.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatSP.HoverState.Parent = this.btnCapNhatSP;
            this.btnCapNhatSP.IndicateFocus = true;
            this.btnCapNhatSP.Location = new System.Drawing.Point(1157, 64);
            this.btnCapNhatSP.Name = "btnCapNhatSP";
            this.btnCapNhatSP.ShadowDecoration.Parent = this.btnCapNhatSP;
            this.btnCapNhatSP.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.btnCapNhatSP.Size = new System.Drawing.Size(138, 43);
            this.btnCapNhatSP.TabIndex = 17;
            this.btnCapNhatSP.Text = "Cập nhật";
            this.btnCapNhatSP.Click += new System.EventHandler(this.btnCapNhatSP_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.Animated = true;
            this.btnThemSP.BorderColor = System.Drawing.Color.Transparent;
            this.btnThemSP.BorderRadius = 20;
            this.btnThemSP.CheckedState.Parent = this.btnThemSP;
            this.btnThemSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemSP.CustomImages.Parent = this.btnThemSP;
            this.btnThemSP.FillColor = System.Drawing.Color.Turquoise;
            this.btnThemSP.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.btnThemSP.ForeColor = System.Drawing.Color.White;
            this.btnThemSP.HoverState.Parent = this.btnThemSP;
            this.btnThemSP.IndicateFocus = true;
            this.btnThemSP.Location = new System.Drawing.Point(998, 64);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.ShadowDecoration.Parent = this.btnThemSP;
            this.btnThemSP.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.btnThemSP.Size = new System.Drawing.Size(138, 43);
            this.btnThemSP.TabIndex = 17;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // numTrangThaiSP
            // 
            this.numTrangThaiSP.BackColor = System.Drawing.Color.Transparent;
            this.numTrangThaiSP.BorderRadius = 5;
            this.numTrangThaiSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numTrangThaiSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numTrangThaiSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numTrangThaiSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numTrangThaiSP.DisabledState.Parent = this.numTrangThaiSP;
            this.numTrangThaiSP.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numTrangThaiSP.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numTrangThaiSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numTrangThaiSP.FocusedState.Parent = this.numTrangThaiSP;
            this.numTrangThaiSP.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTrangThaiSP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numTrangThaiSP.Location = new System.Drawing.Point(673, 132);
            this.numTrangThaiSP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numTrangThaiSP.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTrangThaiSP.Name = "numTrangThaiSP";
            this.numTrangThaiSP.ShadowDecoration.Parent = this.numTrangThaiSP;
            this.numTrangThaiSP.Size = new System.Drawing.Size(134, 36);
            this.numTrangThaiSP.TabIndex = 16;
            this.numTrangThaiSP.UpDownButtonFillColor = System.Drawing.Color.Turquoise;
            this.numTrangThaiSP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTrangThaiSP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numTrangThaiSP_KeyUp);
            // 
            // cboLoaiSanPham
            // 
            this.cboLoaiSanPham.BackColor = System.Drawing.Color.Transparent;
            this.cboLoaiSanPham.BorderRadius = 5;
            this.cboLoaiSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboLoaiSanPham.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoaiSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiSanPham.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoaiSanPham.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoaiSanPham.FocusedState.Parent = this.cboLoaiSanPham;
            this.cboLoaiSanPham.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiSanPham.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboLoaiSanPham.HoverState.Parent = this.cboLoaiSanPham;
            this.cboLoaiSanPham.ItemHeight = 30;
            this.cboLoaiSanPham.ItemsAppearance.Parent = this.cboLoaiSanPham;
            this.cboLoaiSanPham.Location = new System.Drawing.Point(183, 205);
            this.cboLoaiSanPham.Name = "cboLoaiSanPham";
            this.cboLoaiSanPham.ShadowDecoration.Parent = this.cboLoaiSanPham;
            this.cboLoaiSanPham.Size = new System.Drawing.Size(276, 36);
            this.cboLoaiSanPham.TabIndex = 15;
            // 
            // cboIDNCC
            // 
            this.cboIDNCC.BackColor = System.Drawing.Color.Transparent;
            this.cboIDNCC.BorderRadius = 5;
            this.cboIDNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboIDNCC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIDNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIDNCC.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboIDNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboIDNCC.FocusedState.Parent = this.cboIDNCC;
            this.cboIDNCC.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIDNCC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboIDNCC.HoverState.Parent = this.cboIDNCC;
            this.cboIDNCC.ItemHeight = 30;
            this.cboIDNCC.ItemsAppearance.Parent = this.cboIDNCC;
            this.cboIDNCC.Location = new System.Drawing.Point(673, 64);
            this.cboIDNCC.Name = "cboIDNCC";
            this.cboIDNCC.ShadowDecoration.Parent = this.cboIDNCC;
            this.cboIDNCC.Size = new System.Drawing.Size(276, 36);
            this.cboIDNCC.TabIndex = 15;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.BorderRadius = 5;
            this.txtTenSanPham.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSanPham.DefaultText = "";
            this.txtTenSanPham.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenSanPham.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenSanPham.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSanPham.DisabledState.Parent = this.txtTenSanPham;
            this.txtTenSanPham.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSanPham.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSanPham.FocusedState.Parent = this.txtTenSanPham;
            this.txtTenSanPham.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSanPham.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenSanPham.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSanPham.HoverState.Parent = this.txtTenSanPham;
            this.txtTenSanPham.Location = new System.Drawing.Point(183, 132);
            this.txtTenSanPham.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.PasswordChar = '\0';
            this.txtTenSanPham.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenSanPham.PlaceholderText = "";
            this.txtTenSanPham.SelectedText = "";
            this.txtTenSanPham.ShadowDecoration.Parent = this.txtTenSanPham;
            this.txtTenSanPham.Size = new System.Drawing.Size(276, 36);
            this.txtTenSanPham.TabIndex = 14;
            // 
            // txtIDSanPham
            // 
            this.txtIDSanPham.BorderRadius = 5;
            this.txtIDSanPham.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDSanPham.DefaultText = "";
            this.txtIDSanPham.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDSanPham.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDSanPham.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDSanPham.DisabledState.Parent = this.txtIDSanPham;
            this.txtIDSanPham.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDSanPham.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDSanPham.FocusedState.Parent = this.txtIDSanPham;
            this.txtIDSanPham.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDSanPham.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIDSanPham.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDSanPham.HoverState.Parent = this.txtIDSanPham;
            this.txtIDSanPham.Location = new System.Drawing.Point(183, 64);
            this.txtIDSanPham.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIDSanPham.Name = "txtIDSanPham";
            this.txtIDSanPham.PasswordChar = '\0';
            this.txtIDSanPham.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIDSanPham.PlaceholderText = "";
            this.txtIDSanPham.SelectedText = "";
            this.txtIDSanPham.ShadowDecoration.Parent = this.txtIDSanPham;
            this.txtIDSanPham.Size = new System.Drawing.Size(276, 36);
            this.txtIDSanPham.TabIndex = 13;
            this.txtIDSanPham.TextChanged += new System.EventHandler(this.txtIDSanPham_TextChanged);
            this.txtIDSanPham.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDSanPham_KeyPress);
            // 
            // lblTrangThaiSP
            // 
            this.lblTrangThaiSP.AutoSize = true;
            this.lblTrangThaiSP.Location = new System.Drawing.Point(561, 148);
            this.lblTrangThaiSP.Name = "lblTrangThaiSP";
            this.lblTrangThaiSP.Size = new System.Drawing.Size(84, 20);
            this.lblTrangThaiSP.TabIndex = 3;
            this.lblTrangThaiSP.Text = "Trạng thái";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID Nhà cung cấp";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(51, 148);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(114, 20);
            this.lblTenSP.TabIndex = 0;
            this.lblTenSP.Text = "Tên sản phẩm";
            // 
            // lblIDSP
            // 
            this.lblIDSP.AutoSize = true;
            this.lblIDSP.Location = new System.Drawing.Point(61, 80);
            this.lblIDSP.Name = "lblIDSP";
            this.lblIDSP.Size = new System.Drawing.Size(104, 20);
            this.lblIDSP.TabIndex = 0;
            this.lblIDSP.Text = "ID Sản phẩm";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.grpDanhSachHD);
            this.tabPage5.Controls.Add(this.grp2);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1395, 662);
            this.tabPage5.TabIndex = 6;
            this.tabPage5.Text = "Hoá đơn";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // grpDanhSachHD
            // 
            this.grpDanhSachHD.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.grpDanhSachHD.BorderRadius = 3;
            this.grpDanhSachHD.Controls.Add(this.dgvHoaDon);
            this.grpDanhSachHD.CustomBorderColor = System.Drawing.SystemColors.ButtonFace;
            this.grpDanhSachHD.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDanhSachHD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpDanhSachHD.Location = new System.Drawing.Point(19, 293);
            this.grpDanhSachHD.Name = "grpDanhSachHD";
            this.grpDanhSachHD.ShadowDecoration.Parent = this.grpDanhSachHD;
            this.grpDanhSachHD.Size = new System.Drawing.Size(1351, 363);
            this.grpDanhSachHD.TabIndex = 4;
            this.grpDanhSachHD.Text = "Danh sách hoá đơn";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 40);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowHeadersWidth = 60;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(1351, 321);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID_HoaDon";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID Hoá Đơn";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ID_KhachHang";
            this.dataGridViewTextBoxColumn7.HeaderText = "ID Khách Hàng";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DiaChi";
            this.dataGridViewTextBoxColumn8.HeaderText = "Địa Chỉ";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "NgayBan";
            this.dataGridViewTextBoxColumn9.HeaderText = "Ngày Bán";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "TongTien";
            this.dataGridViewTextBoxColumn11.HeaderText = "Tổng Tiền";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "TrangThai";
            this.dataGridViewTextBoxColumn12.HeaderText = "Trạng thái";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // grp2
            // 
            this.grp2.Controls.Add(this.dtpNgayBan);
            this.grp2.Controls.Add(this.btnThoatHD);
            this.grp2.Controls.Add(this.btnXoaHD);
            this.grp2.Controls.Add(this.btnCapNhatHD);
            this.grp2.Controls.Add(this.btnThemHD);
            this.grp2.Controls.Add(this.numTrangThaiHD);
            this.grp2.Controls.Add(this.txtDiaChiHD);
            this.grp2.Controls.Add(this.txtTongTienHD);
            this.grp2.Controls.Add(this.cboIDKhachHang);
            this.grp2.Controls.Add(this.txtIDHoaDon);
            this.grp2.Controls.Add(this.lblTrangThaiHD);
            this.grp2.Controls.Add(this.lblTongTien);
            this.grp2.Controls.Add(this.lblNgayBan);
            this.grp2.Controls.Add(this.lblDiaChi);
            this.grp2.Controls.Add(this.lblIDKhachHang);
            this.grp2.Controls.Add(this.lblIDHoaDon);
            this.grp2.Cursor = System.Windows.Forms.Cursors.Default;
            this.grp2.Location = new System.Drawing.Point(19, 19);
            this.grp2.Name = "grp2";
            this.grp2.Size = new System.Drawing.Size(1351, 268);
            this.grp2.TabIndex = 3;
            this.grp2.TabStop = false;
            this.grp2.Text = "Hoá đơn";
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Animated = true;
            this.dtpNgayBan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtpNgayBan.BorderRadius = 5;
            this.dtpNgayBan.CheckedState.Parent = this.dtpNgayBan;
            this.dtpNgayBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNgayBan.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBan.FillColor = System.Drawing.Color.Turquoise;
            this.dtpNgayBan.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.dtpNgayBan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBan.HoverState.Parent = this.dtpNgayBan;
            this.dtpNgayBan.IndicateFocus = true;
            this.dtpNgayBan.Location = new System.Drawing.Point(732, 120);
            this.dtpNgayBan.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayBan.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.ShadowDecoration.Parent = this.dtpNgayBan;
            this.dtpNgayBan.Size = new System.Drawing.Size(282, 36);
            this.dtpNgayBan.TabIndex = 35;
            this.dtpNgayBan.Value = new System.DateTime(2021, 5, 29, 22, 23, 11, 26);
            // 
            // btnThoatHD
            // 
            this.btnThoatHD.Animated = true;
            this.btnThoatHD.BorderColor = System.Drawing.Color.Transparent;
            this.btnThoatHD.BorderRadius = 20;
            this.btnThoatHD.CheckedState.Parent = this.btnThoatHD;
            this.btnThoatHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoatHD.CustomImages.Parent = this.btnThoatHD;
            this.btnThoatHD.FillColor = System.Drawing.Color.Turquoise;
            this.btnThoatHD.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.btnThoatHD.ForeColor = System.Drawing.Color.White;
            this.btnThoatHD.HoverState.Parent = this.btnThoatHD;
            this.btnThoatHD.IndicateFocus = true;
            this.btnThoatHD.Location = new System.Drawing.Point(1097, 203);
            this.btnThoatHD.Name = "btnThoatHD";
            this.btnThoatHD.ShadowDecoration.Parent = this.btnThoatHD;
            this.btnThoatHD.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.btnThoatHD.Size = new System.Drawing.Size(138, 43);
            this.btnThoatHD.TabIndex = 18;
            this.btnThoatHD.Text = "Thoát";
            this.btnThoatHD.Click += new System.EventHandler(this.btnThoatHD_Click);
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.Animated = true;
            this.btnXoaHD.BorderColor = System.Drawing.Color.Transparent;
            this.btnXoaHD.BorderRadius = 20;
            this.btnXoaHD.CheckedState.Parent = this.btnXoaHD;
            this.btnXoaHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaHD.CustomImages.Parent = this.btnXoaHD;
            this.btnXoaHD.FillColor = System.Drawing.Color.Turquoise;
            this.btnXoaHD.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.btnXoaHD.ForeColor = System.Drawing.Color.White;
            this.btnXoaHD.HoverState.Parent = this.btnXoaHD;
            this.btnXoaHD.IndicateFocus = true;
            this.btnXoaHD.Location = new System.Drawing.Point(1097, 144);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.ShadowDecoration.Parent = this.btnXoaHD;
            this.btnXoaHD.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.btnXoaHD.Size = new System.Drawing.Size(138, 43);
            this.btnXoaHD.TabIndex = 19;
            this.btnXoaHD.Text = "Xoá";
            this.btnXoaHD.Click += new System.EventHandler(this.btnXoaHD_Click);
            // 
            // btnCapNhatHD
            // 
            this.btnCapNhatHD.Animated = true;
            this.btnCapNhatHD.BorderColor = System.Drawing.Color.Transparent;
            this.btnCapNhatHD.BorderRadius = 20;
            this.btnCapNhatHD.CheckedState.Parent = this.btnCapNhatHD;
            this.btnCapNhatHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhatHD.CustomImages.Parent = this.btnCapNhatHD;
            this.btnCapNhatHD.FillColor = System.Drawing.Color.Turquoise;
            this.btnCapNhatHD.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.btnCapNhatHD.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatHD.HoverState.Parent = this.btnCapNhatHD;
            this.btnCapNhatHD.IndicateFocus = true;
            this.btnCapNhatHD.Location = new System.Drawing.Point(1097, 85);
            this.btnCapNhatHD.Name = "btnCapNhatHD";
            this.btnCapNhatHD.ShadowDecoration.Parent = this.btnCapNhatHD;
            this.btnCapNhatHD.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.btnCapNhatHD.Size = new System.Drawing.Size(138, 43);
            this.btnCapNhatHD.TabIndex = 20;
            this.btnCapNhatHD.Text = "Cập nhật";
            this.btnCapNhatHD.Click += new System.EventHandler(this.btnCapNhatHD_Click);
            // 
            // btnThemHD
            // 
            this.btnThemHD.Animated = true;
            this.btnThemHD.BorderColor = System.Drawing.Color.Transparent;
            this.btnThemHD.BorderRadius = 20;
            this.btnThemHD.CheckedState.Parent = this.btnThemHD;
            this.btnThemHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemHD.CustomImages.Parent = this.btnThemHD;
            this.btnThemHD.FillColor = System.Drawing.Color.Turquoise;
            this.btnThemHD.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.btnThemHD.ForeColor = System.Drawing.Color.White;
            this.btnThemHD.HoverState.Parent = this.btnThemHD;
            this.btnThemHD.IndicateFocus = true;
            this.btnThemHD.Location = new System.Drawing.Point(1097, 26);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.ShadowDecoration.Parent = this.btnThemHD;
            this.btnThemHD.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.btnThemHD.Size = new System.Drawing.Size(138, 43);
            this.btnThemHD.TabIndex = 21;
            this.btnThemHD.Text = "Thêm";
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // numTrangThaiHD
            // 
            this.numTrangThaiHD.BackColor = System.Drawing.Color.Transparent;
            this.numTrangThaiHD.BorderRadius = 5;
            this.numTrangThaiHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numTrangThaiHD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numTrangThaiHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numTrangThaiHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numTrangThaiHD.DisabledState.Parent = this.numTrangThaiHD;
            this.numTrangThaiHD.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numTrangThaiHD.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numTrangThaiHD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numTrangThaiHD.FocusedState.Parent = this.numTrangThaiHD;
            this.numTrangThaiHD.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTrangThaiHD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numTrangThaiHD.Location = new System.Drawing.Point(732, 179);
            this.numTrangThaiHD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numTrangThaiHD.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTrangThaiHD.Name = "numTrangThaiHD";
            this.numTrangThaiHD.ShadowDecoration.Parent = this.numTrangThaiHD;
            this.numTrangThaiHD.Size = new System.Drawing.Size(129, 36);
            this.numTrangThaiHD.TabIndex = 13;
            this.numTrangThaiHD.UpDownButtonFillColor = System.Drawing.Color.Turquoise;
            this.numTrangThaiHD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTrangThaiHD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numTrangThaiHD_KeyUp);
            // 
            // txtDiaChiHD
            // 
            this.txtDiaChiHD.BorderRadius = 5;
            this.txtDiaChiHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChiHD.DefaultText = "";
            this.txtDiaChiHD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChiHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChiHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChiHD.DisabledState.Parent = this.txtDiaChiHD;
            this.txtDiaChiHD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChiHD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChiHD.FocusedState.Parent = this.txtDiaChiHD;
            this.txtDiaChiHD.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiHD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDiaChiHD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChiHD.HoverState.Parent = this.txtDiaChiHD;
            this.txtDiaChiHD.Location = new System.Drawing.Point(732, 61);
            this.txtDiaChiHD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDiaChiHD.Name = "txtDiaChiHD";
            this.txtDiaChiHD.PasswordChar = '\0';
            this.txtDiaChiHD.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDiaChiHD.PlaceholderText = "";
            this.txtDiaChiHD.SelectedText = "";
            this.txtDiaChiHD.ShadowDecoration.Parent = this.txtDiaChiHD;
            this.txtDiaChiHD.Size = new System.Drawing.Size(282, 36);
            this.txtDiaChiHD.TabIndex = 12;
            // 
            // txtTongTienHD
            // 
            this.txtTongTienHD.BorderRadius = 5;
            this.txtTongTienHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongTienHD.DefaultText = "";
            this.txtTongTienHD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTongTienHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTongTienHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongTienHD.DisabledState.Parent = this.txtTongTienHD;
            this.txtTongTienHD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongTienHD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongTienHD.FocusedState.Parent = this.txtTongTienHD;
            this.txtTongTienHD.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTienHD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTongTienHD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongTienHD.HoverState.Parent = this.txtTongTienHD;
            this.txtTongTienHD.Location = new System.Drawing.Point(189, 179);
            this.txtTongTienHD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTongTienHD.Name = "txtTongTienHD";
            this.txtTongTienHD.PasswordChar = '\0';
            this.txtTongTienHD.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTongTienHD.PlaceholderText = "";
            this.txtTongTienHD.SelectedText = "";
            this.txtTongTienHD.ShadowDecoration.Parent = this.txtTongTienHD;
            this.txtTongTienHD.Size = new System.Drawing.Size(289, 36);
            this.txtTongTienHD.TabIndex = 11;
            // 
            // cboIDKhachHang
            // 
            this.cboIDKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.cboIDKhachHang.BorderRadius = 5;
            this.cboIDKhachHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIDKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIDKhachHang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboIDKhachHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboIDKhachHang.FocusedState.Parent = this.cboIDKhachHang;
            this.cboIDKhachHang.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIDKhachHang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboIDKhachHang.HoverState.Parent = this.cboIDKhachHang;
            this.cboIDKhachHang.ItemHeight = 30;
            this.cboIDKhachHang.ItemsAppearance.Parent = this.cboIDKhachHang;
            this.cboIDKhachHang.Location = new System.Drawing.Point(189, 120);
            this.cboIDKhachHang.Name = "cboIDKhachHang";
            this.cboIDKhachHang.ShadowDecoration.Parent = this.cboIDKhachHang;
            this.cboIDKhachHang.Size = new System.Drawing.Size(173, 36);
            this.cboIDKhachHang.TabIndex = 10;
            // 
            // txtIDHoaDon
            // 
            this.txtIDHoaDon.BorderRadius = 5;
            this.txtIDHoaDon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDHoaDon.DefaultText = "";
            this.txtIDHoaDon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDHoaDon.DisabledState.Parent = this.txtIDHoaDon;
            this.txtIDHoaDon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDHoaDon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDHoaDon.FocusedState.Parent = this.txtIDHoaDon;
            this.txtIDHoaDon.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDHoaDon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIDHoaDon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDHoaDon.HoverState.Parent = this.txtIDHoaDon;
            this.txtIDHoaDon.Location = new System.Drawing.Point(189, 61);
            this.txtIDHoaDon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIDHoaDon.Name = "txtIDHoaDon";
            this.txtIDHoaDon.PasswordChar = '\0';
            this.txtIDHoaDon.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIDHoaDon.PlaceholderText = "";
            this.txtIDHoaDon.SelectedText = "";
            this.txtIDHoaDon.ShadowDecoration.Parent = this.txtIDHoaDon;
            this.txtIDHoaDon.Size = new System.Drawing.Size(289, 36);
            this.txtIDHoaDon.TabIndex = 9;
            this.txtIDHoaDon.TextChanged += new System.EventHandler(this.txtIDHoaDon_TextChanged);
            // 
            // lblNgayBan
            // 
            this.lblNgayBan.AutoSize = true;
            this.lblNgayBan.Location = new System.Drawing.Point(619, 136);
            this.lblNgayBan.Name = "lblNgayBan";
            this.lblNgayBan.Size = new System.Drawing.Size(80, 20);
            this.lblNgayBan.TabIndex = 0;
            this.lblNgayBan.Text = "Ngày bán";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(640, 77);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(59, 20);
            this.lblDiaChi.TabIndex = 0;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblIDKhachHang
            // 
            this.lblIDKhachHang.AutoSize = true;
            this.lblIDKhachHang.Location = new System.Drawing.Point(20, 136);
            this.lblIDKhachHang.Name = "lblIDKhachHang";
            this.lblIDKhachHang.Size = new System.Drawing.Size(117, 20);
            this.lblIDKhachHang.TabIndex = 0;
            this.lblIDKhachHang.Text = "ID Khách hàng";
            // 
            // lblIDHoaDon
            // 
            this.lblIDHoaDon.AutoSize = true;
            this.lblIDHoaDon.Location = new System.Drawing.Point(44, 77);
            this.lblIDHoaDon.Name = "lblIDHoaDon";
            this.lblIDHoaDon.Size = new System.Drawing.Size(93, 20);
            this.lblIDHoaDon.TabIndex = 0;
            this.lblIDHoaDon.Text = "ID Hoá đơn";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.grpNhanVien);
            this.tabPage7.Controls.Add(this.groupBox7);
            this.tabPage7.Location = new System.Drawing.Point(4, 29);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1395, 662);
            this.tabPage7.TabIndex = 9;
            this.tabPage7.Text = "Nhân Viên";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // grpNhanVien
            // 
            this.grpNhanVien.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.grpNhanVien.BorderRadius = 3;
            this.grpNhanVien.Controls.Add(this.dgvNhanVien);
            this.grpNhanVien.CustomBorderColor = System.Drawing.SystemColors.ButtonFace;
            this.grpNhanVien.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNhanVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpNhanVien.Location = new System.Drawing.Point(22, 304);
            this.grpNhanVien.Name = "grpNhanVien";
            this.grpNhanVien.ShadowDecoration.Parent = this.grpNhanVien;
            this.grpNhanVien.Size = new System.Drawing.Size(1343, 350);
            this.grpNhanVien.TabIndex = 4;
            this.grpNhanVien.Text = "Danh sách  nhân viên";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_NhanVien,
            this.TenNhanVien,
            this.Column4,
            this.dataGridViewTextBoxColumn19,
            this.Luong,
            this.dataGridViewTextBoxColumn18,
            this.Trang,
            this.Dia});
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 39);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.RowHeadersWidth = 60;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(1343, 308);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // ID_NhanVien
            // 
            this.ID_NhanVien.DataPropertyName = "ID_NhanVien";
            this.ID_NhanVien.HeaderText = "ID Nhân Viên";
            this.ID_NhanVien.MinimumWidth = 6;
            this.ID_NhanVien.Name = "ID_NhanVien";
            this.ID_NhanVien.ReadOnly = true;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            this.TenNhanVien.HeaderText = "Tên Nhân Viên";
            this.TenNhanVien.MinimumWidth = 6;
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgaySinh";
            this.Column4.HeaderText = "Ngày Sinh";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "SoDT";
            this.dataGridViewTextBoxColumn19.HeaderText = "Số Điện Thoại";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // Luong
            // 
            this.Luong.DataPropertyName = "Luong";
            this.Luong.HeaderText = "Lương";
            this.Luong.MinimumWidth = 6;
            this.Luong.Name = "Luong";
            this.Luong.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn18.HeaderText = "Email";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // Trang
            // 
            this.Trang.DataPropertyName = "TrangThai";
            this.Trang.HeaderText = "Trạng Thái";
            this.Trang.MinimumWidth = 6;
            this.Trang.Name = "Trang";
            this.Trang.ReadOnly = true;
            // 
            // Dia
            // 
            this.Dia.DataPropertyName = "DiaChi";
            this.Dia.HeaderText = "Địa Chỉ";
            this.Dia.MinimumWidth = 6;
            this.Dia.Name = "Dia";
            this.Dia.ReadOnly = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnXuatExcelNV);
            this.groupBox7.Controls.Add(this.dtpNgaySinhNV);
            this.groupBox7.Controls.Add(this.btnThoatNV);
            this.groupBox7.Controls.Add(this.btnXoaNV);
            this.groupBox7.Controls.Add(this.btnCapNhatNV);
            this.groupBox7.Controls.Add(this.btnThemNV);
            this.groupBox7.Controls.Add(this.numTrangThaiNV);
            this.groupBox7.Controls.Add(this.txtDiaChiNV);
            this.groupBox7.Controls.Add(this.txtEmailNV);
            this.groupBox7.Controls.Add(this.txtLuongNV);
            this.groupBox7.Controls.Add(this.txtSoDTNV);
            this.groupBox7.Controls.Add(this.txtTenNhanVien);
            this.groupBox7.Controls.Add(this.txtIDNhanVien);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox7.Location = new System.Drawing.Point(22, 16);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1343, 267);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Nhân viên";
            // 
            // btnXuatExcelNV
            // 
            this.btnXuatExcelNV.BorderRadius = 20;
            this.btnXuatExcelNV.CheckedState.Parent = this.btnXuatExcelNV;
            this.btnXuatExcelNV.CustomImages.Parent = this.btnXuatExcelNV;
            this.btnXuatExcelNV.FillColor = System.Drawing.Color.Turquoise;
            this.btnXuatExcelNV.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcelNV.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcelNV.HoverState.Parent = this.btnXuatExcelNV;
            this.btnXuatExcelNV.Location = new System.Drawing.Point(1157, 104);
            this.btnXuatExcelNV.Name = "btnXuatExcelNV";
            this.btnXuatExcelNV.ShadowDecoration.Parent = this.btnXuatExcelNV;
            this.btnXuatExcelNV.Size = new System.Drawing.Size(138, 43);
            this.btnXuatExcelNV.TabIndex = 39;
            this.btnXuatExcelNV.Text = "Xuất Excel";
            this.btnXuatExcelNV.Click += new System.EventHandler(this.btnXuatExcelNV_Click);
            // 
            // dtpNgaySinhNV
            // 
            this.dtpNgaySinhNV.Animated = true;
            this.dtpNgaySinhNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtpNgaySinhNV.BorderRadius = 5;
            this.dtpNgaySinhNV.CheckedState.Parent = this.dtpNgaySinhNV;
            this.dtpNgaySinhNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNgaySinhNV.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinhNV.FillColor = System.Drawing.Color.Turquoise;
            this.dtpNgaySinhNV.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.dtpNgaySinhNV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtpNgaySinhNV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinhNV.HoverState.Parent = this.dtpNgaySinhNV;
            this.dtpNgaySinhNV.IndicateFocus = true;
            this.dtpNgaySinhNV.Location = new System.Drawing.Point(189, 146);
            this.dtpNgaySinhNV.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinhNV.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinhNV.Name = "dtpNgaySinhNV";
            this.dtpNgaySinhNV.ShadowDecoration.Parent = this.dtpNgaySinhNV;
            this.dtpNgaySinhNV.Size = new System.Drawing.Size(282, 36);
            this.dtpNgaySinhNV.TabIndex = 34;
            this.dtpNgaySinhNV.Value = new System.DateTime(2021, 5, 29, 22, 23, 11, 26);
            // 
            // btnThoatNV
            // 
            this.btnThoatNV.Animated = true;
            this.btnThoatNV.BorderColor = System.Drawing.Color.Transparent;
            this.btnThoatNV.BorderRadius = 20;
            this.btnThoatNV.CheckedState.Parent = this.btnThoatNV;
            this.btnThoatNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoatNV.CustomImages.Parent = this.btnThoatNV;
            this.btnThoatNV.FillColor = System.Drawing.Color.Turquoise;
            this.btnThoatNV.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.btnThoatNV.ForeColor = System.Drawing.Color.White;
            this.btnThoatNV.HoverState.Parent = this.btnThoatNV;
            this.btnThoatNV.IndicateFocus = true;
            this.btnThoatNV.Location = new System.Drawing.Point(1079, 173);
            this.btnThoatNV.Name = "btnThoatNV";
            this.btnThoatNV.ShadowDecoration.Parent = this.btnThoatNV;
            this.btnThoatNV.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.btnThoatNV.Size = new System.Drawing.Size(138, 43);
            this.btnThoatNV.TabIndex = 30;
            this.btnThoatNV.Text = "Thoát";
            this.btnThoatNV.Click += new System.EventHandler(this.btnThoatNV_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Animated = true;
            this.btnXoaNV.BorderColor = System.Drawing.Color.Transparent;
            this.btnXoaNV.BorderRadius = 20;
            this.btnXoaNV.CheckedState.Parent = this.btnXoaNV;
            this.btnXoaNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaNV.CustomImages.Parent = this.btnXoaNV;
            this.btnXoaNV.FillColor = System.Drawing.Color.Turquoise;
            this.btnXoaNV.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.btnXoaNV.ForeColor = System.Drawing.Color.White;
            this.btnXoaNV.HoverState.Parent = this.btnXoaNV;
            this.btnXoaNV.IndicateFocus = true;
            this.btnXoaNV.Location = new System.Drawing.Point(1001, 104);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.ShadowDecoration.Parent = this.btnXoaNV;
            this.btnXoaNV.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.btnXoaNV.Size = new System.Drawing.Size(138, 43);
            this.btnXoaNV.TabIndex = 31;
            this.btnXoaNV.Text = "Xoá";
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnCapNhatNV
            // 
            this.btnCapNhatNV.Animated = true;
            this.btnCapNhatNV.BorderColor = System.Drawing.Color.Transparent;
            this.btnCapNhatNV.BorderRadius = 20;
            this.btnCapNhatNV.CheckedState.Parent = this.btnCapNhatNV;
            this.btnCapNhatNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhatNV.CustomImages.Parent = this.btnCapNhatNV;
            this.btnCapNhatNV.FillColor = System.Drawing.Color.Turquoise;
            this.btnCapNhatNV.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.btnCapNhatNV.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatNV.HoverState.Parent = this.btnCapNhatNV;
            this.btnCapNhatNV.IndicateFocus = true;
            this.btnCapNhatNV.Location = new System.Drawing.Point(1157, 28);
            this.btnCapNhatNV.Name = "btnCapNhatNV";
            this.btnCapNhatNV.ShadowDecoration.Parent = this.btnCapNhatNV;
            this.btnCapNhatNV.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.btnCapNhatNV.Size = new System.Drawing.Size(138, 43);
            this.btnCapNhatNV.TabIndex = 32;
            this.btnCapNhatNV.Text = "Cập nhật";
            this.btnCapNhatNV.Click += new System.EventHandler(this.btnCapNhatNV_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.Animated = true;
            this.btnThemNV.BorderColor = System.Drawing.Color.Transparent;
            this.btnThemNV.BorderRadius = 20;
            this.btnThemNV.CheckedState.Parent = this.btnThemNV;
            this.btnThemNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemNV.CustomImages.Parent = this.btnThemNV;
            this.btnThemNV.FillColor = System.Drawing.Color.Turquoise;
            this.btnThemNV.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.btnThemNV.ForeColor = System.Drawing.Color.White;
            this.btnThemNV.HoverState.Parent = this.btnThemNV;
            this.btnThemNV.IndicateFocus = true;
            this.btnThemNV.Location = new System.Drawing.Point(1001, 28);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.ShadowDecoration.Parent = this.btnThemNV;
            this.btnThemNV.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.btnThemNV.Size = new System.Drawing.Size(138, 43);
            this.btnThemNV.TabIndex = 33;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // numTrangThaiNV
            // 
            this.numTrangThaiNV.BackColor = System.Drawing.Color.Transparent;
            this.numTrangThaiNV.BorderRadius = 5;
            this.numTrangThaiNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numTrangThaiNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numTrangThaiNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numTrangThaiNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numTrangThaiNV.DisabledState.Parent = this.numTrangThaiNV;
            this.numTrangThaiNV.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numTrangThaiNV.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numTrangThaiNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numTrangThaiNV.FocusedState.Parent = this.numTrangThaiNV;
            this.numTrangThaiNV.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTrangThaiNV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numTrangThaiNV.Location = new System.Drawing.Point(663, 202);
            this.numTrangThaiNV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numTrangThaiNV.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTrangThaiNV.Name = "numTrangThaiNV";
            this.numTrangThaiNV.ShadowDecoration.Parent = this.numTrangThaiNV;
            this.numTrangThaiNV.Size = new System.Drawing.Size(139, 36);
            this.numTrangThaiNV.TabIndex = 22;
            this.numTrangThaiNV.UpDownButtonFillColor = System.Drawing.Color.Turquoise;
            this.numTrangThaiNV.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTrangThaiNV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numTrangThaiNV_KeyUp);
            // 
            // txtDiaChiNV
            // 
            this.txtDiaChiNV.BorderRadius = 5;
            this.txtDiaChiNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChiNV.DefaultText = "";
            this.txtDiaChiNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChiNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChiNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChiNV.DisabledState.Parent = this.txtDiaChiNV;
            this.txtDiaChiNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChiNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChiNV.FocusedState.Parent = this.txtDiaChiNV;
            this.txtDiaChiNV.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiNV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDiaChiNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChiNV.HoverState.Parent = this.txtDiaChiNV;
            this.txtDiaChiNV.Location = new System.Drawing.Point(663, 143);
            this.txtDiaChiNV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDiaChiNV.Name = "txtDiaChiNV";
            this.txtDiaChiNV.PasswordChar = '\0';
            this.txtDiaChiNV.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDiaChiNV.PlaceholderText = "";
            this.txtDiaChiNV.SelectedText = "";
            this.txtDiaChiNV.ShadowDecoration.Parent = this.txtDiaChiNV;
            this.txtDiaChiNV.Size = new System.Drawing.Size(284, 36);
            this.txtDiaChiNV.TabIndex = 21;
            // 
            // txtEmailNV
            // 
            this.txtEmailNV.BorderRadius = 5;
            this.txtEmailNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailNV.DefaultText = "";
            this.txtEmailNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmailNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmailNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailNV.DisabledState.Parent = this.txtEmailNV;
            this.txtEmailNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailNV.FocusedState.Parent = this.txtEmailNV;
            this.txtEmailNV.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailNV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEmailNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailNV.HoverState.Parent = this.txtEmailNV;
            this.txtEmailNV.Location = new System.Drawing.Point(663, 88);
            this.txtEmailNV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmailNV.Name = "txtEmailNV";
            this.txtEmailNV.PasswordChar = '\0';
            this.txtEmailNV.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEmailNV.PlaceholderText = "";
            this.txtEmailNV.SelectedText = "";
            this.txtEmailNV.ShadowDecoration.Parent = this.txtEmailNV;
            this.txtEmailNV.Size = new System.Drawing.Size(284, 36);
            this.txtEmailNV.TabIndex = 20;
            // 
            // txtLuongNV
            // 
            this.txtLuongNV.BorderRadius = 5;
            this.txtLuongNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLuongNV.DefaultText = "";
            this.txtLuongNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLuongNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLuongNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLuongNV.DisabledState.Parent = this.txtLuongNV;
            this.txtLuongNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLuongNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLuongNV.FocusedState.Parent = this.txtLuongNV;
            this.txtLuongNV.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuongNV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtLuongNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLuongNV.HoverState.Parent = this.txtLuongNV;
            this.txtLuongNV.Location = new System.Drawing.Point(663, 28);
            this.txtLuongNV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLuongNV.Name = "txtLuongNV";
            this.txtLuongNV.PasswordChar = '\0';
            this.txtLuongNV.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtLuongNV.PlaceholderText = "";
            this.txtLuongNV.SelectedText = "";
            this.txtLuongNV.ShadowDecoration.Parent = this.txtLuongNV;
            this.txtLuongNV.Size = new System.Drawing.Size(284, 36);
            this.txtLuongNV.TabIndex = 19;
            this.txtLuongNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLuongNV_KeyPress);
            // 
            // txtSoDTNV
            // 
            this.txtSoDTNV.BorderRadius = 5;
            this.txtSoDTNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDTNV.DefaultText = "";
            this.txtSoDTNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoDTNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoDTNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDTNV.DisabledState.Parent = this.txtSoDTNV;
            this.txtSoDTNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDTNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDTNV.FocusedState.Parent = this.txtSoDTNV;
            this.txtSoDTNV.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDTNV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSoDTNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDTNV.HoverState.Parent = this.txtSoDTNV;
            this.txtSoDTNV.Location = new System.Drawing.Point(189, 202);
            this.txtSoDTNV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSoDTNV.Name = "txtSoDTNV";
            this.txtSoDTNV.PasswordChar = '\0';
            this.txtSoDTNV.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSoDTNV.PlaceholderText = "";
            this.txtSoDTNV.SelectedText = "";
            this.txtSoDTNV.ShadowDecoration.Parent = this.txtSoDTNV;
            this.txtSoDTNV.Size = new System.Drawing.Size(282, 36);
            this.txtSoDTNV.TabIndex = 18;
            this.txtSoDTNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDTNV_KeyPress);
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.BorderRadius = 5;
            this.txtTenNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNhanVien.DefaultText = "";
            this.txtTenNhanVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNhanVien.DisabledState.Parent = this.txtTenNhanVien;
            this.txtTenNhanVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNhanVien.FocusedState.Parent = this.txtTenNhanVien;
            this.txtTenNhanVien.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhanVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenNhanVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNhanVien.HoverState.Parent = this.txtTenNhanVien;
            this.txtTenNhanVien.Location = new System.Drawing.Point(189, 89);
            this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.PasswordChar = '\0';
            this.txtTenNhanVien.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenNhanVien.PlaceholderText = "";
            this.txtTenNhanVien.SelectedText = "";
            this.txtTenNhanVien.ShadowDecoration.Parent = this.txtTenNhanVien;
            this.txtTenNhanVien.Size = new System.Drawing.Size(282, 36);
            this.txtTenNhanVien.TabIndex = 17;
            // 
            // txtIDNhanVien
            // 
            this.txtIDNhanVien.BorderRadius = 5;
            this.txtIDNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDNhanVien.DefaultText = "";
            this.txtIDNhanVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDNhanVien.DisabledState.Parent = this.txtIDNhanVien;
            this.txtIDNhanVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDNhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDNhanVien.FocusedState.Parent = this.txtIDNhanVien;
            this.txtIDNhanVien.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNhanVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIDNhanVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDNhanVien.HoverState.Parent = this.txtIDNhanVien;
            this.txtIDNhanVien.Location = new System.Drawing.Point(189, 28);
            this.txtIDNhanVien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIDNhanVien.Name = "txtIDNhanVien";
            this.txtIDNhanVien.PasswordChar = '\0';
            this.txtIDNhanVien.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIDNhanVien.PlaceholderText = "";
            this.txtIDNhanVien.SelectedText = "";
            this.txtIDNhanVien.ShadowDecoration.Parent = this.txtIDNhanVien;
            this.txtIDNhanVien.Size = new System.Drawing.Size(282, 36);
            this.txtIDNhanVien.TabIndex = 16;
            this.txtIDNhanVien.TextChanged += new System.EventHandler(this.txtIDNhanVien_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(541, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Trạng thái";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(566, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "Địa chỉ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(574, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(566, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Lương";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Số điện thoại";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(72, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ngày sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên nhân viên";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID Nhân viên";
            // 
            // btnExitHome
            // 
            this.btnExitHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitHome.Animated = true;
            this.btnExitHome.BackgroundImage = global::_452_417_CDTH19E_SHOESSHOP.Properties.Resources.icons8_close_window_642;
            this.btnExitHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExitHome.BorderColor = System.Drawing.Color.Transparent;
            this.btnExitHome.BorderRadius = 5;
            this.btnExitHome.CheckedState.Parent = this.btnExitHome;
            this.btnExitHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitHome.CustomImages.Parent = this.btnExitHome;
            this.btnExitHome.FillColor = System.Drawing.Color.Transparent;
            this.btnExitHome.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.btnExitHome.ForeColor = System.Drawing.Color.White;
            this.btnExitHome.HoverState.Parent = this.btnExitHome;
            this.btnExitHome.Location = new System.Drawing.Point(1340, 15);
            this.btnExitHome.Name = "btnExitHome";
            this.btnExitHome.ShadowDecoration.Parent = this.btnExitHome;
            this.btnExitHome.Size = new System.Drawing.Size(40, 40);
            this.btnExitHome.TabIndex = 19;
            this.btnExitHome.Click += new System.EventHandler(this.btnExitHome_Click);
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1403, 745);
            this.Controls.Add(this.btnExitHome);
            this.Controls.Add(this.grpSanPham);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lý Bán Giày";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTrangChu_FormClosing);
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.grpKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.grpNhaCungCap.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrangThaiNCC)).EndInit();
            this.grpSanPham.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.grpDanhSachSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.grp1.ResumeLayout(false);
            this.grp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrangThaiSP)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.grpDanhSachHD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.grp2.ResumeLayout(false);
            this.grp2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrangThaiHD)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.grpNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrangThaiNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuttTrangChu;
        private System.Windows.Forms.Label lblSoDTHD;
        private System.Windows.Forms.Label lblDiaChiKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.Label lblIDKhachHangKH;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblTrangThaiHD;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.DataGridView dgvNhaCungCap;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label lblTrangThaiSP;
        private System.Windows.Forms.GroupBox grp1;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblIDSP;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl grpSanPham;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.GroupBox grp2;
        private System.Windows.Forms.Label lblNgayBan;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblIDKhachHang;
        private System.Windows.Forms.Label lblIDHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mnuttTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnuttQuanLySanPham;
        private System.Windows.Forms.ToolStripMenuItem loạiSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuttQuanLyHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuttThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnuttThoatChuongTrinh;
        private System.Windows.Forms.ToolStripMenuItem TimKiemTheoSP;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TimKiemTheoHD;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblSDTNCC;
        private System.Windows.Forms.Label lblDiachiNCC;
        private System.Windows.Forms.Label lblTenNCC;
        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private TabPage tabPage7;
        private DataGridView dgvNhanVien;
        private GroupBox groupBox7;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private ToolStripMenuItem TimKiemTheoKH;
        private ToolStripMenuItem TimKiemTheoNCC;
        private ToolStripMenuItem TimKiemTheoNV;
        private Label label15;
        private Guna.UI2.WinForms.Guna2GroupBox grpDanhSachHD;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private Guna.UI2.WinForms.Guna2GroupBox grpDanhSachSP;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Guna.UI2.WinForms.Guna2GroupBox grpKhachHang;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn TrangThai1;
        private Guna.UI2.WinForms.Guna2GroupBox grpNhaCungCap;
        private Guna.UI2.WinForms.Guna2GroupBox grpNhanVien;
        private DataGridViewTextBoxColumn ID_NhanVien;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn Luong;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn Trang;
        private DataGridViewTextBoxColumn Dia;
        private Guna.UI2.WinForms.Guna2TextBox txtIDSanPham;
        private Guna.UI2.WinForms.Guna2TextBox txtTenSanPham;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoaiSanPham;
        private Guna.UI2.WinForms.Guna2ComboBox cboIDNCC;
        private Guna.UI2.WinForms.Guna2NumericUpDown numTrangThaiSP;
        private Guna.UI2.WinForms.Guna2TextBox txtIDHoaDon;
        private Guna.UI2.WinForms.Guna2ComboBox cboIDKhachHang;
        private Guna.UI2.WinForms.Guna2TextBox txtTongTienHD;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChiHD;
        private Guna.UI2.WinForms.Guna2NumericUpDown numTrangThaiHD;
        private Guna.UI2.WinForms.Guna2TextBox txtIDKhachHang;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChiKH;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKhachHang;
        private Guna.UI2.WinForms.Guna2TextBox txtSoDTKH;
        private Guna.UI2.WinForms.Guna2TextBox txtSoDTNCC;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNCC;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChiNCC;
        private Guna.UI2.WinForms.Guna2TextBox txtIDNCC;
        private Guna.UI2.WinForms.Guna2NumericUpDown numTrangThaiNCC;
        private Guna.UI2.WinForms.Guna2TextBox txtIDNhanVien;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNhanVien;
        private Guna.UI2.WinForms.Guna2TextBox txtSoDTNV;
        private Guna.UI2.WinForms.Guna2TextBox txtLuongNV;
        private Guna.UI2.WinForms.Guna2TextBox txtEmailNV;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChiNV;
        private Guna.UI2.WinForms.Guna2NumericUpDown numTrangThaiNV;
        private Guna.UI2.WinForms.Guna2Button btnThemSP;
        private Guna.UI2.WinForms.Guna2Button btnThoatSP;
        private Guna.UI2.WinForms.Guna2Button btnXoaSP;
        private Guna.UI2.WinForms.Guna2Button btnCapNhatSP;
        private Guna.UI2.WinForms.Guna2Button btnThoatHD;
        private Guna.UI2.WinForms.Guna2Button btnXoaHD;
        private Guna.UI2.WinForms.Guna2Button btnCapNhatHD;
        private Guna.UI2.WinForms.Guna2Button btnThemHD;
        private Guna.UI2.WinForms.Guna2Button btnThoatKH;
        private Guna.UI2.WinForms.Guna2Button btnXoaKH;
        private Guna.UI2.WinForms.Guna2Button btnCapNhatKH;
        private Guna.UI2.WinForms.Guna2Button btnThemKH;
        private Guna.UI2.WinForms.Guna2Button btnThoatNCC;
        private Guna.UI2.WinForms.Guna2Button btnXoaNCC;
        private Guna.UI2.WinForms.Guna2Button btnCapNhatNCC;
        private Guna.UI2.WinForms.Guna2Button btnThemNCC;
        private Guna.UI2.WinForms.Guna2Button btnThoatNV;
        private Guna.UI2.WinForms.Guna2Button btnXoaNV;
        private Guna.UI2.WinForms.Guna2Button btnCapNhatNV;
        private Guna.UI2.WinForms.Guna2Button btnThemNV;
        private Guna.UI2.WinForms.Guna2Button btnExitHome;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinhNV;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayBan;
        private Guna.UI2.WinForms.Guna2Button btnXuatExcelSP;
        private SaveFileDialog SaveFile;
        private Guna.UI2.WinForms.Guna2Button btnXuatExcelKH;
        private Guna.UI2.WinForms.Guna2Button btnXuatExcelNCC;
        private Guna.UI2.WinForms.Guna2Button btnXuatExcelNV;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinhKH;
        private DataGridViewTextBoxColumn ID_SanPham;
        private DataGridViewTextBoxColumn ID_NCC;
        private DataGridViewTextBoxColumn ID_LoaiSanPham;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn TrangThai;
    }
}