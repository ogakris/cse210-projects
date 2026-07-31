using System;

namespace EncapsulationOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- Order 1: USA Customer -
            Address address1 = new Address("123 Fedar St", "Stratburg", "ID", "USA");
            Customer customer1 = new Customer("Sam Smith", address1);
            Order order1 = new Order(customer1);

            order1.AddProduct(new Product("Wireless Mouse", "Q101", 25.50m, 2));
            order1.AddProduct(new Product("Mechanical Keyboard", "Q102", 75.00m, 1));
            order1.AddProduct(new Product("Desktop Matt", "Q103", 15.00m, 1));

            // --- Order 2: International Customer -
            Address address2 = new Address("46 High Street", "London", "Greater London", "UK");
            Customer customer2 = new Customer("Jane Wes", address2);
            Order order2 = new Order(customer2);

            order2.AddProduct(new Product("HD Monitor", "Q201", 199.99m, 1));
            order2.AddProduct(new Product("HDMI Cable", "Q202", 10.00m, 2));

            // --- Display Order 1 ---
            Console.WriteLine("==================================================");
            Console.WriteLine("ORDER 1 DETAILS");
            Console.WriteLine("==================================================");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}\n");

            // --- Display Order 2 ---
            Console.WriteLine("==================================================");
            Console.WriteLine("ORDER 2 DETAILS");
            Console.WriteLine("==================================================");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}\n");
        }
    }
}
