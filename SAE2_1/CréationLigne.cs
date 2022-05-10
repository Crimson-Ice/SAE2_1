using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE2_1
{
    public partial class CréationLigne : Form
    {
        public bool validerButton = false;
        public CréationLigne()
        {
            InitializeComponent();
        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            validerButton = true;
            bool empty = false;
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrWhiteSpace(tb.Text) && tb != txt3)
                {
                    empty = true;
                    errorProvider1.SetError(tb, "Champ non saisi");
                }
                else
                {
                    errorProvider1.SetError(tb, "");
                }
            }
            if (empty == false)
            {
                int n;
                bool isNumeric = int.TryParse(txt2.Text, out n);
                if (isNumeric)
                {
                    if(int.Parse(txt2.Text) <= 50)
                    {
                        errorProvider1.SetError(txt2, "");
                        spawnButton(n);
                    }
                    else
                    {
                        errorProvider1.SetError(txt2, "Le nombre est trop grand");
                    }
                }
                else
                {
                    errorProvider1.SetError(txt2, "Ceci n'est pas un nombre");
                }
            }
        }

        /// <summary>
        /// fait spawn les button dans le panel des arrets
        /// </summary>
        /// <param name="n">nombre de button a faire spawn</param>
        private void spawnButton(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Button button = new Button();
                button.Click += buttonArretClick;
                button.Text = "Arrêt" + (i + 1).ToString();
                button.Width = flowLayoutPanel1.Width - 25;
                button.Tag = i;
                button.Location = new Point(0, button.Height * i);
                this.flowLayoutPanel1.Controls.Add(button);

                if (i == 0)
                {
                    button.Enabled = true;
                }
                else
                {
                    button.Enabled = false;
                }
            }
        }

        private void buttonArretClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Frm_createArret frmCreateArret = new Frm_createArret();

            DialogResult result = frmCreateArret.ShowDialog();

            if (result == DialogResult.OK)
            {
                Affiche_Nom_Arret_Cree(btn, frmCreateArret);
            }

            frmCreateArret.Dispose();
        }

        /// <summary>
        /// Affiche dans la textbox le nom de l'arret crée ou selectionner
        /// </summary>
        /// <param name="btn">button actuel</param>
        /// <param name="frmCreateArret">formulaire crée avec le button actuel</param>
        private void Affiche_Nom_Arret_Cree(Button btn, Frm_createArret frmCreateArret)
        {
            string name = btn.Text;

            if ((int)btn.Tag != 0)
            {
                txt3.Text += "**************************** \r\n";
            }

            if (frmCreateArret.chk1.Checked)
            {
                txt3.Text += $" {name} : {frmCreateArret.cbo1.SelectedItem} \r\n";
            }
            else
            {
                txt3.Text += $" {name} : {frmCreateArret.txt1.Text} \r\n";
            }

            this.flowLayoutPanel1.Controls.Remove(btn);

            foreach (Control control in this.flowLayoutPanel1.Controls)
            {
                if ((int)control.Tag == (int)btn.Tag + 1)
                {
                    control.Enabled = true;
                }
            }
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txt1.Text) || !string.IsNullOrWhiteSpace(txt2.Text))
            {
                cmd1.Enabled = true;
                cmd2.Enabled = true;
            }
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            if(validerButton)
            {
                validerButton = false;

                this.flowLayoutPanel1.Controls.Clear();
                txt3.Text = "";
                txt1.Text = "";
                txt2.Text = "";
                cmd1.Enabled = false;
                cmd2.Enabled = false;
                cmd3.Enabled = false;

            }
        }

        private void cmd3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Création d'arret");
        }

        private void flowLayoutPanel1_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count == 0 && validerButton)
            {
                cmd3.Enabled = true;
            }
        }

        private void cmd4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
