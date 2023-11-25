namespace SimpleInventoryManagementSystem.Domain
{
    public class Inventory
    {
        private List<Product> products = new List<Product>();

        private Product FindProductByName(string name)
        {
            if (name == null)
            {
                return null;
            }

            return products?.FirstOrDefault(product => String.Equals(product.Name, name, StringComparison.InvariantCultureIgnoreCase));
        }

        public void AddProduct(string name, float price, int quantity)
        {
            if (FindProductByName(name) != null)
            {
                Console.WriteLine("Product already exists!");
            }
            else if (price <= 0)
            {
                Console.WriteLine("Price must be greater than zero.");
            }
            else if (quantity < 0)
            {
                Console.WriteLine("Quantity cannot be negative.");
            }
            else
            {
                Product product = new Product(name, price, quantity);
                products.Add(product);
            }
        }

        public void ViewAllProducts()
        {
            if (CheckInventoryIsEmpty())
            {
                Console.WriteLine("Products:");
                foreach (var product in products)
                {
                    Console.WriteLine(product);
                }
            }
            else { Console.WriteLine("There are no products to show!"); }
        }

        public bool CheckInventoryIsEmpty() { return products.Any(); }

        public void EditProduct(string oldName, string newName, float price, int quantity)
        {
            Product product = FindProductByName(oldName);
            Console.WriteLine(product);
            if (product != null)
            {
                if (!String.IsNullOrEmpty(newName))
                {
                    product.Name = newName;
                }
                if (price > 0)
                {
                    product.Price = price;
                }
                if (quantity >= 0)
                {
                    product.Quantity = quantity;
                }
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
                Console.WriteLine(product);
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }
    }
}
