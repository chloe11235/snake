using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SaveList
{
    /*
     * Si serpent touche un mur ou une partie de son corps
     *  On ouvre le fichier XML et on écrit (création auto si n'existe pas)
    */

    //Reprise du TP student pour la partie XML
    [Serializable]
    public class Save
    {
        #region Members Declaration

        private string m_pseudo;
        [XmlElement("MonPseudo")]
        public string Pseudo
        {
            get { return m_pseudo; }
            set { m_pseudo = value; }
        }

        private int m_score;
        [XmlElement("MonScore")]
        public int Score
        {
            get { return m_score; }
            set { m_score = value; }
        }

        #endregion Members Declaration

        #region Constructeur Declaration
        //Constructeur
        public Save()
        {
            this.m_pseudo = "";
            this.m_score = 0;
        }

        //Constructeur par paramètres
        public Save(string pseudo, int score)
        {
            this.m_pseudo = pseudo;
            this.Score = score;
        }

        #endregion Constructeur Declaration

    }

    /*
    <?xml version="1.0" encoding="utf-8"?>
    <Save xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
        <MonPseudo>Cad</MonPseudo>
        <MonScore>dss</MonScore>
    </Save>
    */
    // To be serailized, an object (potentially memeber of a collection) must have properties
   
}

//incrémentation du score
/*
void calcul_score(int score)
{
    if (fruitEvent)    //Si la tete touche un fruit
    {
        score++;
    }
}*/

//Issu du lab de la prof sur l'XML
/*Pour créer un container avec les données rentrées 
 *  appeler quand on appuie sur OK après avoir renseigné pseudo et score
*/
/*
static void CreateSaveInstances(SaveContainer container)
{
    container.Add(ucPseudo,ucScore);
}
*/

/*
 *  Pour afficher un containeur (à appeler quand on clique sur score)
static void ReadSaveInstances(SaveContainer container)
{
    container.Load();
}*/