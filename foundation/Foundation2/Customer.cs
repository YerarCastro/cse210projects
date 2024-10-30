public class Customer
{
    private string _name;
    private Address _address;

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Getters
    public string GetName() => _name;

    // Verifica si el cliente vive en EE.UU.
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    // Retorna la dirección del cliente
    public string GetAddress()
    {
        return _address.GetFullAddress();
    }
}
