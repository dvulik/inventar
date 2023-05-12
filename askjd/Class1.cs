using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventar
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Inventory
    {
        private Product[] products;
        private int count;

        public Inventory(int size)
        {
            products = new Product[size];
            count = 0;
        }

        public void AddProduct(string name, double price)
        {
            try
            {
                if (price < 0)
                {
                    throw new Exception("cena nemuze byt zaporna");
                }

                foreach (Product p in products)
                {
                    if (p != null && p.Name == name)
                    {
                        throw new Exception("produkt jiz existuje v inventari");
                    }
                }
                if (count >= products.Length)
                {
                    throw new Exception("inventar je plny");
                }

                products[count] = new Product { Name = name, Price = price };
                count++;
                Console.WriteLine("novy item v inventari: " + name + ", " + price + "kč");
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("error: " + e.Message);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        public void RemoveProduct(string name)
        {
            bool found = false;
            for (int i = 0; i < count; i++)
            {
                if (products[i] != null && products[i].Name == name)
                {
                    products[i] = null;
                    found = true;
                    Console.WriteLine("produkt byl vymazan z inventare: " + name);
                    break;
                }
            }
            if (!found)
                Console.WriteLine("produkt nebyl nalezen: " + name);
        }
    }
}