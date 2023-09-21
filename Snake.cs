using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake
    {

        private static char transfer;

        //定义表示蛇的字符
        private static char charSnake = '〇';

        //private static int snakeHeadPos_x;
        //private static int snakeHeadPos_y;

        //public static int SnakeHeadPos_x { get => snakeHeadPos_x; set => snakeHeadPos_x = value; }
        //public static int SnakeHeadPos_y { get => snakeHeadPos_y; set => snakeHeadPos_y = value; }


        //定义一个int类型的二维数组，用来存储蛇身每个部分的坐标。所有对蛇的操作全部以对此二维数组的操作
        public static int[,] snakeQueue;
        //定义蛇初始化的方法
        public static void SnakeInit()
        {
            //实例化Random类
            Random rd = new Random();

            //分别从5到15的范围内取随机数组成一对横纵坐标，写入snakeQueue
            snakeQueue[0,0] = rd.Next(5, 16);
            snakeQueue[0,1] = rd.Next(5, 16);

            //snakeQueue里现在第一组数据代表蛇头所在的坐标，把map里的对应的字符改写成代表蛇的字符
            Map.map[snakeQueue[0, 0], snakeQueue[0, 1]] = charSnake;
        }


        public  static void Move()
        {
            
            
                transfer = Map.map[snakeQueue[0, 0], snakeQueue[0, 1]];

                

                Snake.WriteSnakeQueueToMap();
                
           
            
        }

        //在处理完所有的移动逻辑之后，把queue里的数据写进map里
        private static void WriteSnakeQueueToMap()
        {
            for (int i = 0; i < snakeQueue.GetLength(0); i++)
            {
                Map.map[snakeQueue[i, 0], snakeQueue[i, 1]] = charSnake;
            }
        }


    }
}
