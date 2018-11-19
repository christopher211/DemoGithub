using QLCuaHangSuaDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangSuaDAO
{
    public class SanPhamSuaDAO
    {
        public List<SanPhamSuaDTO> LayDanhSachSua()
        {
            List<SanPhamSuaDTO> lsResult = new List<SanPhamSuaDTO>();
            string strQuery = "Select * From SanPhamSua";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strQuery, conn);
            while(sdr.Read())
            {
                SanPhamSuaDTO sua = new SanPhamSuaDTO();
                sua.MaSua = sdr["MaSua"].ToString();
                sua.TenSua = sdr["TenSua"].ToString();
                sua.GiaBan = int.Parse(sdr["GiaBan"].ToString());
                sua.NhaSanXuat = sdr["NhaSanXuat"].ToString();
                sua.MaLoai = int.Parse(sdr["MaLoai"].ToString());
                sua.MoTa = sdr["MoTa"].ToString();
                sua.HinhAnh = sdr["HinhAnh"].ToString();
                sua.TrangThai = int.Parse(sdr["TrangThai"].ToString());
                lsResult.Add(sua);
            }
            sdr.Close();
            conn.Close();

            return lsResult;
        }

        public string LayMaSuaLonNhat()
        {
            string strResult = null;
            string strQuery = "Select MAX(MaSua) From SanPhamSua";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strQuery, conn);
            if(sdr.Read())
            {
                strResult = sdr[0].ToString();
            }
            sdr.Close();
            conn.Close();
            return strResult;
        }
        public bool ThemMoiSPSua(SanPhamSuaDTO sua)
        {
            string strInsert = "Insert Into SanPhamSua ([MaSua],[TenSua],[GiaBan],[MaLoai],[HinhAnh],[NhaSanXuat],[MoTa],[TrangThai]) " +
                " Values (@MaSua,@TenSua,@GiaBan,@MaLoai,@HinhAnh,@NhaSanXuat,@MoTa,@TrangThai)";
            SqlParameter[] pars = new SqlParameter[8];
            pars[0] = new SqlParameter("@MaSua", sua.MaSua);
            pars[1] = new SqlParameter("@TenSua", sua.TenSua);
            pars[2] = new SqlParameter("@GiaBan", sua.GiaBan);
            pars[3] = new SqlParameter("@MaLoai", sua.MaLoai);
            pars[4] = new SqlParameter("@HinhAnh", sua.HinhAnh);
            pars[5] = new SqlParameter("@NhaSanXuat", sua.NhaSanXuat);
            pars[6] = new SqlParameter("@MoTa", sua.MoTa);
            pars[7] = new SqlParameter("@TrangThai", sua.TrangThai);

            SqlConnection conn = DataProvider.TaoKetNoi();
            
            return DataProvider.ThucThiCauLenh(strInsert, pars,conn);
        }

        public bool CapNhatSPSua(SanPhamSuaDTO sua)
        {
            string strUpdate = "Update SanPhamSua Set TenSua=@TenSua,GiaBan=@GiaBan,MaLoai=@MaLoai,HinhAnh=@HinhAnh," +
                "NhaSanXuat=@NhaSanXuat,MoTa=@MoTa,TrangThai=@TrangThai Where MaSua = @MaSua";
            SqlParameter[] pars = new SqlParameter[8];
            pars[0] = new SqlParameter("@MaSua", sua.MaSua);
            pars[1] = new SqlParameter("@TenSua", sua.TenSua);
            pars[2] = new SqlParameter("@GiaBan", sua.GiaBan);
            pars[3] = new SqlParameter("@MaLoai", sua.MaLoai);
            pars[4] = new SqlParameter("@HinhAnh", sua.HinhAnh);
            pars[5] = new SqlParameter("@NhaSanXuat", sua.NhaSanXuat);
            pars[6] = new SqlParameter("@MoTa", sua.MoTa);
            pars[7] = new SqlParameter("@TrangThai", sua.TrangThai);

            SqlConnection conn = DataProvider.TaoKetNoi();

            return DataProvider.ThucThiCauLenh(strUpdate, pars, conn);
        }
    }
}
