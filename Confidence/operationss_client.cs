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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Threading;

namespace Confidence
{
    public partial class operationss_client : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["GESTION"].ConnectionString;
        private static operationss_client _instance;
        public static operationss_client Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new operationss_client();
                return _instance;
            }
        }
        public operationss_client()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            //btn nouvelle operation

            materialRaisedButton7.Visible = false;
            materialRaisedButton8.Visible = false;

            materialRaisedButton3.Visible = false;
            materialRaisedButton2.Visible = false;
            txt_compte_a_terme.Text = "";
            txt_compte_courant.Text = "";

            SqlConnection con = new SqlConnection(cs);
            string query = "EXEC recherche_compte '" + this.txt_nom.Text + "', '" + this.txt_postnom.Text + "', '" + this.txt_prenom.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr;
            try
            {
                con.Open();

                sdr = cmd.ExecuteReader();
                //MetroFramework.MetroMessageBox.Show(this, "Compte supprimer avec success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                while (sdr.Read())
                {
                    txt_compte_courant.Text = sdr["nombre"].ToString();
                    txt_compte_a_terme.Text = sdr["deux"].ToString();
                }
                con.Close();

                //conditions en cas des valeurs nulles

                if (txt_compte_courant.Text == "" && txt_compte_a_terme.Text == "")
                {
                    txt_compte_courant.Text = "";
                    txt_compte_a_terme.Text = "";
                    lbl_message_compte.Text = "Ce client n'a aucun compte, veuillez changer les informationsdu client ou ressayer";
                    materialRaisedButton3.Visible = false;
                    materialRaisedButton2.Visible = false;
                }
                else if (txt_compte_courant.Text == "" && txt_compte_a_terme.Text != "")
                {
                    txt_compte_courant.Text = "Aucun compte";
                    materialRaisedButton3.Visible = false;
                    materialRaisedButton2.Visible = true;
                }
                else if (txt_compte_a_terme.Text == "" && txt_compte_courant.Text != "")
                {
                    txt_compte_a_terme.Text = "Aucun compte";
                    materialRaisedButton2.Visible = false;
                    materialRaisedButton3.Visible = true;
                }
                // else if(txt)
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            txt_requete.Text = "";
            txt_requete.Text = "EXEC solde_ca " + this.txt_compte_a_terme.Text + "";

            dataGridView2.Visible = true;
            materialRaisedButton4.Visible = true;
            btn_generer_rapport.Visible = true;
            try
            {
                string requete = "EXEC solde_ca " + this.txt_compte_a_terme.Text + "";
                SqlConnection con = new SqlConnection(cs);
                string query = requete;  //string.Format("SELECT * FROM proprietaire");
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

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            txt_requete.Text = "";
            txt_requete.Text = "EXEC solde_cc " + this.txt_compte_courant.Text + "";

            dataGridView2.Visible = true;
            materialRaisedButton4.Visible = true;
            btn_generer_rapport.Visible = true;
            try
            {
                string requete = "EXEC solde_cc " + this.txt_compte_courant.Text + "";
                SqlConnection con = new SqlConnection(cs);
                string query = requete;  //string.Format("SELECT * FROM proprietaire");
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

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            materialRaisedButton7.Visible = true;
            materialRaisedButton8.Visible = true;
            materialRaisedButton9.Visible = true;
        }

        private void materialRaisedButton9_Click(object sender, EventArgs e)
        {
            materialRaisedButton7.Visible = false;
            materialRaisedButton8.Visible = false;
            materialRaisedButton9.Visible = false;
        }

        private void materialRaisedButton7_Click(object sender, EventArgs e)
        {
            panel_nouvelle_operation.Visible = true;
            txtcompte.Text = this.txt_compte_a_terme.Text;
        }

        private void materialRaisedButton10_Click(object sender, EventArgs e)
        {
            txt_ctrl.Text = "";
            txt_montant_banque.Text = "";

            SqlConnection con = new SqlConnection(cs);
            string query = "EXEC op " + this.txtcompte.Text + ", '"+ this.cmboperation.SelectedItem + "', " 
                + this.txtsolde.Text + ", '" + this.dtdate_creation.Value.ToShortDateString() + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader sdr;
            try
            {
                con.Open();

                sdr = cmd.ExecuteReader();
               // 

                while (sdr.Read())
                {
                    txt_ctrl.Text = sdr["nombre"].ToString();
                    txt_montant_banque.Text = sdr["deux"].ToString();
                }
                con.Close();

                if (txt_ctrl.Text != "111"  || txt_ctrl.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Operation effectuee avec success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txt_ctrl.Text == "111")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Operation non effectuee, le solde en caisse : "+this.txt_montant_banque.Text+" est inferieur a : "+this.txtsolde.Text+"", "Solde insuffisant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void materialRaisedButton8_Click(object sender, EventArgs e)
        {
            panel_nouvelle_operation.Visible = true;
            txtcompte.Text = this.txt_compte_courant.Text;
        }

        private void materialRaisedButton11_Click(object sender, EventArgs e)
        {
            panel_nouvelle_operation.Visible = false;
        }

        Task ProcessImport(List<string> data, IProgress<ProgressReport> progress)
        {
            int index = 1;
            int totalprogress = data.Count;
            var progressReport = new ProgressReport();
            return Task.Run(() =>
            {
                for (int i = 0; i < totalprogress; i++)
                {
                    progressReport.PercentComplete = index++ * 100 / totalprogress;
                    progress.Report(progressReport);
                    Thread.Sleep(5); //simulate
                }
            });
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MetroFramework.MetroMessageBox.Show(this, "Exception occured whille releasing object" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                GC.Collect();
            }
        }

        private async void btn_generer_rapport_Click(object sender, EventArgs e)
        {
            if (txtnom_rapport.Text == "")
            {
                notifyIcon.ShowBalloonTip(200, "Nom du rapport invalide", "Veuillez saisir le nom du rapport", ToolTipIcon.Error);
            }
            else
            {
                panel_progression.Visible = true;

                panel_progression.Visible = true;
                List<string> list = new List<string>();
                for (int ii = 0; ii < 100; ii++)
                    list.Add(ii.ToString());
                lblprogresseBar.Text = "Travail...";
                var progressReport = new Progress<ProgressReport>();
                progressReport.ProgressChanged += (o, report) =>
                {
                    lblprogresseBar.Text = string.Format("Traitement...{0}%", report.PercentComplete);
                    metroProgressBar.Value = report.PercentComplete;
                    metroProgressBar.Update();
                };
                await ProcessImport(list, progressReport);
                lblprogresseBar.Text = "Terminer!";


                try
                {
                    SqlConnection cnn;
                    string connectionstring = null;
                    string sql = null;
                    string data = null;
                    int i = 0;
                    int j = 0;

                    Microsoft.Office.Interop.Excel.Application xlapp;
                    Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                    Excel.Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;

                    xlapp = new Excel.Application();
                    xlWorkBook = xlapp.Workbooks.Add(misValue);
                    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                    connectionstring = cs;
                    cnn = new SqlConnection(connectionstring);
                    cnn.Open();

                    string q = txt_requete.Text;

                    sql = q;

                    SqlDataAdapter dscmd = new SqlDataAdapter(sql, cnn);
                    DataSet ds = new DataSet();
                    dscmd.Fill(ds);

                    foreach (System.Data.DataTable dt in ds.Tables)
                    {
                        for (int i1 = 0; i1 < dt.Columns.Count; i1++)
                        {
                            xlWorkSheet.Cells[1, i1 + 1] = dt.Columns[i1].ColumnName;
                        }
                    }

                    for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                    {
                        int s = i + 1;
                        for (j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
                        {
                            data = ds.Tables[0].Rows[i].ItemArray[j].ToString();
                            xlWorkSheet.Cells[s + 1, j + 1] = data;
                        }
                    }

                    //formating the excel export             A COMMENTER QUAND CELA NNE PASSE PAS

                    Excel.Range formatage;
                    formatage = (Excel.Range)xlWorkSheet.UsedRange;
                    formatage.Font.Name = "Tahoma";
                    formatage.Font.Size = "10";

                    formatage.BorderAround2(Excel.XlLineStyle.xlContinuous,
                        Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic,
                        Excel.XlColorIndex.xlColorIndexAutomatic);

                    //setting the all borders
                    Excel.Range cell = (Excel.Range)xlWorkSheet.UsedRange;
                    Excel.Borders border = cell.Borders;
                    border.Weight = 2d;

                    //setting the background color for the tiltle bar
                    formatage = xlWorkSheet.get_Range("A1", "G1");

                    formatage.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Cyan);


                    xlWorkBook.SaveAs(this.txtnom_rapport.Text, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive);
                    xlWorkBook.Close(true, misValue, misValue);
                    xlapp.Quit();

                    releaseObject(xlWorkSheet);
                    releaseObject(xlWorkBook);
                    releaseObject(xlapp);

                    MetroFramework.MetroMessageBox.Show(this, "Excel file create," + " you can find the file C:\\User\\Username\\MesDocuments\\'" + this.txtnom_rapport.Text + "'.xls.xls", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex + "Please move your '" + this.txtnom_rapport.Text + "'.xls and Retry again...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
