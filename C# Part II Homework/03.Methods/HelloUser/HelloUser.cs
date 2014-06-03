// 01. Write a method that asks the user for his name and prints “Hello, <name>” 
// (for example, “Hello, Peter!”). Write a program to test this method.

using System;

class HelloUser
{
    // method for printing the user greeting
    static void PrintHelloUser(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
    static void Main(string[] args)
    {
        Console.Title = "Hello User";
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        PrintHelloUser(name); // invokes the method PrintHelloUser with the name as parameter
    }
}
