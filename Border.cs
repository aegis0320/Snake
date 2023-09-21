namespace Snake
{

    //定义Border类用来处理地图边界
    public static class Border
    {
        //定义用来表示边界的字符
        public static char borderChar = '@';
        
        //此方法用来在地图初始化之前，把表示边界的字符存储进map数组里的对应位置
        public static void BorderGenerate(char[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    //此处的if（!() ）里有两层括号，最里层的括号里的条件代表着边界，外面的!表示逻辑非，最终的判断条件是非边界
                    if (!(i>0 && i< map.GetLength(0)-1 && j>0 && j< map.GetLength(1)-1))
                    {
                       Map.map[i, j] = borderChar;
                    }
                    
                }
            }
        }
    }

    
}
