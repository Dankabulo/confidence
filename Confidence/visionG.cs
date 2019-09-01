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
    public partial class visionG : UserControl
    {
        Form recherche = new recherche();
        string cs = ConfigurationManager.ConnectionStrings["GESTION"].ConnectionString;
        private static visionG _instance;
        public static visionG Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new visionG();
                return _instance;
            }
        }
        public visionG()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = string.Format("EXEC total_courant");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr;

            try
            {
                con.Open();
                sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    lblusd.Text = sdr["nombre"].ToString();
                    lblcfd.Text = sdr["deux"].ToString();
                }
                if (lblusd.Text == "")
                {
                    lblusd.Text = "0";
                }
                else if (lblcfd.Text == "")
                {
                    lblcfd.Text = "0";
                }
            }
            catch
            {

            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = string.Format("delete from calcul_solde; declare @i int select @i = dbo.MONTANT_TOTAL_TERME('usd');declare @ii int select @ii = dbo.MONTANT_TOTAL_TERME('cfd'); insert into calcul_solde(nombre,deux)values(@i, @ii) select * from calcul_solde; ");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr;

            try
            {
                con.Open();
                sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    lblusd_terme.Text = sdr["nombre"].ToString();
                    lblcfd_terme.Text = sdr["deux"].ToString();
                }
                if (lblusd_terme.Text == "")
                {
                    lblusd_terme.Text = "0";
                }
                if (lblcfd_terme.Text == "")
                {
                    lblcfd_terme.Text = "0";
                }
            }
            catch
            {

            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = string.Format("delete from calcul_solde;declare @i int select @i = dbo.TOTAUX('usd');declare @ii int select @ii = dbo.TOTAUX('cfd');insert into calcul_solde(nombre,deux)values(@i,@ii);select* from calcul_solde; ");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr;

            try
            {
                con.Open();
                sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    lblchiffre_usd.Text = sdr["nombre"].ToString();
                    lblchiffre_cfd.Text = sdr["deux"].ToString();                  
                }
                if (lblchiffre_cfd.Text == "")
                {
                    lblchiffre_cfd.Text = "0";
                }
                if (lblchiffre_usd.Text == "")
                {
                    lblchiffre_usd.Text = "0";
                }
            }
            catch
            {

            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = string.Format("	delete from calcul_solde;declare @i int select @i = dbo.NOMBRE_CL('compte courant');declare @ii int select @ii = dbo.NOMBRE_CL('compte a terme');insert into calcul_solde(nombre,deux)values(@i,@ii);select* from calcul_solde; ");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr;

            try
            {
                con.Open();
                sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    lblnombre_c.Text = sdr["nombre"].ToString();
                    lblnombre_A.Text = sdr["deux"].ToString();
                }
            }
            catch
            {

            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            recherche.ShowDialog();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "EXEC montant_preter_type '"+this.cmb_type_pret.SelectedItem.ToString()+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr;

            try
            {
                con.Open();
                sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    lbl_mp_type_usd.Text = sdr["num_2"].ToString();
                    lbl_mp_type_cdf.Text = sdr["num_1"].ToString();
                }
                if (lbl_mp_type_cdf.Text == "")
                {
                    lbl_mp_type_cdf.Text = "0";
                }
                if (lbl_mp_type_usd.Text == "")
                {
                    lbl_mp_type_usd.Text = "0";
                }
            }
            catch
            {

            }
        }

        public void Find(string query)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr;

            try
            {
                con.Open();
                sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    lbl_fc.Text = sdr["num_2"].ToString();
                    lbl_usd.Text = sdr["num_1"].ToString();
                }

                if (lbl_usd.Text == "")
                {
                    lbl_usd.Text = "0";
                }
                if (lbl_fc.Text == "")
                {
                    lbl_fc.Text = "0";
                }
                // Progresse bar calculs

                double fc = Convert.ToDouble(lbl_fc.Text);
                double usd = Convert.ToDouble(lbl_usd.Text);
                double t = fc + usd;

                int for_fc = Convert.ToInt32(fc * 100 / t);
                int for_usd = Convert.ToInt32(usd * 100 / t);

                this.prgrss_fc.Value = for_fc;
                this.prgrss_usd.Value = for_usd;

                // titre
                lbl_titre.Text = this.cmb_search.SelectedItem.ToString();
                txt_little_title.Text = this.cmb_search.SelectedItem.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void calcul_dette_relle(string requete, TextBox fc, TextBox usd)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(requete, con);
            SqlDataReader sdr;

            try
            {
                con.Open();
                sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    fc.Text = sdr["num_2"].ToString(); // usd
                    usd.Text = sdr["num_1"].ToString(); // fc
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

            string requet = this.cmb_search.SelectedItem.ToString();

            if (requet == "Sommes_compte_courant" || requet == "Sommes_compte_a_terme" || requet == "Sommes_remboursées" || requet == "Chiffre_d_affaire")
            {
                string query = "EXEC " + requet + " ";
                Find(query);
            }
            else if (requet == "Sommes_pretées" || requet == "Interet_sur_pret")
            {
                string query = "EXEC " + requet + " " + this.cmb_typ_pret.SelectedItem.ToString() + "";
                Find(query);
            }
            else if (requet == "Dette_reelle")
            {
                string query1 = "EXEC Sommes_compte_courant";
                string query2 = "EXEC Sommes_compte_a_terme";
                string query3 = "EXEC Sommes_remboursées";

                // Calcules

                calcul_dette_relle(query1, txt_courant_fc, txt_courant_usd);
                calcul_dette_relle(query2, txt_terme_fc, txt_terme_usd);
                calcul_dette_relle(query3, txt_rembourser_franc, txt_rembourser_usd);

                // Dette relle

                // conversions
                double courant_fc = Convert.ToDouble(txt_courant_fc.Text);
                double courant_usd = Convert.ToDouble(txt_courant_usd.Text);
                double terme_fc = Convert.ToDouble(txt_terme_fc.Text);
                double terme_usd = Convert.ToDouble(txt_terme_usd.Text);
                double remb_fc = Convert.ToDouble(txt_rembourser_franc.Text);
                double remb_usd = Convert.ToDouble(txt_rembourser_usd.Text);

                double fc = courant_fc + terme_fc - remb_fc;
                double usd = courant_usd + terme_usd - remb_usd;

                lbl_fc.Text = fc.ToString();
                lbl_usd.Text = usd.ToString();

                // progress bar calculs

                double t = fc + usd;

                int for_fc = Convert.ToInt32(fc * 100 / t);
                int for_usd = Convert.ToInt32(usd * 100 / t);

                this.prgrss_fc.Value = for_fc;
                this.prgrss_usd.Value = for_usd;
            }     
        }

        private void cmb_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            string requet = this.cmb_search.SelectedItem.ToString();

            if (requet == "Sommes_pretées" || requet == "Interet_sur_pret")
            {
                MessageBox.Show("Un type de pret doit etre specifie");
                panel_type_pret.Visible = true;
            }
            else
            {
                panel_type_pret.Visible = false;
            }
        }
    }
}
