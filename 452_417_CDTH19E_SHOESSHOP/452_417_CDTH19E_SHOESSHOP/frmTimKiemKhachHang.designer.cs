
namespace _452_417_CDTH19E_SHOESSHOP
{
    partial class frmTimKiemKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiemKhachHang));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTimKiemKH = new System.Windows.Forms.DataGridView();
            this.ID_KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTimKiemKH = new System.Windows.Forms.Panel();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboKhachHang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTimKiemKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.grpTimKiemKhachHang = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnTimKiemKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnDatLaiKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnThoatTimKiemKH = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemKH)).BeginInit();
            this.pnlTimKiemKH.SuspendLayout();
            this.grpTimKiemKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(432, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "TÌM KIẾM KHÁCH HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTimKiemKH
            // 
            this.dgvTimKiemKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimKiemKH.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTimKiemKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiemKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_KhachHang,
            this.TenKhachHang,
            this.NgaySinh,
            this.DiaChi,
            this.SoDT});
            this.dgvTimKiemKH.Location = new System.Drawing.Point(1, 40);
            this.dgvTimKiemKH.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTimKiemKH.Name = "dgvTimKiemKH";
            this.dgvTimKiemKH.ReadOnly = true;
            this.dgvTimKiemKH.RowHeadersVisible = false;
            this.dgvTimKiemKH.RowHeadersWidth = 51;
            this.dgvTimKiemKH.RowTemplate.Height = 24;
            this.dgvTimKiemKH.Size = new System.Drawing.Size(1145, 272);
            this.dgvTimKiemKH.TabIndex = 0;
            // 
            // ID_KhachHang
            // 
            this.ID_KhachHang.DataPropertyName = "ID_KhachHang";
            this.ID_KhachHang.HeaderText = "ID Khách Hàng";
            this.ID_KhachHang.MinimumWidth = 6;
            this.ID_KhachHang.Name = "ID_KhachHang";
            this.ID_KhachHang.ReadOnly = true;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "Tên Khách Hàng";
            this.TenKhachHang.MinimumWidth = 6;
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
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
            // pnlTimKiemKH
            // 
            this.pnlTimKiemKH.Controls.Add(this.dtpTo);
            this.pnlTimKiemKH.Controls.Add(this.dtpFrom);
            this.pnlTimKiemKH.Controls.Add(this.label3);
            this.pnlTimKiemKH.Controls.Add(this.label2);
            this.pnlTimKiemKH.Location = new System.Drawing.Point(76, 145);
            this.pnlTimKiemKH.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTimKiemKH.Name = "pnlTimKiemKH";
            this.pnlTimKiemKH.Size = new System.Drawing.Size(659, 81);
            this.pnlTimKiemKH.TabIndex = 2;
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "MM/dd/yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(388, 26);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(249, 28);
            this.dtpTo.TabIndex = 1;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "MM/dd/yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(62, 28);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(249, 28);
            this.dtpFrom.TabIndex = 0;
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
            // cboKhachHang
            // 
            this.cboKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.cboKhachHang.BorderRadius = 5;
            this.cboKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboKhachHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboKhachHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboKhachHang.FocusedState.Parent = this.cboKhachHang;
            this.cboKhachHang.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKhachHang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboKhachHang.HoverState.Parent = this.cboKhachHang;
            this.cboKhachHang.ItemHeight = 30;
            this.cboKhachHang.ItemsAppearance.Parent = this.cboKhachHang;
            this.cboKhachHang.Location = new System.Drawing.Point(76, 89);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.ShadowDecoration.Parent = this.cboKhachHang;
            this.cboKhachHang.Size = new System.Drawing.Size(254, 36);
            this.cboKhachHang.TabIndex = 20;
            this.cboKhachHang.SelectedIndexChanged += new System.EventHandler(this.cboKhachHang_SelectedIndexChanged);
            // 
            // txtTimKiemKH
            // 
            this.txtTimKiemKH.BorderRadius = 5;
            this.txtTimKiemKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemKH.DefaultText = "";
            this.txtTimKiemKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiemKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiemKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemKH.DisabledState.Parent = this.txtTimKiemKH;
            this.txtTimKiemKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiemKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemKH.FocusedState.Parent = this.txtTimKiemKH;
            this.txtTimKiemKH.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemKH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTimKiemKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiemKH.HoverState.Parent = this.txtTimKiemKH;
            this.txtTimKiemKH.Location = new System.Drawing.Point(371, 89);
            this.txtTimKiemKH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTimKiemKH.Name = "txtTimKiemKH";
            this.txtTimKiemKH.PasswordChar = '\0';
            this.txtTimKiemKH.PlaceholderText = "";
            this.txtTimKiemKH.SelectedText = "";
            this.txtTimKiemKH.ShadowDecoration.Parent = this.txtTimKiemKH;
            this.txtTimKiemKH.Size = new System.Drawing.Size(364, 36);
            this.txtTimKiemKH.TabIndex = 21;
            // 
            // grpTimKiemKhachHang
            // 
            this.grpTimKiemKhachHang.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.grpTimKiemKhachHang.BorderRadius = 5;
            this.grpTimKiemKhachHang.Controls.Add(this.dgvTimKiemKH);
            this.grpTimKiemKhachHang.CustomBorderColor = System.Drawing.SystemColors.ButtonFace;
            this.grpTimKiemKhachHang.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTimKiemKhachHang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpTimKiemKhachHang.Location = new System.Drawing.Point(12, 254);
            this.grpTimKiemKhachHang.Name = "grpTimKiemKhachHang";
            this.grpTimKiemKhachHang.ShadowDecoration.Parent = this.grpTimKiemKhachHang;
            this.grpTimKiemKhachHang.Size = new System.Drawing.Size(1146, 315);
            this.grpTimKiemKhachHang.TabIndex = 22;
            this.grpTimKiemKhachHang.Text = "Dach sách khách hàng";
            // 
            // btnTimKiemKH
            // 
            this.btnTimKiemKH.BorderRadius = 20;
            this.btnTimKiemKH.CheckedState.Parent = this.btnTimKiemKH;
            this.btnTimKiemKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemKH.CustomImages.Parent = this.btnTimKiemKH;
            this.btnTimKiemKH.FillColor = System.Drawing.Color.Turquoise;
            this.btnTimKiemKH.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemKH.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemKH.HoverState.Parent = this.btnTimKiemKH;
            this.btnTimKiemKH.Location = new System.Drawing.Point(915, 89);
            this.btnTimKiemKH.Name = "btnTimKiemKH";
            this.btnTimKiemKH.ShadowDecoration.Parent = this.btnTimKiemKH;
            this.btnTimKiemKH.Size = new System.Drawing.Size(108, 38);
            this.btnTimKiemKH.TabIndex = 23;
            this.btnTimKiemKH.Text = "Tìm kiếm";
            this.btnTimKiemKH.Click += new System.EventHandler(this.btnTimKiemKH_Click);
            // 
            // btnDatLaiKH
            // 
            this.btnDatLaiKH.BorderRadius = 20;
            this.btnDatLaiKH.CheckedState.Parent = this.btnDatLaiKH;
            this.btnDatLaiKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatLaiKH.CustomImages.Parent = this.btnDatLaiKH;
            this.btnDatLaiKH.FillColor = System.Drawing.Color.Turquoise;
            this.btnDatLaiKH.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLaiKH.ForeColor = System.Drawing.Color.White;
            this.btnDatLaiKH.HoverState.Parent = this.btnDatLaiKH;
            this.btnDatLaiKH.Location = new System.Drawing.Point(915, 161);
            this.btnDatLaiKH.Name = "btnDatLaiKH";
            this.btnDatLaiKH.ShadowDecoration.Parent = this.btnDatLaiKH;
            this.btnDatLaiKH.Size = new System.Drawing.Size(108, 38);
            this.btnDatLaiKH.TabIndex = 23;
            this.btnDatLaiKH.Text = "Tải lại";
            this.btnDatLaiKH.Click += new System.EventHandler(this.btnDatLaiKH_Click);
            // 
            // btnThoatTimKiemKH
            // 
            this.btnThoatTimKiemKH.Animated = true;
            this.btnThoatTimKiemKH.BackgroundImage = global::_452_417_CDTH19E_SHOESSHOP.Properties.Resources.icons8_close_window_642;
            this.btnThoatTimKiemKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThoatTimKiemKH.BorderColor = System.Drawing.Color.Transparent;
            this.btnThoatTimKiemKH.BorderRadius = 5;
            this.btnThoatTimKiemKH.CheckedState.Parent = this.btnThoatTimKiemKH;
            this.btnThoatTimKiemKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoatTimKiemKH.CustomImages.Parent = this.btnThoatTimKiemKH;
            this.btnThoatTimKiemKH.FillColor = System.Drawing.Color.Transparent;
            this.btnThoatTimKiemKH.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatTimKiemKH.ForeColor = System.Drawing.Color.White;
            this.btnThoatTimKiemKH.HoverState.Parent = this.btnThoatTimKiemKH;
            this.btnThoatTimKiemKH.Location = new System.Drawing.Point(1119, 12);
            this.btnThoatTimKiemKH.Name = "btnThoatTimKiemKH";
            this.btnThoatTimKiemKH.ShadowDecoration.Parent = this.btnThoatTimKiemKH;
            this.btnThoatTimKiemKH.Size = new System.Drawing.Size(40, 40);
            this.btnThoatTimKiemKH.TabIndex = 25;
            this.btnThoatTimKiemKH.Click += new System.EventHandler(this.btnThoatTimKiemKH_Click_1);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // frmTimKiemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1171, 573);
            this.Controls.Add(this.btnThoatTimKiemKH);
            this.Controls.Add(this.btnDatLaiKH);
            this.Controls.Add(this.btnTimKiemKH);
            this.Controls.Add(this.grpTimKiemKhachHang);
            this.Controls.Add(this.txtTimKiemKH);
            this.Controls.Add(this.cboKhachHang);
            this.Controls.Add(this.pnlTimKiemKH);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTimKiemKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTimKiemKhachHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTimKiemKhachHang_FormClosing);
            this.Load += new System.EventHandler(this.frmTimKiemKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemKH)).EndInit();
            this.pnlTimKiemKH.ResumeLayout(false);
            this.pnlTimKiemKH.PerformLayout();
            this.grpTimKiemKhachHang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTimKiemKH;
        private System.Windows.Forms.Panel pnlTimKiemKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private Guna.UI2.WinForms.Guna2ComboBox cboKhachHang;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiemKH;
        private Guna.UI2.WinForms.Guna2GroupBox grpTimKiemKhachHang;
        private Guna.UI2.WinForms.Guna2Button btnTimKiemKH;
        private Guna.UI2.WinForms.Guna2Button btnDatLaiKH;
        private Guna.UI2.WinForms.Guna2Button btnThoatTimKiemKH;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}