using System;

class BitBall
{
    static void Main(string[] args)
    {
        int fieldSize = 8;
        int[,] matrix = new int[fieldSize, fieldSize];
        int scoreT = 0;
        int scoreB = 0;

        for (int row = 0; row < fieldSize; row++)
        {
            int num = int.Parse(Console.ReadLine());
            string numToString = Convert.ToString(num, 2).PadLeft(8, '0');
            for (int col = 0; col < 8; col++)
            {
                matrix[row, col] = int.Parse(numToString[col].ToString());
            }
        }

        for (int row = 0; row < fieldSize; row++)
        {
            int num = int.Parse(Console.ReadLine());
            string numToString = Convert.ToString(num, 2).PadLeft(8, '0');
            for (int col = 0; col < 8; col++)
            {
                int xxx = int.Parse(numToString[col].ToString());
                if (matrix[row, col] == 1 && xxx == 1)
                {
                    matrix[row, col] = 0;
                    continue;
                }
                if (matrix[row, col] == 0 && xxx == 1)
                {
                    matrix[row, col] = 2;
                    continue;
                }
            }
        }

        for (int col = 0; col < fieldSize; col++)
        {
            for (int row = fieldSize - 1; row >= 0; row--)
            {
                if (matrix[row, col] == 1)
                {
                    scoreT++;
                    break;
                }
                if (matrix[row, col] == 2)
                {
                    break;
                }
            }
        }

        for (int col = 0; col < fieldSize; col++)
        {
            for (int row = 0; row < fieldSize; row++)
            {
                if (matrix[row, col] == 2)
                {
                    scoreB++;
                    break;
                }
                if (matrix[row, col] == 1)
                {
                    break;
                }
            }
        }
        Console.WriteLine("{0}:{1}", scoreT, scoreB);
    }
}