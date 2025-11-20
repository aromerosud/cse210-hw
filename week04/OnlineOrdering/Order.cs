public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string CalculateTotalCost()
    {
        double subTotal = 0;
        double total = 0;
        foreach (Product item in _products)
        {
            subTotal += item.GetProductCost();
        }

        if (_customer.LiveInUSA()){

            total = subTotal + 5;
        }
        else
        {
            total = subTotal + 35;
        }

        return $"Total: $ {Math.Round(total, 2)}\n";
    }

    public string GetShippingLabel()
    {
        string label = "Shipping Label:\n";
        return $"{label}{_customer.GetCustomerData()}";
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";

        foreach (Product item in _products)
        {
            label += $"-{item.GetName()} (ID: {item.GetId()})\n";
        }
        return label;
    }
}