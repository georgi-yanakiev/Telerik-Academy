// 12. Write a program that exchanges bits 3, 4 and 5 
// with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class BitExchange
{
    static void Main(string[] args)
    {
        Console.Title = "Three Bits Exchange";
        uint num = 4278255360;
        Console.WriteLine("Original number =           " + Convert.ToString(num, 2));

        // using 7 because its binary representation is 111
        uint maskOne = 7 << 3;
        uint maskTwo = 7 << 24;

        // Extraction of 3, 4, 5 bits
        uint bitSetOne = num & maskOne;
        // Extraction of 24, 25, 26 bits
        uint bitSetTwo = num & maskTwo;
        // Shifting bits to their correct position
        uint bitsShiftOne = bitSetOne << 21;
        uint bitsShiftTwo = bitSetTwo >> 21;

        num = num & ~maskOne;
        num = num & ~maskTwo;
        // Inserting the reversed bits
        num = num | bitsShiftOne;
        num = num | bitsShiftTwo;
        Console.WriteLine("Exchanged bits number =     " + Convert.ToString(num, 2));
    }
}