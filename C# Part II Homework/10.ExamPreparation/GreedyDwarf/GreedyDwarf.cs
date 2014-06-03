using System;

class GreedyDwarf
{
    static void Main(string[] args)
    {
        string valley = Console.ReadLine();
        int[] valleyValues = SplitInput(valley);
        int noOfPatt = int.Parse(Console.ReadLine());
        int collected = int.MinValue;



        for (int i = 0; i < noOfPatt; i++)
        {
            int[] pattern = SplitInput(Console.ReadLine());
            bool[] used = new bool[valleyValues.Length];
            int position = 0;

            int sum = 0;
            for (int z = 0; z < valleyValues.Length; z++)
            {
                if (used[position])
                {
                    break;
                }

                used[position] = true;
                sum += valleyValues[position];
                position += pattern[z % pattern.Length];

                if (position < 0 || position >= valleyValues.Length)
                {
                    break;
                }
            }
            if (sum > collected)
            {
                collected = sum;
            }

        }
        Console.WriteLine(collected);
    }

    static int[] SplitInput(string input)
    {
        string[] cleanString = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int[] values = new int[cleanString.Length];

        for (int i = 0; i < cleanString.Length; i++)
        {
            values[i] = int.Parse(cleanString[i]);
        }
        return values;
    }
}