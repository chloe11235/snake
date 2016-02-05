using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Je ne sais pas à quoi sers ce code mais on en a besoin pour le "user entry form designer" (line 32 et 99)
namespace DemoUserControl
{
    public partial class UC_Input : UserControl
    {
        #region Properties

        public String EmptyText
        {
            get { return this.tbProperty.EmptyText; }
            set { this.tbProperty.EmptyText = value; }
        }

        public String PropertyLabel
        {
            get { return this.lblProperty.Text; }
            set { this.lblProperty.Text = value; }
        }

        public String PropertyValue
        {
            get { return this.tbProperty.Text; }
            set { this.tbProperty.Text = value; }
        }

        public override string Text
        {
            get { return this.tbProperty.Text; }
            set { this.tbProperty.Text = value; }
        }

        #endregion Properties

        public UC_Input()
        {
            InitializeComponent();
        }
    }
}
