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
using System.Diagnostics;

namespace SAE2_1
{
    public partial class FormDeModifLigne : Form
    {
        public List<string> Arret = new List<string>();
        public List<string> HoraireArret = new List<string>();
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
            new_arret_btn.Width = flowLayoutPanel1.Width-25;
            new_arret_btn.Height = 23;
            lbl_titre.Text = $"Modification de la ligne : {this.Text}";
            
            MySqlCommand arretcom = new MySqlCommand("select Arret.nom_arret,heure_premier_bus from Correspondance,Ligne,Arret where Correspondance.id_ligne = Ligne.id_ligne and Correspondance.id_arret = Arret.id_arret and Ligne.nom_ligne =" + '\u0022' + this.Text + '\u0022' + " order by rang_arret_ligne;", connexion);

            connexion.Open();

            MySqlDataReader mysqlread = arretcom.ExecuteReader(CommandBehavior.CloseConnection);

            while (mysqlread.Read())
            {
                string nom = mysqlread.GetString(0);
                string horaire = mysqlread.GetString(1);
                HoraireArret.Add(horaire);
                Arret.Add(nom);

            }

            spawnButton(Arret, HoraireArret);

           connexion.Close();

            
        }
        private void spawnButton(List<string> Arret, List<string> HoraireArret)
        {
            for (int i = 0; i < Arret.Count(); i++)
            {
                Button button = new Button();
                button.MouseUp += new MouseEventHandler(btnMouseUp);
                button.MouseMove += btn_MouseMove;
                button.Text = Arret[i];
                button.Width = flowLayoutPanel1.Width - 25;
                button.Tag = HoraireArret[i];
                button.Location = new Point(0, button.Height * i);
           
                this.flowLayoutPanel1.Controls.Add(button);
            }
        }

        private void btnMouseUp(object sender, MouseEventArgs e)
        {
            
            Button btn = (Button)sender;
            Frm_createArret frmCreateArret = new Frm_createArret();

            DialogResult result = frmCreateArret.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;

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

        private void cmd2_Click(object sender, EventArgs e)
        {
            bool ModifValide = true;
            
            //regarde que tous les arret soit remplie
            foreach (Button btnArret in flowLayoutPanel1.Controls)
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
                foreach (Button btnArret in flowLayoutPanel1.Controls)
                {
                    ClassStockage.listArret.Add((btnArret.Text, (string)btnArret.Tag));
                }

                //stockage Base !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                //suppresion
                int id_ligne = ClassMySql.get_id_ligne(this.Text);
                ClassMySql.Delete_from_cresspondance(id_ligne);
                ClassMySql.Delete_from_Ligne(id_ligne);

                //crée la ligne dans la base de  donnée
                ClassMySql.Insert_Create_Arret_in_tab_arret();
                /*
                foreach ((string, string) c in ClassStockage.listArret)
                    MessageBox.Show(c.Item1);
                */

                List<string> arret_intervalle = ClassMySql.getAll_id_arret();
              
                ClassMySql.Insert_id_in_tab_ligne(this.Text, arret_intervalle);

                id_ligne = ClassMySql.get_id_ligne(this.Text);
                ClassMySql.insert_data_in_tab_correspondance(id_ligne, arret_intervalle);

                //changement de nom
                if (!String.IsNullOrEmpty(txt_new_nom.Text))
                {
                    connexion.Open();

                    MySqlCommand update = new MySqlCommand($"UPDATE Ligne SET nom_ligne = '{txt_new_nom.Text} ' WHERE nom_ligne = '{this.Text} '; ", connexion);

                    update.ExecuteNonQuery();


                    connexion.Close();
                }

                MessageBox.Show("Ligne modifier");
                ClassStockage.arretCree.Clear();
                ClassStockage.listArret.Clear();
                this.Close();
            }
            else
            {
                MessageBox.Show("Des Arret de la rajouter ne sont pas remplie");
            }
        }

        private void SpawnNouveauxArret_button()
        {
            Button button = new Button();
            button.Text = "Nouvelle Arret";
            button.MouseMove += new MouseEventHandler(btn_MouseMove);
            button.MouseUp += btnMouseUp;
            button.Size = new Size(flowLayoutPanel1.Width - 25, 23);
            button.ForeColor = Color.White;
            button.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(button);
        }

        private void btn_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            if(e.Button == MouseButtons.Left)
                if(btn.DoDragDrop(btn, DragDropEffects.Move) == DragDropEffects.Move)
                    if(btn.Parent != flowLayoutPanel1)
                        flowLayoutPanel1.Controls.Remove(btn);
                    
            
        }

        private void flowLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
            Button data = (Button)e.Data.GetData(typeof(Button));
            data.Enabled = true;

            SpawnNouveauxArret_button();

            data.Parent = (Panel)sender;
            if (!Arret.Contains(data.Text))
            {
                Arret.Add(data.Text);
            }
        }

        private void flowLayoutPanel1_DragOver(object sender, DragEventArgs e)
        {
            Button data = (Button)e.Data.GetData(typeof(Button));
            data.Enabled = false;
            data.Parent = (Panel)sender;

            Point p = flowLayoutPanel1.PointToClient(new Point(e.X, e.Y));

            List<Button> list = flowLayoutPanel1.Controls.OfType<Button>().ToList();

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

            int index = flowLayoutPanel1.Controls.GetChildIndex(btnNear, false);
            flowLayoutPanel1.Controls.SetChildIndex(data, index);

            flowLayoutPanel1.Invalidate();
        }

        private void flowLayoutPanel1_DragLeave(object sender, EventArgs e)
        {
            List<Button> list = flowLayoutPanel1.Controls.OfType<Button>().ToList();

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
                int indexFantome = flowLayoutPanel1.Controls.GetChildIndex(btnFantome, false);
                flowLayoutPanel1.Controls.RemoveAt(indexFantome);

                flowLayoutPanel1.Invalidate();

                if (Arret.Contains(btnFantome.Text))
                {
                    btnFantome.Parent = flowLayoutPanel1;
                    flowLayoutPanel1.Controls.SetChildIndex(btnFantome, indexFantome);
                    btnFantome.Enabled = true;
                    flowLayoutPanel1.Invalidate();
                }
            }
        }

        private void flowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {
             
            Button data = (Button)e.Data.GetData(typeof(Button));
            if (flowLayoutPanel1.Contains(data))
            {
                int indexBtn = flowLayoutPanel1.Controls.GetChildIndex(data, false);
                flowLayoutPanel1.Controls.RemoveAt(indexBtn);
            }
            
        }

        private void flp2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Button)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}
