using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace Confidence
{
    public partial class view_grid_form : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["GESTION"].ConnectionString;
        public view_grid_form()
        {
            InitializeComponent();
        }
        public void set_requete(string requete, string message)
        {
            this.txt_requete.Text = requete;
            this.lbl_message.Text = message;
        }

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "" + this.txt_requete.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr;
            try
            {
                con.Open();
                sdr = cmd.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = sdr;
                dataGridView1.DataSource = source;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            panel_view_result.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
