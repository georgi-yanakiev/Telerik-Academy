// Task 02. "C# Fundamentals 2011/2012 Part 1 - Test Exam"
using System;

class LeastMajority
{
    static void Main(string[] args)
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        int num4 = int.Parse(Console.ReadLine());
        int num5 = int.Parse(Console.ReadLine());
        long div = 0;

        long count = 0;
        while (count < 3)
        {
            div++;
            count = 0;

            if (div % num1 == 0)
            {
                count++;
            }
            if (div % num2 == 0)
            {
                count++;
            }
            if (div % num3 == 0)
            {
                count++;
            }
            if (div % num4 == 0)
            {
                count++;
            }
            if (div % num5 == 0)
            {
                count++;
            }
        }
        Console.WriteLine(div);
    }
}