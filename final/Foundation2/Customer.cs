class Customer
{
    private string name;
    private Address address;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Address Address
    {
        get { return address; }
        set { address = value; }
    }

    public bool IsInUS()
    {
        return Address.IsInUS();
    }

    public decimal GetShippingCost()
    {
        if (IsInUS())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
}
