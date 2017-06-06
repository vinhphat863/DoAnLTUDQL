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
            if (UserBUS.CheckTaiKhoan(userName,passWord) == true)
            {
                MainView frm = new MainView();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài Khoản Không Đúng Vui Lòng Kiểm Tra Lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                string userName = txb_username.Text;
                string passWord = txb_password.Text;
                if (UserBUS.CheckTaiKhoan(userName, passWord) == true)
                {
                    MainView frm = new MainView();
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài Khoản Không Đúng Vui Lòng Kiểm Tra Lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}