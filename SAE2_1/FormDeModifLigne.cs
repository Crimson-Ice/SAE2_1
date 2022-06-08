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
using ClassSQL;

namespace SAE2_1
{
    public partial class FormDeModifLigne : Form
    {
        public List<string> Arret = new List<string>();
        public List<string> HoraireArret = new List<string>();

        public FormDeModifLigne()
        {
            InitializeComponent();
        }

        private void FormDeModifLigne_Load(object sender, EventArgs e)
        {
            new_arret_btn.Width = flp_arret.Width-25;
            new_arret_btn.Height = 23;
            lbl_titre.Text = $"Modification de la ligne : {this.Text}";
            
            List<(string,string)> arret_firstBus = ClassMySql.get_arretName_and_Firstbus(this.Text);
            foreach((string,string) s in arret_firstBus)
            {
                HoraireArret.Add(s.Item2);
                Arret.Add(s.Item1);
            }

            spawnButton_arret_existant(Arret, HoraireArret);
        }

        /// <summary>
        /// ajoute des buttons qui représente des arret dans le flowlaoutpanel flp_arret
        /// </summary>
        /// <param name="Arret">nom des arret</param>
        /// <param name="HoraireArret">horaire de premier bus des arret</param>
        private void spawnButton_arret_existant(List<string> Arret, List<string> HoraireArret)
        {
            for (int i = 0; i < Arret.Count(); i++)
            {
                Button button = new Button();
                button.MouseUp += new MouseEventHandler(btnMouseUp);
                button.MouseMove += btn_MouseMove;
                button.Text = Arret[i];
                button.Width = flp_arret.Width - 25;
                button.Tag = HoraireArret[i];
                button.Location = new Point(0, button.Height * i);
           
                this.flp_arret.Controls.Add(button);
            }
        }

        private void btnMouseUp(object sender, MouseEventArgs e)
        {
            //crée un formulaire de création d'arret(modification)
            Button btn = (Button)sender;
            Frm_createArret frmCreateArret = new Frm_createArret();

            DialogResult result = frmCreateArret.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                //change les certianes couleurs du buttons
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;

                //stockage des données saisie dans le formulaire création d'arret
                if (frmCreateArret.chk_ArretExistant.Checked)
                {
                    btn.Text = frmCreateArret.cbo_ArretExistant.SelectedItem.ToString();
                    btn.Tag = frmCreateArret.dtp_HorairePremierBus.Text;
                }
                else
                {
                    btn.Text = frmCreateArret.txt_NomArret.Text.ToString();
                    btn.Tag = frmCreateArret.dtp_HorairePremierBus.Text;
                    ClassStockage.arretCree.Add(frmCreateArret.txt_NomArret.Text.ToString());
                }
            }
            
            frmCreateArret.Dispose();
        }

        private void cmd_valider_Click(object sender, EventArgs e)
        {
            bool ModifValide = true;
            
            //regarde que tous les arret soit remplie
            foreach (Button btnArret in flp_arret.Controls)
            {
                if (btnArret.Tag == null || btnArret.Text == "Nouvelle Arret")
                {
                    ModifValide = false;
                }
            }

            //envoie une message si les arret ne sont pas remplie
            if(ModifValide)
            {
                //stock les données dans une liste
                foreach (Button btnArret in flp_arret.Controls)
                {
                    ClassStockage.listArret.Add((btnArret.Text, (string)btnArret.Tag));
                }

                //stockage de la modification dans la base

                //suppresion
                int id_ligne = ClassMySql.Get_id_ligne(this.Text);
                ClassMySql.Delete_from_cresspondance(id_ligne);
                ClassMySql.Delete_from_Ligne(id_ligne);

                //crée la ligne dans la base de  donnée
                ClassMySql.Insert_Create_Arret_in_tab_arret();

                List<string> arret_intervalle = ClassMySql.GetAll_id_arret();
              
                ClassMySql.Insert_id_in_tab_ligne(this.Text, arret_intervalle);

                id_ligne = ClassMySql.Get_id_ligne(this.Text);
                ClassMySql.insert_data_in_tab_correspondance(id_ligne, arret_intervalle);


                //changement de nom
                if (!String.IsNullOrEmpty(txt_new_nom.Text))
                {
                    ClassMySql.change_ligne_name(txt_new_nom.Text, this.Text);
                }

                MessageBox.Show("Ligne modifier");
                ClassStockage.arretCree.Clear();
                ClassStockage.listArret.Clear();
                this.Close();
            }
            else
            {
                MessageBox.Show("Des Arret rajouter dans la ligne n'ont pas été crée(arret en bleu)");
            }
        }

        /// <summary>
        /// crée un button nouvelle arret à chaque fois que l'on glisse un button dans la ligne
        /// </summary>
        private void SpawnNouveauxArret_button()
        {
            Button button = new Button();
            button.Text = "Nouvelle Arret";
            button.MouseMove += new MouseEventHandler(btn_MouseMove);
            button.MouseUp += btnMouseUp;
            button.Size = new Size(flp_arret.Width - 25, 23);
            button.ForeColor = Color.White;
            button.BackColor = SystemColors.HotTrack;
            pnl_nouvelle_arret.Controls.Add(button);
        }

        private void btn_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            if(e.Button == MouseButtons.Left)
                if(btn.DoDragDrop(btn, DragDropEffects.Move) == DragDropEffects.Move)
                    if(btn.Parent != flp_arret)
                        flp_arret.Controls.Remove(btn);
        }

        private void flp_arret_DragDrop(object sender, DragEventArgs e)
        {
            //active le button si celui est déposer dans le panel
            Button data = (Button)e.Data.GetData(typeof(Button));
            data.Enabled = true;

            SpawnNouveauxArret_button();

            data.Parent = (Panel)sender;

            //si ce button ne fait pas partie de la liste arret alors le rajoute dedans
            if (!Arret.Contains(data.Text))
            {
                Arret.Add(data.Text);
            }
        }

        private void flp_arret_DragOver(object sender, DragEventArgs e)
        {
            Button data = (Button)e.Data.GetData(typeof(Button));
            data.Enabled = false;
            data.Parent = (Panel)sender;

            Point p = flp_arret.PointToClient(new Point(e.X, e.Y));

            List<Button> list = flp_arret.Controls.OfType<Button>().ToList();

            int min = 10000;
            Button btnNear = null;
            foreach (Button child in list)
            {
                if (child.Location.Y >= p.Y && child.Location.Y < min)
                {
                    min = child.Location.Y;
                    btnNear = child;
                }
            }

            int index = flp_arret.Controls.GetChildIndex(btnNear, false);
            flp_arret.Controls.SetChildIndex(data, index);

            flp_arret.Invalidate();
        }

        private void flp_arret_DragLeave(object sender, EventArgs e)
        {
            List<Button> list = flp_arret.Controls.OfType<Button>().ToList();

            Button btnFantome = null;

            foreach (Button child in list)
            {
                if (child.Enabled == false)
                {
                    btnFantome = child;
                }
            }

            if(btnFantome != null)
            {
                int indexFantome = flp_arret.Controls.GetChildIndex(btnFantome, false);
                flp_arret.Controls.RemoveAt(indexFantome);

                flp_arret.Invalidate();

                if (Arret.Contains(btnFantome.Text))
                {
                    btnFantome.Parent = flp_arret;
                    flp_arret.Controls.SetChildIndex(btnFantome, indexFantome);
                    btnFantome.Enabled = true;
                    flp_arret.Invalidate();
                }
            }
        }

        private void flp_DragEnter(object sender, DragEventArgs e)
        {
            //si l'objet glisser est un button alors met un effect de drapdrop move sur la souris sinon met aucun effect(croix rouge)
            if(e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void flp_poubelle_DragDrop(object sender, DragEventArgs e)
        {
            //si l'objet est déposé dans la poubelle et qu'il fait partie du panel des arrets de la ligne celui ci sera enlever du panel
            Button data = (Button)e.Data.GetData(typeof(Button));
            if (flp_arret.Contains(data))
            {
                int indexBtn = flp_arret.Controls.GetChildIndex(data, false);
                flp_arret.Controls.RemoveAt(indexBtn);
            } 
        }
    }
}
