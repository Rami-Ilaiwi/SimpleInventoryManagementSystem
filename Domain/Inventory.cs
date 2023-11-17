using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInventoryManagementSystem.Domain
{
    public class Inventory
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(string name, float price, int quantity)
        {
            Product product = new Product(name, price, quantity);
            products.Add(product);
        }

        public void ViewAllProducts()
        {
            if (products.Count > 0)
            {
                Console.WriteLine("Products:");
                foreach (var product in products)
                {
                    Console.WriteLine($"Product name: {product.Name} -- Product price: {product.Price} -- Product quantity: {product.Quantity}");
                }
            }
            else { Console.WriteLine("There are no products to show!"); }
        }
    }
}
