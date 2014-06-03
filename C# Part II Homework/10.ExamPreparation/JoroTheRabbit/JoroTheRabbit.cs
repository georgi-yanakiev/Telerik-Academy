using System;

namespace JoroTheRabbit
{
    class JoroTheRabbit
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] cleanString = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] values = new int[cleanString.Length];
            int bestPath = int.MinValue;

            for (int i = 0; i < cleanString.Length; i++)
            {
                values[i] = int.Parse(cleanString[i]);
            }

            for (int startIndex = 0; startIndex < values.Length; startIndex++)
            {
                for (int step = 1; step < values.Length; step++)
                {
                    int index = startIndex;
                    int currentPath = 1;
                    int next = (index + step) % values.Length;

                    while (next != startIndex && values[index] < values[next])
                    {
                        currentPath++;
                        index = next;
                        next = (index + step) % values.Length;
                    }

                    if (bestPath < currentPath)
                    {
                        bestPath = currentPath;
                    }

                }
            }
            Console.WriteLine(bestPath);
        }
    }
}
