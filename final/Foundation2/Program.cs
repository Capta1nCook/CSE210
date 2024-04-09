using System;
class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("T-Shirt", "001", 5, 2);
        Product product2 = new Product("Flower Pot", "002", 7, 1);
        Product product3 = new Product("Remote", "003", 50, 1);
        Product product4 = new Product("Vacume", "004", 300, 1);
        Product product5 = new Product("Book", "005", 15, 3);
        Product product6 = new Product("Pizza", "006", 7, 4);

        Address address1 = new Address("3883 E 97th N", "Idaho Falls", "ID", "USA");
        Address address2 = new Address("380 Crystal St.", "Broken Hill", "NSW", "Australia");

        Customer customer1 = new Customer("Jase Dryden", address1);
        Customer customer2 = new Customer("Tyler Allred", address2);

        List<Order> orders = new List<Order>();

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product3);
        order1.AddProduct(product6);
        orders.Add(order1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product6);
        order2.AddProduct(product5);
        order2.AddProduct(product2);
        order2.AddProduct(product4);
        orders.Add(order2);

        foreach (Order order in orders)
        {
            order.PackingLabel();
            order.CalculateTotal();
            order.ShippingLabel();
        }
    }
}