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
    public partial class SuppresionLigne : Form
    {
        public SuppresionLigne()
        {
            InitializeComponent();
        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            string message = "Voulez vous vraiment supprimer cette Ligne ?";
            string caption = "Ete-vous sûr ?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Ligne supprimer");
                this.Close();
            }
        }
    }
}
