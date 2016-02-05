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
        List<GameElement> MyMur = new List<GameElement>();
        GameElement brique = new GameElement(GameElement.ElementName.WALL, 0, 0);
        GameElement Exemple = new GameElement();
       
    

        List<GameElement> MySnake = new List<GameElement>();
        GameElement head = new GameElement(GameElement.ElementName.SNAKEHEAD, 10, 10);
        GameElement corps = new GameElement(GameElement.ElementName.SNAKEBODY, 0, 10);
        public   GameView()
        {
            this.Location = new System.Drawing.Point(13, 60);
            this.Name = "panel2";
            this.Size = new System.Drawing.Size(30*Exemple.Width, 10*Exemple.Height);
            this.TabIndex = 3;
            this.BackColor = Color.Black;
            MySnake.Add(head);
            MySnake.Add(corps);
            this.Controls.Add(head);
            this.Controls.Add(corps);
            
        }

        public void moveSnake()
        {
            foreach (GameElement part in MySnake)
            {
                part.PosX = part.PosX + 10;

                part.Location = new System.Drawing.Point(part.PosX, part.PosY);
            }
        }
        public void addMur(){
          
            MyMur.Add(brique);
            this.Controls.Add(brique);
            
        }


         
        
    }

 
}
