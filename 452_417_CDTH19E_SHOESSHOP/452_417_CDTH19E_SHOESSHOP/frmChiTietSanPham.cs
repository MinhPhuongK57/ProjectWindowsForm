using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _452_417_CDTH19E_SHOESSHOP
{
    public partial class frmChiTietSanPham : Form
    {
        public frmChiTietSanPham()
        {
            InitializeComponent();
        }
        //Biến dữ liệu chi tiết sản phẩm
        KetNoiDuLieu iiKetNoi = new KetNoiDuLieu();
        DataTable ChiTietSanPham = new DataTable();
        DataTable IDSanPham = new DataTable();
        public string S;
        //Hàm Kết nối chi tiết sản phẩm
        void HienThiChiTietSP()
        {
            ChiTietSanPham = iiKetNoi.ExcuteQuery("select * from CHITIETSANPHAM where ID_SanPham = '" + S + "'");
        }
        void KetNoiCTSP()
        {
            KetNoiDuLieu iKetNoiCTSP = new KetNoiDuLieu();
            dgvChiTietSP.DataSource = iKetNoiCTSP.ExcuteQuery("select * from CHITIETSANPHAM where ID_SanPham = '" + S + "'");
        }
        //Form Load
        private void frmChiTietSanPham_Load(object sender, EventArgs e)
        {
            cboKichThuoc.Items.Add("35");
            cboKichThuoc.Items.Add("36");
            cboKichThuoc.Items.Add("37");
            cboKichThuoc.Items.Add("38");
            cboKichThuoc.Items.Add("39");
            cboKichThuoc.Items.Add("40");
            cboKichThuoc.Items.Add("41");
            cboKichThuoc.Items.Add("42");
            cboKichThuoc.Items.Add("43");
            cboKichThuoc.Items.Add("44");
            cboKichThuoc.Items.Add("45");
            cboKichThuoc.SelectedIndex = 0;

            frmTrangChu form = new frmTrangChu();
            btnThemCTSP.Enabled = false;
            txtIDSanPham.Text = S;
            KetNoiCTSP();
            HienThiChiTietSP();
            HienThiTextbox(0);
        }
        //Hàm hiển thị textbox
        void HienThiTextbox(int vitri)
        {
            //Sản Phẩm
            if (ChiTietSanPham.Rows.Count > 0)
            {
                txtIDChiTietSanPham.Text = ChiTietSanPham.Rows[vitri][0].ToString();
                txtIDSanPham.Text = ChiTietSanPham.Rows[vitri][1].ToString();
                txtMau.Text = ChiTietSanPham.Rows[vitri][2].ToString();
                //txtKichThuoc.Text = ChiTietSanPham.Rows[vitri][3].ToString();
                cboKichThuoc.Text = ChiTietSanPham.Rows[vitri][3].ToString();
                numSoLuongSP.Value = Convert.ToInt32(ChiTietSanPham.Rows[vitri][4]);
                txtGiaNhap.Text = string.Format("{0:n0}", ChiTietSanPham.Rows[vitri][5]);
                txtGiaBan.Text = string.Format("{0:n0}", ChiTietSanPham.Rows[vitri][6]);
                txtTenAnh.Text = ChiTietSanPham.Rows[vitri][7].ToString();
                string filename = Path.GetFullPath("Image") + @"\";
                filename += txtTenAnh.Text;
                Bitmap img = new Bitmap(filename);
                picAnh.Image = img;

                //Xử lý nhiều ảnh

                txtTenAnhCT.Text = ChiTietSanPham.Rows[vitri][8].ToString();
                if(txtTenAnhCT.Text != "")
                {
                    string Images = txtTenAnhCT.Text = ChiTietSanPham.Rows[vitri][8].ToString();
                    string[] filenames = Images.Split(';');
                    flpAnhChiTiet.Controls.Clear();
                    if (!string.IsNullOrEmpty(Images))
                    {

                        for (int i = 0; i < filenames.Count(); i++)
                        {
                            string a = @".\Image" + @"\";
                            a += filenames[i];
                            Bitmap b = new Bitmap(a);
                            PictureBox pic = new PictureBox();
                            pic.Image = b;
                            pic.SizeMode = PictureBoxSizeMode.StretchImage;
                            pic.Width = 125;
                            pic.Height = 100;
                            pic.BorderStyle = BorderStyle.FixedSingle;
                            flpAnhChiTiet.Controls.Add(pic);
                        }
                    }
                }    
                
            }
            else
            {
                txtIDChiTietSanPham.Text = "";
                txtMau.Text = "";
                cboKichThuoc.Text = "";
                numSoLuongSP.Value = 1;
                txtGiaNhap.Text = "";
                txtGiaBan.Text = "";
                txtTenAnh.Text = "";
                picAnh.Image = null;
                flpAnhChiTiet.Controls.Clear();
            }
        }
        //Kiểm tra dữ liệu ID bảng chi tiết sản phẩm
        bool KiemTraIDCTSP()
        {
            string query = "select ID_ChiTietSanPham from CHITIETSANPHAM ";
            ChiTietSanPham = iiKetNoi.ExcuteQuery(query);
            int size = ChiTietSanPham.Rows.Count;
            for (int i = 0; i < size; i++)
            {
                if (txtIDChiTietSanPham.Text == ChiTietSanPham.Rows[i][0].ToString())
                {
                    return true;
                    break;
                }
            }
            return false;
        }
        //btn Thoát
        private void picExitHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Closing Form
        private void frmChiTietSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ThoatHoi;
            ThoatHoi = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (ThoatHoi == DialogResult.No)
                e.Cancel = true;
        }

        //Hàm thêm chi tiết sản phẩm
        void ThemDLCTSP()
        {
            if (KiemTraIDCTSP())
            {
                MessageBox.Show("ID đã tồn tại", "Thông báo");
            }
            else
            {
                DataTable ThemCTSP = new DataTable();
                string query = "insert into CHITIETSANPHAM values('" + txtIDChiTietSanPham.Text + "','" + txtIDSanPham.Text + "', '" + txtMau.Text + "', '" + cboKichThuoc.Text + "','" + numSoLuongSP.Value +"','" + txtGiaNhap.Text+"', '" + txtGiaBan.Text+"',N'"+txtTenAnh.Text+"',N'"+txtTenAnhCT.Text+"')";
                ThemCTSP = iiKetNoi.ExcuteQuery(query);
                KetNoiCTSP();
            }
        }
        //Button Thêm chi tiết sản phẩm
        private void btnThemCTSP_Click(object sender, EventArgs e)
        {
            try
            {
                ThemDLCTSP();
                KetNoiCTSP();
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
        }

        //Button Màu
        private void btnMau_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();

            if (c.ShowDialog() == DialogResult.OK)
            {
                txtMau.Text = c.Color.Name;
            }
        }

        //Hàm cập nhật dữ liệu chi tiết sản phẩm
        void CapNhatDLCTSP(string query)
        {
            ChiTietSanPham = iiKetNoi.ExcuteQuery(query);
            KetNoiCTSP();
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
        //Button Cập nhật chi tiết sản phẩm
        private void btnCapNhatCTSP_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "update CHITIETSANPHAM set[ID_SanPham] = '" + txtIDSanPham.Text + "',[Mau] = N'" + txtMau.Text + "',[KichThuoc]= '" + cboKichThuoc.Text + "',[SoLuong] = '"+ numSoLuongSP.Value+"' , [GiaNhap] = '"+ txtGiaNhap.Text+"', [GiaBan] = '"+txtGiaBan.Text+"', [HinhAnh] = N'"+txtTenAnh.Text+"',[HinhAnhChiTiet] = N'"+ txtTenAnhCT.Text + "' where ID_ChiTietSanPham = '" + txtIDChiTietSanPham.Text + "'";
                CapNhatDLCTSP(query);
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
        }

        //Hàm xoá SL Loại Sản Phẩm
        void XoaDLCTSP(string query)
        {
            int size = ChiTietSanPham.Rows.Count;
            ChiTietSanPham = iiKetNoi.ExcuteQuery(query);
            int size2 = ChiTietSanPham.Rows.Count;
            if (size2 < size)
            {
                MessageBox.Show("Bạn đã xoá dữ liệu thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xoá dữ liệu không thành công", "Thông báo");
            }
            KetNoiCTSP();
            HienThiTextbox(0);
        }
        //Button Xoá chi tiết sản phẩm
        private void btnXoaCTSP_Click(object sender, EventArgs e)
        {
            string query = "Delete from CHITIETSANPHAM where ID_ChiTietSanPham = '" + txtIDChiTietSanPham.Text + "'";
            XoaDLCTSP(query);
        }

        //CellClick
        private void dgvChiTietSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            int size = ChiTietSanPham.Rows.Count;
            if (vitri >= 0 && vitri != size)
                HienThiTextbox(vitri);
            HienThiChiTietSP();
        }

        //Text changed
        private void txtIDChiTietSanPham_TextChanged(object sender, EventArgs e)
        {
            if (txtIDChiTietSanPham.Text != "")
            {
                btnThemCTSP.Enabled = true;
            }
            else
                btnThemCTSP.Enabled = false;
        }

        //button thêm ảnh
        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Image = new OpenFileDialog();
                //Image.Filter = "(.jpg);(.png)|.jpg;.png";
                Image.InitialDirectory = Path.GetDirectoryName("Image") + @"\";
                if (Image.ShowDialog() == DialogResult.Yes)
                {
                    Image.ShowDialog();
                }
                if (Image.FileName != "")
                {
                    Bitmap i = new Bitmap(Image.FileName);
                    picAnh.Image = i;
                    picAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                    string[] Name;
                    Name = Image.FileName.Split('\\');
                    txtTenAnh.Text = Name[Name.Count() - 1];
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn lại ảnh!", "Thông Báo");
            }
        }

        //Button Thêm ảnh chi tiết
        private void btnThemAnhChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                txtTenAnhCT.Text = "";
                OpenFileDialog o = new OpenFileDialog();
                o.InitialDirectory = Path.GetFullPath("Image") + @"";
                o.Multiselect = true;
                //if (o.ShowDialog() == DialogResult.Cancel)
                //{
                //    o.ShowDialog();
                //}
                if (o.ShowDialog() == DialogResult.OK)
                {
                    flpAnhChiTiet.Controls.Clear();
                    flpAnhChiTiet.Text = null;
                    int count = o.FileNames.Length;
                    foreach (string f in o.FileNames)
                    {
                        Bitmap a = new Bitmap(f);
                        PictureBox pic = new PictureBox();
                        pic.Image = a;
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Width = 125;
                        pic.Height = 100;
                        pic.BorderStyle = BorderStyle.FixedSingle;
                        flpAnhChiTiet.Controls.Add(pic);
                        string[] tens = f.Split('\\');
    
                        count--;
                        if (count >= 1)
                        {
                            txtTenAnhCT.Text += tens[tens.Count() - 1] + ";";
                        }
                        else
                        {
                            txtTenAnhCT.Text += tens[tens.Count() - 1];
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn lại ảnh!", "Thông Báo");
            }
        }

        //Button tạo mã vạch
        private void btnTaoMaVach_Click(object sender, EventArgs e)
        {
            picBarCode.Image = null;
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            picBarCode.Image = barcode.Draw(txtIDChiTietSanPham.Text, 50);
        }
        //Button lưu mã vạch
        private void btnLuuMaVach_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\Lập trình windows\ĐỒ ÁN\Image Barcode\";
            saveFileDialog1.Title = "Save Image Files";
            saveFileDialog1.DefaultExt = "png";
            saveFileDialog1.Filter = "(.jpg);(.png)|.jpg;.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (picBarCode.Image != null)
                    picBarCode.Image.Save(saveFileDialog1.FileName);
                else
                    MessageBox.Show("Vui Lòng Chọn Ảnh", "Thông Báo");
            }
        }
        //Button thoát
        private void btnThoatCTSP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Hàm xử lý xuất excel
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
                worksheet.Name = "Danh sách Chi Tiết Sản Phẩm";

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
        //Button xuất excel
        private void btnXuatExcelCTSP_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.InitialDirectory = @"C:\Lập trình windows\ĐỒ ÁN\Excel";
            //SaveFileSanPham.Title = "Lưu file ảnh";
            SaveFile.DefaultExt = "xlsx";
            //SaveFileSanPham.Filter = "(.jpg);(.png)|.jpg;.png";
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dgvChiTietSP, SaveFile.FileName, ChiTietSanPham);
            }
        }
    }
}
