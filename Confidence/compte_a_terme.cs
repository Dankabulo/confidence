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
    public partial class compte_a_terme : Form
    {
        Form operation = new operation();
        Form personnesA = new PersonnesAt();
        string cs = ConfigurationManager.ConnectionStrings["GESTION"].ConnectionString;
        public compte_a_terme()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);
            string id;

            try
            {
                SqlConnection conn = new SqlConnection(cs);
                string queryn = string.Format("SELECT idproprietaire FROM proprietaire WHERE nom= '"+this.txtnom.Text+"' AND postnom ='"+this.txtpostnom.Text+"' AND prenom='"+this.txtprenom.Text+"'");
                SqlCommand cmdn = new SqlCommand(queryn, conn);
                SqlDataReader sdrn;

                try
                {
                    conn.Open();
                    sdrn = cmdn.ExecuteReader();

                    while (sdrn.Read())
                    {
                        id = sdrn["idproprietaire"].ToString();

                        if (id != "")
                        {

                            string query = "INSERT INTO compte(idproprietaire, type_compte)VALUES((SELECT idproprietaire FROM proprietaire WHERE nom= '" + this.txtnom.Text + "' AND postnom = '"
                         + this.txtpostnom.Text + "' AND prenom= '" + this.txtprenom.Text + "'), 'Compte a terme'); INSERT INTO compte_a_terme(idcompte_ca, date_creation,delai, montant, devise) VALUES((SELECT idcompte FROM compte WHERE idproprietaire ='"+id+"' AND type_compte = 'Compte a terme' ), '" + this.dtdate.Value.ToShortDateString() + "', '"
                         + this.txtdelai.Text + "','" + this.txtmontant.Text + "', '" + this.cmbdevise.SelectedItem + "')";


                            SqlCommand cmd = new SqlCommand(query, con);

                            SqlDataReader sdr;
                            try
                            {
                                con.Open();

                                sdr = cmd.ExecuteReader();
                                MetroFramework.MetroMessageBox.Show(this, "Compte cree avec success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                while (sdr.Read())
                                {
                                    if (sdr.Read())
                                    {
                                        MetroFramework.MetroMessageBox.Show(this, "Please fill all textbox ");
                                    }
                                }
                                con.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                        else {

                            string query = "INSERT INTO proprietaire(nom, postnom, prenom) VALUES('" + this.txtnom.Text + "', '" + this.txtpostnom.Text + "', '"
                            + this.txtprenom.Text + "'); INSERT INTO compte(idproprietaire, type_compte)VALUES((SELECT idproprietaire FROM proprietaire WHERE nom= '" + this.txtnom.Text + "' AND postnom = '"
                            + this.txtpostnom.Text + "' AND prenom= '" + this.txtprenom.Text + "'), 'Compte a terme'); INSERT INTO compte_a_terme(idcompte, date_creation,delai, montant, devise) VALUES((SELECT idcompte FROM compte WHERE idproprietaire =(SELECT idproprietaire FROM proprietaire WHERE nom= '" + this.txtnom.Text + "' AND postnom = '"
                            + this.txtpostnom.Text + "' AND prenom= '" + this.txtprenom.Text + "') ), '" + this.dtdate.Value.ToShortDateString() + "', '"
                            + this.txtdelai.Text + "','" + this.txtmontant.Text + "', '" + this.cmbdevise.SelectedItem + "')";


                            SqlCommand cmd = new SqlCommand(query, con);

                            SqlDataReader sdr;
                            try
                            {
                                con.Open();

                                sdr = cmd.ExecuteReader();
                                MetroFramework.MetroMessageBox.Show(this, "Compte cree avec success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                while (sdr.Read())
                                {
                                    if (sdr.Read())
                                    {
                                        MetroFramework.MetroMessageBox.Show(this, "Please fill all textbox ");
                                    }
                                }
                                con.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }   
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            petitPanel.Visible = false;
            btnlancer.Visible = true;
            bunifuFlatButton3.Visible = false;
            bunifuFlatButton2.Visible = false;
            lbltitre.Text = "Recherche";

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlancer_Click(object sender, EventArgs e)
        {
            lbltitre.Text = "Compte a terme";
            petitPanel.Visible = true;
            bunifuFlatButton1.Visible = false;
            btnlancer.Visible = false;
            //bunifuFlatButton3.Visible = true;
            bunifuFlatButton2.Visible = true;
            bnt_modifier.Visible = true;
            bnt_supprimer.Visible = true;

            SqlConnection con = new SqlConnection(cs);
            string query = string.Format("SELECT * FROM RECHERCHE_COMPTE_CA('"+this.txtnom.Text+"','"+this.txtpostnom.Text+"','"+this.txtprenom.Text+"')");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr;

            try
            {
                con.Open();
                sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    if (string.IsNullOrWhiteSpace(txtnom.Text))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Veuillez saisir le nom du client a rechercher", "Warning Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        txtnom.Text = sdr["nom"].ToString();
                        txtpostnom.Text = sdr["postnom"].ToString();
                        txtpostnom.Text = sdr["postnom"].ToString();
                        txtmontant.Text = sdr["montant"].ToString();
                        cmbdevise.Text = sdr["devise"].ToString();
                        dtdate.Value = Convert.ToDateTime(sdr["date_creation"].ToString());
                        txtdelai.Text = sdr["delai"].ToString();
                    }
                }
            }
            catch
            {

            }
        }

        private void compte_a_terme_Load(object sender, EventArgs e)
        {

        }

        private void bnt_supprimer_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "EXEC DEL_CA '" + this.txtnom.Text + "', '" + this.txtpostnom.Text + "', '" + this.txtprenom.Text + "'";

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader sdr;
            try
            {
                con.Open();

                sdr = cmd.ExecuteReader();
                MetroFramework.MetroMessageBox.Show(this, "Compte supprimer avec success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                while (sdr.Read())
                {
                    if (sdr.Read())
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Please fill all textbox ");
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bnt_modifier_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            bnt_supprimer.Visible = false;
            bunifuFlatButton2.Visible = false;
            bunifuFlatButton4.Visible = true;
            panel11.Visible = true;
            bunifuFlatButton5.Visible = true;
            bnt_modifier.Visible = false;

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            operation.ShowDialog();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "UPDTAE_CA '" + this.txtnom.Text + "', '" + this.txtpostnom.Text + "', '" + this.txtprenom.Text + "', '" 
                    + this.txtdelai.Text + "', '" + this.dtdate.Value.ToShortDateString() +"', '"+this.cmbdevise.SelectedItem+"', '"+this.txt_idcompte.Text+"'";

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader sdr;
            try
            {
                con.Open();

                sdr = cmd.ExecuteReader();
                MetroFramework.MetroMessageBox.Show(this, "Les modifications ont etes enregistrees avec success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                while (sdr.Read())
                {
                    if (sdr.Read())
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Please fill all textbox ");
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
