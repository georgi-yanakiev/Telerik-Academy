// 13.Write a program that calculates for given N how 
// many trailing zeros present at the end of the number N!. 

using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive number: ");
        int num = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        BigInteger divider = 0;
        long count = 0;

        for (int i = 1; i <= num; i++) // finding the N!
        {
            factorial *= i;
        }

        divider = factorial;

        for (int i = 0; i <= decimal.MaxValue; i++)
        {
            if (divider % 10 == 0) // checks for trailing zeroes (if % 10 ==0 means the value ends with 0)
            {
                count++;
                divider /= 10;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine("The number of trailing zeroes in " + num + "! is: " + count + " (" + factorial + ")");
    }
}
