using System;
using System.Collections.Generic;
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
          this.Location = new System.Drawing.Point(62, 132);
           this.BackColor = System.Drawing.SystemColors.ControlDark;
          this.Name = "panel";
           this.Size = new System.Drawing.Size(10*Exemple.Width, 10*Exemple.Height);
           //this.Show();
           this.Enabled = true;
           this.Visible = true;
        }


         
        
    }

    class scaleDef
    {
        private int scaleHeight=10;
        private int scaleWidth=10;
        private int nbScaleVert = 10;
        private int nbScaleHor = 10;

        public int ScaleWidth
        {
            get { return scaleWidth; }
            set { scaleWidth = value; }
        }

        public int ScaleHeight
        {
            get { return scaleHeight; }
            set { scaleHeight = value; }
        }

              

        
    }
}
