using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Snake
{
    class GameView: Panel

    {
        GameElement Exemple = new GameElement(  );

        public   GameView()
        { 
          

            //panel
          this.Location = new System.Drawing.Point(0, 0);
           //this.BackColor = System.Drawing.SystemColors.ControlDark;
          this.Name = "panel";
          this.BackColor = Color.Black;
           this.Size = new System.Drawing.Size(10*Exemple.Width, 10*Exemple.Height);
           //this.Show();
           this.Enabled = true;
           this.Visible = true;
           this.Show();
        }


         
        
    }

 
}
