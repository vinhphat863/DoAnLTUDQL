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

namespace DoAn_LTQLUD
{
    public partial class frmSuaKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        public frmSuaKhuVuc()
        {
            InitializeComponent();
            formKhuVuc frm = new formKhuVuc();
        }

        private void Frm_click(string MaKhuVuc, string TenKhuVuc,string GhiChu)
        {
            txtMaKhuVuc.Text = MaKhuVuc;
            txtTen.Text = TenKhuVuc;
            txtGhiChu.Text = GhiChu;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}