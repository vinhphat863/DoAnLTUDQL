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
    public partial class frmThemKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmThemKhachHang()
        {
            InitializeComponent();
            txtMaKH.Text = KhachHangBUS.LayMaKH();
            gridLookupKhuVuc.Properties.DataSource = KhuVucBUS.DanhSach();
            gridLookupKhuVuc.Properties.DisplayMember = "TenKhuVuc";
            gridLookupKhuVuc.Properties.ValueMember = "MaKhuVuc";
        }

        private void ClearAllText()
        {
            txtMaKH.Text = KhachHangBUS.LayMaKH();
            gridLookupKhuVuc.Text = null;
            txtDiaChi.Text = null;
            txtMaSoThue.Text = null;
            txtTenKH.Text = null;
            txtDienThoai.Text = null;
            txtEmail.Text = null;
            txtTaiKhoan.Text = null;
            txtGioiHanNo.Text = null;
            txtNoHienTai.Text = null;
            txtNganHang.Text = null;
            txtNguoiLienHe.Text = null;
            checkBox1.Checked = true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if(checkBox1.Checked == true)
            {
                ConQuanLy = true;
            }
            else
            {
                ConQuanLy = false;
            }

            KhachHangBUS.Them(MaKH, MaKV, TenKH, DiaChi, MaSoThue, DienThoai, Email, TaiKhoan, GioiHanNo, NoHienTai, NganHang, NguoiLienHe, ConQuanLy);
            ClearAllText();
        }
    }
}