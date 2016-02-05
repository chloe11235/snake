using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Code nécessaire au user entry form
namespace DemoUserControl
{
    class CustomTextBox : TextBox
    {
        public String EmptyText { get; set; }

        #region Event management

        protected override void OnGotFocus(EventArgs e)
        {
            if (this.Text == EmptyText)
                this.Text = "";
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            if (this.Text == "")
                this.Text = EmptyText;
            base.OnLostFocus(e);
        }

        #endregion Event management

    }
}
