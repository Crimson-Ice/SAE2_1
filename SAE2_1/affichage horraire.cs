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

        public List<string> paterne_base = new List<string>() { "01:00/00:45/00:13/00:47/00:20/00:20/00:20/00:20/00:20/00:20/00:20/00:20/00:20/00:20/00:20/00:20/00:20/00:20/00:18/00:20/00:22/00:20/00:20/00:20/00:20/00:20/00:20/00:20/00:20/00:20/00:20/00:20/00:20/00:20/00:20/00:20/00:28/00:32/00:30/00:30/00:30/00:30"
                                                                ,"00:29/00:1/00:10/00:38/00:34/00:34/00:34/00:34/00:34/00:34/00:44/00:44/00:30/00:10/00:10/00:33/00:33/00:33/00:33/00:33/00:33/00:33/00:33/00:36/00:36/00:36/00:36/00:36/00:36" };
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

            string[] horaire = {};
            dgvHoraire.ColumnCount = 3;

            if (this.Text == "Ligne 1")
            {
                horaire = paterne_base[0].Split('/');
               
                dgvHoraire.ColumnCount= horaire.Length;
             
            }else if (this.Text == "Ligne 2")
            {
                horaire = paterne_base[1].Split('/');

                dgvHoraire.ColumnCount = horaire.Length;
            }

            for (int i = 0; i < Form_affichage.arret.Count(); i++)
            {
                dgvHoraire.Rows.Add(Form_affichage.arret[i]);

                for(int k = 1; k < horaire.Length; k++)
                {
                    
                    if(k== 1)
                    {
                        dgvHoraire.Rows[i].Cells[k].Value = arret_horaire[i];
                    }
                    else
                    {
                        TimeSpan dt = TimeSpan.Parse(dgvHoraire.Rows[i].Cells[k - 1].Value.ToString());
                        dgvHoraire.Rows[i].Cells[k].Value = dt + TimeSpan.Parse(horaire[k-2]);
                        
                    }
                    
                }
                
            }
            
        }
    }
}
