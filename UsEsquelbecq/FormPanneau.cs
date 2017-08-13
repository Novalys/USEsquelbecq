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
    public partial class FormPanneau : Form
    {
        public FormPanneau()
        {
            InitializeComponent();
        }

        private void buttonAjouterPanneau_Click(object sender, EventArgs e)
        {

        }

        private void buttonModifierPanneau_Click(object sender, EventArgs e)
        {

        }

        private void buttonSupprimerPanneau_Click(object sender, EventArgs e)
        {
            FormSupprimer formSupp = new FormSupprimer();
            formSupp.ShowDialog();
        }

        private void buttonRetourPanneau_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
