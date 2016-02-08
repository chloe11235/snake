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

        public UserEntryForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
//          this.UcScore.Text = le score passé en paramètres
            this.UcScore.Text = "42"; //En attendant le score passé en paramètre
            TheValue = this.ucPseudo.Text + " " + this.UcScore.Text;

            // Création d'un containeur en passant le pseudo et le score
              SaveContainer container = new SaveContainer();
            
        }
    }
}

namespace SaveList  //Copie du "Program.cs" de l'exemple de l'XML trouvé sur campus
{
    static class Program
    {
        //Issu  XML Serialization sur Campus (lab chap 1)
        /*Pour créer un container avec les données rentrées 
         *  appeler quand on appuie sur OK après avoir renseigné pseudo et score
        */
        static void ReadSaveInstances(SaveContainer container)
        {
            container.Load();
        }
        
        //Issu  XML Serialization sur Campus (lab chap 1)
        /*
         *  Pour afficher un containeur (à appeler quand on clique sur score)
         */
        static void CreateSaveInstances(SaveContainer container)
        {
            //container.Add(ucPseudo, Ucscore);
            container.Add("Awac", 42);
        }
    }
}

//Issu de Demo ECE SE
//Lors de l'évènement qui doit appeler la sauvegarde (à priori une collision), mettre ceci (ça appelle la fenêtre demandant de remplir le pseudo)
//La prof l'avais mis dans son main form lors de l'appui sur le bouton add
/*
private void OnclickScore(object sender, EventArgs e)
{
    //dans l'exemple DEMO ECE SE c'était "namespace DemoUserEntryForm"
    UserEntryForm uef = new UserEntryForm();
    DialogResult dr = uef.ShowDialog();
    if (dr == DialogResult.OK)
    {
        MessageBox.Show("Value = " + uef.TheValue);
        //Appel de la création du fichier xml
    }
    else
    {
        //Rien
    }
}
*/

//Issu de XML Serialization sur Campus (lab chap 1)
//Dans le main elle appelle ces deux fonctions pour afficher le fichier xml
/*
{
    Program.ReadSaveInstances(container);
    container.DisplayAll();
}*/
