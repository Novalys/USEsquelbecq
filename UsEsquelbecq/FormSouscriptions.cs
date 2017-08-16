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
    public partial class FormSouscriptions : Form
    {
        public FormSouscriptions()
        {
            InitializeComponent();
        }

        private void buttonAjouterSouscription_Click(object sender, EventArgs e)
        {
            FormAjouterSouscription formAjoutSous = new FormAjouterSouscription();
            formAjoutSous.ShowDialog();
        }

        private void buttonModifierSouscription_Click(object sender, EventArgs e)
        {
            FormAjouterSouscription formModSous = new FormAjouterSouscription();
            formModSous.Text = "Modifier une souscription";
            formModSous.Controls["buttonAjouterSouscription"].Text = "Modifier";
            formModSous.ShowDialog();
        }

        private void buttonSupprimerSouscription_Click(object sender, EventArgs e)
        {
            FormSupprimer formSupp = new FormSupprimer();
            formSupp.ShowDialog();
        }

        private void buttonRetourSouscription_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
