// Task 02. "Telerik Academy Exam 1 @ 7 Dec 2011 Morning"
using System;
using System.Numerics;

class AstrologicalDigits
{
    static void Main(string[] args)
    {
        string numToString = Console.ReadLine();
        string strNoPoint = numToString.Replace(".", "");
        BigInteger num = BigInteger.Parse(strNoPoint);

        BigInteger sum = 0;
        sum = Sum(num);

        while (sum > 9)
        {
            sum = Sum(num);
            num = sum;
        }
        Console.WriteLine(sum);

    }

    static BigInteger Sum(BigInteger num)
    {
        BigInteger sum = 0;
        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }
        if (sum < 0)
        {
            return -sum;
        }
        else
        {
            return sum;
        }
    }
}