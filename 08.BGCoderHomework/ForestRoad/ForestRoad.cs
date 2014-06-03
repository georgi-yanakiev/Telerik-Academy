// Task 03. "C# Fundamentals 2011/2012 Part 1 - Sample Exam"
using System;
using System.Linq;
using System.Text;

class ForestRoad
{
    static void Main(string[] args)
    {
        int map = int.Parse(Console.ReadLine());
        char asterisk = '*';
        char dot = '.';
        string dotString = null;

        dotString = new string(dot, map);
        for (int j = 0; j <= map - 1; j++)
        {
            StringBuilder astArr = new StringBuilder(dotString);
            astArr[j] = asterisk;
            Console.WriteLine(astArr);
        }
        dotString = new string(dot, map);
        for (int i = map - 2; i >= 0; i--)
        {
            StringBuilder astArr = new StringBuilder(dotString);
            astArr[i] = asterisk;
            Console.WriteLine(astArr);
        }
    }
}