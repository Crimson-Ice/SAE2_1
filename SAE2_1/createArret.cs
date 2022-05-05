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

        private void cmd2_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txt1.Text))
            {
                this.Close();
                errorProvider1.SetError(txt1, "");
            }
            else
            {
                errorProvider1.SetError(txt1, "champ non remplie");
            }
        }
    }
}
