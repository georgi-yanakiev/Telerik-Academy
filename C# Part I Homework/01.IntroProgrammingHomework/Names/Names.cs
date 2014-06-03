// Exercise 6: 
// Create console application that 
// prints your first and last name.

using System;

class Names
{
    static void Main()
    {
        Console.Title = "Names";

        // the names are fictional, not real
        string firstName = "Ivan";
        string lastName = "Ivanov";

        // used formatting with placeholders ( {0}, {1}, etc.) which are replaced with 
        // values contained in the parameters. In this case firstName, lastName
        Console.WriteLine("My first name is {0}.\nMy last name is {1}.", firstName, lastName);
    }
}