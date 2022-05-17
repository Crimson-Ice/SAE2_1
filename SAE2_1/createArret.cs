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
    public partial class Frm_createArret : Form
    {
        public Frm_createArret()
        {
            InitializeComponent();
        }

        private void Frm_createArret_Load(object sender, EventArgs e)
        {
            //Remplisage de la comboBox ArretExistant avec les arrets crée précédamment
            foreach (string s in CréationLigne.arretCree)
            {
                cbo_ArretExistant.Items.Add(s);
            }
            //Affiche l'horaire minimum à rentré sur le label précision et la selection d'horaire 
            lbl_PrecisionPremierHoraire.Text = $"L'horaire du premier bus doit être supérieur à {CréationLigne.time.Hours} : {string.Format("{0:00}", CréationLigne.time.Minutes)}";
            dtp_HorairePremierBus.Text = $"{ CréationLigne.time.Hours} : {string.Format("{0:00}", CréationLigne.time.Minutes + 1)}";

            RemplisageComboBox();
        }

        /// <summary>
        /// Rempli la comboBox avec tout les arrets de la base
        /// </summary>
        private void RemplisageComboBox()
        {
            ClassMySql.connection();

            ClassMySql.RequeteSQl("select * from Arret");

            ClassMySql.Reading();

            while (ClassMySql.ISread())
            {
                cbo_ArretExistant.Items.Add(ClassMySql.Attribut(1));
            }

            ClassMySql.CloseConnexion();
        }

        /// <summary>
        /// verifi si tous les caratères rentrée sont des lettres ou des chiffres
        /// </summary>
        /// <param name="text">chaine de caractère à verifier</param>
        /// <returns>return un booléen true si la chaine est composé de lettre et/ou de chiffre sinon false</returns>
        private bool verifTextValid(string text)
        {
            foreach (char c in txt_NomArret.Text)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void chk1_Click(object sender, EventArgs e)
        {
            //quand la checkbox arretExistant est check desactive et active les bon élements du formulaire
            if (chk_ArretExistant.Checked)
            {
                lbl_ArretExistant.Enabled = true;
                cbo_ArretExistant.Enabled = true;
                lbl_NomArret.Enabled = false;
                txt_NomArret.Enabled = false;
            }
            else
            {
                lbl_ArretExistant.Enabled = false;
                cbo_ArretExistant.Enabled = false;
                lbl_NomArret.Enabled = true;
                txt_NomArret.Enabled = true;
            }
        }
        private void txt_NomArret_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbo_ArretExistant_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Active le button valider si un élément est selectionner dans la combobox
            cmd_Valider.Enabled = true;
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            //split de l'horaire en deux (heure, minute
            string[] t = dtp_HorairePremierBus.Text.Split(':');

            ValidationArret(t);
        }

        /// <summary>
        /// valide l'arret si l'horaire remplie est valider
        /// </summary>
        /// <param name="t"></param>
        private void ValidationArret(string[] t)
        {
            if (double.Parse(t[0]) > CréationLigne.time.Hours)
            {
                this.DialogResult = DialogResult.OK;
                CréationLigne.time = new TimeSpan(int.Parse(t[0]), int.Parse(t[1]), 00);

                this.Close();
            }
            else if (double.Parse(t[0]) == CréationLigne.time.Hours)
            {
                if (double.Parse(t[1]) > CréationLigne.time.Minutes)
                {
                    this.DialogResult = DialogResult.OK;
                    CréationLigne.time = new TimeSpan(int.Parse(t[0]), int.Parse(t[1]), 00);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("non valid minute");
                    errorProvider1.SetError(dtp_HorairePremierBus, $"Horaire du premier bus doit etre suprérieur a {CréationLigne.time.Hours} :  {string.Format("{0:00}", CréationLigne.time.Minutes)}");
                }
            }
            else
            {
                MessageBox.Show("non valid heure");
                errorProvider1.SetError(dtp_HorairePremierBus, $"Horaire du premier bus doit etre suprérieur a {CréationLigne.time.Hours} :  {string.Format("{0:00}", CréationLigne.time.Minutes)}");
            }
        }
    }
}
