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

namespace SAE2_1
{
    public partial class Liste_lignes : Form
    {

        MySqlConnection connexion = new MySqlConnection("database=baseb1; server=10.1.139.236; user id=b1; pwd=nouveau_mdp");
        public Liste_lignes()
        {
            InitializeComponent();


            try
            {
                connexion.Open();
                MessageBox.Show("connecté");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("non connecté");
            }
        }

        private void Liste_lignes_Load(object sender, EventArgs e)
        {
            MySqlCommand mysqlcom = new MySqlCommand("select * from Ligne", connexion);

            MySqlDataReader mysqlread = mysqlcom.ExecuteReader(CommandBehavior.CloseConnection);

            while (mysqlread.Read())
            {
                Button button = new Button();
                button.Text = mysqlread.GetString(1);
                button.Click += Onclickbutton;
                button.Height = 30;
                button.Width = 280;

                pnl_btn.Controls.Add(button);


            }

            mysqlread.Close();
            connexion.Close();
        }


        private void Onclickbutton(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            Form_affichage form = new Form_affichage();
            form.Text = button.Text;
            form.ShowDialog();
        }


    }
}
