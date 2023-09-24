using System;
using System.Collections.Generic;


/*
本项目目的为开发一个在控制台中可以游玩的贪吃蛇游戏。
主要实现思路：
定义一个22*22的二维数组用来存储地图
 
 */





namespace Snake
{
    public class Fruit
    {
        //定义表示水果的字符
        private static char charFruit = '*';

        public static Point fruitPoint = new Point(){X =5,Y =5 };

        public static List<Point> blankPointList = new();

        public static bool ifRefreshFruitPoint = false;

        //把地图上所有空白点写进blankPointList，每生成一段蛇身，就把该蛇身所占的点从blankPointList中删去
        public static void FruitInitiate()
        {
            for (int i = 0; i < Map.map.GetLength(1) - 2; i++)
            {
                //循环当前行中除了左右边界的所有列
                for (int j = 0; j < Map.map.GetLength(0) - 2; j++)
                {
                    Point point = new Point() { X = i+1,Y = j+1};

                    blankPointList.Add(point);
                   
                }
            }



        }

        //此方法用来读取地图中的空白坐标。水果需要生成在没有蛇身的空白位置
        //public static void GetMapBlank()
        //{


        //    for (int i = 0; i < Map.; i++)
        //    {

        //    }

        //    if (Map.map[0,1] == ' ')
        //    {

        //    }

        //    //for (int i = 0; i < Snake.snakeQueue.Count; i++)
        //    //{
        //    //    Snake.snakeQueue[i]
        //    //}


        //}

        public static void FruitGenerate()
        {
            
            
            
            if (ifRefreshFruitPoint)
            {
                //实例化Random类
                Random rd = new Random();

                int temp = rd.Next(0, blankPointList.Count);
                fruitPoint.X = blankPointList[temp].X;
                fruitPoint.Y = blankPointList[temp].Y;

                ifRefreshFruitPoint = false;
            }

            Map.map[fruitPoint.X, fruitPoint.Y] = charFruit;
            

            


            

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
