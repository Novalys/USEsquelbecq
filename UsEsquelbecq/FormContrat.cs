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
    public partial class FormContrat : Form
    {
        public FormContrat()
        {
            InitializeComponent();
        }

        private void buttonAjouterContrat_Click(object sender, EventArgs e)
        {

        }

        private void buttonModifierContrat_Click(object sender, EventArgs e)
        {

        }

        private void buttonSupprimerContrat_Click(object sender, EventArgs e)
        {
            FormSupprimer formSupp = new FormSupprimer();
            formSupp.ShowDialog();
        }

        private void buttonRetourContrat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
