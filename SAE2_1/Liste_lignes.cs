using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ClassSQL;

namespace SAE2_1
{
    public partial class Liste_lignes : Form
    {
        public Liste_lignes()
        {
            InitializeComponent();
        }

        private void Liste_lignes_Load(object sender, EventArgs e)
        {
            List<string> ligne_name = ClassMySql.Get_ligne_name();
            
            //crée des buttons pour les lignes de la base de donéee
            for(int i = 0; i < ligne_name.Count; i++)
            {
                Button button = new Button();
                button.Text = ligne_name[i];
                button.Click += Onclickbutton;
                button.Height = 30;
                button.Width = pnl_btn.Width - 30;

                pnl_btn.Controls.Add(button);
            }
        }


        private void Onclickbutton(object sender, EventArgs e)
        {
            //crée le formulaire d'affichage de la ligne choisie
            Button button = (Button)sender;

            Form_affichage form = new Form_affichage();
            form.Text = button.Text;
            form.ShowDialog();
        }


    }
}
