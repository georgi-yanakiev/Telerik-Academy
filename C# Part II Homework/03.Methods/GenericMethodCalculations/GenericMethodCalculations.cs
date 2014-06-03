// 15. * Modify your last program and try to make it work for any number type, not just integer 
//(e.g. decimal, float, byte, etc.). Use generic method (read in Internet about generic methods in C#).

using System;

class GenericMethodCalculations
{
    private static T CalcProduct<T>(params T[] array)
    {
        dynamic product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        return product;
    }

    private static T CalcSum<T>(params T[] array)
    {
        dynamic sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    private static T CalcAverage<T>(params T[] array)
    {
        dynamic sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum / array.Length;
    }

    private static T CalcMaximum<T>(params T[] array)
    {
        dynamic maximum = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maximum)
            {
                maximum = array[i];
            }
        }
        return maximum;
    }

    private static T CalcMinumum<T>(params T[] array)
    {
        dynamic minimum = array[0];
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
        Console.Title = "Generic Method Calculations";
        Console.WriteLine("Elements: 12, -4.23, 38859897125699.185, -6, 25");

        // all methods could be invoked with variable number of parameters
        // and with different types
        var minumum = CalcMinumum(12, -4.23, 38859897125699.185, -6, 25); // calculation of minimum element
        Console.WriteLine("\nThe minimal element is {0}", minumum);

        var maximum = CalcMaximum(12, -4.23, 38859897125699.185, -6, 25); // calculation of maximum element
        Console.WriteLine("\nThe maximal element is {0}", maximum);

        var average = CalcAverage(12, -4.23, 38859897125699.185, -6, 25); // calculation of average value
        Console.WriteLine("\nThe average element is {0}", average);

        var sum = CalcSum(12, -4.23, 38859897125699.185, -6, 25); // calculation of sum
        Console.WriteLine("\nThe sum is {0}", sum);

        var product = CalcProduct(12, -4.23, 38859897125699.185, -6, 25); // calculation of product
        Console.WriteLine("\nThe product is {0}\n", product);
    }
}
