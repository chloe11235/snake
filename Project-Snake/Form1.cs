using System;
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
        public Form1()
        {
            InitializeComponent();
            
        }

        
        private void panel1_Paint(object sender, PaintEventArgs e)
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
        MessageBox.Show("droite","droite",MessageBoxButtons.OK);
        return true;
        break;
 case Keys.Left:
        MessageBox.Show("gauche","gauche",MessageBoxButtons.OK);
        return true;
        break;
 case Keys.Up:
        MessageBox.Show("haut","haut",MessageBoxButtons.OK);
        return true;
        break;
 case Keys.Down:
        MessageBox.Show("bas","bas",MessageBoxButtons.OK);
        return true;
        break;
 
 
 default:
 return base.ProcessCmdKey(ref msg, keyData);
 }
}

    }
}
