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
    public partial class FormUtilisateur : Form
    {
        public FormUtilisateur()
        {
            InitializeComponent();
        }

        private void buttonAjouterUtilisateur_Click(object sender, EventArgs e)
        {
            FormAjouterUtilisateur formAjoutUti = new FormAjouterUtilisateur();
            formAjoutUti.ShowDialog();
        }

        private void buttonModifierUtilisateur_Click(object sender, EventArgs e)
        {
            FormAjouterUtilisateur formModUti = new FormAjouterUtilisateur();
            formModUti.Controls["buttonAjouterUtilisateur"].Text = "Modifier";
            formModUti.ShowDialog();
        }

        private void buttonSupprimerUtilisateur_Click(object sender, EventArgs e)
        {
            FormSupprimer formSupp = new FormSupprimer();
            formSupp.ShowDialog();
        }

        private void buttonRetourUtilisateur_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
