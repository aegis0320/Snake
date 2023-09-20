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

        private static char charSnake = '〇';

        //private static int snakeHeadPos_x;
        //private static int snakeHeadPos_y;

        //public static int SnakeHeadPos_x { get => snakeHeadPos_x; set => snakeHeadPos_x = value; }
        //public static int SnakeHeadPos_y { get => snakeHeadPos_y; set => snakeHeadPos_y = value; }


        public static int[,] snakeQueue;
        public static void SnakeInit()
        {
            Random rd = new Random();
            snakeQueue[0,0] = rd.Next(5, 16);
            snakeQueue[0,1] = rd.Next(5, 16);
            //SnakeHeadPos_x=rd.Next(5, 16);
            //SnakeHeadPos_y = rd.Next(5, 16);
            Map.map[snakeQueue[0, 0], snakeQueue[0, 1]] = charSnake;
        }

        public  static void Move()
        {
            
            
                transfer = Map.map[snakeQueue[0, 0], snakeQueue[0, 1]];

                ap.map[snakeQueue[0, 0], snakeQueue[0, 1]] = Map.map[SnakeHeadPos_x+1, SnakeHeadPos_y];
                Map.map[SnakeHeadPos_x + 1, SnakeHeadPos_y] = transfer;

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
