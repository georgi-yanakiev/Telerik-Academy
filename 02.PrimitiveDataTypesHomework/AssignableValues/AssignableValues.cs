// Which of the following values can be assigned
// to a variable of type float and which to a variable
// of type double: 34.567839023, 12.345, 8923.1234857,
// 3456.091?

using System;

class AssignableValues
{
    static void Main(string[] args)
    {
        Console.Title = "Assignable Values";
        double a = 34.567839023;
        float b = 12.345f;
        double c = 8923.1234857;
        float d = 3456.091f;
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
        Console.WriteLine("c = {0}", c);
        Console.WriteLine("d = {0}", d);
    }
}