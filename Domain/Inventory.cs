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

        private Product FindProductByName(string name)
        {
            return products.Find(product => product.Name == name);
        }

        public void AddProduct(string name, float price, int quantity)
        {
            Product product = new Product(name, price, quantity);
            products.Add(product);
        }

        public void ViewAllProducts()
        {
            if (CheckInventoryIsEmpty())
            {
                Console.WriteLine("Products:");
                foreach (var product in products)
                {
                    LogProduct(product);
                }
            }
            else { Console.WriteLine("There are no products to show!"); }
        }

        public bool CheckInventoryIsEmpty() { return products.Count > 0; }

        public void EditProduct(string name)
        {
            Product product = FindProductByName(name);

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

        public void DeleteProduct(string name)
        {
            Product product = FindProductByName(name);

            if (product != null)
            {
                products.Remove(product);
                Console.WriteLine("Product has been removed successfully!");
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        public void SearchProduct(string name)
        {
            Product product = FindProductByName(name);
            if (product != null)
            {
                LogProduct(product);
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        private void LogProduct(Product product)
        {
            Console.WriteLine($"Product name: {product.Name} -- Product price: {product.Price} -- Product quantity: {product.Quantity}");
        }
    }
}
