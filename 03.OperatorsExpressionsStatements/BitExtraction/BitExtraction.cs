// 11. Write an expression that extracts from a given integer i 
// the value of a given bit number b. Example: i=5; b=2 -> value=1.

using System;

class BitExtraction
{
    static void Main(string[] args)
    {
        Console.Title = "Bit Extraction";
        Console.Write("Enter an integer: ");
        int i = int.Parse(Console.ReadLine());

        Console.Write("Enter a bit number: ");
        int b = int.Parse(Console.ReadLine());
        int mask = 1 << b; // shifts the 1's bits p positions left for bit manipulation
        int iAndMask = i & mask; // setting the bit
        int bit = iAndMask >> b; // getting the bit at position b
        Console.WriteLine("Bit {0} is: {1}", b, bit);
    }
}