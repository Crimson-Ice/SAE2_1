﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClassSQL;

namespace SAE2_1
{
    public partial class CréationLigne : Form
    {
        private bool validerButton;
        public static TimeSpan time = new TimeSpan(05,00,00);
        public static List<(string, string)> listArret = new List<(string, string)>();
        public static List<string> arretCree = new List<string> ();

        public CréationLigne()
        {
            InitializeComponent();
        }

        private void cmd_Valider_Click(object sender, EventArgs e)
        {
            //clear les éléments des listes destockage d'arret
            arretCree.Clear();
            listArret.Clear();

            validerButton = true;
            bool empty = false;

            //verifi que les textboxs du control non sont pas vide (sauf celle d'affichage des arrets crée)
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrWhiteSpace(tb.Text) && tb != txt_AfficheArretCree)
                {
                    empty = true;
                    errorProvider1.SetError(tb, "Champ non saisi");
                }
                else
                {
                    errorProvider1.SetError(tb, "");
                }
            }

            //verification des saisies classic
            if (empty == false)
            {
                int n;
                bool isNumeric = int.TryParse(txt_NombreArret.Text, out n);
                if (isNumeric)
                {
                    if(int.Parse(txt_NombreArret.Text) <= 50)
                    {
                        if(verifTextValid(txt_NomLigneCree.Text))
                        {
                            errorProvider1.SetError(txt_NombreArret, "");
                            spawnButton(n);
                            cmd_Valider.Enabled = false;
                        }
                        else
                        {
                            errorProvider1.SetError(txt_NomLigneCree, "Le nom doit etre composer de lettre et/ou de chiffre");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(txt_NombreArret, "Le nombre est trop grand");
                    }
                }
                else
                {
                    errorProvider1.SetError(txt_NombreArret, "Ceci n'est pas un nombre");
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
            foreach (char c in txt_NomLigneCree.Text)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// fait spawn les buttons dans le panel des arrets
        /// </summary>
        /// <param name="n">nombre de button a faire spawn</param>
        private void spawnButton(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Button button = new Button();
                button.Click += buttonArretClick;
                button.Text = "Arrêt" + (i + 1).ToString();
                button.Width = flp_ArretCree.Width - 25;
                button.Tag = i;
                button.Location = new Point(0, button.Height * i);
                this.flp_ArretCree.Controls.Add(button);

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

        /// <summary>
        /// Fonction rajouter a chaque button crée pour faire les arrets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                txt_AfficheArretCree.Text += "**************************** \r\n";
            }

            if (frmCreateArret.chk_ArretExistant.Checked)
            {
                txt_AfficheArretCree.Text += $" {name} : {frmCreateArret.cbo_ArretExistant.SelectedItem} \r\n";
                listArret.Add((frmCreateArret.cbo_ArretExistant.SelectedItem.ToString(), frmCreateArret.dtp_HorairePremierBus.Text));
            }
            else
            {
                txt_AfficheArretCree.Text += $" {name} : {frmCreateArret.txt_NomArret.Text} \r\n";
                listArret.Add((frmCreateArret.txt_NomArret.Text, frmCreateArret.dtp_HorairePremierBus.Text));
                arretCree.Add(frmCreateArret.txt_NomArret.Text);
            }

            //supprime le button du dernier arret crée
            this.flp_ArretCree.Controls.Remove(btn);

            //Rend le button suivant Actif
            foreach (Control control in this.flp_ArretCree.Controls)
            {
                if ((int)control.Tag == (int)btn.Tag + 1)
                {
                    control.Enabled = true;
                }
            }
        }

        private void txt_NomLigneCree_Enter(object sender, EventArgs e)
        {
            //les textboxs des informations de la ligne sont rempli active les button annuler et valider
            if(!string.IsNullOrWhiteSpace(txt_NomLigneCree.Text) || !string.IsNullOrWhiteSpace(txt_NombreArret.Text))
            {
                cmd_Valider.Enabled = true;
                cmd_Annuler.Enabled = true;
            }
        }

        private void cmd_Annuler_Click(object sender, EventArgs e)
        {
            //si le button valider a deja été clicker ont reset les informations remplie dans la sur le formulaire 
            if(validerButton)
            {
                validerButton = false;

                this.flp_ArretCree.Controls.Clear();
                txt_AfficheArretCree.Text = "";
                txt_NomLigneCree.Text = "";
                txt_NombreArret.Text = "";
                cmd_Valider.Enabled = false;
                cmd_Annuler.Enabled = false;
                cmd_Terminer.Enabled = false;

                arretCree.Clear();
                listArret.Clear();
            }
        }

        private void cmd_Terminer_Click(object sender, EventArgs e)
        {
            //crée la ligne dans la base de  donnée
            int id_ligne=0;
            ClassMySql.connection();

            //insére les arrets crée dans la base de donnée
            foreach (string arret in arretCree)
            {
                ClassMySql.RequeteSQl($"INSERT INTO Arret (nom_arret,nb_ligne_desservi) VALUES('{arret}', 1);");

                ClassMySql.CommandeExecute();
            }
            ClassMySql.CloseConnexion();
            ClassMySql.connection();

            List<string> arret_intervalle = getAll_id_arret();

            ClassMySql.CloseConnexion();
            ClassMySql.connection();

            //insére les id arret dans la tablea ligne
            ClassMySql.RequeteSQl($"INSERT INTO Ligne (nom_ligne,nb_arret,id_arret_depart,id_arret_fin) VALUES('{txt_NomLigneCree.Text}',{listArret.Count()},{arret_intervalle[0]},{arret_intervalle[arret_intervalle.Count() - 1]});");

            ClassMySql.CommandeExecute();

            ClassMySql.CloseConnexion();
            ClassMySql.connection();

            //Récuppère l'id de la ligne crée
            ClassMySql.RequeteSQl("select * from Ligne;");

            ClassMySql.Reading();

            while (ClassMySql.ISread())
            {
                if (ClassMySql.Attribut(1) == txt_NomLigneCree.Text)
                {
                    id_ligne = int.Parse(ClassMySql.Attribut(0)); //mysqlread.GetInt32(0);
                }
            }

            ClassMySql.CloseConnexion();
            ClassMySql.connection();

            //insére tout les donnée recuppérer dans la table correspondance
            for (int i = 0; i < listArret.Count; i++)
            {
                ClassMySql.RequeteSQl($"INSERT INTO Correspondance (id_arret,id_ligne,rang_arret_ligne,heure_premier_bus,heure_dernier_bus) VALUES({arret_intervalle[i]},{id_ligne},{i + 1},'{listArret[i].Item2}','20:21');");

                ClassMySql.CommandeExecute();

            }

            ClassMySql.CloseConnexion();
        }

        private void flp_ArretCree_ControlRemoved(object sender, ControlEventArgs e)
        {
            //si le panel des arrets a crée est vide alors active le button terminer
            if (flp_ArretCree.Controls.Count == 0 && validerButton)
            {
                cmd_Terminer.Enabled = true;
            }
        }

        /// <summary>
        /// Reccupère tous les id des arret de la ligne crée
        /// </summary>
        /// <returns></returns>
        private List<string> getAll_id_arret()
        {
            List<string> arret = new List<string>();

            ClassMySql.RequeteSQl($"select * from Arret;");

            ClassMySql.Reading();

            while (ClassMySql.ISread())
            {
                foreach ((string,string) c in listArret)
                {
                    if (c.Item1 == ClassMySql.Attribut(1))
                    {
                        arret.Add(ClassMySql.Attribut(0));
                    }
                }
                    
            }

            return arret;
        } 
    }
}
