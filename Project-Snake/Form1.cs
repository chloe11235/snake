﻿using System.Windows.Forms;
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Snake
{
    public partial class Form1 : Form
    {
        GameElement exemple = new GameElement();
        
        public Form1()
        {
            InitializeComponent();
          
            
        }

        
        
        private void panel(object sender, PaintEventArgs e)
        {
                    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
        

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
{
switch (keyData)
 {
        
 case Keys.Right:
         
        
         MainView.collisionAll();
         MainView.moveSnake(0);
        return true;
        
 case Keys.Left:
      //  MessageBox.Show("gauche","gauche",MessageBoxButtons.OK);
       
        MainView.collisionAll();
        MainView.moveSnake(1);
        return true;
        
 case Keys.Up:
       
        MainView.collisionAll();
        MainView.moveSnake(2);
        return true;
        
 case Keys.Down:
       // MessageBox.Show("bas","bas",MessageBoxButtons.OK);
        
        MainView.collisionAll();
        MainView.moveSnake(3);
        return true;
        
 
 
 default:
 return base.ProcessCmdKey(ref msg, keyData);
        }
}
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!MainView.GameStop) {
                MainView.collisionAll();
            MainView.moveSnake(4);
            
            }
            else{}

        }

        private void OnclickNewGame(object sender, EventArgs e)
        {
            if (!MainView.GameOn)
            {
                NewGame.Text = "Stop";
                timer1.Enabled = true;
                MainView.initSnake();
                MainView.GameOn = true;
            }
            else
            {
                NewGame.Text = "New Game";
                timer1.Enabled = false;
                MainView.destroySnake();
                MainView.GameOn = false;
            }
           
        }

        //Issu du TP XML sur campus
        private void OnclickScore(object sender, EventArgs e)
        {
            UserControl.Container1.Load();
            UserControl.Container1.DisplayAll();
        }
    }
}
