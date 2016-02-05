﻿using System;
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
        private snakeDir dir ;
        private bool gameOn = false;

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
            GameElement corps = new GameElement(GameElement.ElementName.SNAKEBODY, 40, 10);
            MySnake.Add(head);
            MySnake.Add(corps);
            this.Controls.Add(head);
            this.Controls.Add(corps);
            addSnake(3);
        }

        public void destroySnake()
        {
            foreach (GameElement part in MySnake)
            {
                this.Controls.Remove(part);
            }
            MySnake.Clear();
        }

        public void addSnake(int x) //x: nb de morceau
        {
            int i;
            for (i = 0; i < x; i++)
            {
                GameElement corps = new GameElement(GameElement.ElementName.SNAKEBODY, MySnake.ElementAt(MySnake.Count-1).PosX - i * 10, MySnake.ElementAt(MySnake.Count-1).PosY);
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

       

        
        public void addMur(){
          
            MyMur.Add(brique);
            this.Controls.Add(brique);
            
        }


         
        
    }

 
}
