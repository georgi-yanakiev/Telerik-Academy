// 01. Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;

class IsItLeapYear
{
    static void Main(string[] args)
    {
        Console.Title = "Is It Leap Year";
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        bool IsItLeap = DateTime.IsLeapYear(year); // returns if the year is leap (True/False)

        if (IsItLeap)
        {
            Console.WriteLine("The year {0} is leap.", year);
        }
        else
        {
            Console.WriteLine("The year {0} is not leap.", year);
        }
    }
}