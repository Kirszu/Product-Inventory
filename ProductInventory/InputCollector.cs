using System;

namespace ProductInventory
{
    public class InputCollector
    {
        private Validator val = new Validator();

        public InputCollector()
        {
        }

        public double AskForDouble(string message)
        {
            Console.WriteLine(message);
            bool correctValue = false;
            do
            {
                string test = Console.ReadLine();
                if (val.CheckInputIfDouble(test))
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

        public int AskForInteger(string message)
        {
            Console.WriteLine(message);
            bool correctValue = false;
            do
            {
                string test = Console.ReadLine();
                if (val.CheckInputIfInteger(test))
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

        public string AskForString(string message)
        {
            Console.WriteLine(message);
            bool correctValue = false;
            do
            {
                string test = Console.ReadLine();
                if (val.CheckInputIfValidProductName(test))
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