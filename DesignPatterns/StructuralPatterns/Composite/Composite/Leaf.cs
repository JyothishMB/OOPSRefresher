using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Leaf : IComponent
    {
        public int Price { get; set; }
        public string Name { get; set; }

        public Leaf(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }
        public void DisplayPrice()
        {
            Console.WriteLine($"Component \n\tName -> {this.Name}\n\tPrice -> {this.Price}");
        }
    }
}
