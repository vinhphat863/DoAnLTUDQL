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
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public delegate void SendData(string MaKH);
        public frmKhachHang()
        {
            InitializeComponent();
            gridControl1.DataSource = KhachHangBUS.DanhSach();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmThemKhachHang frm = new frmThemKhachHang();
            frm.ShowDialog();
            gridControl1.DataSource = KhachHangBUS.DanhSach();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string MaKH = "";
            int vitri = gridView1.GetFocusedDataSourceRowIndex();
            MaKH = gridView1.GetRowCellValue(vitri, "MaKH").ToString();
            frmSuaKhachHang frm = new frmSuaKhachHang();
            SendData s = new SendData(frm.getData);
            s(MaKH);
            frm.ShowDialog();
            gridControl1.DataSource = KhachHangBUS.DanhSach();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            string MaKH = "";
            int vitri = gridView1.GetFocusedDataSourceRowIndex();
            MaKH = gridView1.GetRowCellValue(vitri, "MaKH").ToString();
            KhachHangBUS.Xoa(MaKH);
            gridControl1.DataSource = KhachHangBUS.DanhSach();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}