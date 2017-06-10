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
using DoAn_LTQLUD.BUS;

namespace DoAn_LTQLUD
{
    public partial class formKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        public delegate void SendData(string Ma, string Ten, string GhiChu);
        public formKhuVuc()
        {
            InitializeComponent();
        }

        private void formKhuVuc_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = KhuVucBUS.DanhSach();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmThemKhuVuccs frmThem = new frmThemKhuVuccs();
            frmThem.ShowDialog();
            gridControl1.DataSource = KhuVucBUS.DanhSach();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string gc = "";
            string ma = "";
            string ten = "";
            int vitri = gridView1.GetFocusedDataSourceRowIndex();
            ma = gridView1.GetRowCellValue(vitri, "MaKhuVuc").ToString();
            ten = gridView1.GetRowCellValue(vitri, "TenKhuVuc").ToString();
            if (gridView1.GetRowCellValue(vitri, "GhiChu") != null)
            {
                gc = gridView1.GetRowCellValue(vitri, "GhiChu").ToString();
            }
            frmSuaKhuVuc frm = new frmSuaKhuVuc();
            SendData s = new SendData(frm.getData);
            s(ma, ten, gc);
            frm.ShowDialog();
            gridControl1.DataSource = KhuVucBUS.DanhSach();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            int vitri = gridView1.GetFocusedDataSourceRowIndex();
            KhuVucBUS.Xoa(gridView1.GetRowCellValue(vitri, "MaKhuVuc").ToString());
            gridControl1.DataSource = KhuVucBUS.DanhSach();
        }
    }
}