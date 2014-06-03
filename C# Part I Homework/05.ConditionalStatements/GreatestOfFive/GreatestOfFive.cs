// 07.Write a program that finds the 
// greatest of given 5 variables.

using System;

class GreatestOfFive
{
    static void Main(string[] args)
    {
        Console.Title = "Greatest Of Five";
        Console.Write("Enter the first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int secondNum = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int thirdNum = int.Parse(Console.ReadLine());
        Console.Write("Enter the fourth number: ");
        int fourthNum = int.Parse(Console.ReadLine());
        Console.Write("Enter the fifth number: ");
        int fifthNum = int.Parse(Console.ReadLine());

        int greatestNum = 0;
        greatestNum = firstNum;

        if (greatestNum < secondNum)
        {
            greatestNum = secondNum; // each time reassign the bigger value to greatestNum variable
        }
        if (greatestNum < thirdNum)
        {
            greatestNum = thirdNum;
        }
        if (greatestNum < fourthNum)
        {
            greatestNum = fourthNum;
        }
        if (greatestNum < fifthNum)
        {
            greatestNum = fifthNum;
        }

        Console.WriteLine("The greatest number is: {0}.", greatestNum);
    }
}