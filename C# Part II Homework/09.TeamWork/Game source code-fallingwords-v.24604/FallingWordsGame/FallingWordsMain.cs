
namespace FallingWordsGame
{
    using System;

    class FallingWordsMain
    {
        public static bool SoundOn;
        private static bool InStartScreen = true;
        static void Main()
        {

            SoundOn = true;
            Console.CursorVisible = false;
            Console.WindowHeight = Console.BufferHeight = 30;
            Console.WindowWidth = Console.BufferWidth = 80;
            Keyboard keyboard = new Keyboard();
            Game game = new Game(keyboard);

            bool startPressed = false;
            keyboard.LetterPressed += (sender, eventInfo) =>
            {
                game.OnLetterPressed((sender as Keyboard).pressedKey.KeyChar);
            };

            keyboard.SpacePressed += (sender, eventInfo) =>
            {
                game.OnSpacePressed();
            };

            keyboard.UpDownPressed += (sender, eventInfo) =>
            {
                if (InStartScreen)
                {
                    onStart = !onStart;
                }
            };

            keyboard.LeftRightPressed += (sender, eventInfo) =>
            {
                if(!InStartScreen)
                {
                    SoundOn = !SoundOn;
                }

            };

            keyboard.EnterPressed += (sender, eventInfo) =>
            {
                if(InStartScreen)
                {
                    if(onStart)
                    {
                        startPressed = true;
                    }
                    else
                    {
                        InStartScreen = false;
                    }
                }
                else
                {
                    InStartScreen = true;
                }
            };

            
            while (!startPressed)
            {
                keyboard.ProcessInput();
                if (InStartScreen)
                {
                    StartScreen();
                }
                else
                {
                    OptionsScreen();
                }
                System.Threading.Thread.Sleep(50);
                Console.Clear();
            }
            game.Start();
        }

        private static bool onStart = true;

        private static void StartScreen()
        {
            Console.WriteLine("\n\n\n\n\n\n\n\n");
            if (onStart)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t\t START\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\t\t\t\tOPTIONS");
            }
            else
            {
                Console.WriteLine("\t\t\t\t START\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t\tOPTIONS");
                Console.ForegroundColor = ConsoleColor.White;
                
            }

        }
 
        private static void OptionsScreen()
        {
            Console.WriteLine("\n\n\n\n\n\n\n\n");
            Console.Write("\t\t\t\tSOUND: ");
            if(SoundOn)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ON");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("    ");
                Console.WriteLine("OFF");
            }
            else
            {
                Console.Write("ON");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("    ");
                Console.WriteLine("OFF");
                Console.ForegroundColor = ConsoleColor.White;

            }

        }
    }
}
