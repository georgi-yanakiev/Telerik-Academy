// Task 04. "C# Fundamentals 2011/2012 Part 1 - Test Exam"
using System;
using System.Linq;
using System.Collections.Generic;

class OddNumber
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<long> list = new List<long>();
        for (int i = 0; i < n; i++)
        {
            list.Add(long.Parse(Console.ReadLine()));
        }

        foreach (long value in list.Distinct())
        {
            if ((list.Count(v => v == value)) % 2 != 0)
            {
                Console.WriteLine(value);
            }
        }
    }
}
