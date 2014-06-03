namespace StringBuilderExtension
{
    using System;

    class SubstringTest
    {
        static void Main(string[] args)
        {
            string text = "Imalo edno vreme edna vafla...";

            Console.WriteLine(text.SubstringExtended(22, 5)); // testing the extension method
        }
    }
}