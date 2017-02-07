using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FindAndReplace
{
    public class Program
    {
        static string searchPhrase = "";
        static string replacePhrase = "";
        static string filePath = "";
        static string destinationPath = "";
        static bool sourceDirExists;
        static bool destintationDirExists;
        static void Main(string[] args)
        {
            // Ask user for File Path

            Console.WriteLine("Please enter the full filepath ?");
            filePath = Console.ReadLine();

            // Ask user for Destination Path

            Console.WriteLine("Please enter the destination full filepath: ");
            destinationPath = Console.ReadLine();

            //string filename = @"alices_adventures_in_wonderland.txt";

            //string fullPath = Path.Combine(filePath, filename); /// full path

            sourceDirExists = File.Exists(filePath);

            destintationDirExists = File.Exists(destinationPath);

            if (sourceDirExists)
            {

                // Ask user for Search phrase
                Console.WriteLine("What phrase would you like to replace?");
                searchPhrase = Console.ReadLine();

                // Ask user for Replace phrase

                Console.WriteLine("What would you like to replace it with?");
                replacePhrase = Console.ReadLine();
                if (searchPhrase == "" || replacePhrase == "")
                {
                    Console.WriteLine("Error - please fill out both fields.");
                }
                else
                {
                    if (!destintationDirExists)
                    {
                        SearchAndReplaceMethod();
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Invalid destination found.");
                        Console.ReadLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid path or filename.");
            }
        }

        public static void SearchAndReplaceMethod()
        {
            // Open the existing file with the typo using a StreamReader
            using (StreamReader sr = new StreamReader(filePath))
            {
                // Open a StreamWriter where we will output the file
                using (StreamWriter sw = new StreamWriter(destinationPath, false))
                {
                    // For each line in the input file, read it in                    
                    while (!sr.EndOfStream)
                    {
                        // Read an individual line
                        string line = sr.ReadLine();

                        // Replace the occurence of the word langauge with language
                        string fixedLine = line.Replace(searchPhrase, replacePhrase);


                            // Write the new line to the output file
                            sw.WriteLine(fixedLine);
                        }
                    }
                }
            }
        }
    }
