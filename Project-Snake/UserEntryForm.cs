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
            TheValue = this.ucPseudo.Text + " " + this.ucScore.Text;
        }
    }
}
