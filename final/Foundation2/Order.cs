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
    public void CalculateTotal()
    {
        double total = 0;
        if (_customer.IsUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        foreach (Product product in _products)
        {
            total += product.CalculateCost();
        }
        Console.WriteLine($"Total: ${total}.00");
    }
    public void PackingLabel()
    {
        Console.WriteLine("Packing Label");
        foreach (Product product in _products)
        {
            Console.WriteLine(product.GetProductInfo());
        }
    }
    public void ShippingLabel()
    {
        _customer.Display();
    }

}