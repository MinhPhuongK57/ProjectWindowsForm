
namespace _452_417_CDTH19E_SHOESSHOP
{
    partial class frmTimKiemNhanVien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiemNhanVien));
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTimKiemTheoLuong = new System.Windows.Forms.Panel();
            this.txtFromNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtToNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTimKiemNV = new System.Windows.Forms.DataGridView();
            this.ID_NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTimKiemTheoNgaySinh = new System.Windows.Forms.Panel();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDatLaiNV = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimKiemNV = new Guna.UI2.WinForms.Guna2Button();
            this.cboNhanVien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTimKiemNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.grpDanhSachNV = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnThoatTimKiemNV = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlTimKiemTheoLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemNV)).BeginInit();
            this.pnlTimKiemTheoNgaySinh.SuspendLayout();
            this.grpDanhSachNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(552, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "TÌM KIẾM NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTimKiemTheoLuong
            // 
            this.pnlTimKiemTheoLuong.Controls.Add(this.txtFromNV);
            this.pnlTimKiemTheoLuong.Controls.Add(this.txtToNV);
            this.pnlTimKiemTheoLuong.Controls.Add(this.label3);
            this.pnlTimKiemTheoLuong.Controls.Add(this.label2);
            this.pnlTimKiemTheoLuong.Location = new System.Drawing.Point(101, 159);
            this.pnlTimKiemTheoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTimKiemTheoLuong.Name = "pnlTimKiemTheoLuong";
            this.pnlTimKiemTheoLuong.Size = new System.Drawing.Size(674, 81);
            this.pnlTimKiemTheoLuong.TabIndex = 7;
            // 
            // txtFromNV
            // 
            this.txtFromNV.BorderRadius = 5;
            this.txtFromNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFromNV.DefaultText = "";
            this.txtFromNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFromNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFromNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFromNV.DisabledState.Parent = this.txtFromNV;
            this.txtFromNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFromNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFromNV.FocusedState.Parent = this.txtFromNV;
            this.txtFromNV.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromNV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFromNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFromNV.HoverState.Parent = this.txtFromNV;
            this.txtFromNV.Location = new System.Drawing.Point(98, 18);
            this.txtFromNV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFromNV.Name = "txtFromNV";
            this.txtFromNV.PasswordChar = '\0';
            this.txtFromNV.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFromNV.PlaceholderText = "";
            this.txtFromNV.SelectedText = "";
            this.txtFromNV.ShadowDecoration.Parent = this.txtFromNV;
            this.txtFromNV.Size = new System.Drawing.Size(192, 36);
            this.txtFromNV.TabIndex = 31;
            this.txtFromNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromNV_KeyPress_1);
            // 
            // txtToNV
            // 
            this.txtToNV.BorderRadius = 5;
            this.txtToNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtToNV.DefaultText = "";
            this.txtToNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtToNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtToNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtToNV.DisabledState.Parent = this.txtToNV;
            this.txtToNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtToNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtToNV.FocusedState.Parent = this.txtToNV;
            this.txtToNV.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToNV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtToNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtToNV.HoverState.Parent = this.txtToNV;
            this.txtToNV.Location = new System.Drawing.Point(419, 18);
            this.txtToNV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtToNV.Name = "txtToNV";
            this.txtToNV.PasswordChar = '\0';
            this.txtToNV.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtToNV.PlaceholderText = "";
            this.txtToNV.SelectedText = "";
            this.txtToNV.ShadowDecoration.Parent = this.txtToNV;
            this.txtToNV.Size = new System.Drawing.Size(192, 36);
            this.txtToNV.TabIndex = 31;
            this.txtToNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromNV_KeyPress_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "&Đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "&Từ";
            // 
            // dgvTimKiemNV
            // 
            this.dgvTimKiemNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimKiemNV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTimKiemNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiemNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_NhanVien,
            this.TenNhanVien,
            this.NgaySinh,
            this.SoDT,
            this.Luong,
            this.Email,
            this.TrangThai,
            this.DiaChi});
            this.dgvTimKiemNV.Location = new System.Drawing.Point(1, 40);
            this.dgvTimKiemNV.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTimKiemNV.Name = "dgvTimKiemNV";
            this.dgvTimKiemNV.ReadOnly = true;
            this.dgvTimKiemNV.RowHeadersVisible = false;
            this.dgvTimKiemNV.RowHeadersWidth = 51;
            this.dgvTimKiemNV.RowTemplate.Height = 24;
            this.dgvTimKiemNV.Size = new System.Drawing.Size(1275, 330);
            this.dgvTimKiemNV.TabIndex = 0;
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
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // SoDT
            // 
            this.SoDT.DataPropertyName = "SoDT";
            this.SoDT.HeaderText = "Số Điện Thoại";
            this.SoDT.MinimumWidth = 6;
            this.SoDT.Name = "SoDT";
            this.SoDT.ReadOnly = true;
            // 
            // Luong
            // 
            this.Luong.DataPropertyName = "Luong";
            this.Luong.HeaderText = "Lương";
            this.Luong.MinimumWidth = 6;
            this.Luong.Name = "Luong";
            this.Luong.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // pnlTimKiemTheoNgaySinh
            // 
            this.pnlTimKiemTheoNgaySinh.Controls.Add(this.dtpTo);
            this.pnlTimKiemTheoNgaySinh.Controls.Add(this.dtpFrom);
            this.pnlTimKiemTheoNgaySinh.Controls.Add(this.label4);
            this.pnlTimKiemTheoNgaySinh.Controls.Add(this.label5);
            this.pnlTimKiemTheoNgaySinh.Location = new System.Drawing.Point(101, 159);
            this.pnlTimKiemTheoNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTimKiemTheoNgaySinh.Name = "pnlTimKiemTheoNgaySinh";
            this.pnlTimKiemTheoNgaySinh.Size = new System.Drawing.Size(674, 81);
            this.pnlTimKiemTheoNgaySinh.TabIndex = 2;
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "MM/dd/yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(404, 34);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(249, 28);
            this.dtpTo.TabIndex = 7;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "MM/dd/yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(64, 34);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(249, 28);
            this.dtpFrom.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "&Đến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "&Từ";
            // 
            // btnDatLaiNV
            // 
            this.btnDatLaiNV.BorderRadius = 20;
            this.btnDatLaiNV.CheckedState.Parent = this.btnDatLaiNV;
            this.btnDatLaiNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatLaiNV.CustomImages.Parent = this.btnDatLaiNV;
            this.btnDatLaiNV.FillColor = System.Drawing.Color.Turquoise;
            this.btnDatLaiNV.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLaiNV.ForeColor = System.Drawing.Color.White;
            this.btnDatLaiNV.HoverState.Parent = this.btnDatLaiNV;
            this.btnDatLaiNV.Location = new System.Drawing.Point(983, 159);
            this.btnDatLaiNV.Name = "btnDatLaiNV";
            this.btnDatLaiNV.ShadowDecoration.Parent = this.btnDatLaiNV;
            this.btnDatLaiNV.Size = new System.Drawing.Size(108, 38);
            this.btnDatLaiNV.TabIndex = 26;
            this.btnDatLaiNV.Text = "Tải lại";
            this.btnDatLaiNV.Click += new System.EventHandler(this.btnDatLaiNV_Click_1);
            // 
            // btnTimKiemNV
            // 
            this.btnTimKiemNV.BorderRadius = 20;
            this.btnTimKiemNV.CheckedState.Parent = this.btnTimKiemNV;
            this.btnTimKiemNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemNV.CustomImages.Parent = this.btnTimKiemNV;
            this.btnTimKiemNV.FillColor = System.Drawing.Color.Turquoise;
            this.btnTimKiemNV.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemNV.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemNV.HoverState.Parent = this.btnTimKiemNV;
            this.btnTimKiemNV.Location = new System.Drawing.Point(983, 88);
            this.btnTimKiemNV.Name = "btnTimKiemNV";
            this.btnTimKiemNV.ShadowDecoration.Parent = this.btnTimKiemNV;
            this.btnTimKiemNV.Size = new System.Drawing.Size(108, 38);
            this.btnTimKiemNV.TabIndex = 27;
            this.btnTimKiemNV.Text = "Tìm kiếm";
            this.btnTimKiemNV.Click += new System.EventHandler(this.btnTimKiemNV_Click_1);
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.cboNhanVien.BorderRadius = 5;
            this.cboNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboNhanVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboNhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboNhanVien.FocusedState.Parent = this.cboNhanVien;
            this.cboNhanVien.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNhanVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboNhanVien.HoverState.Parent = this.cboNhanVien;
            this.cboNhanVien.ItemHeight = 30;
            this.cboNhanVien.ItemsAppearance.Parent = this.cboNhanVien;
            this.cboNhanVien.Location = new System.Drawing.Point(101, 88);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.ShadowDecoration.Parent = this.cboNhanVien;
            this.cboNhanVien.Size = new System.Drawing.Size(242, 36);
            this.cboNhanVien.TabIndex = 28;
            this.cboNhanVien.SelectedIndexChanged += new System.EventHandler(this.cboNhanVien_SelectedIndexChanged_1);
            // 
            // txtTimKiemNV
            // 
            this.txtTimKiemNV.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.txtTimKiemNV.BorderRadius = 5;
            this.txtTimKiemNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemNV.DefaultText = "";
            this.txtTimKiemNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiemNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiemNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemNV.DisabledState.Parent = this.txtTimKiemNV;
            this.txtTimKiemNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemNV.FocusedState.Parent = this.txtTimKiemNV;
            this.txtTimKiemNV.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemNV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTimKiemNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemNV.HoverState.Parent = this.txtTimKiemNV;
            this.txtTimKiemNV.Location = new System.Drawing.Point(383, 88);
            this.txtTimKiemNV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTimKiemNV.Name = "txtTimKiemNV";
            this.txtTimKiemNV.PasswordChar = '\0';
            this.txtTimKiemNV.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTimKiemNV.PlaceholderText = "";
            this.txtTimKiemNV.SelectedText = "";
            this.txtTimKiemNV.ShadowDecoration.Parent = this.txtTimKiemNV;
            this.txtTimKiemNV.Size = new System.Drawing.Size(392, 36);
            this.txtTimKiemNV.TabIndex = 29;
            // 
            // grpDanhSachNV
            // 
            this.grpDanhSachNV.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.grpDanhSachNV.BorderRadius = 5;
            this.grpDanhSachNV.Controls.Add(this.dgvTimKiemNV);
            this.grpDanhSachNV.CustomBorderColor = System.Drawing.SystemColors.ButtonFace;
            this.grpDanhSachNV.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDanhSachNV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpDanhSachNV.Location = new System.Drawing.Point(12, 272);
            this.grpDanhSachNV.Name = "grpDanhSachNV";
            this.grpDanhSachNV.ShadowDecoration.Parent = this.grpDanhSachNV;
            this.grpDanhSachNV.Size = new System.Drawing.Size(1276, 370);
            this.grpDanhSachNV.TabIndex = 30;
            this.grpDanhSachNV.Text = "Danh sách nhân viên";
            // 
            // btnThoatTimKiemNV
            // 
            this.btnThoatTimKiemNV.Animated = true;
            this.btnThoatTimKiemNV.BackgroundImage = global::_452_417_CDTH19E_SHOESSHOP.Properties.Resources.icons8_close_window_642;
            this.btnThoatTimKiemNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThoatTimKiemNV.BorderColor = System.Drawing.Color.Transparent;
            this.btnThoatTimKiemNV.BorderRadius = 5;
            this.btnThoatTimKiemNV.CheckedState.Parent = this.btnThoatTimKiemNV;
            this.btnThoatTimKiemNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoatTimKiemNV.CustomImages.Parent = this.btnThoatTimKiemNV;
            this.btnThoatTimKiemNV.FillColor = System.Drawing.Color.Transparent;
            this.btnThoatTimKiemNV.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatTimKiemNV.ForeColor = System.Drawing.Color.White;
            this.btnThoatTimKiemNV.HoverState.Parent = this.btnThoatTimKiemNV;
            this.btnThoatTimKiemNV.Location = new System.Drawing.Point(1248, 12);
            this.btnThoatTimKiemNV.Name = "btnThoatTimKiemNV";
            this.btnThoatTimKiemNV.ShadowDecoration.Parent = this.btnThoatTimKiemNV;
            this.btnThoatTimKiemNV.Size = new System.Drawing.Size(40, 40);
            this.btnThoatTimKiemNV.TabIndex = 31;
            this.btnThoatTimKiemNV.Click += new System.EventHandler(this.btnThoatTimKiemNV_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // frmTimKiemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1301, 654);
            this.Controls.Add(this.btnThoatTimKiemNV);
            this.Controls.Add(this.grpDanhSachNV);
            this.Controls.Add(this.txtTimKiemNV);
            this.Controls.Add(this.cboNhanVien);
            this.Controls.Add(this.btnDatLaiNV);
            this.Controls.Add(this.btnTimKiemNV);
            this.Controls.Add(this.pnlTimKiemTheoNgaySinh);
            this.Controls.Add(this.pnlTimKiemTheoLuong);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTimKiemNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTimKiemNhanVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTimKiemNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.frmTimKiemNhanVien_Load);
            this.pnlTimKiemTheoLuong.ResumeLayout(false);
            this.pnlTimKiemTheoLuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemNV)).EndInit();
            this.pnlTimKiemTheoNgaySinh.ResumeLayout(false);
            this.pnlTimKiemTheoNgaySinh.PerformLayout();
            this.grpDanhSachNV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTimKiemTheoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTimKiemNV;
        private System.Windows.Forms.Panel pnlTimKiemTheoNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private Guna.UI2.WinForms.Guna2Button btnDatLaiNV;
        private Guna.UI2.WinForms.Guna2Button btnTimKiemNV;
        private Guna.UI2.WinForms.Guna2ComboBox cboNhanVien;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiemNV;
        private Guna.UI2.WinForms.Guna2GroupBox grpDanhSachNV;
        private Guna.UI2.WinForms.Guna2TextBox txtFromNV;
        private Guna.UI2.WinForms.Guna2TextBox txtToNV;
        private Guna.UI2.WinForms.Guna2Button btnThoatTimKiemNV;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}