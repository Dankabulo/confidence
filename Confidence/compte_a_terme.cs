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
            // insertion cas d'un compte type a terme   
            txt_compte_existae.Text = "";
            txt_idproprietaire.Text = "";   // mise a vide du champ txt_idproprietaire

            SqlConnection con = new SqlConnection(cs);
            string query = "EXEC CC_recherche '" + this.txtnom.Text+"', '"+this.txtpostnom.Text+"', '"+this.txtprenom.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader sdr;
            try
            {
                con.Open();
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    txt_idproprietaire.Text = sdr["idproprietaire"].ToString();
                }
                con.Close();

                if (this.txt_idproprietaire.Text == "")
                {
                    SqlConnection con1 = new SqlConnection(cs);
                    string query1 = "EXEC CC_insertionCA '" + this.txtnom.Text + "', '" + this.txtpostnom.Text + "', '" 
                        + this.txtprenom.Text + "', "+this.txtmontant.Text+", '"+this.cmbdevise.SelectedItem+"', '"+this.dtdate.Value.ToShortDateString()+"', '"+this.txtdelai.Text+"' ";
                   
                    SqlCommand cmd1 = new SqlCommand(query1, con1);
                    SqlDataReader sdr1;
                    
                    try
                    {
                        con1.Open();

                        sdr1 = cmd1.ExecuteReader();
                        
                        MetroFramework.MetroMessageBox.Show(this, "Compte cree avec success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                       
                        con1.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    SqlConnection con1 = new SqlConnection(cs);
                    string query1 = "EXEC CC_recherche_compteCA '" + this.txtnom.Text + "', '" + this.txtpostnom.Text + "', '" + this.txtprenom.Text + "' ";
                    SqlCommand cmd1 = new SqlCommand(query1, con1);

                    SqlDataReader sdr1;
                    try
                    {
                        con1.Open();

                        sdr1 = cmd1.ExecuteReader();

                        while (sdr1.Read())
                        {
                            txt_compte_existae.Text = sdr1["idcompte"].ToString();
                        }
                        con1.Close();

                        if (txt_compte_existae.Text == "")
                        {
                            SqlConnection con11 = new SqlConnection(cs);
                            string query11 = "EXEC CC_insertion_miniCA '" + this.txtnom.Text + "', '" + this.txtpostnom.Text + "', '"
                        + this.txtprenom.Text + "', " + this.txtmontant.Text + ", '" + this.cmbdevise.SelectedItem + "', '" + this.dtdate.Value.ToShortDateString() + "', '" + this.txtdelai.Text + "' ";

                            SqlCommand cmd11 = new SqlCommand(query11, con11);


                            SqlDataReader sdr11;

                            try
                            {
                                con11.Open();

                                sdr11 = cmd11.ExecuteReader();

                                MetroFramework.MetroMessageBox.Show(this, "Compte cree avec success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                               
                                con11.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }

                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Ce client pocede deja un compte de ce type, veuillez changer de client ou le type du compte", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
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
