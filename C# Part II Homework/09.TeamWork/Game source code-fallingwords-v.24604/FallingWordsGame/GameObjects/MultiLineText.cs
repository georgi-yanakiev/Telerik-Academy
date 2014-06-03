using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingWordsGame
{
    class MultiLineText : GameObject
    {
        public Word this [int index]
        {
            get
            {
                return body[index];
            }
        }

        public MultiLineText(string [] lines)
        {
            body = new List<Word>();
            Populate(lines);
        }

        public void Populate(string[] lines)
        {
            int longestStringLength = 0;
            foreach (string line in lines)
            {
                Word newWord = new Word(line, new Coordinates(0, 0));
                body.Add(newWord);
                if (line.Length > longestStringLength)
                {
                    longestStringLength = line.Length;
                }
            }
            int leftPosition = 5; // This needs to be done more carefully
            
            for (int i = 0; i < body.Count; i++)
            {
                body[i].setPosition(i, leftPosition);
            }
        }

        public override void Move()
        {
            for (int i = 0; i < body.Count; i++)
            {
                Coordinates currentCoordinates = body[i].GetPosition();
                body[i].SetPostition(currentCoordinates + new Coordinates(1, 0));
            }
        }
        
    }
}
