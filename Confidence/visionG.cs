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
    }
}
