using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsInventory
{
    internal class Product1
    {
        static int i = 1000;
        private int id;
        private string name;
        private string description;
        private double price;

        public int Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Product1(string name, string description, double price)
        {
            id = ++i;
            this.name = name;
            this.description = description;
            this.price = price;
            Console.WriteLine(id); //gives id as expected
            Console.WriteLine(Id); // gives 0
        }

        public override string ToString()
        {
            return id.ToString() + " " + name + " " + description + " " + price.ToString();
        }
    }
}
