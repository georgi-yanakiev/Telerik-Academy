// 02. Implement a set of extension methods for IEnumerable<T> that 
// implement the following group functions: sum, product, min, max, average.

namespace IEnumerableExtension
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtended
    {
        // summing
        public static T Sum<T>(this IEnumerable<T> inputData)
        {
            dynamic sum = 0;
            foreach (var item in inputData)
            {
                sum += item;
            }

            return sum;
        }

        // product
        public static T Product<T>(this IEnumerable<T> inputData)
        {
            dynamic product = 1;
            foreach (var item in inputData)
            {
                product *= item;
            }
            return product;
        }

        // minimum
        public static T Minimum<T>(this IEnumerable<T> inputData) where T : IComparable
        {
            T minimum = inputData.First();

            foreach (var item in inputData)
            {
                if (item.CompareTo(minimum) < 0)
                {
                    minimum = item;
                }
            }
            return minimum;
        }

        // maximum
        public static T Maximum<T>(this IEnumerable<T> inputData) where T : IComparable
        {
            T maximum = inputData.First();
            foreach (var item in inputData)
            {
                if (item.CompareTo(maximum) > 0)
                {
                    maximum = item;
                }
            }
            return maximum;
        }

        // average
        public static decimal Average<T>(this IEnumerable<T> inputData)
        {
            dynamic sum = 0;
            dynamic average = 0;
            decimal counter = 0;

            foreach (var item in inputData)
            {
                sum += item;
                counter++;
            }
            average = sum / counter;
            return average;
        }
    }
}