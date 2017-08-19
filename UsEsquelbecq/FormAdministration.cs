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
    public partial class FormAdministration : Form
    {
        public FormAdministration()
        {
            InitializeComponent();
        }

        private void buttonMDP_Click(object sender, EventArgs e)
        {
            FormMDP formPass = new FormMDP();
            formPass.ShowDialog();
        }

        private void buttonRetourAdministration_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
