using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _452_417_CDTH19E_SHOESSHOP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmDangNhap());
            //Application.Run(new frmTrangChu());
            //Application.Run(new frmTimKiemNhaCungCap());
            //Application.Run(new frmTimKiemKhachHang());
            //Application.Run(new frmTimKiemHoaDon());
            //Application.Run(new frmTimKiemNhanVien());
            //Application.Run(new frmTimKiem());
            Application.Run(new frmChiTietSanPham());
            //Application.Run(new frmChiTietHoaDon());
            //Application.Run(new frmLoaiSanPham());

        }
    }
}
