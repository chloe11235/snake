﻿using System;
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

        private uint m_score;
        private string Pseudo1;
        private uint score;
        [XmlElement("MonScore")]
        public uint Score
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
        public Save(string pseudo, uint score)
        {
            this.m_pseudo = pseudo;
            this.m_score = score;
        }



        #endregion Constructeur Declaration

    }

    /* code en commentaire dans l'exemple de la prof
    <?xml version="1.0" encoding="utf-8"?>
    <Save xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
        <MonPseudo>Cad</MonPseudo>
        <MonScore>dss</MonScore>
    </Save>
    */
    // To be serailized, an object (potentially member of a collection) must have properties
   
}

