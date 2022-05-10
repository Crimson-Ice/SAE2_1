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
                    errorProvider1.SetError(txt2, "");
                    for (int i = 0; i < n; i++)
                    {
                        Button button = new Button();
                        button.Click += buttonArretClick;
                        button.Text = "Arrêt" + (i + 1).ToString();
                        button.Width = flowLayoutPanel1.Width - 25;
                        button.Location = new Point(0, button.Height * i);
                        if(i == 0)
                        {
                            button.Enabled = true;
                        }
                        else
                        {
                            button.Enabled = false;
                        }
                        button.Tag = i;
                        this.flowLayoutPanel1.Controls.Add(button);
                    }
                }
                else
                {
                    errorProvider1.SetError(txt2, "Ceci n'est pas un nombre");
                }
            }
        }

        private void buttonArretClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Frm_createArret frmCreateArret = new Frm_createArret();

            DialogResult result = frmCreateArret.ShowDialog();
            string name = btn.Text;

            if (result == DialogResult.OK)
            {
                if((int)btn.Tag != 0)
                {
                    txt3.Text += "**************************** \r\n";
                }
                txt3.Text += $" {name} : {frmCreateArret.txt1.Text} \r\n";
                this.flowLayoutPanel1.Controls.Remove(btn);
                foreach(Control c in this.flowLayoutPanel1.Controls)
                {
                    if((int)c.Tag == (int)btn.Tag+1)
                    {
                        c.Enabled = true;
                    }
                }
            }

            frmCreateArret.Dispose();
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
