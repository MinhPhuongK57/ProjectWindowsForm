
namespace _452_417_CDTH19E_SHOESSHOP
{
    partial class frmTimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiem));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTimKiemSP = new System.Windows.Forms.DataGridView();
            this.ID_SanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_LoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDatLaiSP = new Guna.UI2.WinForms.Guna2Button();
            this.cboTimKiemSP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTimKiemSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.grpDanhSachSP = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnThoatTimKiemSP = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemSP)).BeginInit();
            this.grpDanhSachSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(421, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM KIẾM SẢN PHẨM";
            // 
            // dgvTimKiemSP
            // 
            this.dgvTimKiemSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimKiemSP.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTimKiemSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiemSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_SanPham,
            this.ID_LoaiSanPham,
            this.TenSanPham,
            this.TrangThai,
            this.ID_NCC});
            this.dgvTimKiemSP.Location = new System.Drawing.Point(0, 40);
            this.dgvTimKiemSP.Name = "dgvTimKiemSP";
            this.dgvTimKiemSP.ReadOnly = true;
            this.dgvTimKiemSP.RowHeadersVisible = false;
            this.dgvTimKiemSP.RowHeadersWidth = 60;
            this.dgvTimKiemSP.RowTemplate.Height = 24;
            this.dgvTimKiemSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimKiemSP.Size = new System.Drawing.Size(1056, 224);
            this.dgvTimKiemSP.TabIndex = 0;
            // 
            // ID_SanPham
            // 
            this.ID_SanPham.DataPropertyName = "ID_SanPham";
            this.ID_SanPham.HeaderText = "ID Sản Phẩm";
            this.ID_SanPham.MinimumWidth = 6;
            this.ID_SanPham.Name = "ID_SanPham";
            this.ID_SanPham.ReadOnly = true;
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
            // ID_NCC
            // 
            this.ID_NCC.DataPropertyName = "ID_NCC";
            this.ID_NCC.HeaderText = "ID Nhà Cung Cấp";
            this.ID_NCC.MinimumWidth = 6;
            this.ID_NCC.Name = "ID_NCC";
            this.ID_NCC.ReadOnly = true;
            // 
            // btnDatLaiSP
            // 
            this.btnDatLaiSP.BorderRadius = 20;
            this.btnDatLaiSP.CheckedState.Parent = this.btnDatLaiSP;
            this.btnDatLaiSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatLaiSP.CustomImages.Parent = this.btnDatLaiSP;
            this.btnDatLaiSP.FillColor = System.Drawing.Color.Turquoise;
            this.btnDatLaiSP.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLaiSP.ForeColor = System.Drawing.Color.White;
            this.btnDatLaiSP.HoverState.Parent = this.btnDatLaiSP;
            this.btnDatLaiSP.Location = new System.Drawing.Point(848, 85);
            this.btnDatLaiSP.Name = "btnDatLaiSP";
            this.btnDatLaiSP.ShadowDecoration.Parent = this.btnDatLaiSP;
            this.btnDatLaiSP.Size = new System.Drawing.Size(108, 38);
            this.btnDatLaiSP.TabIndex = 28;
            this.btnDatLaiSP.Text = "Tải lại";
            this.btnDatLaiSP.Click += new System.EventHandler(this.btnDatLaiSP_Click_1);
            // 
            // cboTimKiemSP
            // 
            this.cboTimKiemSP.BackColor = System.Drawing.Color.Transparent;
            this.cboTimKiemSP.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.cboTimKiemSP.BorderRadius = 5;
            this.cboTimKiemSP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTimKiemSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimKiemSP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTimKiemSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTimKiemSP.FocusedState.Parent = this.cboTimKiemSP;
            this.cboTimKiemSP.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTimKiemSP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboTimKiemSP.HoverState.Parent = this.cboTimKiemSP;
            this.cboTimKiemSP.ItemHeight = 30;
            this.cboTimKiemSP.ItemsAppearance.Parent = this.cboTimKiemSP;
            this.cboTimKiemSP.Location = new System.Drawing.Point(69, 87);
            this.cboTimKiemSP.Name = "cboTimKiemSP";
            this.cboTimKiemSP.ShadowDecoration.Parent = this.cboTimKiemSP;
            this.cboTimKiemSP.Size = new System.Drawing.Size(213, 36);
            this.cboTimKiemSP.TabIndex = 30;
            this.cboTimKiemSP.SelectedIndexChanged += new System.EventHandler(this.cboTimKiemSP_SelectedIndexChanged);
            // 
            // txtTimKiemSP
            // 
            this.txtTimKiemSP.BorderRadius = 5;
            this.txtTimKiemSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemSP.DefaultText = "";
            this.txtTimKiemSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiemSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiemSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemSP.DisabledState.Parent = this.txtTimKiemSP;
            this.txtTimKiemSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemSP.FocusedState.Parent = this.txtTimKiemSP;
            this.txtTimKiemSP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemSP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTimKiemSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemSP.HoverState.Parent = this.txtTimKiemSP;
            this.txtTimKiemSP.Location = new System.Drawing.Point(339, 87);
            this.txtTimKiemSP.Name = "txtTimKiemSP";
            this.txtTimKiemSP.PasswordChar = '\0';
            this.txtTimKiemSP.PlaceholderText = "";
            this.txtTimKiemSP.SelectedText = "";
            this.txtTimKiemSP.ShadowDecoration.Parent = this.txtTimKiemSP;
            this.txtTimKiemSP.Size = new System.Drawing.Size(323, 36);
            this.txtTimKiemSP.TabIndex = 31;
            this.txtTimKiemSP.TextChanged += new System.EventHandler(this.txtTimKiemSP_TextChanged);
            // 
            // grpDanhSachSP
            // 
            this.grpDanhSachSP.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.grpDanhSachSP.BorderRadius = 5;
            this.grpDanhSachSP.Controls.Add(this.dgvTimKiemSP);
            this.grpDanhSachSP.CustomBorderColor = System.Drawing.SystemColors.ButtonFace;
            this.grpDanhSachSP.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDanhSachSP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpDanhSachSP.Location = new System.Drawing.Point(12, 151);
            this.grpDanhSachSP.Name = "grpDanhSachSP";
            this.grpDanhSachSP.ShadowDecoration.Parent = this.grpDanhSachSP;
            this.grpDanhSachSP.Size = new System.Drawing.Size(1058, 264);
            this.grpDanhSachSP.TabIndex = 32;
            this.grpDanhSachSP.Text = "Danh sách sản phẩm";
            // 
            // btnThoatTimKiemSP
            // 
            this.btnThoatTimKiemSP.Animated = true;
            this.btnThoatTimKiemSP.BackgroundImage = global::_452_417_CDTH19E_SHOESSHOP.Properties.Resources.icons8_close_window_642;
            this.btnThoatTimKiemSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThoatTimKiemSP.BorderColor = System.Drawing.Color.Transparent;
            this.btnThoatTimKiemSP.BorderRadius = 5;
            this.btnThoatTimKiemSP.CheckedState.Parent = this.btnThoatTimKiemSP;
            this.btnThoatTimKiemSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoatTimKiemSP.CustomImages.Parent = this.btnThoatTimKiemSP;
            this.btnThoatTimKiemSP.FillColor = System.Drawing.Color.Transparent;
            this.btnThoatTimKiemSP.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatTimKiemSP.ForeColor = System.Drawing.Color.White;
            this.btnThoatTimKiemSP.HoverState.Parent = this.btnThoatTimKiemSP;
            this.btnThoatTimKiemSP.Location = new System.Drawing.Point(1030, 9);
            this.btnThoatTimKiemSP.Name = "btnThoatTimKiemSP";
            this.btnThoatTimKiemSP.ShadowDecoration.Parent = this.btnThoatTimKiemSP;
            this.btnThoatTimKiemSP.Size = new System.Drawing.Size(40, 40);
            this.btnThoatTimKiemSP.TabIndex = 33;
            this.btnThoatTimKiemSP.Click += new System.EventHandler(this.btnThoatTimKiemSP_Click_1);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 5;
            this.guna2PictureBox1.Image = global::_452_417_CDTH19E_SHOESSHOP.Properties.Resources.icon_vesinhgiay_2x6;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 9);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(45, 35);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 54;
            this.guna2PictureBox1.TabStop = false;
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1080, 427);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.btnThoatTimKiemSP);
            this.Controls.Add(this.grpDanhSachSP);
            this.Controls.Add(this.txtTimKiemSP);
            this.Controls.Add(this.cboTimKiemSP);
            this.Controls.Add(this.btnDatLaiSP);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTimKiem_FormClosing);
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemSP)).EndInit();
            this.grpDanhSachSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTimKiemSP;
        private Guna.UI2.WinForms.Guna2Button btnDatLaiSP;
        private Guna.UI2.WinForms.Guna2ComboBox cboTimKiemSP;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiemSP;
        private Guna.UI2.WinForms.Guna2GroupBox grpDanhSachSP;
        private Guna.UI2.WinForms.Guna2Button btnThoatTimKiemSP;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_SanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_LoaiSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_NCC;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}