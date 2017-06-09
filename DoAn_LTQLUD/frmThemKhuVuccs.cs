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
    public partial class frmThemKhuVuccs : DevExpress.XtraEditors.XtraForm
    {
        public frmThemKhuVuccs()
        {
            InitializeComponent();
        }

        private void frmThemKhuVuccs_Load(object sender, EventArgs e)
        {
            txtMaKhuVuc.Text = KhuVucBUS.MaKhuVuc();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            KhuVucBUS.Them(txtMaKhuVuc.Text, txtTen.Text, txtGhiChu.Text);
            txtMaKhuVuc.Text = KhuVucBUS.MaKhuVuc();
            txtTen.Text = null;
            txtGhiChu.Text = null;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}