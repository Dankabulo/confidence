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
    public partial class last_op : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["GESTION"].ConnectionString;
        private static last_op _instance;
        public static last_op Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new last_op();
                return _instance;
            }
        }
        public last_op()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string requete = "EXEC derniere";
                SqlConnection con = new SqlConnection(cs);
                string query = requete;  //string.Format("SELECT * FROM proprietaire");
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = sdr;
                metroGrid2.DataSource = source;

                //    txt_numero.Text = "1";

                con.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
