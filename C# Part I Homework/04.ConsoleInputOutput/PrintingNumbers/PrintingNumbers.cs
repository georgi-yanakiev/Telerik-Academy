// 08.Write a program that reads an integer number n from the console 
// and prints all the numbers in the interval [1..n], each on a single line.


using System;

class PrintingNumbers
{
    static void Main(string[] args)
    {
        Console.Title = "Printing Numbers";
        Console.Write("Enter an integer number: ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine(i);
        }
    }
}