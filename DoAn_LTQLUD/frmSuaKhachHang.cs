using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BUS;
namespace DoAn_LTQLUD
{
    public partial class frmSuaKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmSuaKhachHang()
        {
            InitializeComponent();
            gridLookupKhuVuc.Properties.DataSource = KhuVucBUS.DanhSach();
            gridLookupKhuVuc.Properties.DisplayMember = "TenKhuVuc";
            gridLookupKhuVuc.Properties.ValueMember = "MaKhuVuc";
        }
        public void getData(string MaKH)
        {
            txtMaKH.Text = MaKH;
            KhachHang kh = KhachHangBUS.ChiTietKH(MaKH);
            gridLookupKhuVuc.EditValue = kh.MaKhuVuc;
            txtTenKH.Text = kh.TenKH;
            txtDiaChi.Text = kh.DiaChi;
            txtDienThoai.Text = kh.DienThoai;
            txtEmail.Text = kh.Email;
            txtGioiHanNo.Text = kh.GioiHanNo.ToString();
            txtNoHienTai.Text = kh.NoHienTai.ToString();
            txtTaiKhoan.Text = kh.TaiKhoan;
            txtNganHang.Text = kh.NganHang;
            txtNguoiLienHe.Text = kh.NguoiLienHe;
            txtMaSoThue.Text = kh.MaSoThue;
            if (kh.ConQuanLy == true)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string MaKH = txtMaKH.Text;
            string MaKV = gridLookupKhuVuc.EditValue.ToString();
            string DiaChi = txtDiaChi.Text;
            string MaSoThue = txtMaSoThue.Text;
            string TenKH = txtTenKH.Text;
            string DienThoai = txtDienThoai.Text;
            string Email = txtEmail.Text;
            string TaiKhoan = txtTaiKhoan.Text;
            int GioiHanNo;
            int.TryParse(txtGioiHanNo.Text, out GioiHanNo);
            int NoHienTai;
            int.TryParse(txtNoHienTai.Text, out NoHienTai);
            string NganHang = txtNganHang.Text;
            string NguoiLienHe = txtNguoiLienHe.Text;
            bool ConQuanLy;
            if (checkBox1.Checked == true)
            {
                ConQuanLy = true;
            }
            else
            {
                ConQuanLy = false;
            }
            KhachHangBUS.Sua(MaKH, MaKV, TenKH, DiaChi, MaSoThue, DienThoai, Email, TaiKhoan, GioiHanNo, NoHienTai, NganHang, NguoiLienHe, ConQuanLy);
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}