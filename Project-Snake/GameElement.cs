using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Snake
{
    
    class GameElement : PictureBox
    {
        private enum ElementName { SNAKEHEAD, SNAKE, FRUIT, WALL };

        private ElementName Nom;

        private int posX;

        public int Horizontal
        {
            get { return posX; }
            set { posX = value; }
        }

        private int posY;

        public int Vertical
        {
            get { return posY; }
            set { posY = value; }
        }

        public GameElement()
        {
            this.Height = 10;
            this.Width = 10;
        }
        public GameElement (ElementName type, int x, int y)
        {
            Nom = type; 
            posX = x;
            posY = y;
            this.Height = 10;
            this.Width = 10;
        }
       
        
    }

}


