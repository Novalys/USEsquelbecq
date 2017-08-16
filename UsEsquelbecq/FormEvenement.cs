using System;
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
    public partial class FormEvenement : Form
    {
        public FormEvenement()
        {
            InitializeComponent();
        }

        private void buttonAjouterEvenement_Click(object sender, EventArgs e)
        {
            FormAjouterEvenement formAjoutEve = new FormAjouterEvenement();
            formAjoutEve.ShowDialog();
        }

        private void buttonModifierEvenement_Click(object sender, EventArgs e)
        {
            FormAjouterEvenement formModEve = new FormAjouterEvenement();
            formModEve.Text = "Modifier un événement";
            formModEve.Controls["buttonAjouterEvenement"].Text = "Modifier";
            formModEve.ShowDialog();
        }

        private void buttonSupprimerEvenement_Click(object sender, EventArgs e)
        {
            FormSupprimer formSupp = new FormSupprimer();
            formSupp.ShowDialog();
        }

        private void buttonRetourEvenement_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
