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

        public List<Product> GetAllProducts() { return products; }

        public void EditProduct(string name)
        {
            Product product = products.Find(product => product.Name == name);

            if (product != null)
            {
                Console.WriteLine("Enter new product name:");
                string productName = Console.ReadLine();
                Console.WriteLine("Enter new product price:");
                float productPrice = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter new product quantity:");
                int productQuantity = int.Parse(Console.ReadLine());

                product.Name = productName;
                product.Price = productPrice;
                product.Quantity = productQuantity;
                Console.WriteLine("Product has been updated successfully!");

            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }
    }
}
