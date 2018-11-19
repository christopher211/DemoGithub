using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangSuaDAO
{
    public class DataProvider
    {
        private static string strChuoiKetNoi = "Data Source = .; Initial Catalog = CuaHangBanSua; Integrated Security = true;";

        public static SqlConnection TaoKetNoi()
        {
            SqlConnection conn = new SqlConnection(strChuoiKetNoi);
            conn.Open();
            return conn;
        }

        public static SqlDataReader TruyVanDuLieu(string strTruyVan, SqlConnection con)
        {
            SqlCommand com = new SqlCommand(strTruyVan, con);
            return com.ExecuteReader();
        }

        public static SqlDataReader TruyVanDuLieu(string strTruyVan, SqlParameter[] pars, SqlConnection con)
        {
            SqlCommand com = new SqlCommand(strTruyVan, con);
            com.Parameters.AddRange(pars);
            return com.ExecuteReader();
        }

        public static bool ThucThiCauLenh(string strCauLenh, SqlConnection con)
        {
            SqlCommand com = new SqlCommand(strCauLenh, con);
            int kq = com.ExecuteNonQuery();
            return kq > 0;
        }

        public static bool ThucThiCauLenh(string strCauLenh, SqlParameter[] pars, SqlConnection con)
        {
            SqlCommand com = new SqlCommand(strCauLenh, con);
            com.Parameters.AddRange(pars);
            int kq = com.ExecuteNonQuery();
            return kq > 0;
        }
    }
}
