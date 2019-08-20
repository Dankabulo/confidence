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
    public partial class details_operation : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["GESTION"].ConnectionString;
        public details_operation()
        {           
            InitializeComponent();
            SqlConnection con = new SqlConnection(cs);
            string query = string.Format("SELECT * FROM operation_details WHERE id_operation IN(SELECT idopration FROM operation WHERE idcompte_operation = '"
                + this.txt_receive.Text + "') ");
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

        public void receive(string compte)
        {
            txt_receive.Text = compte;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = string.Format("SELECT * FROM operation_details WHERE id_operation IN(SELECT idopration FROM operation WHERE idcompte_operation = '"
                + this.txt_receive.Text + "') ");
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

        private void cmb_mois_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "EXEC " + this.cmb_mois.SelectedItem.ToString() + " " + this.txt_receive.Text + "";      
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
    }
}
