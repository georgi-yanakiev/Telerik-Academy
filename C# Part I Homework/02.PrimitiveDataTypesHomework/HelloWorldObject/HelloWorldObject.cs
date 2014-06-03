// Declare two string variables and assign them with
// "Hello" and "World". Declare an object variable and
// assign it with the concatenation of the first two
// variables (mind adding an interval). Declare a 
// third string variable and initialize it with the value
// of the object variable (you should

using System;

class HelloWorldObject
{
    static void Main(string[] args)
    {
        Console.Title = "Hello World Object";
        string hello = "Hello";
        string world = "World";
        object obj = hello + " " + world;
        string toObj = (string)obj;
        Console.WriteLine(obj);
        Console.WriteLine(toObj);
    }
}