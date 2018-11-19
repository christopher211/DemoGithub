using QLCuaHangSuaDAO;
using QLCuaHangSuaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangSuaBUS
{
    public class SanPhamSuaBUS
    {
        public List<SanPhamSuaDTO> DanhSachSua()
        {
            SanPhamSuaDAO suaDAO = new SanPhamSuaDAO();
            return suaDAO.LayDanhSachSua();
        }

        public string LayMaSuaTiepTheo()
        {
            SanPhamSuaDAO suaDAO = new SanPhamSuaDAO();
            string strMaSuaLonNhat = suaDAO.LayMaSuaLonNhat();
            if (string.IsNullOrEmpty(strMaSuaLonNhat))
            {
                return "S0001";
            }
            //Loại bỏ chữ S
            string strMaMax = strMaSuaLonNhat.Replace("S","");
            int somax = int.Parse(strMaMax);
            int matieptheo = somax + 1;
            return "S" + matieptheo.ToString("0000");
        }

        public bool ThemMoiSua(SanPhamSuaDTO suaDTO)
        {
            SanPhamSuaDAO suaDAO = new SanPhamSuaDAO();
            return suaDAO.ThemMoiSPSua(suaDTO);
        }
        public bool CapNhatSua(SanPhamSuaDTO suaDTO)
        {
            SanPhamSuaDAO suaDAO = new SanPhamSuaDAO();
            return suaDAO.CapNhatSPSua(suaDTO);
        }
    }
}
