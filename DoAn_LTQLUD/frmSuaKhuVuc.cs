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
using DTO;
namespace DoAn_LTQLUD
{
    public partial class frmSuaKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        public void getData(string Ma,string Ten,string GhiChu,bool ConQuanLy)
        {
            txtMaKhuVuc.Text = Ma;
            txtTen.Text = Ten;
            txtGhiChu.Text = GhiChu;
            if(ConQuanLy == true)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }
        public frmSuaKhuVuc()
        {
            InitializeComponent();
            
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bool ConQuanLy;
            if (checkBox1.Checked)
            {
                ConQuanLy = true;
            }
            else
            {
                ConQuanLy = false;
            }
            KhuVucBUS.Sua(txtMaKhuVuc.Text, txtTen.Text, txtGhiChu.Text,ConQuanLy);
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}