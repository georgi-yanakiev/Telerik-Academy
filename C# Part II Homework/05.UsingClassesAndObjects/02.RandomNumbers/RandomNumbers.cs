// 02. Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class RandomNumbers
{
    static void Main(string[] args)
    {
        Console.Title = "Random Numbers";

        Random randomNum = new Random();
        Console.WriteLine(randomNum.Next(100, 201)); // generates random numbers between 100 and 200
    }
}