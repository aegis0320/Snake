using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Snake
{   
        public class Input
        {
            public enum Direction
                        {
                            Up,
                            Down,
                            Left,
                            Right
                        }


            private static Direction moveDirection;

            public static Direction MoveDirection { get => moveDirection; private set => moveDirection = value; }

        
            

            

            
            public static void GetUserInput()
            {


                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                         MoveDirection = Direction.Up;
                         break;
                    case ConsoleKey.DownArrow:
                         MoveDirection = Direction.Down;
                        break;
                    case ConsoleKey.LeftArrow:
                        MoveDirection = Direction.Left;
                        break;
                    case ConsoleKey.RightArrow:
                        MoveDirection = Direction.Right;
                        break;
                
                }
            }
            


    }
}
