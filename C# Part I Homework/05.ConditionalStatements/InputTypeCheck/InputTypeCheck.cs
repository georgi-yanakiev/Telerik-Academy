// 08.Write a program that, depending on the user's choice inputs int, 
// double or string variable. If the variable is integer or double, increases it with 1. 
// If the variable is string, appends "*" at its end. The program must show the value 
// of that variable as a console output. Use switch statement.

using System;

class InputTypeCheck
{
    static void Main(string[] args)
    {
        Console.Title = "Input Type Check";
        Console.Write("Enter something: ");
        var input = Console.ReadLine();
        int tempInt = 1;
        double tempDouble = 1.00;
        bool inputInt = int.TryParse(input, out tempInt);
        bool inputDouble = double.TryParse(input, out tempDouble);
        char type;
        if (inputInt == false)
        {
            if (inputDouble == false)
            {
                type = 's';
            }
            else
            {
                type = 'd';
            }
        }
        else
        {
            type = 'i';
        }

        switch (type)
        {
            case 's':
                Console.WriteLine("Your input is String -> " + (input + "*"));
                break;
            case 'd':
                Console.WriteLine("Your input is Double -> " + (Convert.ToDouble(input) + 1));
                break;
            case 'i':
                Console.WriteLine("Your input is Integer -> " + (Convert.ToInt32(input) + 1));
                break;
            default:
                Console.WriteLine("Inappropriate value.");
                break;
        }
    }
}