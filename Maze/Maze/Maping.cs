using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{


    class Maping
    {
        public static int hori = 8;
        public static int vert = 8;
        public static string player = "●";
        public static string key = "㉿";
        public static string esc = "★";
        public static string emp = "  ";

        public static string[,] map = new string[hori, vert];
        static string maping = 
            "00000000"+
            "0P111110"+
            "00010000"+
            "0K010110"+
            "01111100"+
            "00010000"+
            "011111E0"+
            "00000000";

        public static char[] conmap = maping.ToCharArray();

        public static void Maps()
        {
            int n = 0;
            for(int Hori = 0; Hori < map.GetLength(0); Hori++)
            {
                for(int Vert = 0; Vert < map.GetLength(1); Vert++)
                {
                    Console.ResetColor();
                    if (conmap[n] == 'P')
                    {
                        Console.Write(player);
                    }
                    else if (conmap[n] == 'K')
                    {
                        Console.Write(key);
                    }
                    else if (conmap[n] == 'E')
                    {
                        Console.Write(esc);
                    }
                    else if(conmap[n] == '0')
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write(emp);
                    }
                    else
                    {
                        Console.Write(emp);
                    }
                    n++;
                }
                Console.WriteLine();
            }
        }
    }
}
