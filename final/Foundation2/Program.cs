using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create some products
        Product product1 = new Product("T-Shirt", "ABC123", 19.99, 2);
        Product product2 = new Product("Mug", "DEF456", 9.99, 1);
        Product product3 = new Product("Headphones", "GHI789", 49.99, 1);
        Product product4 = new Product("Laptop", "JKL012", 799.99, 1);

        // Create some addresses
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Maple Ave", "Big City", "ON", "Canada");

        // Create some customers
        Customer customer1 = new Customer("David Jerry", address1);
        Customer customer2 = new Customer("John Smith", address2);

        // Create some orders
        List<Product> order1Products = new List<Product>() { product1, product2, product3, product4 };
        Order order1 = new Order(order1Products);
        
    }
}    