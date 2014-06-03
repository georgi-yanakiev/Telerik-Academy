using System;

class ValueExchange
{
    static void Main(string[] args)
    {
        Console.Title = "ValueExchange";
        byte a = 5;
        byte b = 10;
        byte c; // 3rd variable for value exchange
        Console.WriteLine("Before the exchange: \na = {0}\nb = {1}", a, b);
        c = a;
        a = b;
        b = c;
        Console.WriteLine("After the exchange: \na = {0}\nb = {1}", a, b);
    }
}