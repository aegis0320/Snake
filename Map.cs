using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public static class Map
    {
        public static char[,] map = new char[22, 22];

        public static void MapInitialPrint()
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();

            }
        }

        public static void MapCenterRefresh()
        {
            for (int i = 0; i < map.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < map.GetLength(1) - 2; j++)
                {
                    Console.CursorLeft = i + 1;
                    Console.CursorTop = j + 1;
                    Console.Write(" \b");
                    //System.Threading.Thread.Sleep(1);
                    Console.Write(map[i + 1, j + 1]);

                    //每一帧刷新之后，将中间区域的map存储的数据全部归零

                    map[i + 1, j + 1] = ' ';

                }
            }
        }




    }
}
