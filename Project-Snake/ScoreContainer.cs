using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace SaveList
{

    class SaveContainer
    {
        private List<Save> m_saveList = null;


        public SaveContainer()
        {
            m_saveList = new List<Save>();
        }

        public void Add(DemoUserControl.UC_Input Pseudo, int score)
        {
            m_saveList.Add(new Save(Pseudo, score));
        }

        public void DisplayAll()
        {
            if (m_saveList.Count == 0) return;

            /*Console.WriteLine("La liste des scores est: ");
            foreach (Save crt in m_saveList)
            {
                Console.WriteLine(crt.ToString());
            }*/
            MessageBox.Show("la liste des scores est : ");
            foreach (Save crt in m_saveList)
            {
                MessageBox.Show(crt.ToString());
            }
        }

        public bool SaveScore()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Save>));
            using (StreamWriter wr = new StreamWriter("Save.xml"))
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
            using (StreamReader rd = new StreamReader("Save.xml"))
            {
                m_saveList = xmlDeserializer.Deserialize(rd) as List<Save>;
            }

            return true;
        }

        //Copie du "Program.cs" de l'exemple de l'XML trouvé sur campus
        /*public void CreateSaveInstances(SaveList.SaveContainer container)
        {
            container.Add(ucPseudo, Ucscore);
            //container.Add("Awac", 42);
        }*/

        //Copie du "Program.cs" de l'exemple de l'XML trouvé sur campus
        //Issu de XML Serialization sur Campus (lab chap 1)
        /*
         *  Pour afficher un containeur (à appeler quand on clique sur score)
         */
        public void ReadSaveInstances(SaveList.SaveContainer container)
        {
            container.Load();
        }
    }
}
