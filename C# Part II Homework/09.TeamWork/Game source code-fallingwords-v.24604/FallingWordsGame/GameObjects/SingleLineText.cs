using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingWordsGame
{
    public class SingleLineText : GameObject 
    {
        public string Text 
        {
            get
            {
                return body[0].Text;
            }
        }

        public SingleLineText(string text, Coordinates coords)
        {
            Word newWord = new Word(text, coords);
            body.Add(newWord);
        }

        public SingleLineText(Word wordObject)
        {
            body.Add(wordObject);
        }

        public override void Move()
        {
            
            Coordinates currentCoordinates = body[0].GetPosition();
            body[0].SetPostition(currentCoordinates + new Coordinates(1, 0));
        }

        public string GetValueAsString()
        {
            return body[0].GetValueAsString();
        }
    }
}
