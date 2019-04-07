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
    public partial class recherche : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["GESTION"].ConnectionString;
        public recherche()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void recherche_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cONFIDENCEXDataSet.compte' table. You can move, or remove it, as needed.
            this.compteTableAdapter.Fill(this.cONFIDENCEXDataSet.compte);
            // TODO: This line of code loads data into the 'cONFIDENCEXDataSet.compte' table. You can move, or remove it, as needed.
            this.compteTableAdapter.Fill(this.cONFIDENCEXDataSet.compte);

        }

        private void cmbcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = string.Format("SELECT nom,postnom,prenom, type_compte FROM proprietaire p inner join compte c on p.idproprietaire = c.idproprietaire inner join compte_a_terme ca on c.idcompte = ca.idcompte_ca inner join compte_courant cc on c.idcompte = cc.idcompte_cc WHERE idcompte = '" + this.cmbcode.Text + "' ");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr;

            try
            {
                con.Open();
                sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    txtnom.Text = sdr["nom"].ToString();
                    txtpostnom.Text = sdr["postnom"].ToString();
                    txtprenom.Text = sdr["prenom"].ToString();
                    txtType.Text = sdr["type_compte"].ToString();
                    lblsolde.Text = sdr["montant"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
