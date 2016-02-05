using System.Windows.Forms;
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project_Snake
{
    public partial class Form1 : Form
    {
        GameElement exemple = new GameElement();
        private bool GameOn= false;
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
        //MessageBox.Show("droite","droite",MessageBoxButtons.OK);
         MainView.moveSnake();
        return true;
        
 case Keys.Left:
      //  MessageBox.Show("gauche","gauche",MessageBoxButtons.OK);
        MainView.addMur();
        return true;
        
 case Keys.Up:
        MessageBox.Show("haut","haut",MessageBoxButtons.OK);
        return true;
        
 case Keys.Down:
        MessageBox.Show("bas","bas",MessageBoxButtons.OK);
        return true;
        
 
 
 default:
 return base.ProcessCmdKey(ref msg, keyData);
 }
}

        private void timer1_Tick(object sender, EventArgs e)
        {
            MainView.moveSnake();

        }

        private void OnclickNewGame(object sender, EventArgs e)
        {
            if (!GameOn)
            {
                NewGame.Text = "Stop";
                timer1.Enabled = true;
            }
            else
            {
                NewGame.Text = "New Game";
                timer1.Enabled = false;
            }
            GameOn = !GameOn;
        }


    }
}

