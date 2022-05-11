﻿using System;
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

            foreach(string s in CréationLigne.arretCree)
            {
                cbo1.Items.Add(s);
            }
            lbl5.Text = $"L'horaire du premier bus doit être supérieur à {CréationLigne.time.Hours} : {string.Format("{0:00}", CréationLigne.time.Minutes)}";
            dtp1.Text = $"{ CréationLigne.time.Hours} : {string.Format("{0:00}", CréationLigne.time.Minutes+1)}";

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
                cbo1.Items.Add(ClassMySql.Attribut(1));
            }

            ClassMySql.CloseConnexion();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt1.Text))
            {
                if(cbo1.Items.Contains(txt1.Text))
                {
                    cmd2.Enabled = false;
                    errorProvider1.SetError(txt1, "Arret deja existant");
                }
                else
                {
                    errorProvider1.SetError(txt1, "");
                    cmd2.Enabled = true;
                }
            }
            else
            {
                cmd2.Enabled = false;
                errorProvider1.SetError(txt1, "champ non remplie");
            }
        }

        private void chk1_Click(object sender, EventArgs e)
        {
            if (chk1.Checked)
            {
                lbl3.Enabled = true;
                cbo1.Enabled = true;
                lbl2.Enabled = false;
                txt1.Enabled = false;
            }
            else
            {
                lbl3.Enabled = false;
                cbo1.Enabled = false;
                lbl2.Enabled = true;
                txt1.Enabled = true;
            }
        }

        private void cbo1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmd2.Enabled = true;
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            string[] t = dtp1.Text.Split(':');

            ValidationArret(t);
        }

        /// <summary>
        /// valide l'arret si les condition sont rempli
        /// </summary>
        /// <param name="t"></param>
        private void ValidationArret(string[] t)
        {
            if (double.Parse(t[0]) > CréationLigne.time.Hours)
            {
                MessageBox.Show("valid");
                this.DialogResult = DialogResult.OK;
                CréationLigne.time = new TimeSpan(int.Parse(t[0]), int.Parse(t[1]), 00);

                this.Close();
            }
            else if (double.Parse(t[0]) == CréationLigne.time.Hours)
            {
                if (double.Parse(t[1]) > CréationLigne.time.Minutes)
                {
                    MessageBox.Show("valid");
                    this.DialogResult = DialogResult.OK;
                    CréationLigne.time = new TimeSpan(int.Parse(t[0]), int.Parse(t[1]), 00);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("non valid minute");
                    errorProvider1.SetError(dtp1, $"Horaire du premier bus doit etre suprérieur a {CréationLigne.time.Hours} :  {string.Format("{0:00}", CréationLigne.time.Minutes)}");
                }
            }
            else
            {
                MessageBox.Show("non valid heure");
                errorProvider1.SetError(dtp1, $"Horaire du premier bus doit etre suprérieur a {CréationLigne.time.Hours} :  {string.Format("{0:00}", CréationLigne.time.Minutes)}");
            }
        }
    }
}
