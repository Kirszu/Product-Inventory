using System;

namespace ProductInventory
{
    internal class Validator
    {
        public Validator()
        {
        }

        public bool CheckInputIfInteger(string input)
        {
            int number;
            if (!int.TryParse(input, out number))
            {
                return false;
            } else
            {
                return true;
            }
        }
        public bool CheckInputIfDouble(string input)
        {
            double number;
            if (!double.TryParse(input, out number))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CheckInputIfValidProductName(string test)
        {
            int i = 0;
            if (!int.TryParse(test, out i) && (test != "")) 
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool CheckIfInventoryIsEmpty(Inventory inv)
        {
            if (inv.inventory.Count == 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}