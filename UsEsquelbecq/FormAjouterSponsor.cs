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
    public partial class FormAjouterSponsor : Form
    {
        public FormAjouterSponsor()
        {
            InitializeComponent();
        }

        private void buttonAnnulerSponsor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAjouterSponsor_Click(object sender, EventArgs e)
        {

        }

        private void buttonAjouterUtilisateurSponsor_Click(object sender, EventArgs e)
        {
            FormAjouterUtilisateur formAjoutUti = new FormAjouterUtilisateur();
            formAjoutUti.ShowDialog();
        }

        private void buttonAjouterContactSponsor_Click(object sender, EventArgs e)
        {
            FormAjouterUtilisateur formAjoutUti = new FormAjouterUtilisateur();
            formAjoutUti.ShowDialog();
        }

        private void buttonAjouterReferentSponsor_Click(object sender, EventArgs e)
        {
            FormAjouterUtilisateur formAjoutUti = new FormAjouterUtilisateur();
            formAjoutUti.ShowDialog();
        }
    }
}
