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
    public partial class SuppresionLigne : Form
    {

        public MySqlConnection connexion = new MySqlConnection("database=baseb1; server=10.1.139.236; user id=b1; pwd=nouveau_mdp");
        public SuppresionLigne()
        {
            InitializeComponent();
        }

        private void cmd_Valider_Click(object sender, EventArgs e)
        {
            
            connexion.Close();   
            connexion.Open();

            MySqlCommand mysqlcom = new MySqlCommand($"select id_ligne from Ligne where nom_ligne = '{cbo_ligne.SelectedItem}';", connexion);

            MySqlDataReader mysqlread = mysqlcom.ExecuteReader(CommandBehavior.CloseConnection);

            int id = 0;

            if (mysqlread.Read())
            {
                id = int.Parse(mysqlread.GetString(0));
            }
            connexion.Close();

            string message = $"Voulez vous vraiment supprimer la ligne : {cbo_ligne.SelectedItem} ?";
            string caption = "Ete-vous sûr ?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);

            connexion.Open();

            MySqlDataReader MyReader2;

            if (result == DialogResult.Yes)
            {
                MySqlCommand delete1 = new MySqlCommand($"delete from Correspondance where id_ligne = '{id}';", connexion);
                MyReader2 = delete1.ExecuteReader();
                while (MyReader2.Read())
                {
                }

                connexion.Close();

                connexion.Open();
                MySqlCommand delete2 = new MySqlCommand($"delete from Ligne where id_ligne = '{id}';", connexion);
                MyReader2 = delete2.ExecuteReader();
                while (MyReader2.Read())
                {
                }

                connexion.Close();

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
            MySqlCommand mysqlcom = new MySqlCommand("select * from Ligne;", connexion);

            connexion.Open();

            MySqlDataReader mysqlread = mysqlcom.ExecuteReader(CommandBehavior.CloseConnection);

            while (mysqlread.Read())
            {
                cbo_ligne.Items.Add(mysqlread.GetString(1));
            }

            connexion.Close();
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
