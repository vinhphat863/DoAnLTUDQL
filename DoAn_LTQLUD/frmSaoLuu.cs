using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DoAn_LTQLUD
{
    public partial class frmSaoLuu : DevExpress.XtraEditors.XtraForm
    {
        public frmSaoLuu()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtNameBAK.Text;
                string path = txtPathBAK.Text;
                string sqlBackup = "BACKUP DATABASE [PerfectApp] TO DISK='" + path + "" + name + "'";
                SqlConnection con = new SqlConnection("Data Source=PC;Initial Catalog=PerfectApp;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand(sqlBackup, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Đã backup cơ sở dữ liệu");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Backup Database");
                return;
            }
            catch (Exception ex)
            {

            }
        }
    }
}