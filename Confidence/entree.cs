using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace Confidence
{
    public partial class entree : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["GESTION"].ConnectionString;

        Form courant = new CreerCompte();
        Form terme = new compte_a_terme();
        Form Pret = new pret_form();
        recherche recherche = new recherche();
        private static entree _instance;
        public static entree Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new entree();
                return _instance;
            }
        }
        public entree()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            courant.ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            terme.ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            recherche.ShowDialog();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Pret.ShowDialog();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "EXEC montant_caisse";
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader sdr;
            string[] montant = new string[1];

            try
            {
                con.Open();

                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    montant[0] = sdr["nombre"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            other_ressource_form n = new other_ressource_form();
            n.somme_totale(montant[0]);

            n.ShowDialog();
        }
    }
}
