﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using BUS;
namespace DoAn_LTQLUD
{
    public partial class frmMuaHang : DevExpress.XtraEditors.XtraForm
    {
        public frmMuaHang()
        {
            InitializeComponent();
            
            repositoryItemGridLookUpEdit8.DataSource = PhieuTempBUS.DanhSachHangHienThi();
            repositoryItemGridLookUpEdit8.NullText = "";
            repositoryItemGridLookUpEdit8.DisplayMember = "MaHang";
            repositoryItemGridLookUpEdit8.ValueMember = "MaHang";

            repositoryItemGridLookUpEdit9.DataSource = PhieuTempBUS.DanhSachHangHienThi();
            repositoryItemGridLookUpEdit9.NullText = "";
            repositoryItemGridLookUpEdit9.DisplayMember = "TenHang";
            repositoryItemGridLookUpEdit9.ValueMember = "MaHang";

            repositoryItemGridLookUpEdit10.DataSource = PhieuTempBUS.DanhSachHangHienThi();
            repositoryItemGridLookUpEdit10.NullText = "";
            repositoryItemGridLookUpEdit10.DisplayMember = "TenDonVi";
            repositoryItemGridLookUpEdit10.ValueMember = "MaDonVi";

            gridControl2.DataSource = PhieuTempBUS.DanhSach();

            txtNCC.Properties.DataSource = NhaCungCapBUS.DanhSach();
            txtNCC.Properties.DisplayMember = "TenNCC";
            txtNCC.Properties.ValueMember = txtMaNCC.Properties.ValueMember;
            txtNCC.Properties.EditValueChanged += Properties_EditValueChanged;
            txtNCC.Properties.NullText = "";

            txtMaNCC.Properties.DataSource = NhaCungCapBUS.DanhSach();
            txtMaNCC.Properties.DisplayMember = "MaNCC";
            txtMaNCC.Properties.ValueMember = "MaNCC";
            txtMaNCC.Properties.EditValueChanged += Properties_EditValueChanged1;
            txtMaNCC.Properties.NullText = "";

            txtPhieu.Text = PhieuNhapHangBUS.LayMaPhieu();

            txtNhanVien.Properties.DataSource = NhanVienBUS.DanhSach();
            txtNhanVien.Properties.DisplayMember = "Ten";
            txtNhanVien.Properties.ValueMember = "MaNV";

            txtDieuKhoanTT.Properties.DataSource = DieuKhoanThanhToanBUS.DanhSach();
            txtDieuKhoanTT.Properties.DisplayMember = "TenDKTT";
            txtDieuKhoanTT.Properties.ValueMember = "MaDKTT";

            txtHinhThucTT.Properties.DataSource = HinhThucThanhToanBUS.DanhSach();
            txtHinhThucTT.Properties.DisplayMember = "TenHTTT";
            txtHinhThucTT.Properties.ValueMember = "MaHTTT";

            txtKho.Properties.DataSource = KhoHangBUS.DanhSach();
            txtKho.Properties.DisplayMember = "Ten";
            txtKho.Properties.ValueMember = "MaKho";
        }

        private void ClearAllTxt()
        {
            txtMaNCC.Text = null;
            txtNCC.Text = null;
            txtDiaChi.Text = null;
            txtDienThoai.Text = null;
            txtDieuKhoanTT.Text = null;
            txtGhiChu.Text = null;
            txtHinhThucTT.Text = null;
            txtHoaDonVAT.Text = null;
            txtKho.Text = null;
            txtNhanVien.Text = null;
            txtPhieu.Text = PhieuNhapHangBUS.LayMaPhieu();
            txtPhieuVietTay.Text = null;
            Ngay.Text = null;
            HanTT.Text = null;
            gridControl2.DataSource = PhieuTempBUS.DanhSach();
        }

        private void Properties_EditValueChanged1(object sender, EventArgs e)
        {
            int vitri = txtMaNCC.Properties.GetIndexByKeyValue(txtMaNCC.EditValue);
            txtNCC.EditValue = txtNCC.Properties.GetKeyValue(vitri);
        }

        private void Properties_EditValueChanged(object sender, EventArgs e)
        {
            int vitri = txtNCC.Properties.GetIndexByKeyValue(txtNCC.EditValue);
            txtMaNCC.EditValue = txtMaNCC.Properties.GetKeyValue(vitri);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            PhieuNhapHangBUS.Them(txtPhieu.Text, txtMaNCC.EditValue.ToString(), txtDiaChi.Text, txtDienThoai.Text, Ngay.DateTime, txtGhiChu.Text, txtHoaDonVAT.Text, txtPhieuVietTay.Text, txtNhanVien.EditValue.ToString(), txtKho.EditValue.ToString(), txtDieuKhoanTT.EditValue.ToString(), txtHinhThucTT.EditValue.ToString(), HanTT.DateTime);
            for (int i = 0; i < gridView2.RowCount - 1; i++)
            {
                string MaHang = gridView2.GetRowCellValue(i, "MaHang").ToString();
                string MaDonVi = gridView2.GetRowCellValue(i, "TenDonVi").ToString();
                int SoLuong = (int)gridView2.GetRowCellValue(i, "SoLuong");
                double DonGia = (double)gridView2.GetRowCellValue(i, "DonGia");
                string GhiChu = gridView2.GetRowCellValue(i, "GhiChu").ToString();
                ChiTietPhieuNhapHangBUS.Them(txtPhieu.Text, MaHang, MaDonVi, SoLuong, DonGia, GhiChu);
            }
            ClearAllTxt();
        }
    } 
}