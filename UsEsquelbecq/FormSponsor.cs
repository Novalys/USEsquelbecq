﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsEsquelbecq
{
    public partial class FormSponsor : Form
    {
        public FormSponsor()
        {
            InitializeComponent();
        }

        private void buttonAjouterSponsor_Click(object sender, EventArgs e)
        {

        }

        private void buttonModifierSponsor_Click(object sender, EventArgs e)
        {

        }

        private void buttonSupprimerSponsor_Click(object sender, EventArgs e)
        {
            FormSupprimer formSupp = new FormSupprimer();
            formSupp.ShowDialog();
        }

        private void buttonRetourSponsor_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
