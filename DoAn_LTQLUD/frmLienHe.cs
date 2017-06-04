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
    public partial class frmLienHe : DevExpress.XtraEditors.XtraForm
    {
        public frmLienHe()
        {
            InitializeComponent();
        }


        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}