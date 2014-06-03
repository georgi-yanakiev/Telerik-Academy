// 06. Write a program that prints from given array of integers all numbers that are divisible by 
// 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.


namespace DivisableNumbers
{
    using System;
    using System.Linq;

    public class NumbersTest
    {
        static void Main(string[] args)
        {
            int[] numbersArray =
            {
                5,
                8,
                3,
                21,
                42,
                7,
                31,
                19,
                63,
                69
            };

            // all numbers that are divisible by 7 and 3, which means not at the same time
            // so im using the || operator, if all the numbers divisible by 7 and 3 AT THE SAME TIME is needed
            // then || should be replaced with &&

            // using Linq
            Console.WriteLine("***Using Linq***");
            var divisableUsingLinq =
                                    from numbers in numbersArray
                                    where numbers % 3 == 0 || numbers % 7 ==0 
                                    select numbers;

            foreach (var number in divisableUsingLinq)
            {
                Console.WriteLine(number);
            }

            // using Linq
            Console.WriteLine("\n***Using Lambda Exp***");
            var divisableUsingLambdaExp = numbersArray.Where(n => n % 3 == 0 || n % 7 == 0);

            foreach (var number in divisableUsingLambdaExp)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
        }
    }
}