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

  

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
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
                        panel_view_courant.Visible = true;
                    }

                    if (lbl_terme.Text == "")
                    {
                        panel_view_terme.Visible = false;
                    }
                    else
                    {
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
    }
}
