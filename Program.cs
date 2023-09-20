using System;


/*
本项目目的为开发一个在控制台中可以游玩的贪吃蛇游戏。
主要实现思路：
定义一个22*22的二维数组用来存储地图
 
 */





namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Border.BorderGenerate(Map.map);
            Map.MapInitialPrint();
            Snake.SnakeInit();

            Console.CursorVisible = false;
            while (true)
            {

                //Snake.Move();
                System.Threading.Thread.Sleep(2);
                Map.MapCenterRefresh();
                
                System.Threading.Thread.Sleep(Tick.tick);

            }

            /*Console.WriteLine("Hello World!");
            Console.ReadLine();*/

        }
    }

    public static class Tick
    {
        //1秒 = 1000 

        //定义帧数为每秒20帧
        static int frame = 20;
        public static int tick = 1000 / frame;

    }

    
}
