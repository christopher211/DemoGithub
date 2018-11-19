using QLCuaHangSuaBUS;
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
    public partial class frmBanHang : Form
    {
        List<SanPhamSuaDTO> lsSua = new List<SanPhamSuaDTO>();
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            LoadDanhSachSua();
            LoadDanhSachLoaiSua();
        }

        private void LoadDanhSachLoaiSua()
        {
            List<LoaiSuaDTO> lsLoai = (new LoaiSuaBUS()).LayDanhSachLoai();
            cboLoaiSua.DataSource = lsSua;
            cboLoaiSua.DisplayMember = "TenLoai";
            cboLoaiSua.ValueMember = "MaSua";
        }

        private void LoadDanhSachSua()
        {
            lsSua = (new SanPhamSuaBUS()).DanhSachSua().FindAll(item => item.TrangThai == 1);
            colTenSua.DataSource = lsSua;
            colTenSua.DisplayMember = "TenSua";
            colTenSua.ValueMember = "MaSua";
            LoadDSLenListView();
        }

        private void LoadDSLenListView()
        {
            imlSua.ColorDepth = ColorDepth.Depth32Bit;
            imlSua.ImageSize = new Size(60, 60);
            imlSua.Images.Clear();
            lvwSua.LargeImageList = imlSua;
            //Đỗ dữ liệu sữa vào Listview kèm hình ảnh
            for(int i = 0; i < lsSua.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(lsSua[i].TenSua);
                lvi.SubItems.Add(lsSua[i].MaSua);
                //Thêm hình vào ImageList
                if(File.Exists(lsSua[i].HinhAnh))
                {
                    byte[] byteHA = File.ReadAllBytes(lsSua[i].HinhAnh);
                    MemoryStream ms = new MemoryStream(byteHA);
                    Image img =  Image.FromStream(ms);
                    imlSua.Images.Add(img);
                    lvi.ImageIndex = imlSua.Images.Count - 1;
                }
                lvwSua.Items.Add(lvi);

            }
        }
    }
}
