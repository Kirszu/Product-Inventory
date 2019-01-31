using System;
using System.Collections.Generic;
using System.Text;

namespace ProductInventory
{
    public static class ConsoleUI
    {
        public static void PrintInstruction()
        {
            Console.WriteLine("What you want to do?");
            Console.WriteLine("1: Add new item");
            Console.WriteLine("2: Check the items in the inventory");
            Console.WriteLine("3: Remove existing item");
            Console.WriteLine("4: Calculate worth of the whole inventory");
            Console.WriteLine("5: Exit Program");
        }

        public static void AddNewItemToTheInventory(Inventory inv)
        {
            string name = InputCollector.AskForString("Provide name:");
            double price = InputCollector.AskForDouble("Provide price:");
            int quantity = InputCollector.AskForInteger("Provide quantity");
            Product product = new Product(name, price, quantity);
            inv.Add(product); 
        }

        public static void CheckItemsInInventory(Inventory inv)
        {
            if (Validator.CheckIfInventoryIsEmpty(inv))
            {
                Console.WriteLine("The inventory is empty");
            }
            else
            {
                Console.WriteLine(inv.ToString());
            };
        }

        public static void CalculateInventoryWorth(Inventory inv)
        {
            double sum = inv.CalculateSumOfInventory();
            Console.WriteLine("The sum of the invetory is {0}", sum); ;
        }

        public static void RemoveExistingItem(Inventory inv)
        {
            if (Validator.CheckIfInventoryIsEmpty(inv))
            {
                Console.WriteLine("You cannot remove anything from empty inventory");
            }
            else
            {
                Console.WriteLine(inv.ToString());
                string productNameToBeRemoved = InputCollector.AskForString("Provide name of product you want to remove:");
                inv.RemoveProduct(productNameToBeRemoved);
            };
        }

        public static void TryAgainMessage()
        {
            Console.WriteLine("Invalid option - type again"); 
        }
    }
}
