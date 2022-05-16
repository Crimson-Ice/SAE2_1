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

        private void cmdRechercheItineraire_Click(object sender, EventArgs e)
        {
            Itinéraire frmItinéraire = new Itinéraire();
            frmItinéraire.ShowDialog();
            frmItinéraire.Dispose();
        }

        private void cmd_ListeLigne_Click(object sender, EventArgs e)
        {
            Liste_lignes formLigneAffiche = new Liste_lignes();
            formLigneAffiche.ShowDialog();
            formLigneAffiche.Dispose();
        }

        private void cmd_CreationLigne_Click(object sender, EventArgs e)
        {
            CréationLigne frmCreationLinge = new CréationLigne();
            frmCreationLinge.ShowDialog();
            frmCreationLinge.Dispose();
        }

        private void cmd_ModifLigne_Click(object sender, EventArgs e)
        {
            ModificationLigne frmModif = new ModificationLigne();
            frmModif.ShowDialog();
            frmModif.Dispose();
        }

        private void cmd_SuppLigne_Click(object sender, EventArgs e)
        {
            SuppresionLigne frmSuppLigne = new SuppresionLigne();
            frmSuppLigne.ShowDialog();
            frmSuppLigne.Dispose();
        }

        private void Acceuille_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog ;
        }
    }
}
