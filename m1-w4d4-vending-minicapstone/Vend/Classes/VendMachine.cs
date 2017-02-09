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
        double balance = 0.00;


        public void VendMethod()
        {
            Console.WriteLine($"**************** VENDO-MATIC 500 ****************");
            Console.WriteLine($"\n********* PLEASE MAKE A SELECTION *********\n\n");

            while (true)
            {
                Console.WriteLine($"Current Balance: ${balance.ToString("F")} \n");
                Console.WriteLine("1) Feed Money");
                Console.WriteLine("2) Purchase Items");
                Console.Write($"\nPlease enter either a 1 or 2: ");


                // this if statement will reject non-int invalid inputs
                Int16 tempInput;
                int userInput = 0;

                if(Int16.TryParse(Console.ReadLine(), out tempInput))
                {
                    userInput = tempInput;
                }
                else
                {
                    Console.WriteLine($"Invalid selection\n");
                }


                if(userInput == 1)
                {
                    Console.WriteLine("You entered 1.\n");
                    FeedMoney();
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
                else
                {
                    Console.WriteLine($"Not a valid selection. Please try again.\n\n");
                    
                }

            }
        }

        public double FeedMoney()
        {
            Console.Write("Please enter a valid dollar amount (in 0.00 format): ");
            double tempBalance = 0.00;
            try { 

            tempBalance = double.Parse(Console.ReadLine());
            balance += tempBalance;
            }
            catch
            {
                Console.WriteLine("Not a valid dollar amount. Use dollar.cents format");
                FeedMoney();
            }

            Console.WriteLine($"You added ${tempBalance.ToString("F")} to your account. You now have ${balance.ToString("F")} available.\n\n");
            return balance;

        }
    }
}
