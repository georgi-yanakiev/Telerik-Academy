// 01. Write an expression that checks if 
// given integer is odd or even.

using System;

class OddOrEven
{
    static void Main(string[] args)
    {
        Console.Title = "Odd Or Even";
        Console.Write("Enter an integer: ");
        int num = int.Parse(Console.ReadLine());

        // if the remainder of division to 2 is 0, then the number is odd.
        if (num % 2 == 0)
        {
            Console.WriteLine("The number {0} is odd.", num);
        }
        else
        {
            Console.WriteLine("The number {0} is even.", num);
        }
    }
}