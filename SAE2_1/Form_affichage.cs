using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassSQL;

namespace SAE2_1
{
    public partial class Form_affichage : Form
    {
        public bool verif = true;

        public static List<string> arret = new List<string>();

        private Random rnd = new Random();

        public Form_affichage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Déssine la ligne dans la picturebox du formulaire
        /// </summary>
        /// <param name="nb_arret">nombre d'arret</param>
        /// <param name="hauteur_panel">parametre fixe</param>
        /// <param name="largeur_panel">parametre fixe</param>
        /// <param name="longeurligne">parametre fixe</param>
        /// <param name="diametrecercle">parametre fixe</param>
        /// <param name="marge_gauche">parametre fixe</param>
        /// <param name="arret">Liste des arrets</param>
        private void ligne(int nb_arret, int hauteur_panel, int largeur_panel, int longeurligne, int diametrecercle, int marge_gauche, List<string> arret)
        {

            int Xronddeb = marge_gauche;
            int Xlignedebut = Xronddeb + diametrecercle;
            int Xlignefin = Xlignedebut + longeurligne;

            Bitmap flag = new Bitmap(100000, 200);
            pb_LigneAffiche.Width = 100000;
            Graphics flagGraphics = Graphics.FromImage(flag);

            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            Brush brushrond = new SolidBrush(randomColor);
            Brush brushligne = new SolidBrush(randomColor);
            Pen pen;


            for (int i = 0; i < nb_arret; i++)
            {
                Point location;
                Font drawFont = new Font(new FontFamily("Arial"), 50, FontStyle.Regular, GraphicsUnit.Document);

                if (i % 2 == 0)
                {
                    location = new Point(Xronddeb + (diametrecercle / 2), (hauteur_panel / 2) - (diametrecercle) - 8);

                }
                else
                {
                    location = new Point(Xronddeb + (diametrecercle / 2), (hauteur_panel / 2) + (diametrecercle) + 8);

                }

                flagGraphics.DrawString(arret[i], drawFont, Brushes.Black, location);

                /* Label l = new Label();
                 l.AutoSize = false;
                 l.BackColor = Color.Transparent;
                 l.Location= location;
                 l.TextAlign = ContentAlignment.MiddleLeft;
                 l.Font = new Font("Arial", 8);

                 l.Text = arret[i];
                 pictureBox1.Controls.Add(l);

                 //pictureBox1.Show(); */

                pen = new Pen(brushrond, 3);
                flagGraphics.DrawEllipse(pen, Xronddeb, (hauteur_panel / 2) - (diametrecercle / 2), diametrecercle, diametrecercle);

                if (i != nb_arret - 1)
                {
                    pen = new Pen(brushligne, 3);
                    flagGraphics.DrawLine(pen, Xlignedebut, hauteur_panel / 2, Xlignefin, hauteur_panel / 2);
                }

                pb_LigneAffiche.Width = pb_LigneAffiche.Width - (pb_LigneAffiche.Width - (longeurligne + diametrecercle) * nb_arret) + 50;

                Xronddeb = Xlignefin;
                Xlignedebut = Xlignefin + diametrecercle;
                Xlignefin = Xlignedebut + longeurligne;
            }

            pb_LigneAffiche.Image = flag;

            hSB.Maximum = pb_LigneAffiche.Width - this.Size.Width;
        }

        private void hSB_Scroll(object sender, ScrollEventArgs e)
        {
            //pnl.Location = new Point(pnl.Location.X - this.hSB.Value, pnl.Location.Y);

            this.pb_LigneAffiche.Left = -this.hSB.Value;
        }

        private void Form_affichage_TextChanged(object sender, EventArgs e)
        {
            lbl_nom_ligne.Text = this.Text;
            lbl_nom_ligne.BackColor = Color.Transparent;
        }

        private void Form_affichage_Load(object sender, EventArgs e)
        {
            arret.Clear();
            ClassMySql.connection();
            ClassMySql.RequeteSQl("select Arret.nom_arret from Correspondance,Ligne,Arret where Correspondance.id_ligne = Ligne.id_ligne and Correspondance.id_arret = Arret.id_arret and Ligne.nom_ligne =" + '\u0022' + this.Text + '\u0022' + " order by rang_arret_ligne;");

            ClassMySql.Reading();

            while (ClassMySql.ISread())
            {
                string nom = ClassMySql.Attribut(0);
                arret.Add(nom);
            }

            int haut = pb_LigneAffiche.Height;
            int larg = pb_LigneAffiche.Width;
            int nbarret = arret.Count();

            ligne(nbarret, haut, larg, 100, 30, 30, arret);

            lbl_arret_departAffiche.Text = arret[0];
            lbl_arret_finAffiche.Text = arret[arret.Count()-1];

        }

        private void cmd_horaire_Click(object sender, EventArgs e)
        {
            affichage_horraire horraire_from = new affichage_horraire();
            horraire_from.Text = this.Text;
            horraire_from.ShowDialog();
        }
    }
}
