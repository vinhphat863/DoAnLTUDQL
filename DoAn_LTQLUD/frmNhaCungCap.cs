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
using BUS;
namespace DoAn_LTQLUD
{
    public partial class frmNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public delegate void SendData(string MaNCC);
        public frmNhaCungCap()
        {
            InitializeComponent();

            gridControl1.DataSource = NhaCungCapBUS.DanhSach();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmThemNCC frm = new frmThemNCC();
            frm.ShowDialog();
            gridControl1.DataSource = NhaCungCapBUS.DanhSach();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int Vitri = gridView1.GetFocusedDataSourceRowIndex();
            string MaNCC = gridView1.GetRowCellValue(Vitri, "MaNCC").ToString();
            frmSuaNCC frm = new frmSuaNCC();
            SendData s = new SendData(frm.GetData);
            s(MaNCC);
            frm.ShowDialog();
            gridControl1.DataSource = NhaCungCapBUS.DanhSach();
        }
    }
}