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
            bool ConQuanLy;
            if(checkBox1.Checked == true)
            {
                ConQuanLy = true;
            }
            else
            {
                ConQuanLy = false;
            }
            KhuVucBUS.Them(txtMaKhuVuc.Text, txtTen.Text, txtGhiChu.Text,ConQuanLy);
            txtMaKhuVuc.Text = KhuVucBUS.MaKhuVuc();
            txtTen.Text = null;
            txtGhiChu.Text = null;
            checkBox1.Checked = true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}