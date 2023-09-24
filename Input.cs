using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Snake
{
    public class Input
    {
        //定义一个枚举类型变量Direction用来存储移动方向
        public enum Direction
        {
            Up,
            Left,
            Down,
            Right
        }

        //声明枚举变量,默认开局向右移动
        private static Direction moveDirection = Direction.Right;

        //枚举变量属性化
        public static Direction MoveDirection { get => moveDirection; private set => moveDirection = value; }






        //获取用户输入的方法
        //public static void GetUserInput()
        //{

        //}


        //接收用户输入的循环
        public static void InputCycle(double tick)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); // 开始计时

            TimeSpan targetTime = TimeSpan.FromSeconds(tick); // 目标执行时间为 tick 秒

            Direction userInputDirection = moveDirection;

            while (stopwatch.Elapsed < targetTime)
            {
                // 循环执行的代码

                /*Console.KeyAvailable方法用来获取键盘是否有按键输入。
                 * 如果有按键输入则返回True。只有用户按键之后才执行后面的代码。
                 * 因为Console.ReadKey()方法会造成程序的堵塞，让程序停止运行等待用户输入*/
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow:
                            userInputDirection = Direction.Up;
                            break;
                        case ConsoleKey.DownArrow:
                            userInputDirection = Direction.Down;
                            break;
                        case ConsoleKey.LeftArrow:
                            userInputDirection = Direction.Left;
                            break;
                        case ConsoleKey.RightArrow:
                            userInputDirection = Direction.Right;
                            break;

                    }

                }
                //Debug.WriteLine(MoveDirection);
                //Debug.WriteLine("Looping...");
            }
            stopwatch.Stop(); // 停止计时
            if (Math.Abs(userInputDirection - MoveDirection) != 2)
            {
                MoveDirection = userInputDirection;
            }





        }




    }
}
