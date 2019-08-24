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
    public partial class other_ressource_form : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["GESTION"].ConnectionString;
        public other_ressource_form()
        {
            InitializeComponent();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            actionnaire_operation_form n = new actionnaire_operation_form();
            n.ShowDialog();
        }

        public void somme_totale(string sommme)
        {
            this.txt_montant_total.Text = sommme;
            if (this.txt_montant_total.Text == "")
            {
                this.txt_montant_total.Text = "1";
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            

            SqlConnection con = new SqlConnection(cs);
            string query = "EXEC new_actionnaire '"+this.txtnom.Text+"', '"
                +this.txtpostnom.Text+"', '"+this.txtprenom.Text+"', "+this.txt_montant_apport.Text+"";
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader sdr;

            try
            {
                con.Open();
                sdr = cmd.ExecuteReader();
                MetroFramework.MetroMessageBox.Show(this, "l'enregistrement s'est effectué avec success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_montant_apport_TextChanged(object sender, EventArgs e)
        {
            double m_apport = Convert.ToInt32(this.txt_montant_apport.Text);
            double total = m_apport + Convert.ToInt32(this.txt_montant_total.Text);
            double pourcentage = (m_apport / total) * 100;

            if (pourcentage <= 0)
            {
                pourcentage = 0;
            }
            else if (pourcentage > 100)
            {
                pourcentage = 100;
            }
            else
            {
                this.txt_pourcentage_apport.Text = pourcentage.ToString();
            }
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            view_grid_form n = new view_grid_form();
            string requete = "SELECT * FROM actionnaire";
            n.set_requete(requete, "Informations des actionnaires enregistré(e)s");
            n.ShowDialog();
        }
    }
}
