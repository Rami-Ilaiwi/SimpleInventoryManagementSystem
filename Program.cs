﻿using SimpleInventoryManagementSystem.Domain;

Inventory inventory = new Inventory();
bool exitProgram = false;
while (!exitProgram)
{
    Console.WriteLine("1: Add a product");
    Console.WriteLine("2: View all products");
    Console.WriteLine("3: Edit a product");
    Console.WriteLine("4: Delete a product");
    Console.WriteLine("5: Search for a product");
    Console.WriteLine("6: Exit");

    Console.Write("Your selection: ");
    string selection = Console.ReadLine();
    Console.WriteLine();

    switch (selection)
    {
        case "1":
            Console.WriteLine("Enter product name: ");
            string productName = Console.ReadLine();
            Console.WriteLine("Enter product price");
            float productPrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter product quantity");
            int productQuantity = int.Parse(Console.ReadLine());
            inventory.AddProduct(productName, productPrice, productQuantity);
            break;
        case "2":
            inventory.ViewAllProducts();
            break;
        case "3":
            List<Product> products = inventory.GetAllProducts();
            if(products.Count > 0)
            {
                Console.WriteLine("Enter the product name to update:");
                string editProductName = Console.ReadLine();
                inventory.EditProduct(editProductName);
            } else
            {
                Console.WriteLine("There are no products to update!");
            }
            break;
        case "4":
            Console.WriteLine("Delete a product");
            break;
        case "5":
            Console.WriteLine("Search for a product");
            break;
        case "6":
            Console.WriteLine("Exit");
            break;
        default: Console.WriteLine("Wrong selection! Please enter a valid selection");
            break;
    }
    Console.WriteLine();
}
