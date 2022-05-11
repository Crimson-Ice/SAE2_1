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
        public List<string> Arret = new List<string>();
        public MySqlConnection connexion = new MySqlConnection("database=baseb1; server=10.1.139.236; user id=b1; pwd=nouveau_mdp");

        private bool appuie = false;
        private bool dedans = false;
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
            new_arret_btn.Width = flowLayoutPanel1.Width-25;
            new_arret_btn.Height = 23;
            lbl_titre.Text = $"Modification de la ligne : {this.Text}";

            
            
            MySqlCommand arretcom = new MySqlCommand("select Arret.nom_arret from Correspondance,Ligne,Arret where Correspondance.id_ligne = Ligne.id_ligne and Correspondance.id_arret = Arret.id_arret and Ligne.nom_ligne =" + '\u0022' + this.Text + '\u0022' + " order by rang_arret_ligne;", connexion);

            connexion.Open();

            MySqlDataReader mysqlread = arretcom.ExecuteReader(CommandBehavior.CloseConnection);

            while (mysqlread.Read())
            {
                string nom = mysqlread.GetString(0);
                Arret.Add(nom);

            }

            spawnButton(Arret);

           connexion.Close();

            
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
                MyReader.Close();
                connexion.Close();
            }


            this.Close();
            
        }

        private void spawnButton(List<string> Arret)
        {
            for (int i = 0; i < Arret.Count(); i++)
            {
                Button button = new Button();
                //button.Click += buttonArretClick;
                button.Text = Arret[i];
                button.Width = flowLayoutPanel1.Width - 25;
                button.Tag = i;
                button.Location = new Point(0, button.Height * i);
                this.flowLayoutPanel1.Controls.Add(button);

                
            }
        }

        private void new_arret_btn_MouseDown(object sender, MouseEventArgs e)
        {
            
            new_arret_btn.DoDragDrop(new_arret_btn, DragDropEffects.Move);
            appuie = true;
        }

        private void flowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            if (!appuie )
            {
                flowLayoutPanel1.Controls.Add(new_arret_btn);
            }
            
        }

        private void flowLayoutPanel1_DragOver(object sender, DragEventArgs e)
        {
            dedans = true;
        }


        
    }
}
