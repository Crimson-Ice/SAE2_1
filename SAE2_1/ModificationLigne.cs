using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE2_1
{
    public partial class ModificationLigne : Form
    {
        public ModificationLigne()
        {
            InitializeComponent();
        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            FormDeModifLigne FrmDeModifLigne = new FormDeModifLigne();
            FrmDeModifLigne.ShowDialog();
            FrmDeModifLigne.Dispose();
        }
    }
}
