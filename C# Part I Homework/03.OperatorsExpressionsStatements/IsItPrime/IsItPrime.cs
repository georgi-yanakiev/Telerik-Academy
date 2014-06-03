// 07. Write an expression that checks if given positive 
// integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;

class IsItPrime
{
    static void Main(string[] args)
    {
        Console.Title = "Is It Prime";
        Console.Write("Enter an integer: ");
        byte num = byte.Parse(Console.ReadLine());
        int cnt = 0;

        for (byte i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                cnt++;
            }
        }
        if (cnt > 2) // If the number can be divided on more than 3 numbers i.e. 1, itself and other, then it is not prime
        {
            Console.WriteLine("The number {0} is not prime.", num);
        }
        else
        {
            Console.WriteLine("The number {0} is prime.", num);
        }
    }
}