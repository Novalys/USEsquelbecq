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
    public partial class FormEmplacement : Form
    {
        public FormEmplacement()
        {
            InitializeComponent();
        }

        private void buttonAjouterEmplacement_Click(object sender, EventArgs e)
        {
            FormAjouterEmplacement formAjoutEmp = new FormAjouterEmplacement();
            formAjoutEmp.ShowDialog();
        }

        private void buttonModifierEmplacement_Click(object sender, EventArgs e)
        {
            FormAjouterEmplacement formModEmp = new FormAjouterEmplacement();
            formModEmp.Controls["buttonAjouterEmplacement"].Text = "Modifier";
            formModEmp.ShowDialog();
        }

        private void buttonSupprimerEmplacement_Click(object sender, EventArgs e)
        {
            FormSupprimer formSupp = new FormSupprimer();
            formSupp.ShowDialog();
        }

        private void buttonRetourEmplacement_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
