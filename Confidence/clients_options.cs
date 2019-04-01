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
    public partial class clients_options : UserControl
    {
        Form operation = new operation();
        string cs = ConfigurationManager.ConnectionStrings["GESTION"].ConnectionString;
        private static clients_options _instance;
        public static clients_options Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new clients_options();
                return _instance;
            }
        }
        public clients_options()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection(cs);
            

            try
            {
                SqlConnection conn = new SqlConnection(cs);
                string queryn = string.Format("declare @_nombre int;  SELECT @_nombre = nombre COUNT(idproprietaire) FROM proprietaire");
                SqlCommand cmdn = new SqlCommand(queryn, conn);
                SqlDataReader sdrn;

                try
                {
                    conn.Open();
                    sdrn = cmdn.ExecuteReader();

                    while (sdrn.Read())
                    {
                        //lblnombre.Text = sdrn[].ToString;
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

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;

            try
            {
                

                SqlConnection con = new SqlConnection(cs);
                string query = string.Format("SELECT nom, postnom, prenom, idcompte,type, type_operation, solde FROM operation inner join compte c on o.idcompte = c.idcompte inner join proprietaire p on c.idproprietaire = p.idproprietaire WHERE o.date between '"
                    + this.dtdebut.Value.ToShortDateString() + "' AND '" + this.dtfin.Value.ToShortDateString() +"'  ");
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = sdr;
                dataGridView2.DataSource = source;

                con.Close();

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            operation.ShowDialog();
        }
    }
}
