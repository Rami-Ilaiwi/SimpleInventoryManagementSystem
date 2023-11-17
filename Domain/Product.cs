using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInventoryManagementSystem.Domain
{
    public class Product
    {
        public Product(string name, float price, int quantity) { 
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
    }
}
