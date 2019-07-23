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
    public partial class access : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["GESTION"].ConnectionString;
        Form main = new Form1();
        public access()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void access_Load(object sender, EventArgs e)
        {
            notifyIcon.Icon = SystemIcons.Application;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "EXEC logn '" + this.txtpseudo.Text + "', '" + this.txtpwd.Text +  "'";

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader sdr;
            try
            {
                con.Open();

                sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    lbllog.Text = sdr["nombre"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (lbllog.Text != "")
            {
                // ouverture
                this.Hide();
                main.ShowDialog();
            }
            else
            {
                // refus
                notifyIcon.ShowBalloonTip(200, "Echec d'ouverture", "Veuillez saisir les bonnes informations, ou contacter l'admin", ToolTipIcon.Error);
            }
        }
    }
}
