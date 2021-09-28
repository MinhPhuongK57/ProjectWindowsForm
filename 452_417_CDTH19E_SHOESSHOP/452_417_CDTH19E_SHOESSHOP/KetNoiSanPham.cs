using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _452_417_CDTH19E_SHOESSHOP
{
    class KetNoiDuLieu
    {
        private string QuanLyBanGiay = @"Data Source=TRAN-MINH-PHUON\SQLEXPRESS;Initial Catalog=QuanLyBanGiay;Integrated Security=True";
        public DataTable ExcuteQuery(string query)
        {
            SqlConnection iKetNoiDuLieu = new SqlConnection(QuanLyBanGiay);
            iKetNoiDuLieu.Open();
            SqlDataAdapter QLBG = new SqlDataAdapter(query, iKetNoiDuLieu);
            DataTable DanhSach = new DataTable();
            QLBG.Fill(DanhSach);
            iKetNoiDuLieu.Close();
            return DanhSach;
        }
        public int ExcuteNonQuery(string query)
        {
            int NotData = 0;
            SqlConnection iKetNoiDuLieu = new SqlConnection(QuanLyBanGiay);
            iKetNoiDuLieu.Open();
            SqlCommand Command = new SqlCommand(query,iKetNoiDuLieu);
            SqlDataAdapter QLBG = new SqlDataAdapter(Command);
            NotData = Command.ExecuteNonQuery();
            iKetNoiDuLieu.Close();
            return NotData;
        }
    }
}
