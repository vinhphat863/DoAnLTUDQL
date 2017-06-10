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
    public partial class frmSuaKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        public void getData(string Ma,string Ten,string GhiChu)
        {
            txtMaKhuVuc.Text = Ma;
            txtTen.Text = Ten;
            txtGhiChu.Text = GhiChu;
        }
        public frmSuaKhuVuc()
        {
            InitializeComponent();
            
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            KhuVucBUS.Sua(txtMaKhuVuc.Text, txtTen.Text, txtGhiChu.Text);
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}