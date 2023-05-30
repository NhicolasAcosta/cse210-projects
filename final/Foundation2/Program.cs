using System;

class Program
{
    static void Main()
    {
        // Make Customer
        Address address = new Address
        {
            Street = "Catamarca 402",
            City = "San Miguel",
            State = "Tucuman",
            Country = "Argentina"
        };
        Customer customer = new Customer
        {
            Name = "Pablo Rios",
            Address = address
        };

        // Make first ordering
        Order order1 = new Order(customer);
        order1.AddProduct(new Product { Name = "Product 1", Id = 1, Price = 10.99m, Quantity = 2 });
        order1.AddProduct(new Product { Name = "Product 2", Id = 2, Price = 5.99m, Quantity = 3 });

        // Make second ordering
        Order order2 = new Order(customer);
        order2.AddProduct(new Product { Name = "Product 3", Id = 3, Price = 8.49m, Quantity = 1 });
        order2.AddProduct(new Product { Name = "Product 4", Id = 4, Price = 12.99m, Quantity = 2 });
        order2.AddProduct(new Product { Name = "Product 5", Id = 5, Price = 6.99m, Quantity = 4 });

        // Show the ordering results
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackagingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackagingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.CalculateTotalCost());
    }
}
