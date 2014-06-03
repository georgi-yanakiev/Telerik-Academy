namespace IEnumerableExtension
{
    using System;

    class IEnumerableExtendedTest
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            // testing
            Console.WriteLine("The sum of all numbers is {0}", numbers.Sum());
            Console.WriteLine("The product of all numbers is {0}", numbers.Product());
            Console.WriteLine("The minimal of all numbers is {0}", numbers.Minimum());
            Console.WriteLine("The maximal of all numbers is {0}", numbers.Maximum());
            Console.WriteLine("The average of all numbers is {0}", numbers.Average());
        }
    }
}