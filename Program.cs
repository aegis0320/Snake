using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;


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

            

            //定义帧与帧之间的时间间隔，单位为秒,使用double类型存储数据
            double tick = 0.2;

            //把光标设置为不可见，全局有效
            Console.CursorVisible = false;


            Console.WriteLine("↑↓←→控制移动，蛇头触碰边界或者蛇身则游戏失败");
            Console.WriteLine("单击回车开始游戏");
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            bool isEnterPressed = (keyInfo.Key == ConsoleKey.Enter);

            if (isEnterPressed)
            {
                Console.Clear();

                //游戏初始化
                GameInitiate();




                //游戏核心循环
                CoreCycle(tick);

            }






        }




        //游戏核心循环方法
        private static void CoreCycle(double tick)
        {


            //游戏核心循环
            while (true)
            {
                //在核心循环的每一帧开始之前把map数据全部归零
                Map.MapCenterClear();

                /* 在游戏的一个核心循环里，应该经历以下过程：
                 * 执行果实的生成函数
                 * 执行蛇的移动函数
                 * 
                 * 

                */
                Debug.WriteLine("1");



                Snake.Move();


                Fruit.FruitGenerate();





                //System.Threading.Thread.Sleep(2);
                Map.MapCenterRefresh();


                //以获取用户输入的循环执行一定时间来替代休眠函数
                Input.InputCycle(tick);

                //System.Threading.Thread.Sleep(tick);
                //Map.MapCenterClear();

            }
        }

        //游戏初始化方法
        private static void GameInitiate()
        {
            //这三个部分的初始化顺序有先后区别。地图初始化一定要放到最后执行。地图初始化是从Map.map里读取数据打印。蛇初始化要放到边界初始化之后执行，如果反过来，蛇的字符会被覆盖掉

            //边界初始化
            Border.BorderGenerate(Map.map);

            //蛇初始化
            Snake.SnakeInit();

            //将地图空白的坐标存储进list
            Fruit.FruitInitiate();

            //生成第一个水果


            //地图初始化
            Map.MapInitialPrint();


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
