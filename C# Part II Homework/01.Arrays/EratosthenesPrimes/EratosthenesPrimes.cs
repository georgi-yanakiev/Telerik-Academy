// 15. Write a program that finds all prime numbers in the range [1...10 000 000]. 
// Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;

internal class EratosthenesPrimes
{
    private static void Main(string[] args)
    {
        Console.Title = "Eratosthenes Primes";
        int num = 100;
        int[] numbers = new int[num + 1];
        int count = 2;

        for (int i = 2; i <= num; i++)
        {
            numbers[i] = count;
            count++;
        }

        // Starting at two and going until the square of the counter is less 
        // than the number specified, start crossing out multiples with a zero.

        for (int i = 2; (i*i) <= num; i++)
        {
            for (int j = (i*i); j <= num; j = j + i)
            {
                numbers[j] = 0;
            }
        }

        // Back through the array and look for the values not crossed out (not = 0).

        for (int i = 2; i <= num; i++)
        {
            if (numbers[i] != 0)
            {
                Console.WriteLine(("Primes: " + numbers[i]));
            }
        }
    }
}