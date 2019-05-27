using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Confidence
{
    public partial class Form1 : Form
    {
        Form operation = new operation();
        Form courant = new CreerCompte();
        Form terme = new compte_a_terme();
        Form fermeture = new Authentification();
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (Panelmenu.Width == 223)
            {
                Panelmenu.Visible = false;
                hidephoto.Visible = true;
                Panelmenu.Width = 58;
                paneltransition.ShowSync(Panelmenu);


            }
            
        }

        private void hidephoto_Click(object sender, EventArgs e)
        {
            if(Panelmenu.Width == 58)
            {
                Panelmenu.Visible = false;
                hidephoto.Visible = false;
                Panelmenu.Width = 223;
                paneltransition.ShowSync(Panelmenu);


            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtTexte_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            txtTexte.Text = "Tableau de bord";
            if (!mmainpale.Controls.Contains(visionG.Instance))
            {
                mmainpale.Controls.Add(visionG.Instance);
                visionG.Instance.Dock = DockStyle.Fill;
                visionG.Instance.BringToFront();
            }
            else
            {
                visionG.Instance.BringToFront();
            }
            barre.Visible = false;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            barre.Visible = true;
            if (barre.Height == 0)
            {
                barre.Height = 97;
            }
            if (mmainpale.Height == 575)
            {
                mmainpale.Height = 730;
            }
            btn_recherche.Visible = false;
            btn_lancer_recherche.Visible = true;
            btncompteA.Visible = false;
            btncompteC.Visible = false;
            btnListe_clients.Visible = true;
           // btnoperation.Visible = true;
            //btnvision.Visible = true;
            if (!mmainpale.Controls.Contains(lister.Instance))
            {
                mmainpale.Controls.Add(lister.Instance);
                lister.Instance.Dock = DockStyle.Fill;
                lister.Instance.BringToFront();
            }
            else
            {
                lister.Instance.BringToFront();
            }
            txtTexte.Text = "Clients";
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            //descativation des autres boutons
            barre.Visible = false;

            txtTexte.Text = "Operations par client";
            if (!mmainpale.Controls.Contains(operationss_client.Instance))
            {
                mmainpale.Controls.Add(operationss_client.Instance);
                operationss_client.Instance.Dock = DockStyle.Fill;
                operationss_client.Instance.BringToFront();
            }
            else
            {
                operationss_client.Instance.BringToFront();
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            txtTexte.Text = "A Propos";
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            txtTexte.Text = "Les Conceptreurs";
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            
            mmainpale.Height = 575;

            btn_recherche.Visible = true;
            btn_lancer_recherche.Visible = false;
            btncompteA.Visible = true;
            btncompteC.Visible = true;
            btnListe_clients.Visible = false;
            btnoperation.Visible = false;
            btnvision.Visible = false;

            

            // Appel au formulaire Askcompte a l'evenement click du bouton cree un compte
            if (!mmainpale.Controls.Contains(entree.Instance))
            {
                mmainpale.Controls.Add(entree.Instance);
                entree.Instance.Dock = DockStyle.Fill;
                entree.Instance.BringToFront();
            }
            else
            {
                entree.Instance.BringToFront();
            }

            txtTexte.Text = "Creation du compte";

        }

        private void btncompteC_Click(object sender, EventArgs e)
        {
            courant.ShowDialog();
        }

        private void btncompteA_Click(object sender, EventArgs e)
        {
            terme.ShowDialog();
        }

        private void btnListe_clients_Click(object sender, EventArgs e)
        {
            if (!mmainpale.Controls.Contains(clients_options.Instance))
            {
                mmainpale.Controls.Add(clients_options.Instance);
                clients_options.Instance.Dock = DockStyle.Fill;
                clients_options.Instance.BringToFront();
            }
            else
            {
                clients_options.Instance.BringToFront();
            }
        }

        private void btnoperation_Click(object sender, EventArgs e)
        {
            operation.ShowDialog();
        }

        private void btnvision_Click(object sender, EventArgs e)
        {
            if (!mmainpale.Controls.Contains(visionG.Instance))
            {
                mmainpale.Controls.Add(visionG.Instance);
                visionG.Instance.Dock = DockStyle.Fill;
                visionG.Instance.BringToFront();
            }
            else
            {
                visionG.Instance.BringToFront();
            }
        }

        private void btn_lancer_recherche_Click(object sender, EventArgs e)
        {
            if (!mmainpale.Controls.Contains(operationss_client.Instance))
            {
                mmainpale.Controls.Add(operationss_client.Instance);
                operationss_client.Instance.Dock = DockStyle.Fill;
                operationss_client.Instance.BringToFront();
            }
            else
            {
                operationss_client.Instance.BringToFront();
            }
        }
    }
}
