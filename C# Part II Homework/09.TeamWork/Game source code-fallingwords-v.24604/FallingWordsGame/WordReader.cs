using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FallingWordsGame
{
    public class WordReader
    {
 
        private string destination;
        private StreamReader textReader;
        private string[] inCaseOfErrorWords;
        private int currentWordInCaseOfError;
        private bool errorOccured;

        public WordReader(string dest)
        {
            errorOccured = false;
            this.destination = dest;
            OpenFileForReading();
        }

        private void OpenFileForReading()
        {
            try
            {
                textReader = new StreamReader(destination);
            }
            catch(FileNotFoundException)
            {
                Console.Error.WriteLine("File {0} can does not exist.", 
                    destination.Substring(destination.LastIndexOf('/') + 1));
                errorOccured = true;
            }
            catch(DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Destination path {0} is not a valid path",
                    destination.Substring(0, destination.LastIndexOf('/')));
                errorOccured = true;
            }
            catch(IOException)
            {
                Console.Error.WriteLine("Can not read from file {0} because of I/O error", 
                    destination.Substring(destination.LastIndexOf('/') + 1));
                errorOccured = true;
            }
            finally
            {
                if (errorOccured)
                {
                    Console.Error.WriteLine("Words will be created manually");
                    System.Threading.Thread.Sleep(5000);
                    inCaseOfErrorWords = new string[] { "error", "terrible", "exception", "can not read", "apologies", "we are sorry" };
                    currentWordInCaseOfError = 0;
                }
            }
        }
  
        public bool End()
        {
            if (errorOccured)
            {
                return currentWordInCaseOfError == inCaseOfErrorWords.Length;
            }
            else
            {
                return textReader.EndOfStream;
            }
        }

        public string NextWord()
        {
            if (errorOccured)
            {
                return inCaseOfErrorWords[currentWordInCaseOfError++];
            }
            else
            {
                return textReader.ReadLine();
            }
        }

    }
}
