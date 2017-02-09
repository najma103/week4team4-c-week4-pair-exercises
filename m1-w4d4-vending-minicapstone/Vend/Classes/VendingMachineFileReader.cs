using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Vend.Classes
{
    public class VendingMachineFileReader
    {
        private string filePath = @"C:\Users\naden\week4team4-c-week4-pair-exercises\m1-w4d4-vending-minicapstone\vendingmachine.csv";
        public VendingMachineFileReader()
        {
            VendingMachineItems vmi = new VendingMachineItems();
            Dictionary<string, VendingMachineItems> items = new 
                Dictionary<string, VendingMachineItems>(readAndLoadFile(filePath));
          
        }

        public Dictionary<string,VendingMachineItems> readAndLoadFile(string filePath)
        {
            bool srcExists = File.Exists(filePath);
            if (srcExists)
            {

                try
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        // Read the file until the end of the stream is reached
                        while (!sr.EndOfStream)
                        {
                            // Read in a single line
                            string[] line = sr.ReadLine().Split('|');

                            // Add each line of the file to allLines collection
                            allLines.Add(line);

                        } //go to the next line until the end is reached
                    }
                }
                catch (IOException e) //catch a specific type of Exception
                {
                    Console.WriteLine("Error reading the file");
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("Error invalid FilePath given ");
                Console.ReadKey();
            }
            return allLines;

        }
    }
}
