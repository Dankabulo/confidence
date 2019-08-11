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
    public partial class new_form_operation : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["GESTION"].ConnectionString;
        public new_form_operation()
        {
            InitializeComponent();
        }
        public List<string> execution(string procedure)
        {
            //traitement de la date depuis sql server, pour updater la table dtails

            SqlConnection con = new SqlConnection(cs);
            string query = "EXEC " + procedure + " " + this.txtcompte.Text + ", '" + this.cmboperation.SelectedItem + "', "
                + this.txtsolde.Text + ", '" + this.dtdate_creation.Value.ToShortDateString() + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader sdr;
            List<string> retour = new List<string>();
            try
            {
                con.Open();

                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    //txt_ctrl.Text = sdr["nombre"].ToString();
                    //txt_montant_banque.Text = sdr["deux"].ToString();
                    retour.Add(sdr["nombre"].ToString());
                    retour.Add(sdr["deux"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return retour;
        }

        public void receive_compte(string compte)
        {
            txtcompte.Text = compte;
        }

        public string type_compte(string compte)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "EXEC type_compte '" + this.txtcompte.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            string[] retour = new string[1];
            SqlDataReader sdr;

            try
            {
                con.Open();

                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    retour[0] = sdr["trois"].ToString();
                }
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return retour[0];
        }

        public List<string> year_m(string date)
        {
            // Recuperation de la l'annee ainsi que du mois les tout dans une liste PLUS NECESSAIRE

            SqlConnection con = new SqlConnection(cs);
            string query = "EXEC year_m '" + this.dtdate_creation.Value.ToShortDateString() + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            List<string> n = new List<string>();
            SqlDataReader sdr;

            try
            {
                con.Open();

                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    n.Add(sdr["trois"].ToString());
                    n.Add(sdr["nom"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return n;
        }
        private void materialRaisedButton10_Click(object sender, EventArgs e)
        {

            
            // insertion

            txt_ctrl.Text = "";

            if (cmboperation.SelectedItem.ToString() == "Retrait")
            {
                string type = type_compte(txtcompte.Text);
                if (type == "compte courant")
                {
                    List<string> k = execution("premier");
                    string[] t = k.ToArray();

                    if (t[0] == "111")
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Operation non effectuee, le solde : " + this.txtsolde.Text + " est superieure au montant en compte  : " + t[1], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (t[0] == "")
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Operation effectuee  ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (type == "Compte a terme")
                {
                    List<string> k = execution("deuxieme");
                    string[] t = k.ToArray();

                    if (t[0] == "111")
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Operation non effectuee, le solde : " + this.txtsolde.Text + " est superieure au montant en compte  : " + t[1], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (t[0] == "")
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Operation effectuee  ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else if (cmboperation.SelectedItem.ToString() == "Depot")
            {
                execution("op");
                MetroFramework.MetroMessageBox.Show(this, "Operation effectuee  ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
