using QLCuaHangSuaDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangSuaDAO
{
    public class LoaiSuaDAO
    {
        public List<LoaiSuaDTO> LayDanhSachLoaiSua()
        {
            List<LoaiSuaDTO> lsResult = new List<LoaiSuaDTO>();
            string strQuery = "Select * From LoaiSua";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strQuery, conn);
            while(sdr.Read())
            {
                LoaiSuaDTO loai = new LoaiSuaDTO();
                loai.MaLoai = int.Parse(sdr["MaLoai"].ToString());
                loai.TenLoai = sdr["TenLoai"].ToString();
                loai.TrangThai = int.Parse(sdr["TrangThai"].ToString());
                lsResult.Add(loai);
            }

            sdr.Close();
            conn.Close();

            return lsResult;
        }
    }
}
