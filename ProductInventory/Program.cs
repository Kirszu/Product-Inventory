using System;

namespace ProductInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inv = new Inventory();
            Console.WriteLine("Hello!");
            bool exitProgram = false;
            do
            {
                ConsoleUI.PrintInstruction();
                bool askAgain = true;
                do
                {
                    int answer = InputCollector.AskForInteger("Type your choice:");
                    askAgain = true;
                    {
                        switch (answer)
                        {
                            case 1:
                                ConsoleUI.AddNewItemToTheInventory(inv);
                                askAgain = false;
                                break;
                            case 2:
                                ConsoleUI.CheckItemsInInventory(inv);
                                askAgain = false;
                                break;
                            case 3:
                                ConsoleUI.RemoveExistingItem(inv);
                                askAgain = false;
                                break;
                            case 4:
                                ConsoleUI.CalculateInventoryWorth(inv);
                                askAgain = false;
                                break;
                            case 5:
                                exitProgram = true;
                                askAgain = false;
                                break;
                            default:
                                askAgain = true;
                                ConsoleUI.TryAgainMessage();
                                break;
                        }
                    }
                } while (askAgain);
            } while (exitProgram == false);
           
        }
    }
}
