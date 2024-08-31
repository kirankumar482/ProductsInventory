using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsInventory
{
    internal class Product
    {
        static int i = 1000;

        public int Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Product(string name, string description, double price)
        {
            Id = i++;
            Name = name;
            Description = description;
            Price = price;
            Console.WriteLine(Id); 
        }

        public override string ToString()
        {
            return Id.ToString() + " " + Name + " " + Description + " " + Price.ToString();
        }
    }
}
