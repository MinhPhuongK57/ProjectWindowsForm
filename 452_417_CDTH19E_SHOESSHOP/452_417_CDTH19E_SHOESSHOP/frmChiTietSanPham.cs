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

        //Hàm Kết nối chi tiết sản phẩm
        void KetNoiCTSP()
        {
            KetNoiDuLieu iKetNoiCTSP = new KetNoiDuLieu();
            dgvChiTietSP.DataSource = iKetNoiCTSP.ExcuteQuery("select * from CHITIETSANPHAM");
        }
        //Form Load
        private void frmChiTietSanPham_Load(object sender, EventArgs e)
        {
            IDSanPham = iiKetNoi.ExcuteQuery("Select ID_SanPham from SANPHAM");
            for(int i= 0; i < IDSanPham.Rows.Count;i++)
            {
                cboIDSanPham.Items.Add(IDSanPham.Rows[i][0]);
            }   
            btnThemCTSP.Enabled = false;
            ChiTietSanPham = iiKetNoi.ExcuteQuery("Select ID_ChiTietSanPham from CHITIETSANPHAM");
            KetNoiCTSP();
            HienThiTextbox(0);
        }
        void HienThiTextbox(int vitri)
        {
            //Sản Phẩm
            ChiTietSanPham = iiKetNoi.ExcuteQuery("select * from CHITIETSANPHAM");
            txtIDChiTietSanPham.Text = ChiTietSanPham.Rows[vitri][0].ToString();
            cboIDSanPham.Text = ChiTietSanPham.Rows[vitri][1].ToString();
            txtMau.Text = ChiTietSanPham.Rows[vitri][2].ToString();
            txtKichThuoc.Text = ChiTietSanPham.Rows[vitri][3].ToString();
            numSoLuongSP.Value = Convert.ToInt32(ChiTietSanPham.Rows[vitri][4]);
            txtGiaNhap.Text = string.Format("{0:n0}", ChiTietSanPham.Rows[vitri][5]);
            txtGiaBan.Text = string.Format("{0:n0}", ChiTietSanPham.Rows[vitri][6]);
            txtTenAnh.Text = ChiTietSanPham.Rows[vitri][7].ToString();
            string filename = Path.GetFullPath("Image") + @"\";
            //filename += txtTenAnh.Text;
            //Bitmap img = new Bitmap(filename);
            //picAnh.Image = img;
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

        //Key_ SoLuongSP

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
                string query = "insert into CHITIETSANPHAM values('" + txtIDChiTietSanPham.Text + "','" + cboIDSanPham.SelectedItem + "', '" + txtMau.Text + "', '" + txtKichThuoc.Text + "','" + numSoLuongSP.Value +"','" + txtGiaNhap.Text+"', '" + txtGiaBan.Text+"','"+picAnh.Text+"')";
                ThemCTSP = iiKetNoi.ExcuteQuery(query);
                KetNoiCTSP();
            }
        }
        //Button Thêm chi tiết sản phẩm
        private void btnThemCTSP_Click(object sender, EventArgs e)
        {
            ThemDLCTSP();
            KetNoiCTSP();
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
            string query = "update CHITIETSANPHAM set[ID_SanPham] = '" + cboIDSanPham.SelectedItem + "' , [Mau] = N'" + txtMau.Text + "',[KichThuoc]= '" + txtKichThuoc.Text + "',[SoLuong] = '"+ numSoLuongSP.Value+"' , [GiaNhap] = '"+ txtGiaBan.Text+"', [GiaBan] = '"+txtGiaBan.Text+"', [HinhAnh] = '"+picAnh.Text+"' where ID_ChiTietSanPham = '" + txtIDChiTietSanPham.Text + "'";
            CapNhatDLCTSP(query);
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
            if (KiemTraIDCTSP())
            {
                MessageBox.Show("Còn sản phẩm loại này", "Thông báo");
            }
            else
            {
                string query = "Delete from CHITIETSANPHAM where ID_ChiTietSanPham = '" + txtIDChiTietSanPham.Text + "'";
                XoaDLCTSP(query);
            }
        }

        //CellClick
        private void dgvChiTietSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            int size = ChiTietSanPham.Rows.Count;
            if (vitri >= 0 && vitri != size)
                HienThiTextbox(vitri);
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

        //Load ảnh
        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Image = new OpenFileDialog();
                //Image.Filter = "(.jpg);(.png)|.jpg;.png";
                Image.InitialDirectory = Path.GetDirectoryName(@"C:\Lập trình windows\ĐỒ ÁN\452_417_CDTH19E_SHOESSHOP\452_417_CDTH19E_SHOESSHOP\bin\Debug\Image");
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

        private void txtTenAnh_TextChanged(object sender, EventArgs e)
        {
            
        }

        //Button tạo mã vạch
        private void btnTaoMaVach_Click(object sender, EventArgs e)
        {
            picBarCode.Image = null;
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            picBarCode.Image = barcode.Draw(txtIDChiTietSanPham.Text, 50);
        }

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

        private void btnThoatCTSP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
