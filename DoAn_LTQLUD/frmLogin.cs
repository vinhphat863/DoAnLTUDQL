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
using DoAn_LTQLUD.DAO;

namespace DoAn_LTQLUD
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string userName = txb_username.Text;
            string passWord = txb_password.Text;
            if (Login(userName, passWord))
            {
                MainView w1 = new MainView();
                w1.Owner = this;
                this.Hide();
                w1.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Password Sai Bét");
            }
        }
        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Close();
            frm.Show();
        }
    }
}