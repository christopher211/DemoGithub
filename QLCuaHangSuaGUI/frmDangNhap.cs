using QLCuaHangSuaBUS;
using QLCuaHangSuaDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangSuaGUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTK.Text.Trim() == "" || txtMK.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin tài khoản");
            }
            else
            {
                NhanVienBUS nvBUS = new NhanVienBUS();
                NhanVienDTO nvdn = nvBUS.NhanVienDangNhap(txtTK.Text, Utils.TaoMD5(txtMK.Text));
                if(nvdn != null)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    frmMain f = (frmMain)this.MdiParent;
                    f.nhanvienDN = nvdn;
                    f.SetDangNhapThanhCong();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                }
            }
        }
    }
}
