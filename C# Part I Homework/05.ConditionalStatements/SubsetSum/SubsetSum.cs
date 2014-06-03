// 09.We are given 5 integer numbers. Write a program that checks 
// if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8 -> 1+1-2=0.

using System;

class SubsetSum
{
    static void Main(string[] args)
    {
        Console.Title = "Subset Sum";
        Console.WriteLine("Enter 5 numbers: ");
        int[] numbers = new int[5];
        int maxCount = (int)Math.Pow(2, 5) - 1; // define all possible sum combinations
        int cnt = 0;
        
        for (int i = 0; i < 5; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i <= maxCount; i++) // loop throuh all possible combinations
        {
            int sum = 0;
            for (int j = 0; j < 5; j++) 
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    sum += numbers[j];
                }
            }
            if (sum == 0)
            {
                cnt++; // how many times the sum = 0 is obtained
            }
        }
        Console.WriteLine("{0} subsets = 0", cnt);
    }
}