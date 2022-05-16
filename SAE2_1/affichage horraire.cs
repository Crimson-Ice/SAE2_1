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
    public partial class affichage_horraire : Form
    {
        public MySqlConnection connexion = new MySqlConnection("database=baseb1; server=10.1.139.236; user id=b1; pwd=nouveau_mdp");

        public List<string> arret_horaire = new List<string>();
        public affichage_horraire()
        {
            InitializeComponent();
        }

        private void affichage_horraire_Load_1(object sender, EventArgs e)
        {

            MySqlCommand mysqlcom = new MySqlCommand("select * from Correspondance,Ligne,Arret where Correspondance.id_ligne = Ligne.id_ligne and Correspondance.id_arret = Arret.id_arret and Ligne.nom_ligne =" + '\u0022' + this.Text + '\u0022' + " order by rang_arret_ligne;", connexion);

            connexion.Open();

            MySqlDataReader mysqlread = mysqlcom.ExecuteReader(CommandBehavior.CloseConnection);

            
            while (mysqlread.Read())
            {
                arret_horaire.Add(mysqlread.GetString(3));

            }

            connexion.Close();
            dataGridView1.ColumnCount = 3;

            for (int i = 0; i < Form_affichage.arret.Count(); i++)
            {
                dataGridView1.Rows.Add(Form_affichage.arret[i]);
                dataGridView1.Rows[i].Cells[1].Value= arret_horaire[i];
            }
        }
    }
}
