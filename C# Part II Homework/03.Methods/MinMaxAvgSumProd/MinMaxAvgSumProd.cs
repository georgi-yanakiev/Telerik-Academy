// 14. Write methods to calculate minimum, maximum, average, sum and 
// product of given set of integer numbers. Use variable number of arguments.

using System;

class MinMaxAvgSumProd
{
    private static long CalcProduct(params int[] array)
    {
        long product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        return product;
    }

    private static int CalcSum(params int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    private static int CalcAverage(params int[] array)
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum / array.Length;
    }

    private static int CalcMaximum(params int[] array)
    {
        int maximum = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maximum)
            {
                maximum = array[i];
            }
        }
        return maximum;
    }

    private static int CalcMinumum(params int[] array)
    {
        int minimum = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minimum)
            {
                minimum = array[i];
            }
        }
        return minimum;
    }

    static void Main(string[] args)
    {
        Console.Title = "Min Max Avg Sum Prod";
        Console.WriteLine("Elements: 12, 4, 38, 6, 25");

        // all methods could be invoked with variable number of parameters
        int minumum = CalcMinumum(12, 4, 38, 6, 25); // calculation of minimum element
        Console.WriteLine("\nThe minimal element is {0}", minumum);

        int maximum = CalcMaximum(12, 4, 38, 6, 25); // calculation of maximum element
        Console.WriteLine("\nThe maximal element is {0}", maximum);

        int average = CalcAverage(12, 4, 38, 6, 25); // calculation of average value
        Console.WriteLine("\nThe average element is {0}", average);

        int sum = CalcSum(12, 4, 38, 6, 25); // calculation of sum
        Console.WriteLine("\nThe sum is {0}", sum);

        long product = CalcProduct(12, 4, 38, 6, 25); // calculation of product
        Console.WriteLine("\nThe product is {0}\n", product);
    }
}
