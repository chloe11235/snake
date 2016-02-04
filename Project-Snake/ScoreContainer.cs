﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SaveList
{

    class SaveContainer
    {
        private List<Save> m_saveList = null;


        public SaveContainer()
        {
            m_saveList = new List<Save>();
        }

        /*
        public void Add(string Pseudo, uint score)
        {
            uint cpt = (uint)m_saveList.Count;
            m_saveList.Add(new Save(Pseudo, score, cpt));
        }*/

        public void DisplayAll()
        {
            if (m_saveList.Count == 0) return;

            Console.WriteLine("La liste des scores est: ");
            foreach (Save crt in m_saveList)
            {
                Console.WriteLine(crt.ToString());
            }
        }

        public bool Save()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Save>));
            using (StreamWriter wr = new StreamWriter("save.xml"))
            {
                xmlSerializer.Serialize(wr, m_saveList);
            }

            return true;
        }

        public bool SerializeOnString()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Save>));
            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, m_saveList);

                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("La serialisation XML donne: ");
                Console.WriteLine(textWriter.ToString());
            }

            return true;
        }

        public bool Load()
        {
            XmlSerializer xmlDeserializer = new XmlSerializer(typeof(List<Save>));
            using (StreamReader rd = new StreamReader("students.xml"))
            {
                m_saveList = xmlDeserializer.Deserialize(rd) as List<Save>;
            }

            return true;
        }
    }
}