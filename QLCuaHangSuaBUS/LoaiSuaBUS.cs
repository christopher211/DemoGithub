using QLCuaHangSuaDAO;
using QLCuaHangSuaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangSuaBUS
{
    public class LoaiSuaBUS
    {
        public List<LoaiSuaDTO> LayDanhSachLoai()
        {
            LoaiSuaDAO loaiDAO = new LoaiSuaDAO();
            return loaiDAO.LayDanhSachLoaiSua(); 
        }
    }
}
