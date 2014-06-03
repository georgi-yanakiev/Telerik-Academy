// 12. We are given integer number n, value v (v=0 or 1) and a position p. 
// Write a sequence of operators that modifies n to hold the value v at 
// the position p from the binary representation of n.

using System;

class BitModifier
{
    static void Main(string[] args)
    { 
        Console.Title = "Bit Modifier";
        Console.Write("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter value [1, 0]: ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Enter a bit position: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 0;
        int res = 0;

        if (v == 0)
        {
            mask = ~(1 << p); // mask to manipulate the bit in p position
            res = (n & mask); // setting a bit to 0 in a p position using bitwise operator AND
        }
        else
        {
            mask = 1 << p;     // mask to manipulate the bit in p position
            res = (n | mask);  // setting a bit to 1 in a p position using bitwise operator OR
        }
        Console.WriteLine("The new number value is: {0}", res);
    }
}