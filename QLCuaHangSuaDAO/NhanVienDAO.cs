using QLCuaHangSuaDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangSuaDAO
{
    public class NhanVienDAO
    {
        public NhanVienDTO DangNhap(string strTK, string strMK)
        {
            NhanVienDTO nv = null;
            string strQuery = "select * from NhanVien Where MaNV = @TaiKhoan AND Password = @MatKhau AND TrangThai = 1";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlParameter[] arrPars = new SqlParameter[2];
            arrPars[0] = new SqlParameter("@TaiKhoan", strTK);
            arrPars[1] = new SqlParameter("@MatKhau", strMK);
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strQuery, arrPars, conn);
            if(sdr.Read())
            {
                nv = new NhanVienDTO();
                nv.MaNV = sdr["MaNV"].ToString();
                nv.Ho = sdr["Ho"].ToString();
                nv.Ten = sdr["Ten"].ToString();
                nv.NgaySinh = DateTime.Parse(sdr["NgaySinh"].ToString());
                nv.HinhAnh = sdr["HinhAnh"].ToString();
                nv.Password = sdr["Password"].ToString();
                nv.TrangThai = int.Parse(sdr["TrangThai"].ToString());
            }
            sdr.Close();
            conn.Close();
            return nv;
        }
    }
}
