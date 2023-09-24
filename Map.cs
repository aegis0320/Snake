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


        //地图初始化，只把地图边界打印出来
        public static void MapInitialPrint()
        {
            for (int i = 0; i < map.GetLength(1); i++)
            {
                for (int j = 0; j < map.GetLength(0); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();

            }

        }



        public static void MapCenterClear()
        {
            //循环除了上下边界的所有行。一共有22行，所以需要循环20次，所以使用“i < map.GetLength(0) - 2”
            for (int i = 0; i < map.GetLength(1) - 2; i++)
            {
                //循环当前行中除了左右边界的所有列
                for (int j = 0; j < map.GetLength(0) - 2; j++)
                {
                    //每一帧刷新之后，将中间区域的map存储的数据全部归零
                    map[i + 1, j + 1] = ' ';




                }
            }
        }



        //此方法用来从map中读取数据重新打印地图中央区域，
        public static void MapCenterRefresh()
        {
            //循环除了上下边界的所有行。一共有22行，所以需要循环20次，所以使用“i < map.GetLength(0) - 2”
            for (int i = 0; i < map.GetLength(1) - 2; i++)
            {
                //循环当前行中除了左右边界的所有列
                for (int j = 0; j < map.GetLength(0) - 2; j++)
                {
                    //把光标移动到当前循环到的某行
                    Console.CursorTop = i + 1;
                    //把光标移动到当前循环到的某列
                    Console.CursorLeft = j + 1;
                    //" \b"是空格加退位符，这样可以把当前位置的字符删除掉然后再替换成空格
                    Console.Write(" \b");
                    //System.Threading.Thread.Sleep(1);

                    //从map存储的数据中读取当前光标所处位置的对应的字符并打印出来
                    Console.Write(map[i + 1, j + 1]);


                    

                }
            }
        }




    }
}
