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
        Form ask = new AskCompte();

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
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtTexte_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            txtTexte.Text = "Tableau de bord et de fous";
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            txtTexte.Text = "Clients";
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            txtTexte.Text = "Parametres";
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
            txtTexte.Text = "Creation du compte";

            // Appel au formulaire Askcompte a l'evenement click du bouton cree un compte
            ask.ShowDialog();
        }
    }
}
