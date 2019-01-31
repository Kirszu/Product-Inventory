using System;

namespace ProductInventory
{
    public static class InputCollector
    {

  
        public static double AskForDouble(string message)
        {
            Console.WriteLine(message);
            bool correctValue = false;
            do
            {
                string test = Console.ReadLine();
                if (Validator.CheckInputIfDouble(test))
                {
                    correctValue = true;
                    return double.Parse(test);
                }
                else
                {
                    Console.WriteLine("Provided value: {0} is not correct", test);
                    Console.WriteLine(message);
                }
            } while (correctValue == false);
            return 0;
        }

        public static int AskForInteger(string message)
        {
            Console.WriteLine(message);
            bool correctValue = false;
            do
            {
                string test = Console.ReadLine();
                if (Validator.CheckInputIfInteger(test))
                {
                    correctValue = true;
                    return int.Parse(test);
                }
                else
                {
                    Console.WriteLine("Provided value: {0} is not correct", test);
                    Console.WriteLine(message);
                }
            } while (correctValue == false);
            return 0;
        }

        public static string AskForString(string message)
        {
            Console.WriteLine(message);
            bool correctValue = false;
            do
            {
                string test = Console.ReadLine();
                if (Validator.CheckInputIfValidProductName(test))
                {
                    correctValue = true;
                    return test;
                }
                else
                {
                    Console.WriteLine("Provided value: {0} is not correct", test);
                    Console.WriteLine(message);
                }
            } while (correctValue == false);
            return "";
        }
    }
}