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

        private void cmd1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            FormDeModifLigne FrmDeModifLigne = new FormDeModifLigne();
            FrmDeModifLigne.Text = cbo_choix_ligne.SelectedItem.ToString();
            FrmDeModifLigne.ShowDialog();
            FrmDeModifLigne.Dispose();
            this.Close();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmd_modifier.Enabled = true;
        }

        private void ModificationLigne_Load(object sender, EventArgs e)
        {
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
