using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClassSQL;

namespace SAE2_1
{
    public partial class SuppresionLigne : Form
    {
        public SuppresionLigne()
        {
            InitializeComponent();
        }

        private void cmd_Valider_Click(object sender, EventArgs e)
        {
            //Récuppère l'id de la ligne a supprimer
            int id = ClassMySql.Get_id_ligne(cbo_ligne.SelectedItem.ToString());

            string message = $"Voulez vous vraiment supprimer la ligne : {cbo_ligne.SelectedItem} ?";
            string caption = "Ete-vous sûr ?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                ClassMySql.Delete_from_cresspondance(id);

                ClassMySql.Delete_from_Ligne(id);

                MessageBox.Show("Ligne supprimer");
                this.Close();
            }
        }

        private void cbo_ligne_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Si un element est selectionner dans la comboBox cbo_Ligne alors active le button valider et rend visible le button visualiser
            cmd_visualiser.Visible = true;
            cmd_Valider.Enabled = true;
        }

        private void SuppresionLigne_Load(object sender, EventArgs e)
        {
            //Remplie la comboBox cbo_ligne avec les lignes de la base de donnée
            List<string> ligne_name = ClassMySql.Get_ligne_name();

            for (int i = 0; i < ligne_name.Count; i++)
                cbo_ligne.Items.Add(ligne_name[i]);
        }

        private void cmd_visualiser_Click(object sender, EventArgs e)
        {
            //crée un formulaire affichage qui affiche la ligne selectionner
            Form_affichage form_affiche = new Form_affichage();

            form_affiche.Text = cbo_ligne.SelectedItem.ToString();
            
            form_affiche.ShowDialog();
        }
    }
}
