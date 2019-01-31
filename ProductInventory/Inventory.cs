using System;
using System.Collections.Generic;

namespace ProductInventory
{
    public class Inventory
    {
        internal List<Product> inventory = new List<Product>();

        internal void Add(Product prod)
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
                    result += item.Name + ", ";
                }
   
            }
            result = result.Remove(result.Length - 2);
            return result;
        }

        public void RemoveProduct(string name)
        {
            inventory.RemoveAll(product => product.Name == name);

        }
    }
}