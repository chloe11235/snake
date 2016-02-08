using SaveList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoUserControl
{
    public partial class UserEntryForm : Form
    {
        public String TheValue { get; private set; }
       
        private SaveContainer container = new SaveContainer();

        internal SaveContainer Container1
        {
            get { return container; }
            set { container = value; }
        }



       // List<SaveContainer> container = new list<SaveContainer>();
            
        

        public UserEntryForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
//          this.UcScore.Text = le score passé en paramètres
            //this.UcScore = Project_Snake.GameView.Score; //En attendant le score passé en paramètre
            TheValue = "Pseudo  = " + this.ucPseudo.Text + " Score : " + Project_Snake.GameView.Score;

            //UcScore.Text = "" + Project_Snake.GameView.Score;
            // Création d'un containeur en passant le pseudo et le score
            container.Add(ucPseudo, Project_Snake.GameView.Score);
            container.SaveScore();

            //Mettre appel de la fonction d'enregistrement de l'XML
        }
    }
}



//Issu de XML Serialization sur Campus (lab chap 1)
//Dans le main elle appelle ces deux fonctions pour afficher le fichier xml
/*
private void OnclickScore(object sender, EventArgs e)
{
    Program.ReadSaveInstances(container);
    container.DisplayAll();
}*/
