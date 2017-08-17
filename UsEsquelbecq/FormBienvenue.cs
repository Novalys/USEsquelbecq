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
    public partial class FormBienvenue : System.Windows.Forms.Form
    {
        public FormBienvenue()
        {
            InitializeComponent();
        }

        private void buttonParticipation_Click(object sender, EventArgs e)
        {
            FormParticipation formPar = new FormParticipation();
            formPar.ShowDialog();
        }

        private void buttonUtilisateur_Click(object sender, EventArgs e)
        {
            FormUtilisateur formUti = new FormUtilisateur();
            formUti.ShowDialog();
        }

        private void buttonContrat_Click(object sender, EventArgs e)
        {
            FormContrat formCont = new FormContrat();
            formCont.ShowDialog();
        }

        private void buttonSponsor_Click(object sender, EventArgs e)
        {
            FormSponsor formSpo = new FormSponsor();
            formSpo.ShowDialog();
        }

        private void buttonPanneau_Click(object sender, EventArgs e)
        {
            FormPanneau formPan = new FormPanneau();
            formPan.ShowDialog();
        }

        private void buttonEmplacement_Click(object sender, EventArgs e)
        {
            FormEmplacement formEmp = new FormEmplacement();
            formEmp.ShowDialog();
        }
    }
}
