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
    }
}