// Task 02. "Telerik Academy Exam 1 @ 6 Dec 2011 Morning"
using System;
using System.Numerics;

class Tribonacci
{
    static void Main(string[] args)
    {
        BigInteger numbers = BigInteger.Parse(Console.ReadLine());
        BigInteger numbers1 = BigInteger.Parse(Console.ReadLine());
        BigInteger numbers2 = BigInteger.Parse(Console.ReadLine());
        int member = int.Parse(Console.ReadLine());
        BigInteger[] arr = new BigInteger[member];

        arr[0] = numbers;
        arr[1] = numbers1;
        arr[2] = numbers2;

        for (long i = 3; i < member; i++)
        {
            arr[i] = arr[i - 3] + arr[i - 2] + arr[i - 1];
        }
        Console.WriteLine(arr[member - 1]);
    }
}