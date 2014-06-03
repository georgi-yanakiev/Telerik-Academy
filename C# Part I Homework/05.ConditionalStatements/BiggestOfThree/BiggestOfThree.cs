// 03.Write a program that finds the biggest of 
// three integers using nested if statements.

using System;

class BiggestOfThree
{
    static void Main(string[] args)
    {
        Console.Title = "Biggest Of Three";
        Console.Write("Enter the first number: ");
        int numOne = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int numTwo = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int numThree = int.Parse(Console.ReadLine());
        
        if (numOne > numTwo)
        {
            if (numOne > numThree)
            {
                Console.WriteLine("{0} is the biggest number.", numOne);
            }
            else
            {
                Console.WriteLine("{0} is the biggest number.", numThree);
            }
        }
        else
        {
            if (numTwo > numThree)
            {
                Console.WriteLine("{0} is the biggest number.", numTwo);
            }
            else
            {
                Console.WriteLine("{0} is the biggest number.", numThree);
            }
        }
    }
}