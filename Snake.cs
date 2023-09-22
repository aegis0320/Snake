using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake
    {

        private static char transfer;

        //定义表示蛇的字符
        private static char charSnake = 'o';


        //定义一个int类型的二维数组，用来存储蛇身每个部分的坐标。所有对蛇的操作全部以对此二维数组的操作
        public  static List<Point> snakeQueue = new List<Point>();
        //public static int[,] snakeQueue = new int[1,2];
        //定义蛇初始化的方法
        public static void SnakeInit()
        {
            //实例化Random类
            //Random rd = new Random();
            //int snakeIni_x = rd.Next(5, 16);
            //int snakeIni_y = rd.Next(5, 16);

            //蛇头永远从中心点生成
            Point point = new Point { X = 10, Y = 10 };
            //分别从5到15的范围内取随机数组成一对横纵坐标，写入snakeQueue
            snakeQueue.Add(point);
               

            //snakeQueue里现在第一组数据代表蛇头所在的坐标，把map里的对应的字符改写成代表蛇的字符
            Map.map[snakeQueue[0].X, snakeQueue[0].Y] = charSnake;
        }


        public  static void Move()
        {
                
            
                
                Point point = snakeQueue[0];
                point.X ++;
                snakeQueue[0] = point;
                WriteSnakeQueueToMap();

            
            





            
                
           
            
        }

        //在处理完所有的移动逻辑之后，把queue里的数据写进map里
        private static void WriteSnakeQueueToMap()
        {

            Map.map[snakeQueue[0].X, snakeQueue[0].Y] = charSnake;
            //for (int i = 0; i < snakeQueue.GetLength(0); i++)
            //{
            //  Map.map[snakeQueue[i, 0], snakeQueue[i, 1]] = charSnake;
            //}
        }

        

        


    }
}
