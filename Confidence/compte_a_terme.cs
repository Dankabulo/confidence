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
                         + this.txtpostnom.Text + "' AND prenom= '" + this.txtprenom.Text + "'), '"
                         + this.cmbtypecompte.SelectedItem + "'); INSERT INTO compte_a_terme(idcompte_ca, date_creation,delai, montant, devise) VALUES((SELECT idcompte FROM compte WHERE idproprietaire ='"+id+"' AND type_compte = 'Compte a terme' ), '" + this.dtdate.Value.ToShortDateString() + "', '"
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
                            + this.txtpostnom.Text + "' AND prenom= '" + this.txtprenom.Text + "'), '"
                            + this.cmbtypecompte.SelectedItem + "'); INSERT INTO compte_a_terme(idcompte, date_creation,delai, montant, devise) VALUES((SELECT idcompte FROM compte WHERE idproprietaire =(SELECT idproprietaire FROM proprietaire WHERE nom= '" + this.txtnom.Text + "' AND postnom = '"
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
                catch
                {

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }   
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            personnesA.ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
