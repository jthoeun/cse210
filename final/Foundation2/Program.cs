using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Address address = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer = new Customer("John Doe", address);

        List<Product> products = new List<Product>
        {
            new Product("Laptop", "P001", 999.99m, 1),
            new Product("Mouse", "P002", 19.99m, 2),
            new Product("Keyboard", "P003", 49.99m, 1)
        };

        Order order = new Order(products, customer);

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order.CalculateTotalPrice():0.00}");
    }
}
