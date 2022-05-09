using System;
using System.Windows.Forms;

namespace SAE2_1
{
    public partial class Acceuille : Form
    {
        public Acceuille()
        {
            InitializeComponent();
        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            Itinéraire frmItinéraire = new Itinéraire();
            frmItinéraire.ShowDialog();
            frmItinéraire.Dispose();
        }

        private void cmd3_Click(object sender, EventArgs e)
        {
            CréationLigne frmCreationLinge = new CréationLigne();
            frmCreationLinge.ShowDialog();
            frmCreationLinge.Dispose();
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            Liste_lignes formLigneAffiche = new Liste_lignes();
            formLigneAffiche.ShowDialog();
        }

        private void cmd4_Click(object sender, EventArgs e)
        {
            ModificationLigne frmModif = new ModificationLigne();
            frmModif.ShowDialog();
            frmModif.Dispose();
        }

        private void cmd5_Click(object sender, EventArgs e)
        {
            SuppresionLigne frmSuppLigne = new SuppresionLigne();
            frmSuppLigne.ShowDialog();
            frmSuppLigne.Dispose();
        }
    }
}
