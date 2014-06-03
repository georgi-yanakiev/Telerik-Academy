// for testing purposes

namespace GenericList
{
    using System;

    class GenericListTest
    {
        static void Main()
        {
            GenericList<int> testArray = new GenericList<int>();
            testArray.Add(2);
            testArray.Add(45);
            testArray.Add(-7);
            testArray.Add(12);
            testArray.Add(79);
            testArray.Add(30);

            Console.WriteLine("Add elements test: {0} ", testArray);

            testArray.Remove(2);
            Console.WriteLine("\nRemove elements test: {0}", testArray);

            testArray.Insert(2, 100);
            Console.WriteLine("\nInsert elements at position test: {0}", testArray);

            Console.WriteLine("\nFind element by value test: {0}", testArray.FindByValue(100));

            Console.WriteLine("\nMaximum value test: {0}", testArray.Max());
            Console.WriteLine("\nMinimum value test: {0}", testArray.Min());

            testArray.Clear();
            Console.WriteLine("\nClear array test: {0}\n", testArray);
        }
    }
}