
namespace _452_417_CDTH19E_SHOESSHOP
{
    partial class frmLoaiSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiSanPham));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpLoaiSanPham = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvLoaiSanPham = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemLoaiSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapNhatLoaiSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaLoaiLSP = new Guna.UI2.WinForms.Guna2Button();
            this.txtIDLoaiSanPham = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenLoaiSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThoatLoaiSP = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.btnXuatExcelCTSP = new Guna.UI2.WinForms.Guna2Button();
            this.cboTrangThaiLSP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.grpLoaiSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(260, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOẠI SẢN PHẨM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID Loại sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Trạng thái";
            // 
            // grpLoaiSanPham
            // 
            this.grpLoaiSanPham.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.grpLoaiSanPham.BorderRadius = 5;
            this.grpLoaiSanPham.Controls.Add(this.dgvLoaiSanPham);
            this.grpLoaiSanPham.CustomBorderColor = System.Drawing.SystemColors.ButtonFace;
            this.grpLoaiSanPham.FillColor = System.Drawing.SystemColors.ControlLight;
            this.grpLoaiSanPham.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLoaiSanPham.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpLoaiSanPham.Location = new System.Drawing.Point(5, 267);
            this.grpLoaiSanPham.Name = "grpLoaiSanPham";
            this.grpLoaiSanPham.ShadowDecoration.Parent = this.grpLoaiSanPham;
            this.grpLoaiSanPham.Size = new System.Drawing.Size(724, 293);
            this.grpLoaiSanPham.TabIndex = 13;
            this.grpLoaiSanPham.Text = "Danh sách loại sản phẩm";
            // 
            // dgvLoaiSanPham
            // 
            this.dgvLoaiSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiSanPham.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLoaiSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvLoaiSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvLoaiSanPham.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLoaiSanPham.Location = new System.Drawing.Point(0, 41);
            this.dgvLoaiSanPham.Name = "dgvLoaiSanPham";
            this.dgvLoaiSanPham.ReadOnly = true;
            this.dgvLoaiSanPham.RowHeadersVisible = false;
            this.dgvLoaiSanPham.RowHeadersWidth = 51;
            this.dgvLoaiSanPham.RowTemplate.Height = 24;
            this.dgvLoaiSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiSanPham.Size = new System.Drawing.Size(724, 249);
            this.dgvLoaiSanPham.TabIndex = 0;
            this.dgvLoaiSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiSanPham_CellClick_2);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID_LoaiSanPham";
            this.Column1.HeaderText = "ID Loại Sản Phẩm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenLoai";
            this.Column2.HeaderText = "Tên Loại";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TrangThai";
            this.Column3.HeaderText = "Trạng Thái";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnThemLoaiSP
            // 
            this.btnThemLoaiSP.BorderRadius = 20;
            this.btnThemLoaiSP.CheckedState.Parent = this.btnThemLoaiSP;
            this.btnThemLoaiSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemLoaiSP.CustomImages.Parent = this.btnThemLoaiSP;
            this.btnThemLoaiSP.FillColor = System.Drawing.Color.Turquoise;
            this.btnThemLoaiSP.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLoaiSP.ForeColor = System.Drawing.Color.White;
            this.btnThemLoaiSP.HoverState.Parent = this.btnThemLoaiSP;
            this.btnThemLoaiSP.Location = new System.Drawing.Point(560, 85);
            this.btnThemLoaiSP.Name = "btnThemLoaiSP";
            this.btnThemLoaiSP.ShadowDecoration.Parent = this.btnThemLoaiSP;
            this.btnThemLoaiSP.Size = new System.Drawing.Size(115, 39);
            this.btnThemLoaiSP.TabIndex = 14;
            this.btnThemLoaiSP.Text = "Thêm";
            this.btnThemLoaiSP.Click += new System.EventHandler(this.btnThemLoaiSP_Click_1);
            // 
            // btnCapNhatLoaiSP
            // 
            this.btnCapNhatLoaiSP.BorderRadius = 20;
            this.btnCapNhatLoaiSP.CheckedState.Parent = this.btnCapNhatLoaiSP;
            this.btnCapNhatLoaiSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhatLoaiSP.CustomImages.Parent = this.btnCapNhatLoaiSP;
            this.btnCapNhatLoaiSP.FillColor = System.Drawing.Color.Turquoise;
            this.btnCapNhatLoaiSP.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatLoaiSP.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatLoaiSP.HoverState.Parent = this.btnCapNhatLoaiSP;
            this.btnCapNhatLoaiSP.Location = new System.Drawing.Point(560, 146);
            this.btnCapNhatLoaiSP.Name = "btnCapNhatLoaiSP";
            this.btnCapNhatLoaiSP.ShadowDecoration.Parent = this.btnCapNhatLoaiSP;
            this.btnCapNhatLoaiSP.Size = new System.Drawing.Size(115, 39);
            this.btnCapNhatLoaiSP.TabIndex = 14;
            this.btnCapNhatLoaiSP.Text = "Cập nhật";
            this.btnCapNhatLoaiSP.Click += new System.EventHandler(this.btnCapNhatLoaiSP_Click);
            // 
            // btnXoaLoaiLSP
            // 
            this.btnXoaLoaiLSP.BorderRadius = 20;
            this.btnXoaLoaiLSP.CheckedState.Parent = this.btnXoaLoaiLSP;
            this.btnXoaLoaiLSP.CustomImages.Parent = this.btnXoaLoaiLSP;
            this.btnXoaLoaiLSP.FillColor = System.Drawing.Color.Turquoise;
            this.btnXoaLoaiLSP.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLoaiLSP.ForeColor = System.Drawing.Color.White;
            this.btnXoaLoaiLSP.HoverState.Parent = this.btnXoaLoaiLSP;
            this.btnXoaLoaiLSP.Location = new System.Drawing.Point(560, 202);
            this.btnXoaLoaiLSP.Name = "btnXoaLoaiLSP";
            this.btnXoaLoaiLSP.ShadowDecoration.Parent = this.btnXoaLoaiLSP;
            this.btnXoaLoaiLSP.Size = new System.Drawing.Size(115, 39);
            this.btnXoaLoaiLSP.TabIndex = 14;
            this.btnXoaLoaiLSP.Text = "Xoá";
            this.btnXoaLoaiLSP.Click += new System.EventHandler(this.btnXoaLoaiLSP_Click);
            // 
            // txtIDLoaiSanPham
            // 
            this.txtIDLoaiSanPham.BorderRadius = 5;
            this.txtIDLoaiSanPham.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDLoaiSanPham.DefaultText = "";
            this.txtIDLoaiSanPham.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDLoaiSanPham.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDLoaiSanPham.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDLoaiSanPham.DisabledState.Parent = this.txtIDLoaiSanPham;
            this.txtIDLoaiSanPham.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDLoaiSanPham.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDLoaiSanPham.FocusedState.Parent = this.txtIDLoaiSanPham;
            this.txtIDLoaiSanPham.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDLoaiSanPham.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIDLoaiSanPham.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDLoaiSanPham.HoverState.Parent = this.txtIDLoaiSanPham;
            this.txtIDLoaiSanPham.Location = new System.Drawing.Point(215, 85);
            this.txtIDLoaiSanPham.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIDLoaiSanPham.Name = "txtIDLoaiSanPham";
            this.txtIDLoaiSanPham.PasswordChar = '\0';
            this.txtIDLoaiSanPham.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIDLoaiSanPham.PlaceholderText = "";
            this.txtIDLoaiSanPham.SelectedText = "";
            this.txtIDLoaiSanPham.ShadowDecoration.Parent = this.txtIDLoaiSanPham;
            this.txtIDLoaiSanPham.Size = new System.Drawing.Size(299, 33);
            this.txtIDLoaiSanPham.TabIndex = 15;
            this.txtIDLoaiSanPham.TextChanged += new System.EventHandler(this.txtIDLoaiSanPham_TextChanged_1);
            // 
            // txtTenLoaiSP
            // 
            this.txtTenLoaiSP.BorderRadius = 5;
            this.txtTenLoaiSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenLoaiSP.DefaultText = "";
            this.txtTenLoaiSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenLoaiSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenLoaiSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenLoaiSP.DisabledState.Parent = this.txtTenLoaiSP;
            this.txtTenLoaiSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenLoaiSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenLoaiSP.FocusedState.Parent = this.txtTenLoaiSP;
            this.txtTenLoaiSP.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.txtTenLoaiSP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenLoaiSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenLoaiSP.HoverState.Parent = this.txtTenLoaiSP;
            this.txtTenLoaiSP.Location = new System.Drawing.Point(215, 146);
            this.txtTenLoaiSP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTenLoaiSP.Name = "txtTenLoaiSP";
            this.txtTenLoaiSP.PasswordChar = '\0';
            this.txtTenLoaiSP.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenLoaiSP.PlaceholderText = "";
            this.txtTenLoaiSP.SelectedText = "";
            this.txtTenLoaiSP.ShadowDecoration.Parent = this.txtTenLoaiSP;
            this.txtTenLoaiSP.Size = new System.Drawing.Size(299, 33);
            this.txtTenLoaiSP.TabIndex = 16;
            // 
            // btnThoatLoaiSP
            // 
            this.btnThoatLoaiSP.Animated = true;
            this.btnThoatLoaiSP.BackgroundImage = global::_452_417_CDTH19E_SHOESSHOP.Properties.Resources.icons8_close_window_642;
            this.btnThoatLoaiSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThoatLoaiSP.BorderColor = System.Drawing.Color.Transparent;
            this.btnThoatLoaiSP.BorderRadius = 5;
            this.btnThoatLoaiSP.CheckedState.Parent = this.btnThoatLoaiSP;
            this.btnThoatLoaiSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoatLoaiSP.CustomImages.Parent = this.btnThoatLoaiSP;
            this.btnThoatLoaiSP.FillColor = System.Drawing.Color.Transparent;
            this.btnThoatLoaiSP.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.btnThoatLoaiSP.ForeColor = System.Drawing.Color.White;
            this.btnThoatLoaiSP.HoverState.Parent = this.btnThoatLoaiSP;
            this.btnThoatLoaiSP.Location = new System.Drawing.Point(689, 1);
            this.btnThoatLoaiSP.Name = "btnThoatLoaiSP";
            this.btnThoatLoaiSP.ShadowDecoration.Parent = this.btnThoatLoaiSP;
            this.btnThoatLoaiSP.Size = new System.Drawing.Size(40, 40);
            this.btnThoatLoaiSP.TabIndex = 18;
            this.btnThoatLoaiSP.Click += new System.EventHandler(this.btnThoatLoaiSP_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // btnXuatExcelCTSP
            // 
            this.btnXuatExcelCTSP.BorderRadius = 20;
            this.btnXuatExcelCTSP.CheckedState.Parent = this.btnXuatExcelCTSP;
            this.btnXuatExcelCTSP.CustomImages.Parent = this.btnXuatExcelCTSP;
            this.btnXuatExcelCTSP.FillColor = System.Drawing.Color.Turquoise;
            this.btnXuatExcelCTSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcelCTSP.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcelCTSP.HoverState.Parent = this.btnXuatExcelCTSP;
            this.btnXuatExcelCTSP.Location = new System.Drawing.Point(401, 202);
            this.btnXuatExcelCTSP.Name = "btnXuatExcelCTSP";
            this.btnXuatExcelCTSP.ShadowDecoration.Parent = this.btnXuatExcelCTSP;
            this.btnXuatExcelCTSP.Size = new System.Drawing.Size(113, 39);
            this.btnXuatExcelCTSP.TabIndex = 50;
            this.btnXuatExcelCTSP.Text = "Xuất Excel";
            this.btnXuatExcelCTSP.Click += new System.EventHandler(this.btnXuatExcelCTSP_Click);
            // 
            // cboTrangThaiLSP
            // 
            this.cboTrangThaiLSP.BackColor = System.Drawing.Color.Transparent;
            this.cboTrangThaiLSP.BorderRadius = 5;
            this.cboTrangThaiLSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTrangThaiLSP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTrangThaiLSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThaiLSP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTrangThaiLSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTrangThaiLSP.FocusedState.Parent = this.cboTrangThaiLSP;
            this.cboTrangThaiLSP.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThaiLSP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboTrangThaiLSP.HoverState.Parent = this.cboTrangThaiLSP;
            this.cboTrangThaiLSP.ItemHeight = 30;
            this.cboTrangThaiLSP.ItemsAppearance.Parent = this.cboTrangThaiLSP;
            this.cboTrangThaiLSP.Location = new System.Drawing.Point(215, 205);
            this.cboTrangThaiLSP.Name = "cboTrangThaiLSP";
            this.cboTrangThaiLSP.ShadowDecoration.Parent = this.cboTrangThaiLSP;
            this.cboTrangThaiLSP.Size = new System.Drawing.Size(180, 36);
            this.cboTrangThaiLSP.TabIndex = 51;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 5;
            this.guna2PictureBox1.Image = global::_452_417_CDTH19E_SHOESSHOP.Properties.Resources.icon_vesinhgiay_2x6;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(45, 35);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 54;
            this.guna2PictureBox1.TabStop = false;
            // 
            // frmLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(737, 565);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.cboTrangThaiLSP);
            this.Controls.Add(this.btnXuatExcelCTSP);
            this.Controls.Add(this.btnThoatLoaiSP);
            this.Controls.Add(this.txtTenLoaiSP);
            this.Controls.Add(this.txtIDLoaiSanPham);
            this.Controls.Add(this.btnXoaLoaiLSP);
            this.Controls.Add(this.btnCapNhatLoaiSP);
            this.Controls.Add(this.btnThemLoaiSP);
            this.Controls.Add(this.grpLoaiSanPham);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLoaiSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại Sản Phẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLoaiSanPham_FormClosing);
            this.Load += new System.EventHandler(this.frmLoaiSanPham_Load);
            this.grpLoaiSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GroupBox grpLoaiSanPham;
        private Guna.UI2.WinForms.Guna2Button btnThemLoaiSP;
        private Guna.UI2.WinForms.Guna2Button btnCapNhatLoaiSP;
        private Guna.UI2.WinForms.Guna2Button btnXoaLoaiLSP;
        private Guna.UI2.WinForms.Guna2TextBox txtIDLoaiSanPham;
        private Guna.UI2.WinForms.Guna2TextBox txtTenLoaiSP;
        private Guna.UI2.WinForms.Guna2Button btnThoatLoaiSP;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.DataGridView dgvLoaiSanPham;
        private Guna.UI2.WinForms.Guna2Button btnXuatExcelCTSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Guna.UI2.WinForms.Guna2ComboBox cboTrangThaiLSP;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}