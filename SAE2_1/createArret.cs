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

            ClassMySql.connection();

            

            ClassMySql.RequeteSQl("select * from Arret");

            ClassMySql.Reading();

            while(ClassMySql.ISread())
            {
                cbo1.Items.Add(ClassMySql.Attribut(1));
            }

            ClassMySql.CloseConnexion();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt1.Text))
            {
                errorProvider1.SetError(txt1, "");
                cmd2.Enabled = true;
            }
            else
            {
                cmd2.Enabled = false;
                errorProvider1.SetError(txt1, "champ non remplie");
            }
        }

        private void chk1_Click(object sender, EventArgs e)
        {
            if(chk1.Checked)
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
    }
}
