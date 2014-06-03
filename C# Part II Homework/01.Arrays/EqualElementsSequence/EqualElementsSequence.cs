// 04. Write a program that finds the maximal
// sequence of equal elements in an array.
//	Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.

using System;

internal class EqualElementsSequence
{
    private static void Main(string[] args)
    {
        Console.Title = "Equal Elements Sequence";

        Console.Write("Enter the number of elements in the array: ");
        int elements = int.Parse(Console.ReadLine());
        var array = new int[elements];
        int currentSequenceLength = 1;
        int maxSequenceLength = 0;
        int currValue = 0;

        for (int i = 0; i < elements; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        if (elements == 1)
        {
            Console.WriteLine("The sequence is {"+array[0]+"} -> {"+array[0]+"}" ); // if there is only one element
            return;
        }

        Console.Write("The sequence is {");
        foreach (int i in array)
        {
            Console.Write(i + ", "); 
        }
        Console.Write("\b\b} -> ");

        int initValue = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == initValue)
            {
                currentSequenceLength++;
                if (currentSequenceLength > maxSequenceLength)
                {
                    maxSequenceLength = currentSequenceLength;
                    currValue = initValue;
                }
                continue;
            }
            currentSequenceLength = 1;
            initValue = array[i];
        }

        if (maxSequenceLength == 1)
        {
            Console.WriteLine("There are no equal sequent elements!");
        }
        else
        {
            Console.Write("{");
            for (int z = 1; z <= maxSequenceLength; z++)
            {
                Console.Write(currValue + ", "); // printing the sequence
            }
            Console.WriteLine("\b\b}");
        }
    }
}