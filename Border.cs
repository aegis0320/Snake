namespace Snake
{
    public static class Border
    {
        public static char borderChar = '@';
        
        public static void BorderGenerate(char[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (i>0 && i< map.GetLength(0)-1 && j>0 && j< map.GetLength(1)-1)
                    {
                       //Map.map[i, j] = borderChar;
                    }
                    else
                    {
                        Map.map[i, j] = borderChar;
                    }
                }
            }
        }
    }

    
}
