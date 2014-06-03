using System;
using System.Text;

namespace MovingLetters
{
    class MovingLetters
    {
        static void Main(string[] args)
        {
            string[] encoded = Console.ReadLine().Split(' ');
            StringBuilder decoded = new StringBuilder();

            int longestWord = 0;

            for (int i = 0; i < encoded.Length; i++)
            {
                if (encoded[i].Length > longestWord)
                {
                    longestWord = encoded[i].Length;
                }
            }

            for (int index = 1; index <= longestWord; index++)
            {
                for (int word = 0; word < encoded.Length; word++)
                {
                    if (encoded[word].Length - index >= 0)
                    {
                        decoded.Append(encoded[word][encoded[word].Length - index]);
                    }
                }
            }

            int strLen = decoded.Length;
            int charPosition = 0;
            for (int i = 0; i < strLen; i++)
            {
                char currLetter = decoded[i];
                if (Char.IsUpper(currLetter))
                {
                    charPosition = i + (decoded[i] - 64);
                }
                else
                {
                    charPosition = i + (decoded[i] - 96);
                }

                if (charPosition >= strLen)
                {
                    charPosition = charPosition % strLen;
                }

                decoded.Remove(i, 1);
                decoded.Insert(charPosition, currLetter);
            }

            Console.WriteLine(decoded);
        }
    }
}
