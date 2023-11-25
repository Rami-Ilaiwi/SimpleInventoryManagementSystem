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

        public override string? ToString()
        {
            return $"Product name: {this.Name} -- Product price: {this.Price} -- Product quantity: {this.Quantity}";
        }
    }
}
