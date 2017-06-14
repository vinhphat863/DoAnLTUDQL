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
    public partial class frmHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public delegate void SendData(string MaHang);
        public frmHangHoa()
        {
            InitializeComponent();
            gridControl1.DataSource = HangHoaBUS.DanhSach();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmThemHangHoa frm = new frmThemHangHoa();
            frm.ShowDialog();
            gridControl1.DataSource = HangHoaBUS.DanhSach();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int vitri = gridView1.GetFocusedDataSourceRowIndex();
            string MaHang = gridView1.GetRowCellValue(vitri, "MaHang").ToString();
            frmSuaHangHoa frm = new frmSuaHangHoa();
            SendData s = new SendData(frm.GetData);
            s(MaHang);
            frm.ShowDialog();
            gridControl1.DataSource = HangHoaBUS.DanhSach();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            int vitri = gridView1.GetFocusedDataSourceRowIndex();
            string MaHang = gridView1.GetRowCellValue(vitri, "MaHang").ToString();
            HangHoaBUS.Xoa(MaHang);
            gridControl1.DataSource = HangHoaBUS.DanhSach();
        }
    }
}