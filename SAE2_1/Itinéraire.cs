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
    public partial class Itinéraire : Form
    {
        public Itinéraire()
        {
            InitializeComponent();
            //création objet connexion 
            MySqlConnection connexion = new MySqlConnection("database=baseb1; server=10.1.139.236; user id=b1; pwd=nouveau_mdp");
            
            //test connexion base de donnée
            try
            {
                connexion.Open();
                MessageBox.Show("connecté");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("non connecté");
            }
            
            //requete sql
            MySqlCommand mysqlcom = new MySqlCommand("select * from Arret", connexion);

            //lis la requete et recupère les données
            MySqlDataReader mysqlread = mysqlcom.ExecuteReader(CommandBehavior.CloseConnection);

            while (mysqlread.Read())
            {
                
                cbo1.Items.Add(mysqlread.GetString(1));
                cbo2.Items.Add(mysqlread.GetString(1));
            }

            connexion.Close();
        }

        private void chk1_Click(object sender, EventArgs e)
        {
            if (chk1.Checked)
            {
                Dtp1.Visible = true;
                chk2.Checked = false;
                Dtp2.Visible = false;
            }
            else if(chk1.Checked == false)
            {
                Dtp1.Visible = false;

                Dtp2.Visible = false;
            }
        }

        private void chk2_Click(object sender, EventArgs e)
        {
            if (chk2.Checked)
            {
                chk1.Checked = false;
                Dtp2.Visible = true;
                Dtp1.Visible = false;
            }
            else if(chk2.Checked == false)
            {
                Dtp2.Visible = false;

                Dtp1.Visible = false;
            }
        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            //recherche d'itinéraire
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
