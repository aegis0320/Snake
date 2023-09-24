using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake
    {


        //定义表示蛇的字符
        private static char charSnake = 'O';


        //定义一个int类型的二维数组，用来存储蛇身每个部分的坐标。所有对蛇的操作全部以对此二维数组的操作
        public static List<Point> snakeQueue = new List<Point>();
        //public static int[,] snakeQueue = new int[1,2];


        public static Point target;

        //定义蛇初始化的方法
        public static void SnakeInit()
        {

            //实例化Random类
            //Random rd = new Random();
            //int snakeIni_x = rd.Next(5, 16);
            //int snakeIni_y = rd.Next(5, 16);

            //蛇头永远从中心点生成
            Point point = new() { X = 10, Y = 10 };


            //生成两段蛇身用作测试
            Point point1 = new() { X = 10, Y = 9 };
            Point point2 = new() { X = 10, Y = 8 };


            //分别从5到15的范围内取随机数组成一对横纵坐标，写入snakeQueue
            snakeQueue.Add(point);
            snakeQueue.Add(point1);
            snakeQueue.Add(point2);


            //snakeQueue里现在第一组数据代表蛇头所在的坐标，把map里的对应的字符改写成代表蛇的字符
            Map.map[snakeQueue[0].X, snakeQueue[0].Y] = charSnake;
            Map.map[snakeQueue[1].X, snakeQueue[1].Y] = charSnake;
            Map.map[snakeQueue[2].X, snakeQueue[2].Y] = charSnake;
        }


        public static void Move()
        {
            Point point = snakeQueue[0];
            Point point1 = snakeQueue[snakeQueue.Count - 1];

            switch (Input.MoveDirection)
            {
                case Input.Direction.Up:
                    target.X = point.X - 1;
                    target.Y = point.Y;
                    //point.Y--;
                    break;
                case Input.Direction.Down:
                    target.X = point.X + 1;
                    target.Y = point.Y;
                    //point.Y++;
                    break;
                case Input.Direction.Left:
                    target.X = point.X;
                    target.Y = point.Y - 1;
                    //point.X--;
                    break;
                case Input.Direction.Right:
                    target.X = point.X;
                    target.Y = point.Y + 1;
                    //point.X++;
                    break;
            }




            for (int i = snakeQueue.Count; i > 0; i--)
            {
                if (i == 1)
                {
                    snakeQueue[0] = target;
                }
                else
                {
                    snakeQueue[i - 1] = snakeQueue[i - 2];
                }

            }
            FailureJudge();
            Debug.WriteLine(snakeQueue[0].X);
            Debug.WriteLine(snakeQueue[0].Y);

            SnakeGrowth(point1);

            WriteSnakeQueueToMap();
            
            Debug.WriteLine(snakeQueue[0]);
            Debug.WriteLine(Fruit.fruitPoint);
        }

        //在处理完所有的移动逻辑之后，把queue里的数据写进map里
        private static void WriteSnakeQueueToMap()
        {
            

            //在此处把已经存在蛇身的坐标点从list中删去
            for (int i = 0; i < snakeQueue.Count; i++)
            {
                for (int j = 0; j < Fruit.blankPointList.Count; j++)
                {
                    if (snakeQueue[i].Equals( Fruit.blankPointList[j]))
                    {
                        Fruit.blankPointList.RemoveAt(j);
                        break;
                    }
                }
            }

            for (int i = 0; i < snakeQueue.Count; i++)
            {
                Map.map[snakeQueue[i].X, snakeQueue[i].Y] = charSnake;
            }



            //for (int i = 0; i < snakeQueue.GetLength(0); i++)
            //{
            //  Map.map[snakeQueue[i, 0], snakeQueue[i, 1]] = charSnake;
            //}
        }

        public static void SnakeGrowth(Point point)
        {
           
            if (snakeQueue[0].Equals(Fruit.fruitPoint))
            {
                Debug.WriteLine("fasheng");
                snakeQueue.Add(point);
                Fruit.ifRefreshFruitPoint = true;

            }
        }

        public static void FailureJudge()
        {
            bool touchItself = false;

            for (int i = 1; i < snakeQueue.Count; i++)
            {
                if (snakeQueue[0].Equals( snakeQueue[i]))
                {
                    touchItself = true;
                } 
            }


            if ( snakeQueue[0].X == 0 || snakeQueue[0].X == 21 || snakeQueue[0].Y == 0 || snakeQueue[0].Y == 21 || touchItself)
            {

                Console.Clear();
                Console.WriteLine("游戏失败,单击回车重新开始");
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                bool isEnterPressed = (keyInfo.Key == ConsoleKey.Enter);
                Console.Clear();
                if (true)
                {

                    // 获取当前进程的文件名
                    string fileName = Process.GetCurrentProcess().MainModule.FileName;
                    // 启动一个新的进程来重新启动应用程序
                    Process.Start(fileName);
                    // 终止当前进程
                    Environment.Exit(0);
                }
                


            }
        }





    }
}
