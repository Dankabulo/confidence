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
    public partial class find_client : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["GESTION"].ConnectionString;
        private static find_client _instance;
        public static find_client Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new find_client();
                return _instance;
            }
        }
        public find_client()
        {
            InitializeComponent();
        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // proprietaire rechrche 
            //panel_search.Visible = false;
            //panel_result_search.Visible = true;
            

            SqlConnection con = new SqlConnection(cs);
            string query = "EXEC recherche_compte_deux '" + this.txt_code_proprietaire.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr;
            try
            {
                con.Open();

                sdr = cmd.ExecuteReader();
                //MetroFramework.MetroMessageBox.Show(this, "Compte supprimer avec success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                while (sdr.Read())
                {
                    lbl_courant.Text = sdr["nombre"].ToString();
                    lbl_terme.Text = sdr["deux"].ToString();
                    txt_nom.Text = sdr["nom"].ToString();
                    txt_postnom.Text = sdr["postnom"].ToString();
                    txt_prenom.Text = sdr["prenom"].ToString();
                }
                con.Close();       
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel_result_search_Paint(object sender, PaintEventArgs e)
        {
            
        }


        public List<string> total_SIV(int compte)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "EXEC total_SIV "+compte+"";
            SqlCommand cmd = new SqlCommand(query, con);

            List<string> n = new List<string>();
            SqlDataReader sdr;

            try
            {
                con.Open();

                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    n.Add(sdr["nombre"].ToString());
                    n.Add(sdr["second"].ToString());
                    n.Add(sdr["deux"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return n;

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            // hide panels prets
            panel_pret_1.Visible = false;
            panel_pret_2.Visible = false;
            panel_pret_3.Visible = false;
            panel_pret_4.Visible = false;
            panel_pret_imm.Visible = false;

            txt_idproprietaire.Text = "";
            lbl_courant.Text = "";
            lbl_terme.Text = "";

            SqlConnection con = new SqlConnection(cs);
            string query = "EXEC recherche_compte_deux '" + this.txt_code_proprietaire.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr;
            try
            {
                con.Open();

                sdr = cmd.ExecuteReader();
                //MetroFramework.MetroMessageBox.Show(this, "Compte supprimer avec success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                while (sdr.Read())
                {
                    lbl_courant.Text = sdr["nombre"].ToString();
                    lbl_terme.Text = sdr["deux"].ToString();
                    txt_nom.Text = sdr["nom"].ToString();
                    txt_postnom.Text = sdr["postnom"].ToString();
                    txt_prenom.Text = sdr["prenom"].ToString();
                    txt_idproprietaire.Text = sdr["second"].ToString();
                }
                con.Close();

                if (txt_idproprietaire.Text != "")
                {
                    lbl_result_recherche.Text = "Client retrouve !";
                    tab_detail.Show();
                    if (lbl_courant.Text == "")
                    {
                        panel_view_courant.Visible = false;
                    }
                    else
                    {
                        List<string> valeurs = new List<string>();
                        valeurs = total_SIV(Convert.ToInt32(lbl_courant.Text));

                        string[] tableau = valeurs.ToArray();
                        // Affectation 
                        lbl_solde_courant.Text = tableau[0];
                        lbl_val_courant.Text = tableau[2];
                        panel_view_courant.Visible = true;
                    }

                    if (lbl_terme.Text == "")
                    {
                        panel_view_terme.Visible = false;
                    }
                    else
                    {
                        List<string> valeurs = new List<string>();
                        valeurs = total_SIV(Convert.ToInt32(lbl_terme.Text));

                        string[] tableau = valeurs.ToArray();
                        // Affectation 
                        lbl_solde_terme.Text = tableau[0];
                        lbl_interet_terme.Text = tableau[1];
                        lbl_val_terme.Text = tableau[2];
                        panel_view_terme.Visible = true;
                    }
                }
                else
                {
                    lbl_result_recherche.Text = "Erreur code client";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = string.Format("SELECT 'Numero proprietaire' = idproprietaire , nom, postnom, prenom   FROM proprietaire ");
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
        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            details_operation n= new details_operation();
            n.receive(lbl_terme.Text);
            n.ShowDialog();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            details_operation n = new details_operation();
            n.receive(lbl_courant.Text);
            n.ShowDialog();           
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            new_form_operation n = new new_form_operation();
            n.receive_compte(lbl_terme.Text);
            n.ShowDialog();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            new_form_operation n = new new_form_operation();
            n.receive_compte(lbl_courant.Text);
            n.ShowDialog();
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void materialRaisedButton7_Click(object sender, EventArgs e)
        {
            lbl_id_pret_1.Text = "";

            SqlConnection con = new SqlConnection(cs);
            string query = "EXEC recherche_prets '" + this.txt_code_proprietaire.Text + "', 'pret_1'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr;
            try
            {
                con.Open();

                sdr = cmd.ExecuteReader();
                //MetroFramework.MetroMessageBox.Show(this, "Compte supprimer avec success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                while (sdr.Read())
                {
                    lbl_id_pret_1.Text = sdr["quatre"].ToString();
                    lbl_montant_prete_1.Text = sdr["nombre"].ToString();
                    lbl_interet_pret_1.Text = sdr["second"].ToString();
                    lbl_mr_1.Text = sdr["deux"].ToString();
                    dt_debut_pret_1.Text = sdr["date_debut"].ToString();
                    dt_fin_pret_1.Text = sdr["date_fin"].ToString();
                }
                con.Close();

                if (this.lbl_id_pret_1.Text != "")
                {
                    panel_pret_1.Show();
                }
                else
                {
                    panel_pret_1.Hide();
                    MessageBox.Show("Aucune information correspondante");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void materialRaisedButton9_Click(object sender, EventArgs e)
        {
            lbl_id_pret_2.Text = "";

            SqlConnection con = new SqlConnection(cs);
            string query = "EXEC recherche_prets '" + this.txt_code_proprietaire.Text + "', 'pret_2'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr;
            try
            {
                con.Open();

                sdr = cmd.ExecuteReader();
                //MetroFramework.MetroMessageBox.Show(this, "Compte supprimer avec success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                while (sdr.Read())
                {
                    lbl_id_pret_2.Text = sdr["quatre"].ToString();
                    lbl_montant_prete_2.Text = sdr["nombre"].ToString();
                    lbl_interet_pret_2.Text = sdr["second"].ToString();
                    lbl_mr_2.Text = sdr["deux"].ToString();
                    dt_debut_pret_2.Text = sdr["date_debut"].ToString();
                    dt_fin_pret_2.Text = sdr["date_fin"].ToString();
                }
                con.Close();

                if (this.lbl_id_pret_2.Text != "")
                {
                    panel_pret_2.Show();
                }
                else
                {
                    panel_pret_2.Hide();
                    MessageBox.Show("Aucune information correspondante");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void materialRaisedButton19_Click(object sender, EventArgs e)
        {
            lbl_id_pret_3.Text = "";

            SqlConnection con = new SqlConnection(cs);
            string query = "EXEC recherche_prets '" + this.txt_code_proprietaire.Text + "', 'pret_3'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr;
            try
            {
                con.Open();

                sdr = cmd.ExecuteReader();
                //MetroFramework.MetroMessageBox.Show(this, "Compte supprimer avec success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                while (sdr.Read())
                {
                    lbl_id_pret_3.Text = sdr["quatre"].ToString();
                    lbl_montant_prete_3.Text = sdr["nombre"].ToString();
                    lbl_interet_pret_3.Text = sdr["second"].ToString();
                    lbl_mr_3.Text = sdr["deux"].ToString();
                    dt_debut_pret_3.Text = sdr["date_debut"].ToString();
                    dt_fin_pret_3.Text = sdr["date_fin"].ToString();
                }
                con.Close();

                if (this.lbl_id_pret_3.Text != "")
                {
                    panel_pret_3.Show();
                }
                else
                {
                    panel_pret_3.Hide();
                    MessageBox.Show("Aucune information correspondante");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void materialRaisedButton20_Click(object sender, EventArgs e)
        {
            lbl_id_pret_4.Text = "";

            SqlConnection con = new SqlConnection(cs);
            string query = "EXEC recherche_prets '" + this.txt_code_proprietaire.Text + "', 'pret_4'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr;
            try
            {
                con.Open();

                sdr = cmd.ExecuteReader();
                //MetroFramework.MetroMessageBox.Show(this, "Compte supprimer avec success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                while (sdr.Read())
                {
                    lbl_id_pret_4.Text = sdr["quatre"].ToString();
                    lbl_montant_prete_4.Text = sdr["nombre"].ToString();
                    lbl_interet_pret_4.Text = sdr["second"].ToString();
                    lbl_mr_4.Text = sdr["deux"].ToString();
                    dt_debut_pret_4.Text = sdr["date_debut"].ToString();
                    dt_fin_pret_4.Text = sdr["date_fin"].ToString();
                }
                con.Close();

                if (this.lbl_id_pret_4.Text != "")
                {
                    panel_pret_4.Show();
                }
                else
                {
                    panel_pret_4.Hide();
                    MessageBox.Show("Aucune information correspondante");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void materialRaisedButton21_Click(object sender, EventArgs e)
        {
            lbl_id_pret_imm.Text = "";

            SqlConnection con = new SqlConnection(cs);
            string query = "EXEC recherche_prets '" + this.txt_code_proprietaire.Text + "', 'Immobilier'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr;
            try
            {
                con.Open();

                sdr = cmd.ExecuteReader();
                //MetroFramework.MetroMessageBox.Show(this, "Compte supprimer avec success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                while (sdr.Read())
                {
                    lbl_id_pret_imm.Text = sdr["quatre"].ToString();
                    lbl_montant_prete_imm.Text = sdr["nombre"].ToString();
                    lbl_interet_pret_imm.Text = sdr["second"].ToString();
                    lbl_mr_imm.Text = sdr["deux"].ToString();
                    dt_debut_pret_imm.Text = sdr["date_debut"].ToString();
                    dt_fin_pret_imm.Text = sdr["date_fin"].ToString();
                }
                con.Close();

                if (this.lbl_id_pret_imm.Text != "")
                {
                    panel_pret_imm.Show();
                }
                else
                {
                    panel_pret_imm.Hide();
                    MessageBox.Show("Aucune information correspondante");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
