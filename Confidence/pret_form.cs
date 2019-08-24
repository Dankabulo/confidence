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
    public partial class pret_form : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["GESTION"].ConnectionString;
        public pret_form()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (txtnom.Text == ""  || txt_montant_prete.Text == "" || cmb_type_pret.Text == "" || dt_date_debut.Text == "" || txt_nb_tranche.Text == "" || dt_date_fin.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Veuillez renseigner tous les champs avant de continuer", "Certains champs sont vides", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txt_montant_deja_prete_type.Text = "";
                txt_utilisateur_compte.Text = "";

                // verification de l'existance de l'utilisateur dans la data

                SqlConnection con = new SqlConnection(cs);
                string query = "EXEC CC_recherche '" + this.txtnom.Text + "', '" + this.txtpostnom.Text + "', '" + this.txtprenom.Text + "'";
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

                    //conditions OK OK OK OK

                    if (txt_utilisateur_compte.Text == "")
                    {
                        // s'il n'existe pas dans la data => INSERTTION GLOABALE utiliateur + PRET

                        SqlConnection conn = new SqlConnection(cs);
                        string queryn = "EXEC new_pret_with_proprietaire '"+this.txtnom.Text+"','"
                            +this.txtpostnom.Text+"', '"+this.txtprenom.Text+"', '"+this.cmb_type_pret.SelectedItem.ToString()+"', "
                            +this.txt_montant_prete.Text+", "+this.txt_interet.Text+", "+this.txt_montant_rembourser.Text+", "
                            +this.txt_nb_tranche.Text+", "+this.txt_mr_tranche.Text+", '"+this.dt_date_debut.Value.ToShortDateString()+"', '"
                            +this.dt_date_fin.Value.ToShortDateString()+"', '"+this.dt_date_creation.Value.ToShortDateString()+"', '"
                            +this.cmb_devise.SelectedItem.ToString()+"'";
                        SqlCommand cmdn = new SqlCommand(queryn, conn);
                        SqlDataReader sdrn;
                        try
                        {
                            conn.Open();
                            sdrn = cmdn.ExecuteReader();
                            MetroFramework.MetroMessageBox.Show(this, "Pret cree avec success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        // Verifaction de l'existance d'un pret pour ce client

                        SqlConnection conn = new SqlConnection(cs);
                        string queryn = "EXEC existance_pret '"+this.txtnom.Text+"','"
                            +this.txtpostnom.Text+"', '"+this.txtprenom.Text+"', '"+this.cmb_type_pret.SelectedItem+"' ";
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
                                txt_utilisateur_compte.Text = sdrn["nombre"].ToString();
                                txt_montant_deja_prete_type.Text = sdrn["deux"].ToString();
                            }
                            conn.Close();

                            // conditions 

                            if (this.txt_utilisateur_compte.Text != "")
                            {
                                int reste = Convert.ToInt32(txt_montant_deja_prete_type.Text);
                                if (reste == 0)
                                {
                                    // update insertion
                                    SqlConnection cond = new SqlConnection(cs);
                                    string querynd = "EXEC update_pret_none_proprietaire '"
                                        + this.txtnom.Text + "','"
                                        + this.txtpostnom.Text + "', '" + this.txtprenom.Text + "','" + this.cmb_type_pret.SelectedItem + "', "
                                        + this.txt_montant_prete.Text + ", " + this.txt_interet.Text + ", " + this.txt_montant_rembourser.Text + ", "
                                        + this.txt_nb_tranche.Text + ", " + this.txt_mr_tranche.Text + ", '" + this.dt_date_debut.Value.ToShortDateString() + "', '"
                                        + this.dt_date_fin.Value.ToShortDateString() + "', '" + this.dt_date_creation.Value.ToShortDateString() + "', '"
                                        + this.cmb_devise.SelectedItem.ToString() + "'";
                                    SqlCommand cmdnd = new SqlCommand(querynd, cond);
                                    SqlDataReader sdrnd;
                                    try
                                    {
                                        cond.Open();
                                        sdrnd = cmdnd.ExecuteReader();
                                        //
                                        //recuperation de la valeur retournee
                                        MetroFramework.MetroMessageBox.Show(this, "Pret cree avec success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        cond.Close();

                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }

                                }
                                else
                                {
                                    //message d'erreur
                                    MetroFramework.MetroMessageBox.Show(this, "Ce client a deja effectue un pret de ce type, il nous doit encore : " + this.txt_montant_deja_prete_type.Text + "", "Message erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                //insertion sans utilisateur
                                //existe mais sans un pret de ce type
                               SqlConnection cond = new SqlConnection(cs);
                                string querynd = "EXEC new_pret_none_proprietaire '" 
                                    + this.txtnom.Text + "','"
                                    + this.txtpostnom.Text + "', '" + this.txtprenom.Text + "','" + this.cmb_type_pret.SelectedItem + "', "
                                    + this.txt_montant_prete.Text + ", " + this.txt_interet.Text + ", " + this.txt_montant_rembourser.Text + ", "
                                    + this.txt_nb_tranche.Text + ", " + this.txt_mr_tranche.Text + ", '" + this.dt_date_debut.Value.ToShortDateString() + "', '"
                                    + this.dt_date_fin.Value.ToShortDateString() + "', '" + this.dt_date_creation.Value.ToShortDateString() + "', '"
                                    +this.cmb_devise.SelectedItem.ToString()+"'";
                                SqlCommand cmdnd = new SqlCommand(querynd, cond);
                                SqlDataReader sdrnd;
                                try
                                {
                                    cond.Open();
                                    sdrnd = cmdnd.ExecuteReader();
                                    //
                                    //recuperation de la valeur retournee
                                    MetroFramework.MetroMessageBox.Show(this, "Pret cree avec success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void cmb_type_pret_SelectedIndexChanged(object sender, EventArgs e)
        {
            // taux des prets
        }

        private void txt_montant_prete_TextChanged(object sender, EventArgs e)
        {
            int interet = Convert.ToInt32(this.txt_montant_prete.Text) / 5;
            txt_interet.Text = interet.ToString();

            int montant_remb = Convert.ToInt32(this.txt_interet.Text) + Convert.ToInt32(txt_montant_prete.Text);
            txt_montant_rembourser.Text = montant_remb.ToString();

        }

        private void txt_nb_tranche_TextChanged(object sender, EventArgs e)
        {
            double mr_tranche = Convert.ToInt32(this.txt_montant_rembourser.Text) / Convert.ToInt32(this.txt_nb_tranche.Text);
            txt_mr_tranche.Text = mr_tranche.ToString();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            view_grid_form n = new view_grid_form();
            string requete = "SELECT * FROM PRET";
            n.set_requete(requete, "Informations des prets enregistrés");
            n.ShowDialog();
        }
    }
}
