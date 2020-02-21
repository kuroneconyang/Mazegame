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
        public static string[,] firmap = new string[hori, vert];


        public static string maping =
                    "00000000" +
                    "0P111110" +
                    "00010000" +
                    "0K010110" +
                    "01111100" +
                    "00010000" +
                    "011111E0" +
                    "00000000";


        static char[] conmap = maping.ToCharArray();

        public static int goalKey()
        {
            int key = 0;
            for(int i = 0; i < conmap.Length ;i++)
            {
                if(conmap[i] == 'K')
                {
                    key++;
                }
            }
            return key;
        }

        public static string[,] convertMap(string maping)
        {
            
            int n = 0;
            string[,] convmap = new string[map.GetLength(0), map.GetLength(1)];
            for (int Hori = 0; Hori < map.GetLength(0); Hori++)
            {
                for (int Vert = 0; Vert < map.GetLength(1); Vert++)
                {
                    convmap[Hori,Vert] = conmap[n].ToString();
                    n++;
                }
            }
            return convmap;
        }


        public static void MapsPrint(string[,] maps)
        {
            
            for(int Hori = 0; Hori < maps.GetLength(0); Hori++)
            {
                for(int Vert = 0; Vert < maps.GetLength(1); Vert++)
                {
                    
                    if (maps[Hori, Vert] == "P")
                    {
                        Console.Write(player);
                    }
                    else if (maps[Hori, Vert] == "K")
                    {
                        Console.Write(key);
                    }
                    else if (maps[Hori, Vert] == "E")
                    {
                        Console.Write(esc);
                    }
                    else if (maps[Hori, Vert] == "N")
                    {
                        Console.Write(player);
                    }
                    else if (maps[Hori, Vert] == "F")
                    {
                        Console.Write(player);
                    }
                    else if(maps[Hori, Vert] == "0")
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write(emp);
                    }
                    else if(maps[Hori, Vert] == "1")
                    {
                        Console.Write(emp);
                    }

                        Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }
}
