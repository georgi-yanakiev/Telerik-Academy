using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingWordsGame
{
    // Finished class
    public class WordGenerator
    {
        private Random random;
        private string[] wordDataBase;
        private int maxWidth;

        public WordGenerator(string [] wordDataBase)
        {
            this.wordDataBase = wordDataBase;
            maxWidth = Game.viewFieldWidth / 2;
            random = new Random();
        }

        private int GetCoordinates(int wordLength)
        {
            return random.Next(0, maxWidth - wordLength);
        }

        public Word NewWord()
        {
            int randomNumIndex = random.Next(0, wordDataBase.Length - 1);
            string randomWord = wordDataBase[randomNumIndex];
            int y = GetCoordinates(randomWord.Length);
            Word newRandomWord = new Word(randomWord, new Coordinates(0, y));
            return newRandomWord;
        }
    }
}
