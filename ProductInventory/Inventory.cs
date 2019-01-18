using System;
using System.Collections.Generic;

namespace ProductInventory
{
    internal class Inventory
    {
        public List<Product> inventory = new List<Product>();

        public void Add(Product prod)
        {
            inventory.Add(prod);
        }

        public double CalculateSumOfInventory()
        {
            double sum = 0;
            foreach (Product product in inventory)
            {
                sum += (product.Price * product.Quantity);
            }
            return sum;
        }

        public override string ToString()
        {
            string result = "";
            foreach (var item in this.inventory) { 
                {
                    result += "," + item.Name;
                }
   
            }
            return result;
        }

        public void RemoveProduct(string name)
        {
            inventory.RemoveAll(product => product.Name == name);

        }
    }
}