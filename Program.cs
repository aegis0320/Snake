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

            //1秒 = 1000 ,定义帧数为每秒20帧,即每帧之间的时间间隔是50
            int tick = 50; 
            
            //把光标设置为不可见，全局有效
            Console.CursorVisible = false;

            //游戏初始化
            GameInitiate();

           
            //游戏核心循环
            CoreCycle(tick);

            /*Console.WriteLine("Hello World!");
            Console.ReadLine();*/

        }

        //游戏核心循环方法
        private static void CoreCycle(int tick)
        {
            //游戏核心循环
            while (true)
            {

                /* 在游戏的一个核心循环里，应该经历以下过程：
                 * 执行果实的生成函数
                 * 执行蛇的移动函数
                 * 
                 * 

                */
                //Snake.Move();


                System.Threading.Thread.Sleep(2);
                Map.MapCenterRefresh();
                System.Threading.Thread.Sleep(tick);

            }
        }

        //游戏初始化方法
        private static void GameInitiate()
        {
            //边界初始化
            Border.BorderGenerate(Map.map);

            //地图初始化
            Map.MapInitialPrint();

            //蛇初始化
            Snake.SnakeInit();
        }


    }


    

    //public static class Tick
    //{
    //    //1秒 = 1000 

    //    //定义帧数为每秒20帧
    //    static int frame = 20;
    //    public static int tick = 1000 / frame;

    //}

    
}
