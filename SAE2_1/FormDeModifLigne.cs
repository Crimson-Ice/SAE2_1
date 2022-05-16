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


                MySqlCommand update = new MySqlCommand($"UPDATE Ligne SET nom_ligne = '{txt_new_nom.Text} ' WHERE nom_ligne = '{this.Text} '; ", connexion);

                update.ExecuteNonQuery();

                
                connexion.Close();
            }


            this.Close();
            
        }

        private void SpawnNouveauxArret_button()
        {
            Button button = new Button();
            button.Text = "Nouvelle Arret";
            button.MouseDown += new MouseEventHandler(this.MouseDown);
            button.Size = new Size(flowLayoutPanel1.Width - 25, 23);
            button.Location = new Point(344, 150); ;
            this.Controls.Add(button);
        }

        private void spawnButton(List<string> Arret)
        {
            for (int i = 0; i < Arret.Count(); i++)
            {
                Button button = new Button();
                button.Text = Arret[i];
                button.Width = flowLayoutPanel1.Width - 25;
                button.Tag = i;
                button.Location = new Point(0, button.Height * i);
                button.MouseDown += new MouseEventHandler(this.MouseDown);
                this.flowLayoutPanel1.Controls.Add(button);
            }
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.DoDragDrop(btn, DragDropEffects.Move);
        }


        private void flowLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
            Button data = (Button)e.Data.GetData(typeof(Button));
            data.Enabled = true;

            SpawnNouveauxArret_button();

            data.Parent = (Panel)sender;
            if(!Arret.Contains(data.Text))
            {
                Arret.Add(data.Text);
            }
        }

        private void flowLayoutPanel1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;

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

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {
            Button data = (Button)e.Data.GetData(typeof(Button));
            if(flowLayoutPanel1.Contains(data))
            {
                int indexBtn = flowLayoutPanel1.Controls.GetChildIndex(data, false);
                flowLayoutPanel1.Controls.RemoveAt(indexBtn);
            }
        }

        private void panel2_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
    }
}
