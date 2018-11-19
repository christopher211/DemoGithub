using QLCuaHangSuaDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangSuaGUI
{
    public partial class frmMain : Form
    {
        bool isDangNhap;
        public NhanVienDTO nhanvienDN = null;
        frmSua frmS;
        frmDangNhap frmDN;
        frmBanHang frmBH;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmDN = new frmDangNhap();
            frmDN.MdiParent = this;
            frmDN.Dock = DockStyle.Fill;
            frmDN.Show();
            lblMaNV.Text = "";
            picHANV.Image = null;
            KiemTraDangNhap();
        }

        private void KiemTraDangNhap()
        {
            if(isDangNhap)
            {
                mnuMain.Enabled = true;
                btnDNDX.Text = "ĐĂNG XUẤT";
                btnDNDX.Image = QLCuaHangSuaGUI.Properties.Resources.DangXuat;
            }
            else
            {
                mnuMain.Enabled = false;
                btnDNDX.Text = "ĐĂNG NHẬP";
                btnDNDX.Image = QLCuaHangSuaGUI.Properties.Resources.DangNhap;
            }
        }

        internal void SetDangNhapThanhCong()
        {
            isDangNhap = true;
            KiemTraDangNhap();
            lblMaNV.Text = nhanvienDN.MaNV;
            if(File.Exists(nhanvienDN.HinhAnh))
            {
                byte[] byteHA = File.ReadAllBytes(nhanvienDN.HinhAnh);
                MemoryStream ms = new MemoryStream(byteHA);
                picHANV.Image = Image.FromStream(ms);
            }
        }

        private void btnDNDX_Click(object sender, EventArgs e)
        {
            if(isDangNhap)
            {
                //Trường hợp đã đăng nhập--> trở thành đăng xuất
                isDangNhap = false;
                picHANV.Image = null;
                lblMaNV.Text = "";
                KiemTraDangNhap();
                XoaTatCaFormCon();
            }
            else
            {
                //Chưa đăng nhập hoặc đăng nhập không thành công
                //Mở form đăng nhập lên
                //Nếu form chưa được mở/ hoặc đã đóng thì khởi tạo
                if(frmDN == null || frmDN.IsDisposed) //chưa khởi tạo hoặc form đã đóng
                {
                    frmDN = new frmDangNhap();
                    frmDN.MdiParent = this;
                    frmDN.Dock = DockStyle.Fill;
                }
                frmDN.Show();
            }
        }

        private void mniSua_Click(object sender, EventArgs e)
        {
            XoaTatCaFormCon();
            if (frmS == null || frmDN.IsDisposed) //chưa khởi tạo hoặc form đã đóng
            {
                frmS = new frmSua();
                frmS.MdiParent = this;
                frmS.Dock = DockStyle.Fill;
            }
            frmS.Show();
        }

        private void XoaTatCaFormCon()
        {
            foreach(Form f in this.MdiChildren)
            {
                //Nếu form đang mở thì mới đóng
                if(f!=null && !f.IsDisposed)
                {
                    f.Close();
                }
            }
        }

        private void mniBH_Click(object sender, EventArgs e)
        {
            XoaTatCaFormCon();
            if (frmBH == null || frmBH.IsDisposed) //chưa khởi tạo hoặc form đã đóng
            {
                frmBH = new frmBanHang();
                frmBH.MdiParent = this;
                frmBH.Dock = DockStyle.Fill;
            }
            frmBH.Show();
        }
    }
}
