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
    public partial class CréationLigne : Form
    {
        private bool validerButton;
        public static TimeSpan time = new TimeSpan(05,00,00);
        public static List<(string, string)> listArret = new List<(string, string)>();
        public static List<string> arretCree = new List<string> ();

        public MySqlConnection connexion = new MySqlConnection("database=baseb1; server=10.1.139.236; user id=b1; pwd=nouveau_mdp");
        public CréationLigne()
        {
            InitializeComponent();
        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            arretCree.Clear();
            listArret.Clear();

            validerButton = true;
            bool empty = false;
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrWhiteSpace(tb.Text) && tb != txt3)
                {
                    empty = true;
                    errorProvider1.SetError(tb, "Champ non saisi");
                }
                else
                {
                    errorProvider1.SetError(tb, "");
                }
            }
            if (empty == false)
            {
                int n;
                bool isNumeric = int.TryParse(txt2.Text, out n);
                if (isNumeric)
                {
                    if(int.Parse(txt2.Text) <= 50)
                    {
                        if(verifTextValid(txt1.Text))
                        {
                            errorProvider1.SetError(txt2, "");
                            spawnButton(n);
                            cmd1.Enabled = false;
                        }
                        else
                        {
                            errorProvider1.SetError(txt1, "Le nom doit etre composer de lettre ou de chiffre");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(txt2, "Le nombre est trop grand");
                    }
                }
                else
                {
                    errorProvider1.SetError(txt2, "Ceci n'est pas un nombre");
                }
            }
        }

        /// <summary>
        /// verif si le text contain que des lettres et chiffres
        /// </summary>
        /// <param name="text">texte a verif</param>
        /// <returns>returne un booléen</returns>
        private bool verifTextValid(string text)
        {
            foreach (char c in txt1.Text)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// fait spawn les button dans le panel des arrets
        /// </summary>
        /// <param name="n">nombre de button a faire spawn</param>
        private void spawnButton(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Button button = new Button();
                button.Click += buttonArretClick;
                button.Text = "Arrêt" + (i + 1).ToString();
                button.Width = flowLayoutPanel1.Width - 25;
                button.Tag = i;
                button.Location = new Point(0, button.Height * i);
                this.flowLayoutPanel1.Controls.Add(button);

                if (i == 0)
                {
                    button.Enabled = true;
                }
                else
                {
                    button.Enabled = false;
                }
            }
        }

        private void buttonArretClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Frm_createArret frmCreateArret = new Frm_createArret();

            DialogResult result = frmCreateArret.ShowDialog();

            if (result == DialogResult.OK)
            {
                Affiche_Nom_Arret_Cree(btn, frmCreateArret);
            }

            frmCreateArret.Dispose();
        }

        /// <summary>
        /// Affiche dans la textbox le nom de l'arret crée ou selectionner
        /// </summary>
        /// <param name="btn">button actuel</param>
        /// <param name="frmCreateArret">formulaire crée avec le button actuel</param>
        private void Affiche_Nom_Arret_Cree(Button btn, Frm_createArret frmCreateArret)
        {
            string name = btn.Text;

            if ((int)btn.Tag != 0)
            {
                txt3.Text += "**************************** \r\n";
            }

            if (frmCreateArret.chk_ArretExistant.Checked)
            {
                txt3.Text += $" {name} : {frmCreateArret.cbo_ArretExistant.SelectedItem} \r\n";
                listArret.Add((frmCreateArret.cbo_ArretExistant.SelectedItem.ToString(), frmCreateArret.dtp_HorairePremierBus.Text));
            }
            else
            {
                txt3.Text += $" {name} : {frmCreateArret.txt_NomArret.Text} \r\n";
                listArret.Add((frmCreateArret.txt_NomArret.Text, frmCreateArret.dtp_HorairePremierBus.Text));
                arretCree.Add(frmCreateArret.txt_NomArret.Text);
            }

            this.flowLayoutPanel1.Controls.Remove(btn);

            foreach (Control control in this.flowLayoutPanel1.Controls)
            {
                if ((int)control.Tag == (int)btn.Tag + 1)
                {
                    control.Enabled = true;
                }
            }
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txt1.Text) || !string.IsNullOrWhiteSpace(txt2.Text))
            {
                cmd1.Enabled = true;
                cmd2.Enabled = true;
            }
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            if(validerButton)
            {
                validerButton = false;

                this.flowLayoutPanel1.Controls.Clear();
                txt3.Text = "";
                txt1.Text = "";
                txt2.Text = "";
                cmd1.Enabled = false;
                cmd2.Enabled = false;
                cmd3.Enabled = false;

            }
        }

        private void cmd3_Click(object sender, EventArgs e)
        {

            int id_ligne=0;
            connexion.Open();
            MySqlCommand delete1;
            foreach (string arret in arretCree)
            {
                

                delete1 = new MySqlCommand($"INSERT INTO Arret (nom_arret,nb_ligne_desservi) VALUES('{arret}', 1);", connexion);

                delete1.ExecuteNonQuery();

            }
            connexion.Close();

            List<string> arret_intervalle = get_id_arret_fin(listArret);
            connexion.Open();

            delete1 = new MySqlCommand($"INSERT INTO Ligne (nom_ligne,nb_arret,id_arret_depart,id_arret_fin) VALUES('{txt1.Text}',{listArret.Count()},{arret_intervalle[0]},{arret_intervalle[arret_intervalle.Count()-1]});", connexion);

            delete1.ExecuteNonQuery();

            connexion.Close();

            

            connexion.Open();

            MySqlCommand mysqlcom = new MySqlCommand("select * from Ligne;", connexion);
            MySqlDataReader mysqlread = mysqlcom.ExecuteReader(CommandBehavior.CloseConnection);

            while (mysqlread.Read())
            {
                if (mysqlread.GetString(1) == txt1.Text)
                {
                    id_ligne = mysqlread.GetInt32(0);
                }

            }
            connexion.Close();

            connexion.Open();

            for(int i = 0; i < listArret.Count; i++)
            {
                delete1 = new MySqlCommand($"INSERT INTO Correspondance (id_arret,id_ligne,rang_arret_ligne,heure_premier_bus,heure_dernier_bus) VALUES({arret_intervalle[i]},{id_ligne},{i+1},'{listArret[i].Item2}','20:21');", connexion);

                delete1.ExecuteNonQuery();

            }

            connexion.Close();

        }

        private void flowLayoutPanel1_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count == 0 && validerButton)
            {
                cmd3.Enabled = true;
            }
        }

        private void cmd4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<string> get_id_arret_fin(List<(string,string)> Arret)
        {
            int i = 0;
            List<string> arret = new List<string>();
            MySqlCommand mysqlcom = new MySqlCommand($"select * from Arret;", connexion); ;

            connexion.Open();

            MySqlDataReader mysqlread = mysqlcom.ExecuteReader(CommandBehavior.CloseConnection);

            while (mysqlread.Read())
            {
                foreach ((string,string) c in listArret)
                {
                    if (c.Item1 == mysqlread.GetString(1))
                    {
                        arret.Add(mysqlread.GetString(0));
                    }
                }
                    
            }



            connexion.Close();




            return arret;
        } 
    }
}
