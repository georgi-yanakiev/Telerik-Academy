// 01.Write a program that prints 
// all the numbers from 1 to N.

using System;

class Numbers1ToN
{
    static void Main(string[] args)
    {
        Console.Title = "Numbers 1 to N";
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }

    }
}