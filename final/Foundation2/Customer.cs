public class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool IsUSA()
    {
        return _address.IsUSA();
    }
    public void Display()
    {
        Console.WriteLine($"\n{_name}\n{_address.GetAddress()}");
    }
}