using System;
using System.Collections.Generic;

class DurankulakNumbers
{
    static void Main()
    {
        string numberBase168 = Console.ReadLine();
        ulong numberBase10 = ConvertNumberFromBase(numberBase168, 168);
        Console.WriteLine(numberBase10);
    }


    private static ulong ConvertNumberFromBase(string number, ulong numberBase)
    {
        ulong sum = 0;

        for (int i = 0; i < number.Length; i++)
        {
            int digit;
            if (char.IsUpper(number[i]))
            {
                digit = number[i] - 'A';
            }
            else
            {
                digit = (number[i] - 'a' + 1) * 26 + number[i + 1] - 'A';
                i++;
            }
            sum = sum * numberBase + (ulong)digit;
        }
        return sum;
    }
}