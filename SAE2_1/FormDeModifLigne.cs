using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SAE2_1
{
    public partial class FormDeModifLigne : Form
    {

        public MySqlConnection connexion = new MySqlConnection("database=baseb1; server=10.1.139.236; user id=b1; pwd=nouveau_mdp");
        public FormDeModifLigne()
        {
            InitializeComponent();
        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDeModifLigne_Load(object sender, EventArgs e)
        {
            lbl_titre.Text = $"Modification de la ligne : {this.Text}";
        }

        private void cmd2_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txt_new_nom.Text))
            {
                connexion.Open();

                MySqlDataReader MyReader;

                MySqlCommand update = new MySqlCommand($"UPDATE Ligne SET nom_ligne = '{txt_new_nom.Text} ' WHERE nom_ligne = '{this.Text} '; ", connexion);

                

                MyReader = update.ExecuteReader();

                while (MyReader.Read())
                {
                }

                connexion.Close();
            }


            this.Close();
            
        }
    }
}
