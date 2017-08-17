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
    public partial class FormParticipation : Form
    {
        public FormParticipation()
        {
            InitializeComponent();
        }

        private void buttonAjouterParticpation_Click(object sender, EventArgs e)
        {
            FormAjouterParticipation formAjoutPar = new FormAjouterParticipation();
            formAjoutPar.ShowDialog();
        }

        private void buttonModifierParticpation_Click(object sender, EventArgs e)
        {
            FormAjouterParticipation formModPar = new FormAjouterParticipation();
            formModPar.Text = "Modifier une participation";
            formModPar.Controls["buttonAjouterParticipation"].Text = "Modifier";
            formModPar.ShowDialog();
        }

        private void buttonSupprimerParticpation_Click(object sender, EventArgs e)
        {
            FormSupprimer formSupp = new FormSupprimer();
            formSupp.ShowDialog();
        }

        private void buttonRetourParticpation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEvenement_Click(object sender, EventArgs e)
        {
            FormEvenement formEve = new FormEvenement();
            formEve.ShowDialog();
        }
    }
}
