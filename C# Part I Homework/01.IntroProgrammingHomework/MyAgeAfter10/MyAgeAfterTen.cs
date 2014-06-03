// Exercise 12:
// Write a program to read your age from the console 
// and print how old you will be after 10 years.

using System;

class MyAgeAfterTen
{
    static void Main()
    {
        Console.Title = "My age after 10 years";
        string myAge;

        // initialization of variables with their default values
        bool isInt = false;
        uint num = 0;
        
        // while loop construction used.
        // the code will execute until proper value is inserted
        // in this case only positive numbers are allowed
        while (!isInt)
        {
            Console.Write("Please, enter your age : ");
            myAge = Console.ReadLine();

            // uint.TryParse method converts strings into ints
            isInt = uint.TryParse(myAge, out num);

            // conditional (ternary) operator is used.
            Console.WriteLine(isInt ? "" : "Please enter valid age number!\n");
        }
        Console.WriteLine("In 10 years you will be {0} years old.\n ", num + 10);
    }
}