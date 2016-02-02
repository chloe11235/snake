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
        public   GameView()
        { 
           this.Width = 10*scaleDef.ScaleWidth;

            
        }

        

       
        
       
        
    }

    class scaleDef
    {
        private int scaleHeight=10;
        private int scaleWidth=10;

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
