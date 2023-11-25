using SimpleInventoryManagementSystem;
using SimpleInventoryManagementSystem.Domain;

var inventory = new Inventory();
var exitProgram = false;
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
            Utilities.AddProduct(inventory);
            break;
        case "2":
            Utilities.ViewAllProducts(inventory);
            break;
        case "3":
            Utilities.EditProduct(inventory);
            break;
        case "4":
            Utilities.DeleteProduct(inventory);
            break;
        case "5":
            Utilities.SearchProduct(inventory);
            break;
        case "6":
            exitProgram = true;
            Console.WriteLine("Good bye!");
            break;
        default:
            Console.WriteLine("Wrong selection! Please enter a valid selection");
            break;
    }
    Console.WriteLine();
}
