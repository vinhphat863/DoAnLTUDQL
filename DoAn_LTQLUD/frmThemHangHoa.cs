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
    public partial class frmThemHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public frmThemHangHoa()
        {
            InitializeComponent();

            txtMaHang.Text = HangHoaBUS.LayMaHH();
            txtMaVach.Text = HangHoaBUS.LayMaHH();

            gridlookupPhanLoaiHangHoa.Properties.DataSource = PhanLoaiHangHoaBUS.DanhSach();
            gridlookupPhanLoaiHangHoa.Properties.DisplayMember = "TenPhanLoai";
            gridlookupPhanLoaiHangHoa.Properties.ValueMember = "MaPhanLoai";

            gridlookupKho.Properties.DataSource = KhoHangBUS.DanhSach();
            gridlookupKho.Properties.DisplayMember = "Ten";
            gridlookupKho.Properties.ValueMember = "MaKho";

            gridlookupLoaiHangHoa.Properties.DataSource = NhomHangBUS.DanhSach();
            gridlookupLoaiHangHoa.Properties.DisplayMember = "Ten";
            gridlookupLoaiHangHoa.Properties.ValueMember = "MaNHH";

            gridlookupNCC.Properties.DataSource = NhaCungCapBUS.DanhSach();
            gridlookupNCC.Properties.DisplayMember = "TenNCC";
            gridlookupNCC.Properties.ValueMember = "MaNCC";

            gridlookupDonVi.Properties.DataSource = DonViBUS.DanhSach();
            gridlookupDonVi.Properties.DisplayMember = "Ten";
            gridlookupDonVi.Properties.ValueMember = "MaDV";
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            
            string MaHang = txtMaHang.Text;
            string TenHang = txtTenHang.Text;
            string MaPhanLoaiHangHoa = gridlookupPhanLoaiHangHoa.EditValue.ToString();
            string MaLoaiHangHoa = gridlookupLoaiHangHoa.EditValue.ToString();
            string MaKho = gridlookupKho.EditValue.ToString();
            string MaVach = txtMaVach.Text;
            string MaDonVi = gridlookupDonVi.EditValue.ToString();
            string MaNhaCC = gridlookupNCC.EditValue.ToString();
            string XuatXu = txtXuatXu.Text;
            int TonKhoToiThieu;
            int.TryParse(txtTonKhoToiThieu.Text, out TonKhoToiThieu);
            int TonKhoHienTai;
            int.TryParse(txtTonHienTai.Text, out TonKhoHienTai);
            double GiaMua;
            double.TryParse(txtGiaMua.Text, out GiaMua);
            double GiaBanLe;
            double.TryParse(txtGiaBanLe.Text, out GiaBanLe);
            double GiaBanSi;
            double.TryParse(txtGiaBanSi.Text, out GiaBanSi);
            bool ConQuanLy;
            if(checkBox1.Checked == true)
            {
                ConQuanLy = true;
            }
            else
            {
                ConQuanLy = false;
            }
            HangHoaBUS.Them(MaHang, TenHang, MaPhanLoaiHangHoa, MaLoaiHangHoa, MaKho, MaVach, MaDonVi, MaNhaCC, XuatXu, TonKhoToiThieu, TonKhoHienTai, GiaMua, GiaBanLe, GiaBanSi, ConQuanLy);
        }
    }
}