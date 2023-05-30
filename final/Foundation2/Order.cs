using System.Collections.Generic;

class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in products)
        {
            totalCost += product.Price * product.Quantity;
        }
        totalCost += customer.GetShippingCost();
        return totalCost;
    }

    public string GetPackagingLabel()
    {
        string label = "Packaging Label:\n";
        foreach (Product product in products)
        {
            label += "Product: " + product.Name + " (ID: " + product.Id + ")\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "Shipping Label:\n";
        label += "Customer: " + customer.Name + "\n";
        label += customer.Address.GetAddress();
        return label;
    }
}

