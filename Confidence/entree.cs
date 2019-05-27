using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Confidence
{
    public partial class entree : UserControl
    {
        Form courant = new CreerCompte();
        Form terme = new compte_a_terme();
        recherche recherche = new recherche();
        private static entree _instance;
        public static entree Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new entree();
                return _instance;
            }
        }
        public entree()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            courant.ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            terme.ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            recherche.ShowDialog();
        }
    }
}
