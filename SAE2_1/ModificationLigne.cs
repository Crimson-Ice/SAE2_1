using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassSQL;

namespace SAE2_1
{
    public partial class ModificationLigne : Form
    {
        public ModificationLigne()
        {
            InitializeComponent();
        }

        private void cmd_modifier_Click(object sender, EventArgs e)
        {
            //créer le formulaire FormDeModifLigne
            FormDeModifLigne FrmDeModifLigne = new FormDeModifLigne();
            FrmDeModifLigne.Text = cbo_choix_ligne.SelectedItem.ToString();
            FrmDeModifLigne.ShowDialog();
            FrmDeModifLigne.Dispose();
            this.Close();
        }

        private void cbo_choix_ligne_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Si un element est selectionner dans la comboBox alors active le boutton modifier
            cmd_modifier.Enabled = true;
        }

        private void ModificationLigne_Load(object sender, EventArgs e)
        {
            //Met les lignes de la base de donnée dans la comboBox cbo_choix_ligne
            ClassMySql.connection();
            ClassMySql.RequeteSQl("select * from Ligne;");
            ClassMySql.Reading();
            
            while (ClassMySql.ISread())
            {
                cbo_choix_ligne.Items.Add(ClassMySql.Attribut(1));
            }
        }
    }
}
