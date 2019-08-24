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
    public partial class new_remboursement_form : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["GESTION"].ConnectionString;
        public new_remboursement_form()
        {
            InitializeComponent();
        }

        private void materialRaisedButton8_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            string queryn = "EXEC new_remboursemen '"
                +this.txt_id_pret.Text+"', "+this.txt_montant.Text+", '"
                +this.dt_date_remboursement.Value.ToShortDateString()+"'";
            SqlCommand cmdn = new SqlCommand(queryn, conn);
            SqlDataReader sdrn;
            try
            {
                conn.Open();
                sdrn = cmdn.ExecuteReader();
                MetroFramework.MetroMessageBox.Show(this, "Operation effectuee avec success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtsolde_TextChanged(object sender, EventArgs e)
        {

        }
        public void set_id_pret(string id_pret)
        {
            this.txt_id_pret.Text = id_pret;
        }
    }
}
