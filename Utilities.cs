using SimpleInventoryManagementSystem.Domain;

namespace SimpleInventoryManagementSystem
{
    public class Utilities
    {

        public static void AddProduct(Inventory inventory)
        {
            Console.WriteLine("Enter product name: ");
            var productName = Console.ReadLine();
            if (String.IsNullOrEmpty(productName))
            {
                Console.WriteLine("Product name cannot be null or empty");
                return;
            }
            Console.WriteLine("Enter product price");
            var isPriceValid = float.TryParse(Console.ReadLine(), out var price);
            if (!isPriceValid)
            {
                Console.WriteLine("Invalid price value.");
                return;
            }
            Console.WriteLine("Enter product quantity");
            var isQuantityValid = int.TryParse(Console.ReadLine(), out var quantity);
            if (!isQuantityValid)
            {
                Console.WriteLine("Invalid quantity value.");
                return;
            }
            inventory.AddProduct(productName, price, quantity);
        }

        public static void ViewAllProducts(Inventory inventory)
        {
            inventory.ViewAllProducts();
        }

        public static void EditProduct(Inventory inventory)
        {
            Console.WriteLine("Enter the product name to update:");
            string productName = Console.ReadLine();

            if (String.IsNullOrEmpty(productName))
            {
                Console.WriteLine("Product name cannot be null or empty");
                return;
            }

            Console.WriteLine("Enter new product name (press enter to keep the current name):");
            string newProductName = Console.ReadLine();
            Console.WriteLine("Enter new product price (press enter if you want the same price):");
            var price = Console.ReadLine();
            float productPrice;
            if (!String.IsNullOrEmpty(price))
            {
                var isPriceValid = float.TryParse(price, out var validPrice);
                if (!isPriceValid)
                {
                    Console.WriteLine("Invalid price value.");
                    return;
                }
                productPrice = validPrice;
            }
            else
            {
                productPrice = 0f;
            }
            Console.WriteLine("Enter new product quantity (press enter if you want the same price):");
            var quantity = Console.ReadLine();
            int productQuantity;
            if (!String.IsNullOrEmpty(quantity))
            {
                var isQuantityValid = int.TryParse(quantity, out var validQuantity);
                if (!isQuantityValid)
                {
                    Console.WriteLine("Invalid price value.");
                    return;
                }
                productQuantity = validQuantity;
            }
            else
            {
                productQuantity = -1;
            }
            inventory.EditProduct(productName, newProductName, productPrice, productQuantity);
        }

        public static void DeleteProduct(Inventory inventory)
        {
            Console.WriteLine("Enter the product name to delete:");
            string deleteProductName = Console.ReadLine();
            if (String.IsNullOrEmpty(deleteProductName))
            {
                Console.WriteLine("Invalid input");
                return;
            }
            inventory.DeleteProduct(deleteProductName);
        }

        public static void SearchProduct(Inventory inventory)
        {
            Console.WriteLine("Enter the product name to search for:");
            string searchProductName = Console.ReadLine();
            if (String.IsNullOrEmpty(searchProductName))
            {
                Console.WriteLine("Invalid input");
                return;
            }
            inventory.SearchProduct(searchProductName);
        }
    }
}
