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
        public enum snakeDir : int {DROITE, GAUCHE, HAUT, BAS};
        private snakeDir dir = snakeDir.DROITE;
        private bool gameOn = false;

        public bool GameOn
        {
            get { return gameOn; }
            set { gameOn = value; }
        }
    

        List<GameElement> MySnake = new List<GameElement>();
        GameElement head = new GameElement(GameElement.ElementName.SNAKEHEAD, 50, 10);
        GameElement corps = new GameElement(GameElement.ElementName.SNAKEBODY, 40, 10);
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
            
            addSnake(3);
                        
        }

        public void addSnake(int x) //x: nb de morceau
        {
            int i;
            for (i = 0; i < x; i++)
            {
                GameElement corps = new GameElement(GameElement.ElementName.SNAKEBODY, 30 - i * 10, 10);
                MySnake.Add(corps);
                this.Controls.Add(corps);
            }
        }
        
        public void moveSnake( int x) // 0: droite, 1: gauche, 2:haut, 3: abs
        {
            moveSnakeBody();
            moveSnakeHead(x);
           
        }

        public void moveSnakeHead(int x)
        {
            if (((x == 0 && dir != snakeDir.GAUCHE) || (x == 4 && dir==snakeDir.DROITE)) && gameOn)
            {
                MySnake.ElementAt(0).Image = global::Project_Snake.Properties.Resources.snake_tete;
                MySnake.ElementAt(0).PosX = MySnake.ElementAt(0).PosX + 10;
                MySnake.ElementAt(0).Location = new System.Drawing.Point(MySnake.ElementAt(0).PosX, MySnake.ElementAt(0).PosY);
                
                dir = snakeDir.DROITE;
            }
            else if (((x == 1 && dir != snakeDir.DROITE) || (x == 4 && dir == snakeDir.GAUCHE)) && gameOn)
            {
                MySnake.ElementAt(0).Image = global::Project_Snake.Properties.Resources.snake_gauche;
                MySnake.ElementAt(0).PosX = MySnake.ElementAt(0).PosX - 10;
                MySnake.ElementAt(0).Location = new System.Drawing.Point(MySnake.ElementAt(0).PosX, MySnake.ElementAt(0).PosY);
               
                dir = snakeDir.GAUCHE;
            }

            else if (((x == 2 && dir != snakeDir.BAS) || (x == 4 && dir == snakeDir.HAUT)) && gameOn)
            {
                MySnake.ElementAt(0).Image = global::Project_Snake.Properties.Resources.snake_haut;
                MySnake.ElementAt(0).PosY = MySnake.ElementAt(0).PosY - 10;
                MySnake.ElementAt(0).Location = new System.Drawing.Point(MySnake.ElementAt(0).PosX, MySnake.ElementAt(0).PosY);
               
                dir = snakeDir.HAUT;
            }
            else if (((x == 3 && dir != snakeDir.HAUT) || (x == 4 && dir == snakeDir.BAS)) && gameOn)
            {
                MySnake.ElementAt(0).Image = global::Project_Snake.Properties.Resources.snake_bas;
                MySnake.ElementAt(0).PosY = MySnake.ElementAt(0).PosY + 10;
                MySnake.ElementAt(0).Location = new System.Drawing.Point(MySnake.ElementAt(0).PosX, MySnake.ElementAt(0).PosY);
               
                dir = snakeDir.BAS;
            }
            

        }

         public void moveSnakeBody() 
         {
             int compteur;

             for (compteur = MySnake.Count-1; compteur > 0; compteur--)
             {
                 MySnake.ElementAt(compteur).PosX = MySnake.ElementAt(compteur-1).PosX;
                 MySnake.ElementAt(compteur).PosY = MySnake.ElementAt(compteur-1).PosY;
                 MySnake.ElementAt(compteur).Location = new System.Drawing.Point(MySnake.ElementAt(compteur-1).PosX, MySnake.ElementAt(compteur-1).PosY);
             }
             /*MySnake.ElementAt(0).PosX = MySnake.ElementAt(0).PosX + 10;
             MySnake.ElementAt(0).Location = new System.Drawing.Point(MySnake.ElementAt(0).PosX, MySnake.ElementAt(0).PosY);*/
         }

       public void moveSnakA()
        {
            int compteur;
            for (compteur = 0; compteur < MySnake.Count; compteur++)
            {
                MySnake.ElementAt(compteur).PosX = MySnake.ElementAt(compteur).PosX + 10;
                MySnake.ElementAt(compteur).PosY = MySnake.ElementAt(compteur).PosY;
                MySnake.ElementAt(compteur).Location = new System.Drawing.Point(MySnake.ElementAt(compteur).PosX, MySnake.ElementAt(compteur).PosY);
            }
        }

        
        public void addMur(){
          
            MyMur.Add(brique);
            this.Controls.Add(brique);
            
        }


         
        
    }

 
}
