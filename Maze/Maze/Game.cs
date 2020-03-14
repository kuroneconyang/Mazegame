using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Maze.Maping;

namespace Maze
{
    class Game
    {
        static int x;
        static int y;
        static int goal;
        public static string[,] playMap;

    public static void Move(ConsoleKeyInfo key, string[,] playMap)
        {
            bool moving = true;
            switch (key.Key) //이동불가//
            {
                case ConsoleKey.UpArrow :
                    if (playMap[y - 1, x] == "0")
                    {
                        moving = false;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (playMap[y + 1, x] == "0")
                    {
                        moving = false;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (playMap[y, x - 1] == "0")
                    {
                        moving = false;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (playMap[y, x + 1] == "0")
                    {
                        moving = false;
                    }
                    break;
            }

            if (moving == true)
            {
                if (playMap[y, x] == "N")
                    {
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            playMap[y, x] = "E";
                            y -= 1;
                            break;
                        case ConsoleKey.DownArrow:
                            playMap[y, x] = "E";
                            y += 1;
                            break;
                        case ConsoleKey.LeftArrow:
                            playMap[y, x] = "E";
                            x -= 1;
                            break;
                        case ConsoleKey.RightArrow:
                            playMap[y, x] = "E";
                            x += 1;
                            break;
                    }
                }
                else
                {
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            playMap[y, x] = "1";
                            y -= 1;
                            break;
                        case ConsoleKey.DownArrow:
                            playMap[y, x] = "1";
                            y += 1;
                            break;
                        case ConsoleKey.LeftArrow:
                            playMap[y, x] = "1";
                            x -= 1;
                            break;
                        case ConsoleKey.RightArrow:
                            playMap[y, x] = "1";
                            x += 1;
                            break;
                    }
                }

                if (playMap[y, x] == "K")
                {
                    goal--;
                    playMap[y, x] = "P";
                }
                else if (playMap[y, x] == "E")
                {
                    if (goal == 0)
                    {
                        playMap[y, x] = "F";
                    }
                    else
                    {
                        playMap[y, x] = "N";
                    }
                }
                else
                {
                    playMap[y, x] = "P";
                }
            }
            

        }

        public static void Start()
        {
            bool game = true;
 
            while (game == true)
            {
                x = 1;
                y = 1;
                string[,] newmap = convertMap(maping);
                playMap = newmap;
                goal = goalKey();
                bool start = true;
                while (start == true)
                {

                    MapsPrint(playMap);
                    if (playMap[y, x] == "N")
                    {
                        Console.WriteLine("[ 열쇠가 부족한 것 같다. ]");
                    }
                    if (playMap[y, x] == "F")
                    {
                        Console.WriteLine("[ 클리어! ]");
                        bool sel = true;
                        while (sel == true)
                        {
                            Console.WriteLine("종료하시겠습니까? : [ 1 → 종료 / 2 → 처음부터]");
                            string choice = Console.ReadLine();
                            if (choice == "1")
                            {
                                game = false;
                                start = false;
                                break;
                            }
                            else if (choice == "2")
                            {
                                start = false;
                                break;
                            }
                        }
                    }
                    if (start == false)
                    {
                        Console.Clear();
                        continue;
                    }
                    ConsoleKeyInfo pressKey = Console.ReadKey();
                    if (pressKey.Key == ConsoleKey.Escape)
                    {
                        bool sel = true;
                        while(sel == true)
                        {
                            Console.WriteLine("종료하시겠습니까? : [ 1 → 종료 / 2 → 복귀 / 3 → 처음부터]");
                            string choice = Console.ReadLine();
                            if (choice == "1")
                            {
                                game = false;
                                start = false;
                                break;
                            }
                            else if (choice == "2")
                            {
                                start = true;
                                break;
                            }
                            else if (choice == "3")
                            {
                                start = false;
                                break;
                            }
                        }
                 
                    }
                    else
                    {
                        Move(pressKey,playMap);
                    }
                    Console.Clear();
                }
            }
        }
    }
}
