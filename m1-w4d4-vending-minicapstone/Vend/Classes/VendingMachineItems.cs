using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vend.Classes
{
    public class VendingMachineItems
    {
        private string slot = "";
        private string name = "";
        private double price = 0.00;
        private int quantityRemaining = 0;

        public string Slot
        {
            get { return slot; }
        }
        public string Name
        {
            get { return name; }
        }
        public double Price
        {
            get { return price; }
        }
        public int QuantityRemaining
        {
            get { return quantityRemaining; }
        }

    }
}
