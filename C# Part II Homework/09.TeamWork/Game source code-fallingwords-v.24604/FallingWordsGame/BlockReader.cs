using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingWordsGame
{
    public class BlockReader
    {
        string destination;
        StreamReader reader;
        bool errorOccured;
        List<string[]> inCaseOfErrorBlocks;
        int indexInCaseOfError;
        
        public BlockReader(string dest)
        {
            errorOccured = false;
            destination = dest;
            try
            {
                reader = new StreamReader(destination);
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("File {0} can does not exist.",
                    destination.Substring(destination.LastIndexOf('/') + 1));
                errorOccured = true;
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Destination path {0} is not a valid path",
                    destination.Substring(0, destination.LastIndexOf('/')));
                errorOccured = true;
            }
            catch (IOException)
            {
                Console.Error.WriteLine("Can not read from file {0} because of I/O error",
                    destination.Substring(destination.LastIndexOf('/') + 1));
                errorOccured = true;
            }
            finally
            {
                if(errorOccured)
                {
                    Console.WriteLine("The boss block will be created manually");
                    System.Threading.Thread.Sleep(5000);
                    inCaseOfErrorBlocks = new List<string[]>();
                    indexInCaseOfError = 0;
                    inCaseOfErrorBlocks.Add(
                        new string [] {
                                          "sometimes in the computer can occure an error",
                                          "for some one it can be terrifying shock",
                                          "but dont be affraid and run in terror",
                                          "just use try catch block"
                    }); // LOL
                }
            }
        }

        public bool End()
        {
            if (errorOccured)
            {
                return indexInCaseOfError == inCaseOfErrorBlocks.Count;
            }
            else
            {
                return reader.EndOfStream;
            }
        }

        public string[] NextBlock()
        {
            if (errorOccured)
            {
                return inCaseOfErrorBlocks[indexInCaseOfError++];
            }
            else
            {
                List<string> block = new List<string>();
                string line = "";
                do
                {
                    line = reader.ReadLine();
                    block.Add(line);
                } while (line != "@");
                block.Remove("@");
                return block.ToArray();
            }
        }


    }
}
