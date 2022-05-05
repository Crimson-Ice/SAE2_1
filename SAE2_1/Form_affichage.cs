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
    public partial class Form_affichage : Form
    {
        public MySqlConnection connexion = new MySqlConnection("database=baseb1; server=10.1.139.236; user id=b1; pwd=nouveau_mdp");

        public List<string> arret = new List<string>();
        public Form_affichage()
        {
            InitializeComponent();
        }

        private void Form_affichage_Load(object sender, EventArgs e)
        {
            MySqlCommand mysqlcom = new MySqlCommand("select Arret.nom_arret from Correspondance,Ligne,Arret where Correspondance.id_ligne = Ligne.id_ligne and Correspondance.id_arret = Arret.id_arret and Ligne.nom_ligne =" + '\u0022' + this.Text + '\u0022' + " order by rang_arret_ligne;", connexion);

            connexion.Open();

            MySqlDataReader mysqlread = mysqlcom.ExecuteReader(CommandBehavior.CloseConnection);

            while (mysqlread.Read())
            {
                string nom = mysqlread.GetString(0);
                arret.Add(nom);

            }
        }

        private void Form_affichage_TextChanged(object sender, EventArgs e)
        {
            lbl_nom_ligne.Text = this.Text;
            lbl_nom_ligne.BackColor = Color.Transparent;
        }

        private void hSB_Scroll(object sender, ScrollEventArgs e)
        {
            this.pnl.Left = -this.hSB.Value;
        }


        void ligne(int nb_arret, int hauteur_panel, int largeur_panel, int longeurligne, int diametrecercle, int marge_gauche, List<string> arret)
        {

            int Xronddeb = marge_gauche;
            int Xlignedebut = Xronddeb + diametrecercle;
            int Xlignefin = Xlignedebut + longeurligne;


            Graphics g = pnl.CreateGraphics();
            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            Brush brushrond = new SolidBrush(Color.Red);
            Brush brushligne = new SolidBrush(Color.Red);
            Pen pen;







            for (int i = 0; i < nb_arret; i++)
            {
                Point location;

                if (i % 2 == 0)
                {
                    location = new Point(Xronddeb + (diametrecercle / 2), (hauteur_panel / 2) - (diametrecercle) - 10);
                }
                else
                {
                    location = new Point(Xronddeb + (diametrecercle / 2), (hauteur_panel / 2) + (diametrecercle) + 10);
                }


                Label l = new Label();
                l.AutoSize = false;
                l.BackColor = Color.Transparent;
                l.Location = location;
                l.TextAlign = ContentAlignment.MiddleLeft;
                l.Font = new Font("Arial", 8);

                l.Text = arret[i];
                pnl.Controls.Add(l);
                pnl.Show();

                pen = new Pen(brushrond, 3);
                g.DrawEllipse(pen, Xronddeb, (hauteur_panel / 2) - (diametrecercle / 2), diametrecercle, diametrecercle);

                if (i != nb_arret - 1)
                {
                    pen = new Pen(brushligne, 3);
                    g.DrawLine(pen, Xlignedebut, hauteur_panel / 2, Xlignefin, hauteur_panel / 2);
                }



                Xronddeb = Xlignefin;
                Xlignedebut = Xlignefin + diametrecercle;
                Xlignefin = Xlignedebut + longeurligne;


                if (Xlignefin >= pnl.Width)
                {
                    pnl.Width = pnl.Width + 10;
                }


            }

            hSB.Maximum = pnl.Size.Width - this.Size.Width;

        }

        private void pnl_Paint(object sender, PaintEventArgs e)
        {
            int haut = pnl.Height;
            int larg = pnl.Width;
            int nbarret = arret.Count();




            ligne(nbarret, haut, larg, 100, 30, 30, arret);
        }
    }
}
