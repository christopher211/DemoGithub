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
    public partial class frmSua : Form
    {
        List<LoaiSuaDTO> lsLoai = new List<LoaiSuaDTO>();
        List<SanPhamSuaDTO> lsSua = new List<SanPhamSuaDTO>();
        SanPhamSuaBUS suaBUS = new SanPhamSuaBUS();
        SanPhamSuaDTO suachon = null;
        string pathHA = "Dulieu/Spham/";
        public frmSua()
        {
            InitializeComponent();
        }

        private void frmSua_Load(object sender, EventArgs e)
        {
            dgvSua.AutoGenerateColumns = false;
            LoadDanhSachLoaiSua();
            LoadDanhSachSua();
        }

        private void LoadDanhSachSua()
        {
            lsSua = suaBUS.DanhSachSua();
            dgvSua.DataSource = lsSua;
        }

        private void LoadDanhSachLoaiSua()
        {
            LoaiSuaBUS loaiBUS = new LoaiSuaBUS();
            lsLoai = loaiBUS.LayDanhSachLoai();

            cboLoaiSua.DataSource = lsLoai;
            cboLoaiSua.DisplayMember = "TenLoai";
            cboLoaiSua.ValueMember = "MaLoai";

            colLoai.DataSource = lsLoai;
            colLoai.DisplayMember = "TenLoai";
            colLoai.ValueMember = "MaLoai";
        }

        private void dgvSua_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvSua.SelectedRows.Count > 0)
            {
                suachon = (SanPhamSuaDTO)dgvSua.SelectedRows[0].DataBoundItem;
            }
            else
            {
                suachon = null;
            }

            BindingChiTiet();
        }

        private void BindingChiTiet()
        {
            if(suachon != null)
            {
                txtMaSua.Text = suachon.MaSua;
                txtTenSua.Text = suachon.TenSua;
                txtGia.Text = suachon.GiaBan.ToString("#,##0");
                txtNSX.Text = suachon.NhaSanXuat;
                rtbMoTa.Text = suachon.MoTa;
                cboLoaiSua.SelectedValue = suachon.MaLoai;
                chkKinhdoanh.Checked = (suachon.TrangThai == 1);
                if(File.Exists(suachon.HinhAnh))
                {
                    byte[] HA = File.ReadAllBytes(suachon.HinhAnh);
                    MemoryStream ms = new MemoryStream(HA);
                    pboHAnh.Image = Image.FromStream(ms);
                }
                else
                {
                    pboHAnh.Image = null;
                }
            }
            else
            {
                txtMaSua.Text = "";
                txtTenSua.Text = "";
                txtGia.Text = "0";
                txtNSX.Text = "";
                rtbMoTa.Text = "";
                cboLoaiSua.SelectedIndex = -1;
                pboHAnh.Image = null;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvSua.ClearSelection();

            //Cách 1: sử dụng phát sinh nhờ thao tác truy vấn CSDL
            //txtMaSua.Text = suaBUS.LayMaSuaTiepTheo();

            //Cách 2: dựa vào danh sách sữa
            if (lsSua.Count == 0)
            {
                txtMaSua.Text = "S0001";
            }
            else
            {
                string strMaLonNhat = lsSua.Max(o => o.MaSua);
                int matieptheo = int.Parse(strMaLonNhat.Replace("S", "")) + 1;
                txtMaSua.Text = "S" + matieptheo.ToString("0000");
            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (suachon == null)
            {
                GetDataChiTiet();
                if (suaBUS.ThemMoiSua(suachon))
                {
                    if (pboHAnh.Image != null)
                    {
                        pboHAnh.Image.Save(suachon.HinhAnh);
                    }
                    MessageBox.Show("Thêm mới thành công");

                    LoadDanhSachSua();
                }
                else
                {
                    MessageBox.Show("Thêm mới thất bại");
                    suachon = null;
                }
            }

        }

        private void GetDataChiTiet()
        {
            if(suachon == null)
            {
                suachon = new SanPhamSuaDTO();
            }
            suachon.MaSua = txtMaSua.Text;
            suachon.TenSua = txtTenSua.Text;
            suachon.GiaBan = int.Parse(txtGia.Text.ToString().Replace(",", ""));
            suachon.MaLoai = int.Parse(cboLoaiSua.SelectedValue.ToString());
            suachon.NhaSanXuat = txtNSX.Text;
            suachon.MoTa = rtbMoTa.Text;
            suachon.TrangThai = chkKinhdoanh.Checked ? 1 : 0;
            suachon.HinhAnh = pathHA + suachon.MaSua + ".png";
        }

        private void pboHAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "Hình ảnh | *.png; *.jpg";
            DialogResult dr = ofd.ShowDialog();
            if(dr == DialogResult.Cancel)
            {
                pboHAnh.Image = null;
            }
            else
            {
                byte[] HA = File.ReadAllBytes(ofd.FileName);
                MemoryStream ms = new MemoryStream(HA);
                pboHAnh.Image = Image.FromStream(ms);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(suachon != null)
            {
                GetDataChiTiet();
                if (suaBUS.CapNhatSua(suachon))
                {
                    if (pboHAnh.Image != null)
                    {
                        pboHAnh.Image.Save(suachon.HinhAnh);
                    }
                    MessageBox.Show("Cập nhật thành công");

                    LoadDanhSachSua();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
        }
    }
}
