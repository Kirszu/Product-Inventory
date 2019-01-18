using System;

namespace ProductInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inv = new Inventory();
            InputCollector input = new InputCollector();
            Validator val = new Validator();
            Console.WriteLine("Hello!");
            bool exitProgram = false;
            do
            {
                Console.WriteLine("What you want to do?");
                Console.WriteLine("1: Add new item");
                Console.WriteLine("2: Check the items in the inventory");
                Console.WriteLine("3: Remove existing item");
                Console.WriteLine("4: Calculate worth of the whole inventory");
                Console.WriteLine("5: Exit Program");
                bool askAgain = true;
                do
                {
                    int answer = input.AskForInteger("Type your choice:");
                    askAgain = true;
                    {
                        switch (answer)
                        {
                            case 1:
                                string name = input.AskForString("Provide name:");
                                double price = input.AskForDouble("Provide price:");
                                int quantity = input.AskForInteger("Provide quantity");
                                Product product = new Product(name, price, quantity);
                                inv.Add(product);
                                askAgain = false;
                                break;
                            case 2:
                                if (val.CheckIfInventoryIsEmpty(inv))
                                {
                                    Console.WriteLine("The inventory is empty");
                                }
                                else
                                {
                                    Console.WriteLine(inv.ToString());
                                }
                                askAgain = false;
                                break;
                            case 3:
                                if (val.CheckIfInventoryIsEmpty(inv))
                                {
                                    Console.WriteLine("You cannot remove anything from empty inventory");
                                }
                                else
                                {
                                    Console.WriteLine(inv.ToString());
                                    string productNameToBeRemoved = input.AskForString("Provide name of product you want to remove:");
                                    inv.RemoveProduct(productNameToBeRemoved);
                                }
                                askAgain = false;
                                break;
                            case 4:
                                double sum = inv.CalculateSumOfInventory();
                                Console.WriteLine("The sum of the invetory is {0}", sum);
                                askAgain = false;
                                break;
                            case 5:
                                exitProgram = true;
                                askAgain = false;
                                break;
                            default:
                                askAgain = true;
                                Console.WriteLine("Invalid option - type again");
                                break;
                        }
                    }
                } while (askAgain);
            } while (exitProgram == false);
           
        }
    }
}
