using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangSuaGUI
{
    public class Utils
    {
        public static string TaoMD5(string strChuoi)
        {
            MD5 md5 = MD5.Create();

            //đổi chuỗi sang mảng byte
            byte[] mangchuoi = Encoding.UTF8.GetBytes(strChuoi);
            //băm mảng chuôi
            byte[] data = md5.ComputeHash(mangchuoi);

            //Mã hóa sang hệ 16
            StringBuilder ketqua = new StringBuilder();
            for(int i = 0; i < data.Length; i++)
            {
                ketqua.Append(data[i].ToString("x2"));
            }
            return ketqua.ToString();
        }
    }
}
