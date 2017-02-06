using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordCount
{
    public static class ReadAndProcessWord
    {
        // Create the full path
        
        static string[] words = new string[10000];
        static string[] sentence = new string[5000];
        static int numberOfWords = 0;
        static int numberOfSentence = 0;

        public static void ReadACharacterFile(string filePath)
        {
            string fullPath = filePath;

            // Wrap the effort in a try-catch block to handle any exceptions
            try
            {
                //Open a StreamReader with the using statement
                using (StreamReader sr = new StreamReader(fullPath))
                {
                   

                    // Read the file until the end of the stream is reached
                    // EndOfStream is a "marker" that the stream uses to determine 
                    // if it has reached the end
                    // As we read forward the marker moves forward like a typewriter.
                    while (!sr.EndOfStream)
                    {
                        // Read in the line
                        string line = sr.ReadLine();
                        // Split the line by ,
                        string[] newWord = line.Split(' ');
                        numberOfWords += newWord.Length;
                        char[] separator = { '.', '!', '?' };
                        sentence = line.Split(separator);
                        numberOfSentence += sentence.Length;

                    }
                }     

            
            }
            catch (IOException e) //catch a specific type of Exception
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(e.Message);
            }
        }

      public static void printTotalCount()
        {
            Console.WriteLine();
            Console.WriteLine("Total Word Count: " + numberOfWords);
            Console.WriteLine("Total number of sentences: " + numberOfSentence);
            Console.ReadKey();
        }
    }
}
