using System;


namespace FallingWordsGame
{
    // Този клас е готов - тук се проверява дали е 
    // натиснат клавиш и се испраща информацията към Main метода
    public class Keyboard
    {
        public System.ConsoleKeyInfo pressedKey;
        
        public void ProcessInput()
        {
            if(Console.KeyAvailable)
            {
                pressedKey = Console.ReadKey(true); // true за да не печати на конзолата при натискане на клавиш

                if(char.IsLetter(pressedKey.KeyChar))
                {
                    if (LetterPressed != null)
                    {
                        LetterPressed(this, new EventArgs());
                    }
                }

                if(pressedKey.Key.Equals(ConsoleKey.Spacebar))
                {
                    if(SpacePressed != null)
                    {
                        SpacePressed(this, new EventArgs());
                    }
                }

                if (pressedKey.Key.Equals(ConsoleKey.Enter))
                {
                    if (EnterPressed != null)
                    {
                        EnterPressed(this, new EventArgs());
                    }
                }

                if(pressedKey.Key.Equals(ConsoleKey.UpArrow) || pressedKey.Key.Equals(ConsoleKey.DownArrow))
                {
                    if(UpDownPressed != null)
                    {
                        UpDownPressed(this, new EventArgs());
                    }
                }
                
                if(pressedKey.Key.Equals(ConsoleKey.LeftArrow) || pressedKey.Key.Equals(ConsoleKey.RightArrow))
                {
                    if (LeftRightPressed != null)
                    {
                        LeftRightPressed(this, new EventArgs());
                    }
                }
            }
        }

        public event EventHandler LetterPressed;
        public event EventHandler SpacePressed;
        public event EventHandler UpDownPressed;
        public event EventHandler EnterPressed;
        public event EventHandler LeftRightPressed;
    }
}
