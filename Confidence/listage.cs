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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Threading;

namespace Confidence
{
    public partial class listage : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["GESTION"].ConnectionString;
        public listage()
        {
            InitializeComponent();
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

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;

            try
            {

                if (this.cmbtype.Text == "operations")
                {

                    if (this.cmbcategorie.Text == "Operation de sorties")
                    {
                        try
                        {
                            string requete = "SELECT date_operation, idcompte, type_compte,nom, prenom,type_operation, solde FROM [CONFIDENCEX].[dbo].proprietaire p inner join compte c on p.idproprietaire = c.idproprietaire inner join operation o on c.idcompte = o.idcompte_operation WHERE type_operation = 'Retrait' ";
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
                    else if (this.cmbcategorie.Text == "Operation d'entrees")
                    {
                        string requete = "SELECT date_operation, idcompte, type_compte,nom, prenom,type_operation, solde FROM [CONFIDENCEX].[dbo].proprietaire p inner join compte c on p.idproprietaire = c.idproprietaire inner join operation o on c.idcompte = o.idcompte_operation WHERE date_operation BETWEEN '" 
                                    + dtdebut.Value.ToShortDateString() + "' AND '" + this.dtfin.Value.ToShortDateString() + "' AND type_operation = 'Depot' ";
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
                }
                else if (this.cmbtype.Text == "comptes")
                {
                    if (this.cmbcategorie.Text == "Comptes courants")
                    {
                        string requete = "SELECT idcompte, type_compte,devise, nom, postnom, prenom, date_creation,montant FROM proprietaire p inner join compte c on p.idproprietaire = c.idproprietaire inner join compte_courant cc on c.idcompte = cc.idcompte_cc; ";
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
                    else if (this.cmbcategorie.Text == "Comptes  a termes")
                    {
                        string requete = "SELECT idcompte, type_compte,devise, nom, postnom, prenom, date_creation,montant,delai FROM proprietaire p inner join compte c on p.idproprietaire = c.idproprietaire inner join compte_a_terme ca on c.idcompte = ca.idcompte_ca; ";
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
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            

            if (txtnom_rapport.Text == "")
            {
                notifyIcon.ShowBalloonTip(200, "Nom du rapport invalide", "Veuillez saisir le nom du rapport", ToolTipIcon.Error);
            }
            else
            {
                // traitement compte

                if (cmbcategorie.SelectedItem.ToString() == "comptes")
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
                        sql = "SELECT nom, postnom, prenom, date_creation, type_compte, montant,devise FROM proprietaire p INNER JOIN compte c ON p.idproprietaire = c.idproprietaire INNER JOIN compte_courant cc ON c.idcompte = cc.idcompte_cc INNER JOIN compte_a_terme ca ON c.idcompte = ca.idcompte_ca INNER JOIN operation o ON c.idcompte = o.idcompte_operation WHERE type_compte = '"
                            + this.cmbtype.SelectedItem + "' AND date_creation BETWEEN  '" + this.dtdebut.Value.ToShortDateString() + "' AND '" + this.dtfin.Value.ToShortDateString() + "' ";

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

            //ask.ShowDialog();

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {


            //try
            //{
            //    //SqlConnection con = new SqlConnection("Data Source=DESKTOP-9RMH183\\MYDATA;Initial Catalog=GESTION_SALAIRE;Integrated Security=True");
            //    string query;
            //    if (this.txt_specifique_frais.Text == "")
            //    {
            //        SqlConnection con = new SqlConnection(cs);
            //        query = string.Format(" SELECT nom,postnom, prenom, designation, montant, date_payement, pseudo FROM eleve e INNER JOIN classe c ON e.id_classe = c.id_classe INNER JOIN payement p ON e.id_eleve = p.id_eleve INNER JOIN utilisateur u ON u.id_utilisateur = p.id_utilisateur WHERE motif = '"
            //                + this.cmb_motif.SelectedItem + "' AND designation = '" + this.cmb_classe.SelectedValue.ToString() + "' AND date_payement BETWEEN '"
            //                + this.dt_fin.Value.ToShortDateString() + "' AND  '" + this.dt_debut.Value.ToShortDateString() + "' ");
            //        SqlCommand cmd = new SqlCommand(query, con);
            //        con.Open();
            //        SqlDataReader sdr = cmd.ExecuteReader();
            //        BindingSource source = new BindingSource();
            //        source.DataSource = sdr;
            //        metroGrid1.DataSource = source;

            //        con.Close();
            //    }
            //    else
            //    {

            //    }


            //}
            //catch /*(Exception ex)*/
            //{
            //    //MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void listage_Load(object sender, EventArgs e)
        {
            notifyIcon.Icon = SystemIcons.Application;
        }
    }
}
