// Task 03. "C# Fundamentals 2011/2012 Part 1 - Test Exam"

using System;
using System.Text;

class Trapezoid
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        char asterisk = '*';
        char dot = '.';
        string dotString = null;
        string asteriskString = null;
        string firstString = null;
        string lastString = null;
        string tempString = null;

        dotString = new string(dot, n);
        asteriskString = new string(asterisk, n);
        firstString = dotString + asteriskString;
        tempString = new string(dot, (2 * n) - 1) + asterisk;

        Console.WriteLine(firstString);
        for (int i = n - 1; i > 0; i--)
        {
            StringBuilder astArr = new StringBuilder(tempString);
            astArr[i] = asterisk;
            Console.WriteLine(astArr);
        }
        lastString = new string(asterisk, n * 2);
        Console.WriteLine(lastString);
    }
}