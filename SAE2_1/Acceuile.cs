﻿using System;
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
    public partial class Acceuille : Form
    {
        public Acceuille()
        {
            InitializeComponent();
        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            Itinéraire frmAjout = new Itinéraire();
            frmAjout.ShowDialog();
            frmAjout.Dispose();
        }

        private void cmd3_Click(object sender, EventArgs e)
        {
            CréationLigne frmAjout = new CréationLigne();
            frmAjout.ShowDialog();
            frmAjout.Dispose();
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            Liste_lignes form = new Liste_lignes();
            form.ShowDialog();
        }
    }
}