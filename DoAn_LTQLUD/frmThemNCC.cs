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
    public partial class frmThemNCC : DevExpress.XtraEditors.XtraForm
    {
        public frmThemNCC()
        {
            InitializeComponent();

            txtMaNCC.Text = NhaCungCapBUS.LayMaNCC();

            gridlookupKhuVuc.Properties.DataSource = KhuVucBUS.DanhSach();
            gridlookupKhuVuc.Properties.DisplayMember = "TenKhuVuc";
            gridlookupKhuVuc.Properties.ValueMember = "MaKhuVuc";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string MaNCC = txtMaNCC.Text;
            string TenNCC = txtTenNCC.Text;
            string MaKhuVuc = gridlookupKhuVuc.EditValue.ToString();
            string DiaChi = txtDiaChi.Text;
            string DienThoai = txtDienThoai.Text;
            string Mobile = txtMobile.Text;
            string Email = txtEmail.Text;
            string TaiKhoan = txtTaiKhoan.Text;
            string NganHang = txtNganHang.Text;
            string Website = txtWebSite.Text;
            string ChucVu = txtChucVu.Text;
            string NguoiLienHe = txtNguoiLienHe.Text;

            int MaSoThue;
            int.TryParse(txtMaSoThue.Text, out MaSoThue);
            int GioiHanNo;
            int.TryParse(txtGioiHanNo.Text,out GioiHanNo);
            int Fax;
            int.TryParse(txtFax.Text, out Fax);
            int NoHienTai;
            int.TryParse(txtNoHienTai.Text, out NoHienTai);
            int ChietKhau;
            int.TryParse(txtChietKhau.Text, out ChietKhau);
            
            
            bool ConQuanLy;
            if (checkBox1.Checked)
            {
                ConQuanLy = true;
            }
            else
            {
                ConQuanLy = false;
            }
            NhaCungCapBUS.Them(MaNCC, TenNCC, MaKhuVuc, DiaChi, MaSoThue, DienThoai, Mobile, Email, TaiKhoan, GioiHanNo, Fax, NganHang, Website, NoHienTai, ChucVu, NguoiLienHe, ChietKhau, ConQuanLy);
        }
    }
}