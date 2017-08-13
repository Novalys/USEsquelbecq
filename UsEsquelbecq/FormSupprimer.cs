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
    public partial class FormSupprimer : Form
    {
        public FormSupprimer()
        {
            InitializeComponent();
        }

        private void buttonNonSupprimer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOuiSupprimer_Click(object sender, EventArgs e)
        {

        }
    }
}
