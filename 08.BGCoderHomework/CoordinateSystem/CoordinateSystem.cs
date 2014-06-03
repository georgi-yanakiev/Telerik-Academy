﻿// Task 01. "C# Fundamentals 2011/2012 Part 1 - Sample Exam"
using System;

namespace ExerciseSolution
{
    class CoordinateSystem
    {
        static void Main(string[] args)
        {
            decimal x = decimal.Parse(Console.ReadLine());
            decimal y = decimal.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("1");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("4");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("3");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("0");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("5");
            }
            else if (x != 0 && y == 0)
            {
                Console.WriteLine("6");
            }
        }
    }
}