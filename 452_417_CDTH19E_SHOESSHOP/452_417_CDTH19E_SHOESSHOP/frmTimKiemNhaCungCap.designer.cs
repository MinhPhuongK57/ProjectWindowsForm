
namespace _452_417_CDTH19E_SHOESSHOP
{
    partial class frmTimKiemNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiemNhaCungCap));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNhaCungCap = new System.Windows.Forms.DataGridView();
            this.ID_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDanhSachNCC = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cboNhaCungCap = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnDatLaiNCC = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimKiemNCC = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiemNCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThoatTimKIemNCC = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).BeginInit();
            this.grpDanhSachNCC.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(312, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "TÌM KIẾM NHÀ CUNG CẤP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvNhaCungCap
            // 
            this.dgvNhaCungCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhaCungCap.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaCungCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_NCC,
            this.TenNCC,
            this.DiaChi,
            this.SoDT});
            this.dgvNhaCungCap.Location = new System.Drawing.Point(0, 39);
            this.dgvNhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNhaCungCap.Name = "dgvNhaCungCap";
            this.dgvNhaCungCap.ReadOnly = true;
            this.dgvNhaCungCap.RowHeadersVisible = false;
            this.dgvNhaCungCap.RowHeadersWidth = 51;
            this.dgvNhaCungCap.RowTemplate.Height = 24;
            this.dgvNhaCungCap.Size = new System.Drawing.Size(926, 307);
            this.dgvNhaCungCap.TabIndex = 0;
            // 
            // ID_NCC
            // 
            this.ID_NCC.DataPropertyName = "ID_NCC";
            this.ID_NCC.HeaderText = "ID Nhà Cung Cấp";
            this.ID_NCC.MinimumWidth = 6;
            this.ID_NCC.Name = "ID_NCC";
            this.ID_NCC.ReadOnly = true;
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Tên Nhà Cung Cấp";
            this.TenNCC.MinimumWidth = 6;
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // SoDT
            // 
            this.SoDT.DataPropertyName = "SoDT";
            this.SoDT.HeaderText = "Số Điện Thoại";
            this.SoDT.MinimumWidth = 6;
            this.SoDT.Name = "SoDT";
            this.SoDT.ReadOnly = true;
            // 
            // grpDanhSachNCC
            // 
            this.grpDanhSachNCC.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.grpDanhSachNCC.BorderRadius = 5;
            this.grpDanhSachNCC.Controls.Add(this.dgvNhaCungCap);
            this.grpDanhSachNCC.CustomBorderColor = System.Drawing.SystemColors.ButtonFace;
            this.grpDanhSachNCC.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDanhSachNCC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpDanhSachNCC.Location = new System.Drawing.Point(12, 183);
            this.grpDanhSachNCC.Name = "grpDanhSachNCC";
            this.grpDanhSachNCC.ShadowDecoration.Parent = this.grpDanhSachNCC;
            this.grpDanhSachNCC.Size = new System.Drawing.Size(928, 346);
            this.grpDanhSachNCC.TabIndex = 20;
            this.grpDanhSachNCC.Text = "Danh sách nhà cung cấp";
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.BackColor = System.Drawing.Color.Transparent;
            this.cboNhaCungCap.BorderRadius = 5;
            this.cboNhaCungCap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboNhaCungCap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhaCungCap.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboNhaCungCap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboNhaCungCap.FocusedState.Parent = this.cboNhaCungCap;
            this.cboNhaCungCap.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNhaCungCap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboNhaCungCap.HoverState.Parent = this.cboNhaCungCap;
            this.cboNhaCungCap.ItemHeight = 30;
            this.cboNhaCungCap.ItemsAppearance.Parent = this.cboNhaCungCap;
            this.cboNhaCungCap.Location = new System.Drawing.Point(42, 98);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.ShadowDecoration.Parent = this.cboNhaCungCap;
            this.cboNhaCungCap.Size = new System.Drawing.Size(216, 36);
            this.cboNhaCungCap.TabIndex = 21;
            // 
            // btnDatLaiNCC
            // 
            this.btnDatLaiNCC.BorderRadius = 20;
            this.btnDatLaiNCC.CheckedState.Parent = this.btnDatLaiNCC;
            this.btnDatLaiNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatLaiNCC.CustomImages.Parent = this.btnDatLaiNCC;
            this.btnDatLaiNCC.FillColor = System.Drawing.Color.Turquoise;
            this.btnDatLaiNCC.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLaiNCC.ForeColor = System.Drawing.Color.White;
            this.btnDatLaiNCC.HoverState.Parent = this.btnDatLaiNCC;
            this.btnDatLaiNCC.Location = new System.Drawing.Point(810, 96);
            this.btnDatLaiNCC.Name = "btnDatLaiNCC";
            this.btnDatLaiNCC.ShadowDecoration.Parent = this.btnDatLaiNCC;
            this.btnDatLaiNCC.Size = new System.Drawing.Size(108, 38);
            this.btnDatLaiNCC.TabIndex = 24;
            this.btnDatLaiNCC.Text = "Tải lại";
            this.btnDatLaiNCC.Click += new System.EventHandler(this.btnDatLaiNCC_Click_1);
            // 
            // btnTimKiemNCC
            // 
            this.btnTimKiemNCC.BorderRadius = 20;
            this.btnTimKiemNCC.CheckedState.Parent = this.btnTimKiemNCC;
            this.btnTimKiemNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemNCC.CustomImages.Parent = this.btnTimKiemNCC;
            this.btnTimKiemNCC.FillColor = System.Drawing.Color.Turquoise;
            this.btnTimKiemNCC.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemNCC.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemNCC.HoverState.Parent = this.btnTimKiemNCC;
            this.btnTimKiemNCC.Location = new System.Drawing.Point(685, 96);
            this.btnTimKiemNCC.Name = "btnTimKiemNCC";
            this.btnTimKiemNCC.ShadowDecoration.Parent = this.btnTimKiemNCC;
            this.btnTimKiemNCC.Size = new System.Drawing.Size(108, 38);
            this.btnTimKiemNCC.TabIndex = 25;
            this.btnTimKiemNCC.Text = "Tìm kiếm";
            this.btnTimKiemNCC.Click += new System.EventHandler(this.btnTimKiemNCC_Click_1);
            // 
            // txtTimKiemNCC
            // 
            this.txtTimKiemNCC.BorderRadius = 5;
            this.txtTimKiemNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemNCC.DefaultText = "";
            this.txtTimKiemNCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiemNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiemNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemNCC.DisabledState.Parent = this.txtTimKiemNCC;
            this.txtTimKiemNCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemNCC.FocusedState.Parent = this.txtTimKiemNCC;
            this.txtTimKiemNCC.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemNCC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTimKiemNCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemNCC.HoverState.Parent = this.txtTimKiemNCC;
            this.txtTimKiemNCC.Location = new System.Drawing.Point(278, 98);
            this.txtTimKiemNCC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTimKiemNCC.Name = "txtTimKiemNCC";
            this.txtTimKiemNCC.PasswordChar = '\0';
            this.txtTimKiemNCC.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTimKiemNCC.PlaceholderText = "";
            this.txtTimKiemNCC.SelectedText = "";
            this.txtTimKiemNCC.ShadowDecoration.Parent = this.txtTimKiemNCC;
            this.txtTimKiemNCC.Size = new System.Drawing.Size(339, 36);
            this.txtTimKiemNCC.TabIndex = 26;
            // 
            // btnThoatTimKIemNCC
            // 
            this.btnThoatTimKIemNCC.Animated = true;
            this.btnThoatTimKIemNCC.BackgroundImage = global::_452_417_CDTH19E_SHOESSHOP.Properties.Resources.icons8_close_window_642;
            this.btnThoatTimKIemNCC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThoatTimKIemNCC.BorderColor = System.Drawing.Color.Transparent;
            this.btnThoatTimKIemNCC.BorderRadius = 5;
            this.btnThoatTimKIemNCC.CheckedState.Parent = this.btnThoatTimKIemNCC;
            this.btnThoatTimKIemNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoatTimKIemNCC.CustomImages.Parent = this.btnThoatTimKIemNCC;
            this.btnThoatTimKIemNCC.FillColor = System.Drawing.Color.Transparent;
            this.btnThoatTimKIemNCC.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatTimKIemNCC.ForeColor = System.Drawing.Color.White;
            this.btnThoatTimKIemNCC.HoverState.Parent = this.btnThoatTimKIemNCC;
            this.btnThoatTimKIemNCC.Location = new System.Drawing.Point(900, 1);
            this.btnThoatTimKIemNCC.Name = "btnThoatTimKIemNCC";
            this.btnThoatTimKIemNCC.ShadowDecoration.Parent = this.btnThoatTimKIemNCC;
            this.btnThoatTimKIemNCC.Size = new System.Drawing.Size(40, 40);
            this.btnThoatTimKIemNCC.TabIndex = 27;
            this.btnThoatTimKIemNCC.Click += new System.EventHandler(this.btnThoatTimKIemNCC_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // frmTimKiemNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(949, 539);
            this.Controls.Add(this.btnThoatTimKIemNCC);
            this.Controls.Add(this.txtTimKiemNCC);
            this.Controls.Add(this.btnDatLaiNCC);
            this.Controls.Add(this.btnTimKiemNCC);
            this.Controls.Add(this.cboNhaCungCap);
            this.Controls.Add(this.grpDanhSachNCC);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTimKiemNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTimKiemNhaCungCap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTimKiemNhaCungCap_FormClosing);
            this.Load += new System.EventHandler(this.frmTimKiemNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).EndInit();
            this.grpDanhSachNCC.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNhaCungCap;
        private Guna.UI2.WinForms.Guna2GroupBox grpDanhSachNCC;
        private Guna.UI2.WinForms.Guna2ComboBox cboNhaCungCap;
        private Guna.UI2.WinForms.Guna2Button btnDatLaiNCC;
        private Guna.UI2.WinForms.Guna2Button btnTimKiemNCC;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiemNCC;
        private Guna.UI2.WinForms.Guna2Button btnThoatTimKIemNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}