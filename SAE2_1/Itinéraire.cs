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
    public partial class Itinéraire : Form
    {
        public Itinéraire()
        {
            InitializeComponent();
        }

        private void Itinéraire_Load(object sender, EventArgs e)
        {
            //Connexion a la base
            ClassMySql.connection();


            //requete sql
            ClassMySql.RequeteSQl("select * from Arret");

            //lis la requete et recupère les données
            ClassMySql.Reading();

            while (ClassMySql.ISread())
            {
                string nom = ClassMySql.Attribut(1);
                cbo_arretDepart.Items.Add(nom);
                cbo_arret_fin.Items.Add(nom);
            }

            ClassMySql.CloseConnexion();
        }

        private void chk_FiltreHoraireDebut_Click(object sender, EventArgs e)
        {
            if (chk_FiltreHoraireDebut.Checked)
            {
                Dtp_hroaireDebut.Visible = true;
                chk_FiltreHoraireFin.Checked = false;
                Dtp_HoraireFin.Visible = false;
            }
            else if(chk_FiltreHoraireDebut.Checked == false)
            {
                Dtp_hroaireDebut.Visible = false;

                Dtp_HoraireFin.Visible = false;
            }
        }

        private void chk_FiltreHoraireFin_Click(object sender, EventArgs e)
        {
            if (chk_FiltreHoraireFin.Checked)
            {
                chk_FiltreHoraireDebut.Checked = false;
                Dtp_HoraireFin.Visible = true;
                Dtp_hroaireDebut.Visible = false;
            }
            else if(chk_FiltreHoraireFin.Checked == false)
            {
                Dtp_HoraireFin.Visible = false;

                Dtp_hroaireDebut.Visible = false;
            }
        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fonction non implémenté");
        }
    }
}
