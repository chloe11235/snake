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
        public enum ElementName : int { SNAKEHEAD=0, SNAKEBODY, FRUIT, WALL };

        private ElementName Nom;

        int posX;

        public int PosX
        {
            get { return posX; }
            set { posX = value; }
        }
        int posY;

        public int PosY
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
           this.Nom = type; 
            this.Location= new System.Drawing.Point(x, y);
            this.PosX = x;
           this.PosY = y;
            this.Height = 10;
            this.Width = 10;
            if (type == ElementName.SNAKEBODY) { this.Image = global::Project_Snake.Properties.Resources.snake_corps; }
            else if (type == ElementName.SNAKEHEAD) { this.Image = global::Project_Snake.Properties.Resources.snake_tete; }
            else if (type == ElementName.WALL) { this.Image = global::Project_Snake.Properties.Resources.mur; }
            else if (type == ElementName.FRUIT) { this.Image = global::Project_Snake.Properties.Resources.fruit; }
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }
       
        
    }

}


