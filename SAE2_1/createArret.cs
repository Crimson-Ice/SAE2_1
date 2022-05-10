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
    public partial class Frm_createArret : Form
    {
        public Frm_createArret()
        {
            InitializeComponent();
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


    }
}
