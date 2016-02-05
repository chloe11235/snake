using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoUserControl
{
    public partial class UserEntryForm : Form
    {
        public String TheValue { get; private set; }

        public UserEntryForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
//          this.UcScore.Text = le score passé en paramètres
            this.UcScore.Text = "42"; //En attendant le score passé en paramètre
            TheValue = this.ucPseudo.Text + " " + this.UcScore.Text;

            /* Création d'un containeur en passant le pseudo et le score
             * StudentContainer container = new StudentContainer();
             */
        }
    }
}
