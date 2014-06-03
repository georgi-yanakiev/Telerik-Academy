using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingWordsGame
{                                     //        viewFiedWidth      field
    public class Painter              //   _____________|____________
    {                                 //   |            |           |
        private char[,] field;        //   | words      | score:    |
        private int viewFieldWidth,   //   |  falling   |           |
                    viewFieldHeight;  //   |            |           |
        
        
        // For now - width/height are values of the whole console, but viewField is half the size
        public Painter(int width, int height)
        {
            field = new char[width, height];
            viewFieldHeight = width;
            viewFieldWidth = height / 2;
        }
        // Finished method
        // Removes everything from the matrix. Populates with whitespaces
        public void ClearField()
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = ' ';
                }
            }
        }

        public void PrintField()
        {
            for (int i = 0, len0 = field.GetLength(0); i < len0; i++)
            {
                for (int j = 0, len1 = field.GetLength(1); j < len1; j++)
                {
                    if (char.IsUpper(field[i, j]) && j < Game.viewFieldWidth - 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(char.ToLower(field[i, j]));
                        Console.ForegroundColor = ConsoleColor.White;   
                    }
                    else
                    {
                        if (field[i, j] == '@')
                        {
                            Console.Write(' ');
                        }
                        else
                        {
                            Console.Write(field[i, j]);
                        }
                    }                   
                }
                //Do not print the last NewLine because it makes the screen "jumpy"
                if (i + 1 < field.GetLength(0)) 
                {
                    Console.WriteLine();
                }
            }
        }
       
        private void InsertIntoField(Word WordtoInsert)
        {
            string word = WordtoInsert.GetValueAsString();
            Coordinates position = WordtoInsert.GetPosition();
            int x = position.posX;
            int y = position.posY;
            try
            {
                for (int i = 0; i < WordtoInsert.getLength(); i++)
                {
                    field[x, y + i] = word[i];
                }
            }
            catch(IndexOutOfRangeException)
            {
                Console.Error.Write("Trying to write word {0} at position {1}-{2} when field is {3} in height and {4} in width.", 
                    word, y, y + word.Length, field.GetLength(0), field.GetLength(1));
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
        }

        public void InsertIntoField(Interfaces.IPrintable printableObject)
        {
            foreach (Word word in printableObject.GetValueAsListOfWords())
            {
                InsertIntoField(word);
            }
        }

        public void StartScreen()
        {
            StringBuilder start = new StringBuilder();
            start.Append("Press s to start (^_^)");
            start.AppendLine("Game created by the creators of the game !");

            //for (int i = 0; i < Console.WindowHeight - 2; i++)
            //{
            //    Console.SetCursorPosition(Console.WindowWidth / 2, 0 + i);
            //    Console.WriteLine("|");
            //}


            Console.SetCursorPosition((Console.WindowWidth / 2) - 15, 0); //Принтира на 1/2 от ширината "Press s to start"
            System.Threading.Thread.Sleep(500); //Sleep na 500ms

            Console.WriteLine(start);//Изплюваме на конзолата всичко от StringBuilder-a start

            //Проверка за старт при натискане на S
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.S)
                {
                    //Ако бутонът е S продължаваме натам !
                }
            }
        }
        
        public void EndScreen()
        {
            StringBuilder end = new StringBuilder();

            end.Append("Game Over :( press x to exit");

            //Проверка за бутон x
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.X)
                {
                    //Ако бутонът е x излизаме .... end,exit and stuff ...

                }
            }

        }
    }
}
