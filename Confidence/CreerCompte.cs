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
    public partial class CreerCompte : Form
    {
        Form personnesA = new PersonnesAt();
        string cs = ConfigurationManager.ConnectionStrings["GESTION"].ConnectionString;

        public CreerCompte()
        {
            InitializeComponent();
            lbltitre.Text = "Compte courant";
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreerCompte_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            //personnesA.ShowDialog();
            littele_panel.Visible = false;
            bunifuFlatButton3.Visible = false;
            btnlancer.Visible = true;
            bunifuFlatButton2.Visible = false;
            lbltitre.Text = "Recherche";
            

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            txt_meme_compte.Text = "";
            txt_utilisateur_compte.Text = "";

            // verification de l'existance de l'utilisateur dans la data

            SqlConnection con = new SqlConnection(cs);
            string query = "EXEC CC_recherche '"+this.txtnom.Text+"', '"+this.txtpostnom.Text+"', '"+this.txtprenom.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr;
            try
            {
                con.Open();
                
                sdr = cmd.ExecuteReader();
                //MetroFramework.MetroMessageBox.Show(this, "Compte cree avec success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                while (sdr.Read())
                {
                    txt_utilisateur_compte.Text = sdr["idproprietaire"].ToString();
                }
                con.Close();

                //conditions 

                if (txt_utilisateur_compte.Text == "")
                {
                    // s'il n'existe pas dans la data => INSERTTION GLOABALE utiliateur + compte

                    SqlConnection conn = new SqlConnection(cs);
                    string queryn = "EXEC CC_insertion '" + this.txtnom.Text + "', '" 
                        + this.txtpostnom.Text + "', '" + this.txtprenom.Text + "', " + this.txtmontant.Text+", '"
                        +this.cmbdevise.SelectedItem+"', '"+this.dtdate.Value.ToShortDateString()+"'";
                    SqlCommand cmdn = new SqlCommand(queryn, conn);
                    SqlDataReader sdrn;
                    try
                    {
                        conn.Open();
                        sdrn = cmdn.ExecuteReader();
                        MetroFramework.MetroMessageBox.Show(this, "Compte cree avec success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    // s'il esxiste dans la data
                    // A deja un compte courant 

                    SqlConnection conn = new SqlConnection(cs);
                    string queryn = "EXEC CC_recherche_compte '" + this.txtnom.Text + "', '"
                        + this.txtpostnom.Text + "', '" + this.txtprenom.Text + "'";
                    SqlCommand cmdn = new SqlCommand(queryn, conn);
                    SqlDataReader sdrn;
                    try
                    {
                        conn.Open();
                        sdrn = cmdn.ExecuteReader();
                        //
                        //recuperation de la valeur retournee
                        while (sdrn.Read())
                        {
                            txt_meme_compte.Text = sdrn["idproprietaire"].ToString();
                        }
                        conn.Close();

                        // conditions 

                        if (txt_meme_compte.Text != "")
                        {
                            //message d'erreur
                            MetroFramework.MetroMessageBox.Show(this, "Ce client dispose deja d'un compte de ce type", "Message erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // insertion sans utilisateur
                            // existe mais sans un compte de ce type
                            SqlConnection cond = new SqlConnection(cs);
                            string querynd = "EXEC CC_insertion_mini '" + this.txtnom.Text + "', '"
                        + this.txtpostnom.Text + "', '" + this.txtprenom.Text + "', " + this.txtmontant.Text + ", '"
                        + this.cmbdevise.SelectedItem + "', '" + this.dtdate.Value.ToShortDateString() + "'";
                            SqlCommand cmdnd = new SqlCommand(querynd, conn);
                            SqlDataReader sdrnd;
                            try
                            {
                                cond.Open();
                                sdrnd = cmdnd.ExecuteReader();
                                //
                                //recuperation de la valeur retournee
                                MetroFramework.MetroMessageBox.Show(this, "Compte cree avec success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cond.Close();

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnlancer_Click(object sender, EventArgs e)
        {
            lbltitre.Text = "Compte courant";
            littele_panel.Visible = true;
            bunifuFlatButton3.Visible = true;
            btnlancer.Visible = false;
            bunifuFlatButton2.Visible = true;
            btn_supprimer.Visible = true;
            bnt_modifier.Visible = true;

            SqlConnection con = new SqlConnection(cs);
            string query = string.Format("SELECT * FROM RECHERCHE_COMPTE_CC('" + this.txtnom.Text + "','" + this.txtpostnom.Text + "','" + this.txtprenom.Text + "')");
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
                    }
                }
            }
            catch
            {

            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            // suppresion d'un compte courant
            SqlConnection con = new SqlConnection(cs);
            string query = "EXEC DEL_CC '" + this.txtnom.Text+"', '"+this.txtpostnom.Text+"', '"+this.txtprenom.Text+"'";

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
            // modification des infos du compte
            panel3.Visible = true;
            bnt_modifier.Visible = false;
            btn_supprimer.Visible = false;
            bunifuFlatButton4.Visible = true;
            bunifuFlatButton5.Visible = true;

        }
    }
}
