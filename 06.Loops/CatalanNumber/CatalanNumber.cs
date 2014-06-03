// 09 and 10. Write a program to calculate the 
// Nth Catalan number by given N.

using System;
using System.Numerics;

class CatalanNumber
{
    static void Main()
    {
        Console.Write("Enter a number >= 0: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger fac2N = 1;
        BigInteger facN = 1;
        BigInteger facNPlus = 1;
        BigInteger res = 0;

        if (n > 0)
        {
            for (int i = 1; i <= (2 * n); i++) // 2n factorial calculation
            {
                fac2N *= i;
            }
            for (int i = 1; i <= (n + 1); i++) // (n+1) factorial calculation
            {
                facNPlus *= i;
            }
            for (int i = 1; i <= n; i++) // n factorial calculation
            {
                facN *= i;
            }
            res = fac2N / (facNPlus * facN);
            Console.WriteLine("The {0} Catalan number is: {1}", n, res);
        }
        else if (n == 0)
        {
            Console.WriteLine("The 0 Catalan number is 0.");
        }
    }
}
