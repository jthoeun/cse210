using System;
using System.Collections.Generic;

class Order
{
    private List<Product> products;
    private Customer customer;
    private decimal shippingCost;

    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
        this.shippingCost = customer.LivesInUSA() ? 5.00m : 20.00m;
    }

    public decimal CalculateTotalPrice()
    {
        decimal total = 0;
        foreach (var product in products)
        {
            total += product.GetTotalCost();
        }
        return total + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing List:\n";
        foreach (var product in products)
        {
            label += $"- {product.GetTotalCost():0.00} - {product.Name} (x{product.Quantity})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Ship To: {customer.Name}\n{customer.Address.GetFullAddress()}";
    }
}
