using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingWordsGame
{
    // Finished class
    public static class WordManipulator
    {
        public static bool IsCurrentSpace(Word wordObj)
        {
            string input = wordObj.Text;
            for (int i = 0; i < input.Length; i++)
            {
                
                if (char.IsUpper(input[i]) || input[i] == '@')
                {
                    continue;
                }
                else if (input[i] != ' ' )
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }

        public static void ChangeSpace(Word wordObj)
        {
            char[] input = wordObj.Text.ToCharArray();

            
            for (int i = 0; i < input.Length; i++)
            {
               
                if (input[i] == ' ')
                {
                    input[i] = '@';
                    break;
                }
            }
            wordObj.SetWord(new string(input));
        }

        public static bool MatchFirstLowerChar(Word wordObject, char inputChar)
        {
            bool check = false;
            string wordForCheck = wordObject.Text;

            if (wordForCheck[0] == inputChar && char.IsLower(wordForCheck[0]))
            {
                check = true;
            }
            else
            {
                for (int i = 1; i < wordForCheck.Length; i++)
                {
                    if (wordForCheck[i] == inputChar && char.IsLower(wordForCheck[i]) && (char.IsUpper(wordForCheck[i - 1]) || wordForCheck[i - 1] == '@'))
                    {
                        check = true;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return check;
        }

        public static void MakeFirstLowerToUpperChar(Word wordObject)
        {
            char[] wordForChange = wordObject.Text.ToCharArray();
            if (char.IsLower(wordForChange[0]))
            {
                wordForChange[0] = char.ToUpper(wordForChange[0]);
            }
            else
            {
                for (int i = 1; i < wordForChange.Length; i++)
                {
                    if (char.IsLower(wordForChange[i]) && (char.IsUpper(wordForChange[i - 1]) || wordForChange[i - 1] == '@'))
                    {
                        wordForChange[i] = char.ToUpper(wordForChange[i]);
                        break;
                    }
                }
            }
            wordObject.SetWord(new string (wordForChange));
        }

        public static bool IsWholeWordToUpper(Word wordObject)
        {
            foreach (var item in wordObject.Text)
            {
                if(char.IsLower(item))
                {
                    return false;
                }
            }
            return true;
        }

        public static void UndoChanges(Word obj)
        {
            char[] wordToResetToLower = obj.Text.ToCharArray();
            for (int i = 0; i < wordToResetToLower.Length; i++)
            {
                if (wordToResetToLower[i] == '@')
                {
                    wordToResetToLower[i] = ' ';
                }
                else
                {
                    wordToResetToLower[i] = char.ToLower(wordToResetToLower[i]);
                }
            }
            obj.SetWord(new string (wordToResetToLower));
        }
    }
}
