namespace FallingWordsGame
{
    using System.Collections.Generic;
    public class Word
    {
        public string Text { get; private set; }
        public Coordinates Position { get; private set; }
        public bool IsGuessed { get; set; }

        public Word(string str, Coordinates startingPosition)
        {
            Text = str;
            Position = startingPosition;
        }

        public void Move()
        {
            Position += new Coordinates(1, 0);
        }

        public void SetWord(string newWord)
        {
            Text = newWord;
        }

        public string GetValueAsString()
        {
            return Text;
        }

        public Coordinates GetPosition()
        {
            return Position;
        }

        public void setPosition(int row, int col)
        {
            Position = new Coordinates(row, col);
        }

        public void SetPostition(Coordinates coordinates)
        {
            Position = coordinates;
        }

        public int getLength()
        {
            return Text.Length;
        }
    }
}
