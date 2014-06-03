using System;

class QuoteDeclaration
{
    static void Main(string[] args)
    {
        Console.Title = "Quote Declaration";
        string quote1 = "The \"use\" of quotations causes difficulties.";
        string quote2 = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(quote1);
        Console.WriteLine(quote2);
    }
}
