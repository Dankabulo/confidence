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
    public partial class clients_options : UserControl
    {
        Control lister = new lister();
        Form operation = new operation();
        string cs = ConfigurationManager.ConnectionStrings["GESTION"].ConnectionString;
        private static clients_options _instance;
        public static clients_options Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new clients_options();
                return _instance;
            }
        }
        public clients_options()
        {
            InitializeComponent();     
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            operation.ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            lister.Show();
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;

            try
            {

                if (this.cmbtype.Text == "operations")
                {

                    if (this.cmbcategorie.Text == "Operation de sorties")
                    {
                        try
                        {
                            string requete = "SELECT date_operation, idcompte, type_compte,nom, prenom,type_operation, solde FROM [CONFIDENCEX].[dbo].proprietaire p inner join compte c on p.idproprietaire = c.idproprietaire inner join operation o on c.idcompte = o.idcompte_operation WHERE type_operation = 'Retrait' ";
                            SqlConnection con = new SqlConnection(cs);
                            string query = requete;  //string.Format("SELECT * FROM proprietaire");
                            SqlCommand cmd = new SqlCommand(query, con);
                            con.Open();
                            SqlDataReader sdr = cmd.ExecuteReader();
                            BindingSource source = new BindingSource();
                            source.DataSource = sdr;
                            dataGridView2.DataSource = source;

                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                    else if (this.cmbcategorie.Text == "Operation d'entrees")
                    {
                        string requete = "SELECT date_operation, idcompte, type_compte,nom, prenom,type_operation, solde FROM [CONFIDENCEX].[dbo].proprietaire p inner join compte c on p.idproprietaire = c.idproprietaire inner join operation o on c.idcompte = o.idcompte_operation WHERE type_operation = 'Depot' AND date_operation BETWEEN '" + dtdebut.Value.ToShortDateString() + "' AND '" + this.dtfin.Value.ToShortDateString() + "' ";
                        SqlConnection con = new SqlConnection(cs);
                        string query = requete;  //string.Format("SELECT * FROM proprietaire");
                        SqlCommand cmd = new SqlCommand(query, con);
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        BindingSource source = new BindingSource();
                        source.DataSource = sdr;
                        dataGridView2.DataSource = source;

                        con.Close();
                    }
                }
                else if (this.cmbtype.Text == "comptes")
                {
                    if (this.cmbcategorie.Text == "Comptes courants")
                    {
                        string requete = "SELECT idcompte, type_compte,devise, nom, postnom, prenom, date_creation,montant FROM proprietaire p inner join compte c on p.idproprietaire = c.idproprietaire inner join compte_courant cc on c.idcompte = cc.idcompte_cc WHERE date_creation BETWEEN '" + dtdebut.Value.ToShortDateString() + "' AND '" + this.dtfin.Value.ToShortDateString() + "' ; ";
                        SqlConnection con = new SqlConnection(cs);
                        string query = requete;  //string.Format("SELECT * FROM proprietaire");
                        SqlCommand cmd = new SqlCommand(query, con);
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        BindingSource source = new BindingSource();
                        source.DataSource = sdr;
                        dataGridView2.DataSource = source;

                        con.Close();
                    }
                    else if (this.cmbcategorie.Text == "Comptes  a termes")
                    {
                        string requete = "SELECT idcompte, type_compte,devise, nom, postnom, prenom, date_creation,montant,delai FROM proprietaire p inner join compte c on p.idproprietaire = c.idproprietaire inner join compte_a_terme ca on c.idcompte = ca.idcompte_ca WHERE date_creation BETWEEN '" + dtdebut.Value.ToShortDateString() + "' AND '" + this.dtfin.Value.ToShortDateString() + "'; ";
                        SqlConnection con = new SqlConnection(cs);
                        string query = requete;  //string.Format("SELECT * FROM proprietaire");
                        SqlCommand cmd = new SqlCommand(query, con);
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        BindingSource source = new BindingSource();
                        source.DataSource = sdr;
                        dataGridView2.DataSource = source;

                        con.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
