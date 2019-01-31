using System;

namespace ProductInventory
{
    public static class Validator
    {


        public static bool CheckInputIfInteger(string input)
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
        public static bool CheckInputIfDouble(string input)
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

        public static bool CheckInputIfValidProductName(string test)
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

        public static bool CheckIfInventoryIsEmpty(Inventory inv)
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