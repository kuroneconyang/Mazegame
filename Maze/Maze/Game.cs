using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Game
    {
        public static void Start()
        {

            bool start = true;
            while (start == true)
            {
                Maping.Maps();
                string end = Console.ReadLine();
            }
        }
    }
}
