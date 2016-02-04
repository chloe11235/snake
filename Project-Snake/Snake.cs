using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Snake;

namespace Project_Snake
{
    class Snake
    {
        private List<GameElement> theSnake = new List<GameElement>();

        public Snake()
        {
            theSnake.Add(new GameElement((GameElement.ElementName)0, 112, 182)); // ajoute la tête du serpent
            theSnake.Add(new GameElement((GameElement.ElementName)1, 122, 192)); // ajoute un 1er bout de corps
            theSnake.Add(new GameElement((GameElement.ElementName)1, 132, 202)); // ajoute un 2eme bout de corps
        }

        

    }
}
