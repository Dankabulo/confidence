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
    public partial class AskCompte : Form
    {
        public AskCompte()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            CreerCompte n = new CreerCompte();
            n.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            compte_a_terme n = new compte_a_terme();
            n.Show();
        }
    }
}
