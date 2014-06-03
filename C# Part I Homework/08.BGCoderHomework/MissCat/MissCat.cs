// Task 02.  "C# Fundamentals 2011/2012 Part 1 - Sample Exam"
using System;
using System.Linq;

class MissCat
{
    static void Main(string[] args)
    {
        int memNo = int.Parse(Console.ReadLine());
        int[] catArr = new int[10];
        int maxValue = 0;
        int maxIndex = 0;
        int cats = 0;

        for (int i = 1; i <= memNo; i++)
        {
            cats = int.Parse(Console.ReadLine());
            catArr[cats - 1]++;
        }
        maxValue = catArr.Max();
        maxIndex = catArr.ToList().IndexOf(maxValue);
        Console.WriteLine(maxIndex + 1);
    }
}