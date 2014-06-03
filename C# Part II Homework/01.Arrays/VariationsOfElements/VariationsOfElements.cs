// 20. Write a program that reads two numbers N and K and 
// generates all the variations of K elements from the set [1..N]. 
// Example: N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

using System;

internal class VariationsOfElements
{
    private static void Main(string[] args)
    {
        Console.Title = "Variations Of Elements";
        Console.Write("Enter value for N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter value for K: ");
        int k = int.Parse(Console.ReadLine());
        int[] num = new int[k];

        for (int i = 0; i < Math.Pow(n, k); i++) // number of variations is n^k)
        {
            int temp = i;

            for (int j = 0; j < k; j++)
            {
                num[k - j - 1] = temp%n; // fills the array with the remainder of division
                temp = temp/n; 
            }

            Console.Write("{0}{1}", '{', num[0] + 1);
            for (int j = 1; j < k; j++)
            {
                Console.Write(", {0}", num[j] + 1);
            }
            Console.WriteLine("}");
        }
    }
}