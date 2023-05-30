class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public string State
    {
        get { return state; }
        set { state = value; }
    }

    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    public bool IsInUS()
    {
        return Country == "USA";
    }

    public string GetAddress()
    {
        return "Address: " + Street + ", " + City + ", " + State + ", " + Country + "\n";
    }
}
