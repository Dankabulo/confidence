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
    public partial class account : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["GESTION"].ConnectionString;
        public account()
        {
            InitializeComponent();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            p_initial.Visible = false;
            p_modifier.Visible = true;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            btn_modifier.Visible = false;
            txtid.Text = "";
            SqlConnection con = new SqlConnection(cs);
            string query = "EXEC logn '" + this.txt_pseudo_p.Text + "', '" + this.txt_pwd_p.Text + "'";

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader sdr;
            try
            {
                con.Open();

                sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    txtid.Text = sdr["nombre"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (txtid.Text != "")
            {
                groupBox1.Visible = true;
                btn_modifier.Visible = true;
            }
            else
            {
                // refus
                notifyIcon.ShowBalloonTip(200, "Erreur pseudo ou mot de passe", "Veuillez saisir les bonnes informations, ou contacter l'admin", ToolTipIcon.Error);
            }
        }

        private void account_Load(object sender, EventArgs e)
        {
            notifyIcon.Icon = SystemIcons.Application;
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "EXEC up_account '" + this.txt_pseudo_n.Text + "', '" + this.txt_pwd_n.Text + "', '"
                + this.txtid.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr;
            try
            {
                con.Open();

                sdr = cmd.ExecuteReader();
                MetroFramework.MetroMessageBox.Show(this, " " + this.txt_pseudo_n.Text + " a ete modifie avec success", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
