using System;

class Program
{
    static void Main(string[] args)
    {
        // ==========================================
        // ORDER 1: Domestic (USA) - $5 Shipping
        // ==========================================
        Address address1 = new Address("123 Tech Boulevard", "San Francisco", "CA", "USA");
        Customer customer1 = new Customer("Tech Solutions Inc.", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Wireless Keyboard", "KB-101", 45.99, 2));
        order1.AddProduct(new Product("USB-C Hub", "HUB-202", 25.50, 1));

        // ==========================================
        // ORDER 2: International - $35 Shipping
        // ==========================================
        Address address2 = new Address("No 4 Christ Avenue", "Port Harcourt", "Rivers State", "Nigeria");
        Customer customer2 = new Customer("Ubong Ken", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Django Development Server Deployment Guide", "B01-WEB", 15.00, 1));
        order2.AddProduct(new Product("Sony VAIO Pro PG Battery Replacement", "BAT-774", 89.99, 1));
        order2.AddProduct(new Product("Pioneer Global Logistics API Key Access", "API-SUB", 120.00, 1));

        // ==========================================
        // DISPLAY RESULTS
        // ==========================================
        Console.Clear();
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("ORDER 1 DETAILS");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order1.CalculateTotal():0.00}");
        
        Console.WriteLine("\n\n-----------------------------------");
        Console.WriteLine("ORDER 2 DETAILS");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.CalculateTotal():0.00}");
        Console.WriteLine("-----------------------------------");
    }
}