using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> product = new List<string>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                product.Add(Console.ReadLine());
            }
            product.Sort();
            int counter = 1;
            foreach (var produc in product)
            {
                Console.WriteLine($"{counter}.{produc}");
                counter++;
            }
        }
    }
}
