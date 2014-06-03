// 03. Write a program to check if in a given expression the brackets are put correctly.
// Example of correct expression: ((a+b)/5-d).
// Example of incorrect expression: )(a+b)).

using System;

class BracketsCheck
{
    static void Main(string[] args)
    {
        Console.Title = "Brackets Check";
        Console.Write("Enter an expression: ");
        string expression = Console.ReadLine();
        int bracketsCount = 0;

        for (int i = 0; i < expression.Length; i++) // loop through the characters of the expression
        {
            if (expression[0] == ')') // no expression starts with closing bracket
            {
                Console.WriteLine("The brackets are wrong!");
                return;
            }
            if (expression[i] == '(') // checks if for every opening bracket, there is a closing one
            {
                bracketsCount++;
            }
            if (expression[i] == ')')
            {
                bracketsCount--;
            }
        }

        if (bracketsCount == 0) // when  bracketCount = 0 for every opening bracket a closing one exists
        {
            Console.WriteLine("The brackets are right!");
        }
        else
        {
            Console.WriteLine("The brackets are wrong!");
        }
    }
}
