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
    public partial class lister : UserControl
    {
        Form visualiser = new listage();
        Form operation = new operation();
        private static lister _instance;
        public static lister Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new lister();
                return _instance;
            }
        }
        public lister()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            operation.ShowDialog();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            visualiser.ShowDialog();
        }
    }
}
