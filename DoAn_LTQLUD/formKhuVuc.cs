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
            string ghichu = "";
            int vitri = gridView1.GetFocusedDataSourceRowIndex();
            string ma = gridView1.GetRowCellValue(vitri, "MaKhuVuc").ToString();
            string ten = gridView1.GetRowCellValue(vitri, "TenKhuVuc").ToString();
            if(!string.IsNullOrEmpty(gridView1.GetRowCellValue(vitri, "GhiChu").ToString())){
                ghichu = gridView1.GetRowCellValue(vitri, "GhiChu").ToString();
            }
            frmSuaKhuVuc frm = new frmSuaKhuVuc();
            frm.ShowDialog();
        }
    }
}