// 05.Write a program that calculates 
// N!*K! / (K-N)! for given N and K (1<N<K).

using System;
using System.Numerics;

class AnotherNandKFactorial
{
    static void Main(string[] args)
    {
        Console.Title = "N and K Factorial";
        Console.Write("Enter a number for N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter a number for K: ");
        int k = int.Parse(Console.ReadLine());
        BigInteger resN = 1;
        BigInteger resK = 1;
        BigInteger result = 0;
        int kAndN = k - n;
        BigInteger resKAndN = 1;

        while (n >= 1)// determine the n factorial
        {
            resN *= n;
            n--;
        }
        while (k >= 1)// determine the k factorial
        {
            resK *= k;
            k--;
        }
        while (kAndN >= 1) // k-n factorial
        {
            resKAndN *= kAndN;
            kAndN--;
        }
        result = (resN * resK) / resKAndN;
        Console.WriteLine(result);
    }
}