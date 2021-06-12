
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
            this.dgvLoaiSanPham = new System.Windows.Forms.DataGridView();
            this.ID_LoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpLoaiSanPham = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnThemLoaiSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapNhatLoaiSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaLoaiLSP = new Guna.UI2.WinForms.Guna2Button();
            this.txtIDLoaiSanPham = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenLoaiSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.numTrangThaiLSP = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnThoatLoaiSP = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSanPham)).BeginInit();
            this.grpLoaiSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrangThaiLSP)).BeginInit();
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
            // dgvLoaiSanPham
            // 
            this.dgvLoaiSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiSanPham.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLoaiSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_LoaiSanPham,
            this.TenLoai,
            this.TrangThai});
            this.dgvLoaiSanPham.Location = new System.Drawing.Point(0, 39);
            this.dgvLoaiSanPham.Name = "dgvLoaiSanPham";
            this.dgvLoaiSanPham.ReadOnly = true;
            this.dgvLoaiSanPham.RowHeadersVisible = false;
            this.dgvLoaiSanPham.RowHeadersWidth = 51;
            this.dgvLoaiSanPham.RowTemplate.Height = 24;
            this.dgvLoaiSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiSanPham.Size = new System.Drawing.Size(724, 251);
            this.dgvLoaiSanPham.TabIndex = 0;
            this.dgvLoaiSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiSanPham_CellClick);
            // 
            // ID_LoaiSanPham
            // 
            this.ID_LoaiSanPham.DataPropertyName = "ID_LoaiSanPham";
            this.ID_LoaiSanPham.HeaderText = "ID Loại Sản Phẩm";
            this.ID_LoaiSanPham.MinimumWidth = 6;
            this.ID_LoaiSanPham.Name = "ID_LoaiSanPham";
            this.ID_LoaiSanPham.ReadOnly = true;
            // 
            // TenLoai
            // 
            this.TenLoai.DataPropertyName = "TenLoai";
            this.TenLoai.HeaderText = "Tên Loại";
            this.TenLoai.MinimumWidth = 6;
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
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
            this.grpLoaiSanPham.Location = new System.Drawing.Point(5, 286);
            this.grpLoaiSanPham.Name = "grpLoaiSanPham";
            this.grpLoaiSanPham.ShadowDecoration.Parent = this.grpLoaiSanPham;
            this.grpLoaiSanPham.Size = new System.Drawing.Size(724, 293);
            this.grpLoaiSanPham.TabIndex = 13;
            this.grpLoaiSanPham.Text = "Danh sách loại sản phẩm";
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
            this.btnXoaLoaiLSP.Location = new System.Drawing.Point(560, 207);
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
            this.txtTenLoaiSP.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // numTrangThaiLSP
            // 
            this.numTrangThaiLSP.BackColor = System.Drawing.Color.Transparent;
            this.numTrangThaiLSP.BorderRadius = 5;
            this.numTrangThaiLSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numTrangThaiLSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numTrangThaiLSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numTrangThaiLSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numTrangThaiLSP.DisabledState.Parent = this.numTrangThaiLSP;
            this.numTrangThaiLSP.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numTrangThaiLSP.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numTrangThaiLSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numTrangThaiLSP.FocusedState.Parent = this.numTrangThaiLSP;
            this.numTrangThaiLSP.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTrangThaiLSP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numTrangThaiLSP.Location = new System.Drawing.Point(215, 208);
            this.numTrangThaiLSP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numTrangThaiLSP.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTrangThaiLSP.Name = "numTrangThaiLSP";
            this.numTrangThaiLSP.ShadowDecoration.Parent = this.numTrangThaiLSP;
            this.numTrangThaiLSP.Size = new System.Drawing.Size(132, 33);
            this.numTrangThaiLSP.TabIndex = 17;
            this.numTrangThaiLSP.UpDownButtonFillColor = System.Drawing.Color.Turquoise;
            this.numTrangThaiLSP.UpDownButtonForeColor = System.Drawing.Color.White;
            this.numTrangThaiLSP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTrangThaiLSP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numTrangThaiLSP_KeyUp);
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
            // frmLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(734, 581);
            this.Controls.Add(this.btnThoatLoaiSP);
            this.Controls.Add(this.numTrangThaiLSP);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSanPham)).EndInit();
            this.grpLoaiSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTrangThaiLSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLoaiSanPham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GroupBox grpLoaiSanPham;
        private Guna.UI2.WinForms.Guna2Button btnThemLoaiSP;
        private Guna.UI2.WinForms.Guna2Button btnCapNhatLoaiSP;
        private Guna.UI2.WinForms.Guna2Button btnXoaLoaiLSP;
        private Guna.UI2.WinForms.Guna2TextBox txtIDLoaiSanPham;
        private Guna.UI2.WinForms.Guna2TextBox txtTenLoaiSP;
        private Guna.UI2.WinForms.Guna2NumericUpDown numTrangThaiLSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_LoaiSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private Guna.UI2.WinForms.Guna2Button btnThoatLoaiSP;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}