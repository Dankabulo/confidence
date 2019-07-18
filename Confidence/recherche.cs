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

        private void txtnom_Click(object sender, EventArgs e)
        {
            try
            {
                string requete =string.Format("SELECT * FROM proprietaire WHERE nom LIKE'%{0}%'", this.txtnom.Text);
                SqlConnection con = new SqlConnection(cs);
                string query = requete;  //string.Format("SELECT * FROM proprietaire");
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = sdr;
                metroGrid1.DataSource = source;

                con.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            lbl_message.Text = "";
            txt_id_trouve.Text = "";

            SqlConnection con = new SqlConnection(cs);
            string query = "EXEC check_proprietaire '" + this.txt_id_proprietaire.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr;
            try
            {
                con.Open();

                sdr = cmd.ExecuteReader();
                //MetroFramework.MetroMessageBox.Show(this, "Compte supprimer avec success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                while (sdr.Read())
                {
                    txtnom.Text = sdr["nom"].ToString();
                    txtpostnom.Text = sdr["postnom"].ToString();
                    txtprenom.Text = sdr["prenom"].ToString();
                }
                con.Close();

                if (txtnom.Text != "" || txtpostnom.Text != "" || txtprenom.Text != "")
                {
                    txt_id_trouve.Text = this.txt_id_proprietaire.Text;

                    if (txt_id_trouve.Text != "")
                    {
                        lbl_message.Visible = true;
                        lbl_wrong.Visible = false;
                        lbl_message.Text = "Client trouvé !!";
                        materialRaisedButton2.Visible = true;
                        materialRaisedButton3.Visible = true;
                    }
                }
                else
                {
                    lbl_message.Visible = false;
                    lbl_wrong.Visible = true;
                    lbl_wrong.Text = "Client inconnu.";

                    materialRaisedButton2.Visible = false;
                    materialRaisedButton3.Visible = false;
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "EXEC update_proprietaire '" + this.txtnom.Text + "', '" + this.txtpostnom.Text + "', '" 
                + this.txtprenom.Text + "', '"+this.txt_id_proprietaire.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr;
            try
            {
                con.Open();

                sdr = cmd.ExecuteReader();
                MetroFramework.MetroMessageBox.Show(this, " "+this.txtnom.Text+" a ete modifie avec success", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            suppression n = new suppression();
            n.Set_id(txt_id_proprietaire.Text);
            n.ShowDialog();
        }

        private void metroGrid1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void metroGrid1_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
