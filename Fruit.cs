using System;


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

        public static int [] fruitPoint = new int[2];

        public static void FruitGenerate()
        {
            //实例化Random类
            Random rd = new Random();

            //水果的生成需要判断当前坐标是否已经有蛇身的存在，所以需要先把蛇的类写好才能写水果的生成

            do
            {
                fruitPoint[0] = rd.Next(0,21);
                fruitPoint[1] = rd.Next(0,21);
            } while (true);
            

            Map.map[fruitPoint[0], fruitPoint[1]] = charFruit;

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
