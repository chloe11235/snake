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
        List<GameElement> MyFruit = new List<GameElement>();
        GameElement brique = new GameElement(GameElement.ElementName.WALL, 0, 0);
        GameElement Exemple = new GameElement();
        public enum snakeDir : int {DROITE, GAUCHE, HAUT, BAS};
        private snakeDir dir ;
        private bool gameOn = false;
        private bool gameStop = false;
        private int score;

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public bool GameStop
        {
            get { return gameStop; }
            set { gameStop = value; }
        }

        public bool GameOn
        {
            get { return gameOn; }
            set { gameOn = value; }
        }
    

        List<GameElement> MySnake = new List<GameElement>();
       
        public   GameView()
        {
            this.Location = new System.Drawing.Point(13, 60);
            this.Name = "panel2";
            this.Size = new System.Drawing.Size(30*Exemple.Width, 10*Exemple.Height);
            this.TabIndex = 3;
            this.BackColor = Color.Black;
            
            
            
            
                        
        }
        public void initSnake()
        {
           dir = snakeDir.DROITE;
            GameElement head = new GameElement(GameElement.ElementName.SNAKEHEAD, 50, 10);
            //GameElement corps = new GameElement(GameElement.ElementName.SNAKEBODY, 40, 10);
            MySnake.Add(head);
            //MySnake.Add(corps);
            this.Controls.Add(head);
           // this.Controls.Add(corps);
            addSnake(4);
            addStuff(true);
            addStuff(false);
            gameStop = false;
            score = 0;
        }

        public void destroySnake()
        {
            foreach (GameElement part in MySnake)
            {
                this.Controls.Remove(part);
            }
            MySnake.Clear();
            foreach (GameElement part in MyFruit)
            {
                this.Controls.Remove(part);
            }
            MyFruit.Clear();
            foreach (GameElement part in MyMur)
            {
                this.Controls.Remove(part);
            }
            MyMur.Clear();
        }

        public void addSnake(int x) //x: nb de morceau
        {
            int i;
            for (i = 0; i < x; i++)
            {
                GameElement corps = new GameElement(GameElement.ElementName.SNAKEBODY, MySnake.ElementAt(MySnake.Count-1).PosX -  10, MySnake.ElementAt(MySnake.Count-1).PosY);
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
                
                dir = snakeDir.DROITE;
            }
            else if (((x == 1 && dir != snakeDir.DROITE) || (x == 4 && dir == snakeDir.GAUCHE)) && gameOn)
            {
                MySnake.ElementAt(0).Image = global::Project_Snake.Properties.Resources.snake_gauche;
                MySnake.ElementAt(0).PosX = MySnake.ElementAt(0).PosX - 10;
                dir = snakeDir.GAUCHE;
            }

            else if (((x == 2 && dir != snakeDir.BAS) || (x == 4 && dir == snakeDir.HAUT)) && gameOn)
            {
                MySnake.ElementAt(0).Image = global::Project_Snake.Properties.Resources.snake_haut;
                MySnake.ElementAt(0).PosY = MySnake.ElementAt(0).PosY - 10;
                dir = snakeDir.HAUT;
            }
            else if (((x == 3 && dir != snakeDir.HAUT) || (x == 4 && dir == snakeDir.BAS)) && gameOn)
            {
                MySnake.ElementAt(0).Image = global::Project_Snake.Properties.Resources.snake_bas;
                MySnake.ElementAt(0).PosY = MySnake.ElementAt(0).PosY + 10;                
                dir = snakeDir.BAS;
            }

            limiteSnake(MySnake.ElementAt(0));
            MySnake.ElementAt(0).Location = new System.Drawing.Point(MySnake.ElementAt(0).PosX, MySnake.ElementAt(0).PosY);

        }

         public void moveSnakeBody() 
         {
             int compteur;

             for (compteur = MySnake.Count-1; compteur > 0; compteur--)
             {
                 MySnake.ElementAt(compteur).PosX = MySnake.ElementAt(compteur-1).PosX;
                 MySnake.ElementAt(compteur).PosY = MySnake.ElementAt(compteur-1).PosY;
                 limiteSnake(MySnake.ElementAt(compteur));
                 MySnake.ElementAt(compteur).Location = new System.Drawing.Point(MySnake.ElementAt(compteur-1).PosX, MySnake.ElementAt(compteur-1).PosY);
             }
         }

         public void limiteSnake( GameElement corps)
         {
             if (corps.PosX == this.Size.Width ) { corps.PosX = 0; }
             if (corps.PosX < 0) { corps.PosX = this.Size.Width-10; }
             if (corps.PosY < 0) { corps.PosY = this.Size.Height- 10; }
             if (corps.PosY == this.Size.Height) { corps.PosY = 0; }

         }

       

        
        public void addStuff(bool Fruit) // si 1 ajoute un fruit si 0 ajoute un mur
        {
            int x = 0, y = 0;
            bool superposition=true;
            while(superposition)
            {
                Random rnd = new Random();
                x = rnd.Next(0, 30 * Exemple.Width);
                y = rnd.Next(0, 10 * Exemple.Height);
                x = x - (x % 10);
                y = y - (y % 10);

            foreach(GameElement part in MySnake)
            {
                if ((part.PosX != x) && (part.PosY != y)) superposition = false;
                else superposition = true;
            }
            
            foreach(GameElement part in MyMur)
            {
                if ((part.PosX != x) && (part.PosY != y)) superposition = false;
                else superposition = true;
            }

            foreach(GameElement part in MyFruit)
            {
                if ((part.PosX != x) && (part.PosY != y)) superposition = false;
                else superposition = true;
            }

            }

            if (!Fruit)
            {
                GameElement newBrique = new GameElement(GameElement.ElementName.WALL, x, y);
                MyMur.Add(newBrique);
                this.Controls.Add(newBrique);
            }
            else
            {
                GameElement newFruit = new GameElement(GameElement.ElementName.FRUIT, x, y);
                MyFruit.Add(newFruit);
                this.Controls.Add(newFruit);
            }
        }

        public void collisionAll()
        {
            GameElement obstacle = new GameElement();
            obstacle = testCollision();
            if (obstacle != null) collision(obstacle);
            else { }
        }

        public GameElement testCollision()
        {
            
            bool superposition = true;
            int x = MySnake.ElementAt(0).PosX;
            int y = MySnake.ElementAt(0).PosY;
            int i;
            GameElement obstacle = new GameElement();


            for (i = 1; i < MySnake.Count; i++)
            {
                if ((MySnake.ElementAt(i).PosX == x) && (MySnake.ElementAt(i).PosY == y)) { superposition = true; obstacle = MySnake.ElementAt(i); }
                else { }
            }
                foreach (GameElement part in MyMur)
                {
                    if ((part.PosX == x) && (part.PosY == y)) {superposition = true; obstacle = part; }
                    else { }
                }

                foreach (GameElement part in MyFruit)
                {
                    if ((part.PosX == x) && (part.PosY == y)){ superposition = true; obstacle = part; }
                    else {}
                }

                if (superposition) return obstacle;
                else return null;
                

            
            

        }

        public void collision( GameElement type)
        {
            if (type.Nom1 == GameElement.ElementName.FRUIT)
            {
                addSnake(1);
                this.Controls.Remove(type);
                MyFruit.Remove(type);
                addStuff(true);
                addStuff(false);
                countScore();

            }

            if (type.Nom1 == GameElement.ElementName.WALL || type.Nom1 == GameElement.ElementName.SNAKEBODY) 
            {
              
                gameStop = true;
                MessageBox.Show("Score= "+score, "colision mur", MessageBoxButtons.OK);
            }

            

        }

        public void countScore()
        {
            score = score + 2 * MySnake.Count;
        }
    }

 
}
