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
    public partial class actionnaire_operation_form : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["GESTION"].ConnectionString;

        public actionnaire_operation_form()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            panel_gridview_actionnaire.Visible = true;
        }

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = string.Format("SELECT 'Numero identifiant actionnaire'= id_actionnaire, nom, postnom, prenom,'Apport'= montant_apport FROM actionnaire");
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
            panel_gridview_actionnaire.Visible = true;

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "EXEC find_for_actionnaire "+this.txt_search.Text+"";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr;
            string[] tab = new string[3];
            try
            {
                con.Open();

                sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    lbl_identifiant.Text = sdr["nombre"].ToString();
                    lbl_identifiant_2.Text = sdr["nombre"].ToString();
                    tab[0] = sdr["num_1"].ToString();
                    tab[1] = sdr["num_2"].ToString();
                    tab[2] = sdr["num_3"].ToString();
                   
                }
                con.Close();

                double somme = Convert.ToDouble(tab[0]);
                double m_apport = Convert.ToDouble(tab[1]);
                double somme_immobilier = Convert.ToDouble(tab[2]);

                double pourcentage = (m_apport / somme ) *100;
                double val_acq_est = (somme_immobilier /100 ) *pourcentage;
                this.txt_val_acq_estm.Text = val_acq_est.ToString();
                this.lbl_pourcentage.Text = pourcentage.ToString();

                tabPage1.Show();


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
