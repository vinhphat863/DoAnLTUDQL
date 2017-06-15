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
    public partial class frmPhucHoi : DevExpress.XtraEditors.XtraForm
    {
        public frmPhucHoi()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtNameRes.Text;
                string path = txtPathRes.Text;
                string sqlRestore = "Use master Restore Database [PerfectApp] from disk='" + path + "" + name + "'";
                SqlConnection con = new SqlConnection("Data Source=PC;Initial Catalog=PerfectApp;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand(sqlRestore, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Database đã được restore.");

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Restore Database");
                return;
            }
            catch (Exception ex)
            {

            }
        }
    }
}