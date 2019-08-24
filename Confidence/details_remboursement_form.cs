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
    public partial class details_remboursement_form : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["GESTION"].ConnectionString;
        public details_remboursement_form()
        {
            InitializeComponent();
            this.txt_id_pret.Text = "";
        }

        public void set_id_pret(string id)
        {
            this.txt_id_pret.Text = id;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "EXEC details_operation "+this.txt_id_pret.Text+"";
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
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
