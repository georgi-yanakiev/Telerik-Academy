// 05. Write a method that checks if the element at given position in given 
// array of integers is bigger than its two neighbors (when such exist).

using System;

class BiggerThanNeighbours
{

    static void GetNeighbours(int[] array, int position)
    {
        if (position < array.Length - 1 && position > 0)
        {
            if (array[position] > array[position - 1] && array[position] > array[position + 1])
            {
                Console.WriteLine("The number is bigger than its neighbours.");
            }
            else
            {
                Console.WriteLine("The number is not bigger than its neighbours");
            }
        }
        else if (position == array.Length - 1)
        {
            if (array[position] > array[position - 1])
            {
                Console.WriteLine("The last element chosen and its bigger than previous.");
            }
            else
            {
                Console.WriteLine("The last element chosen and its smaller than previous.");
            }

        }
        else if (position == 0)
        {
            if (array[position] > array[position + 1])
            {
                Console.WriteLine("The first element chosen and its bigger than the next one.");
            }
            else
            {
                Console.WriteLine("The first element chosen and its bigger than the next one.");
            }
        }
    }

    static void Main(string[] args)
    {
        Console.Title = "Bigger Than Neighbours";
        Console.Write("Enter the number of elements in the array N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter an element positon (index) [0 <= pos < N]: ");
        int pos = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter a number: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        GetNeighbours(array, pos);
    }
}
