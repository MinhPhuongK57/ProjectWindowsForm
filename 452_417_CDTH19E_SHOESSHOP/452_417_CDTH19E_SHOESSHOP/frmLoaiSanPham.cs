using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _452_417_CDTH19E_SHOESSHOP
{
    public partial class frmLoaiSanPham : Form
    {
        public frmLoaiSanPham()
        {
            InitializeComponent();
            KetNoiLSP();
        }
        //Biến dữ liệu sản phẩm
        KetNoiDuLieu iiKetNoi = new KetNoiDuLieu();
        DataTable LoaiSanPham = new DataTable();
        DataTable TrangThai = new DataTable();
        //Hàm kết nối
        void KetNoiLSP()
        {
            KetNoiDuLieu iKetNoiLSP = new KetNoiDuLieu();
            dgvLoaiSanPham.DataSource = iKetNoiLSP.ExcuteQuery("select * from LOAISANPHAM");
        }

        //FormLoad
        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            cboTrangThaiLSP.Items.Add("Hoạt động");
            cboTrangThaiLSP.Items.Add("Không hoạt động");
            btnThemLoaiSP.Enabled = false;
            LoaiSanPham = iiKetNoi.ExcuteQuery("Select ID_LoaiSanPham from LOAISANPHAM");
            HienThiTextbox(0);
        }
        void HienThiTextbox(int vitri)
        {
            //Sản Phẩm
            LoaiSanPham = iiKetNoi.ExcuteQuery("select * from LOAISANPHAM");
            txtIDLoaiSanPham.Text = LoaiSanPham.Rows[vitri][0].ToString();
            txtTenLoaiSP.Text = LoaiSanPham.Rows[vitri][1].ToString();
            cboTrangThaiLSP.Text = LoaiSanPham.Rows[vitri][2].ToString();
            if (Convert.ToInt32(LoaiSanPham.Rows[vitri][2]) == 1)
            {
                cboTrangThaiLSP.SelectedIndex = 0;
            }
            else
            {
                cboTrangThaiLSP.SelectedIndex = 1;
            }
        }

        //Button Thoát
        private void btnThoatLoaiSP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Hàm kiểm tra ID Loại Sản Phẩm
        bool KiemTraIDLSP()
        {
            string query = "select ID_LoaiSanPham from LOAISANPHAM ";
            LoaiSanPham = iiKetNoi.ExcuteQuery(query);
            int size = LoaiSanPham.Rows.Count;
            for (int i = 0; i < size; i++)
            {
                if (txtIDLoaiSanPham.Text == LoaiSanPham.Rows[i][0].ToString())
                {
                    return true;
                    break;
                }
            }
            return false;
        }
        //FormClosing 
        private void frmLoaiSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ThoatHoi;
            ThoatHoi = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (ThoatHoi == DialogResult.No)
                e.Cancel = true;
        }
        //Hàm thêm DL Loại Sản Phẩm
        void ThemDLLSP()
        {
            if (KiemTraIDLSP())
            {
                MessageBox.Show("ID đã tồn tại", "Thông báo");
            }
            else
            {
                DataTable ThemLSP = new DataTable();
                string query = "insert into LOAISANPHAM values('" + txtIDLoaiSanPham.Text + "', N'" + txtTenLoaiSP.Text + "', '" + cboTrangThaiLSP.SelectedIndex + "')";
                ThemLSP = iiKetNoi.ExcuteQuery(query);
                KetNoiLSP();
            }
        }
        //Button thêm Loại Sản Phẩm
        private void btnThemLoaiSP_Click_1(object sender, EventArgs e)
        {
            try
            {
                ThemDLLSP();
                KetNoiLSP();
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
        }
        //Hàm cập nhật DL Loại Sản Phẩm
        void CapNhatDLLSP(string query)
        {
            LoaiSanPham = iiKetNoi.ExcuteQuery(query);
            KetNoiLSP();
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
        //Button cập nhật Loại Sản Phẩm
        private void btnCapNhatLoaiSP_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "update LOAISANPHAM set[ID_LoaiSanPham] = '" + txtIDLoaiSanPham.Text + "',[TenLoai] = N'" + txtTenLoaiSP.Text + "',[TrangThai]= '" + cboTrangThaiLSP.SelectedIndex + "' where ID_LoaiSanPham = '" + txtIDLoaiSanPham.Text + "'";
                CapNhatDLLSP(query);
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
        }
        //Hàm xoá SL Loại Sản Phẩm
        void XoaDLLSP(string query)
        {
            int size = LoaiSanPham.Rows.Count;
            LoaiSanPham = iiKetNoi.ExcuteQuery(query);
            int size2 = LoaiSanPham.Rows.Count;
            if (size2 < size)
            {
                MessageBox.Show("Bạn đã xoá dữ liệu thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xoá dữ liệu không thành công", "Thông báo");
            }
            KetNoiLSP();
            HienThiTextbox(0);
        }
        //Button xoá Loại Sản Phẩm
        private void btnXoaLoaiLSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (KiemTraIDLSP())
            {
                MessageBox.Show("Còn sản phẩm loại này", "Thông báo");
            }
            else
            {
                string query = "Delete from LOAISANPHAM where ID_LoaiSanPham = '" + txtIDLoaiSanPham.Text + "'";
                XoaDLLSP(query);
            }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại!!!", "Thông báo");
            }
        }

        //Datagridview LoaiSanPham
        private void dgvLoaiSanPham_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            int size = LoaiSanPham.Rows.Count;
            if (vitri >= 0 && vitri != size)
                HienThiTextbox(vitri);
        }

        //Sự kiện TextChange IDLoaiSanPham
        private void txtIDLoaiSanPham_TextChanged_1(object sender, EventArgs e)
        {
            if (txtIDLoaiSanPham.Text != "")
            {
                btnThemLoaiSP.Enabled = true;
            }
            else
                btnThemLoaiSP.Enabled = false;
        }

        //Hàm xuất Excel
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
                worksheet.Name = "Danh sách Loại Sản Phẩm";

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
        //Button xuất Excel
        private void btnXuatExcelCTSP_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.InitialDirectory = @"C:\Lập trình windows\ĐỒ ÁN\Excel";
            //SaveFileSanPham.Title = "Lưu file ảnh";
            SaveFile.DefaultExt = "xlsx";
            //SaveFileSanPham.Filter = "(.jpg);(.png)|.jpg;.png";
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dgvLoaiSanPham, SaveFile.FileName, LoaiSanPham);
            }
        }
    }
}
