// 10. Write a boolean expression that returns if the bit at position p (counting from 0) 
// in a given integer number v has value of 1. Example: v=5; p=1 -> false.

using System;

class IsItOne
{
    static void Main(string[] args)
    {
        Console.Title = "Is It One";
        Console.Write("Enter an integer: ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Enter a bit position: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p; // shifts the 1's bits p positions left 

        Console.WriteLine("Is the bit on position {0} = 1: {1}", p, (v & mask) != 0);
    }
}