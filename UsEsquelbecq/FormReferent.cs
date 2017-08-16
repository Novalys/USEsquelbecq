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
    public partial class FormReferent : Form
    {
        public FormReferent()
        {
            InitializeComponent();
        }

        private void buttonAjouterReferent_Click(object sender, EventArgs e)
        {
            FormAjouterReferent formAjoutRef = new FormAjouterReferent();
            formAjoutRef.ShowDialog();
        }

        private void buttonModifierReferent_Click(object sender, EventArgs e)
        {
            FormAjouterReferent formModRef = new FormAjouterReferent();
            formModRef.Text = "Modifier un référent";
            formModRef.Controls["buttonAjouterReferent"].Text = "Modifier";
            formModRef.ShowDialog();
        }

        private void buttonSupprimerReferent_Click(object sender, EventArgs e)
        {
            FormSupprimer formSupp = new FormSupprimer();
            formSupp.ShowDialog();
        }

        private void buttonRetourReferent_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
