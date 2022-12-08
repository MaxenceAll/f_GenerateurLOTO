using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace f_GenerateurLOTO
{
    public partial class tirageForm : Form
    {
        public tirageForm()
        {
            InitializeComponent();
        }

        private void retry_Click(object sender, EventArgs e)
        {
            Classique classique = new Classique(); classique.tirer();
        }
    }
}
