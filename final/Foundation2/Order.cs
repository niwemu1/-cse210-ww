using System;

public class Order
{
    private List<Product> products;
    private Customer customer;
    private double shippingCost;

    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
        shippingCost = customer.LivesInUSA() ? 5 : 35;
    }

    public List<Product> Products { get { return products; } }
    public Customer Customer { get { return customer; } }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product product in products)
        {
            total += product.GetTotalCost();
        }
        return total + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in products)
        {
            label += $"Name: {product.Name}, ID: {product.ProductId}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return customer.Address.GetFullAddress();
    }
}