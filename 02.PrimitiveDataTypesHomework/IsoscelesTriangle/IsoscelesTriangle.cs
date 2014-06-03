using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main(string[] args)
    {
        Console.Title = "Isosceles Triangle";
        Console.OutputEncoding = Encoding.Unicode;
        char copyright = (char)169;
        string charString = null;
        byte br = 3;

        for (int i = 1; i < br; i++)
        {
            charString = new string(copyright , i);
            Console.WriteLine(charString);
        }
        for (int z = br; z > 0; z--)
        {
            charString = new string(copyright, z);
            Console.WriteLine(charString);
        }
    }
}