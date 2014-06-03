// 21. Write a program that reads two numbers N and K and generates 
// all the combinations of K distinct elements from the set [1..N]. 
// Example: N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

using System;

    internal class CombinationsOfElements
    {
        private static void Combinations(int n, int k, int[] comboArray, int position, int start)
        {
            if (position == k) // checks the position
            {
                Console.Write("{"+comboArray[0]);
                for (int i = 1; i < k; i++)
                {
                    Console.Write(", " + comboArray[i]);
                }
                Console.WriteLine("}");
            }
            else
            {
                for (int i = start; i <= n; i++)
                {
                    comboArray[position] = i;
                    Combinations(n, k, comboArray, position + 1, start + 1); // recursive call with different position
                    start++;
                }
            }
        }

        private static void Main(string[] args)
        {
            Console.Title = "Combinations Of Elements";
            Console.Write("Enter value for N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter value for K: ");
            int k = int.Parse(Console.ReadLine());
            int[] comboArray = new int[k];
            Combinations(n, k, comboArray, 0, 1); //invoke Combinations method
        }
    }
