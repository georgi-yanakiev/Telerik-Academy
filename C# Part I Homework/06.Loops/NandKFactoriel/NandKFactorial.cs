// 04.Write a program that calculates 
// N!/K! for given N and K (1<K<N).

using System;
using System.Numerics;

class NandKFactorial
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
        result = resN / resK;
        Console.WriteLine(resN);
        Console.WriteLine(resK);
        Console.WriteLine(result);
    }
}