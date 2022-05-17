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
    public partial class affichage_horraire : Form
    {

        public List<string> arret_horaire = new List<string>();
        public affichage_horraire()
        {
            InitializeComponent();
        }

        private void affichage_horraire_Load_1(object sender, EventArgs e)
        {
            ClassMySql.connection();

            ClassMySql.RequeteSQl("select * from Correspondance,Ligne,Arret where Correspondance.id_ligne = Ligne.id_ligne and Correspondance.id_arret = Arret.id_arret and Ligne.nom_ligne =" + '\u0022' + this.Text + '\u0022' + " order by rang_arret_ligne;");

            ClassMySql.Reading();

            while (ClassMySql.ISread())
            {
                arret_horaire.Add(ClassMySql.Attribut(3));
            }

            ClassMySql.CloseConnexion();

            dgvHoraire.ColumnCount = 3;

            for (int i = 0; i < Form_affichage.arret.Count(); i++)
            {
                dgvHoraire.Rows.Add(Form_affichage.arret[i]);
                dgvHoraire.Rows[i].Cells[1].Value= arret_horaire[i];
            }
        }
    }
}
