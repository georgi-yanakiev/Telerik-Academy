// 05. Write a boolean expression for finding if the bit 3 
// (counting from 0) of a given integer is 1 or 0.

using System;

class TheThirdBit
{
    static void Main(string[] args)
    {
        Console.Title = "The Third Bit";
        Console.Write("Enter an integer: ");
        int num = int.Parse(Console.ReadLine());
        int mask = 1 << 3; // shift three bits left =1000 in binary
        Console.WriteLine("Is the third bit 0: " + ((num & mask) == 0)); // checks if the third bit is 1 or 0
    }
}