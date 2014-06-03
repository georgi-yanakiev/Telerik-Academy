// 10.Write a program to calculate the sum 
// (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class PreciseSum
{
    static void Main(string[] args)
    {
        Console.Title = "Precise Sum";
        decimal sum = 1M;
        decimal oldSum = 1M;
        decimal i = 2M;
        decimal accuracy = 0.001M;
        
        do
        {
            oldSum = sum; // keeps the value of the old sum
            if (i % 2 == 0)
            {
                sum += 1 / i;
                i++;
            }
            else
            {
                sum += 1 / -i;
                i++;
            }
        }
        while (Math.Abs(sum - oldSum) > accuracy);
        Console.WriteLine("The sum is: " + sum);
    }
}