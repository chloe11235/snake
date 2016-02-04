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
        GameElement Exemple = new GameElement();

        public   GameView()
        {
            this.Location = new System.Drawing.Point(80, 110);
            this.Name = "panel2";
            this.Size = new System.Drawing.Size(372, 233);
            this.TabIndex = 3;
            this.BackColor = Color.Black;
        }


         
        
    }

 
}
