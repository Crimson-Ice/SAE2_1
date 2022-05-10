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
            //Connexion a la base
            ClassMySql.connection();
            
            //requete sql
            ClassMySql.RequeteSQl("select * from Arret");

            //lis la requete et recupère les données
            ClassMySql.Reading();

            while (ClassMySql.ISread())
            {
                string nom = ClassMySql.Attribut(1);
                cbo1.Items.Add(nom);
                cbo2.Items.Add(nom);
            }

            ClassMySql.CloseConnexion();
        }

        private void chk1_Click(object sender, EventArgs e)
        {
            if (chk1.Checked)
            {
                Dtp1.Visible = true;
                chk2.Checked = false;
                Dtp2.Visible = false;
            }
            else if(chk1.Checked == false)
            {
                Dtp1.Visible = false;

                Dtp2.Visible = false;
            }
        }

        private void chk2_Click(object sender, EventArgs e)
        {
            if (chk2.Checked)
            {
                chk1.Checked = false;
                Dtp2.Visible = true;
                Dtp1.Visible = false;
            }
            else if(chk2.Checked == false)
            {
                Dtp2.Visible = false;

                Dtp1.Visible = false;
            }
        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            //recherche d'itinéraire
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
