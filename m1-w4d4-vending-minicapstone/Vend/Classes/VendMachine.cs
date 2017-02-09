using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vend.Classes
{
    public class VendMachine
    {
        Dictionary<string, VendingMachineItems> machine = new Dictionary<string, VendingMachineItems>();

        public void Vend()
        {

            while (true)
            {
                Console.WriteLine("1) Feed Money");
                Console.WriteLine("2) Purchase Items");
                int userInput = int.Parse(Console.ReadLine());

                if(userInput == 1)
                {
                    // feed money method
                }
                else if (userInput == 2)
                {
                    // purchase items method
                }
                else if (userInput == 0)
                {
                    // technician method
                }
                else if(userInput == 9)
                {
                    // exit loop
                    break;
                }

            }
        }
    }
}
