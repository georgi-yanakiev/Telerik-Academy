// 11. Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
// The cards should be printed with their English names. Use nested for loops and switch-case.

using System;

class CardsDeck
{
    static void Main()
    {
        Console.WriteLine("All 52 cards of the deck are:");

        for (int i = 1; i <= 4; i++) // a loop for card suits 
        {
            for (int j = 1; j <= 13; j++) // a loop for card ranks
            {
                switch (j)
                {
                    case 1:
                        Console.Write("Two");
                        break;
                    case 2:
                        Console.Write("Three");
                        break;
                    case 3:
                        Console.Write("Four");
                        break;
                    case 4:
                        Console.Write("Five");
                        break;
                    case 5:
                        Console.Write("Six");
                        break;
                    case 6:
                        Console.Write("Seven");
                        break;
                    case 7:
                        Console.Write("Eight");
                        break;
                    case 8:
                        Console.Write("Nine");
                        break;
                    case 9:
                        Console.Write("Ten");
                        break;
                    case 10:
                        Console.Write("Jack");
                        break;
                    case 11:
                        Console.Write("Queen");
                        break;
                    case 12:
                        Console.Write("King");
                        break;
                    case 13:
                        Console.Write("Ace");
                        break;
                    default:
                        break;
                }
                switch (i)
                {
                    case 1:
                        Console.WriteLine(" Of Clubs");
                        break;
                    case 2:
                        Console.WriteLine(" Of Hearts");
                        break;
                    case 3:
                        Console.WriteLine(" Of Diamonds");
                        break;
                    case 4:
                        Console.WriteLine(" Of Spades");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
