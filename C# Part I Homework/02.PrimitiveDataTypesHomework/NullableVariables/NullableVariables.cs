using System;

class NullableVariables
{
    static void Main(string[] args)
    {
        Console.Title = "Nullable Variables";
        int? nullInt = null;
        double? nullDouble = null;
        Console.WriteLine(nullInt);
        Console.WriteLine(nullDouble);
        // adding some values or null 
        Console.WriteLine(nullInt + 3);
        Console.WriteLine(nullDouble + null);
    }
}