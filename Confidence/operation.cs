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
    public partial class operation : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["GESTION"].ConnectionString;
        public operation()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            

            littlepanel.Visible = true;
            try
            {

                if (txtnom.Text == "" || txtpostnom.Text == "" || txtprenom.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Rassurez-vous que tous les champs soient remplis avant de proceder a la recherche", "Message error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                SqlConnection con = new SqlConnection(cs);
                string query = string.Format(" SELECT idcompte, type_compte FROM compte WHERE idproprietaire IN (SELECT idproprietaire FROM proprietaire WHERE nom= '"
                            +this.txtnom.Text+"' AND postnom = '"+this.txtpostnom.Text+"' AND prenom = '"+this.txtprenom.Text+"' )");
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

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtprenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(cs);
            string query = "INSERT INTO operation(idcompte_operation, type_operation, solde, date_operation)VALUES('"+this.txtcompte.Text+"', '"
                            +this.cmboperation.SelectedItem+"', '"+this.txtsolde.Text+"', '"+this.dtdate_creation.Value.ToShortDateString()+"')";
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader sdr;
            try
            {
                con.Open();

                sdr = cmd.ExecuteReader();
                MetroFramework.MetroMessageBox.Show(this, "Operation effectuee avec success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            // Incrementation ou decrementation du solde 

        }
    }
}
