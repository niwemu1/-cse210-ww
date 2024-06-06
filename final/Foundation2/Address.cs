using System;

public class Address
{
    private string streetAddress;
    private string city;
    private string stateProvince;
    private string country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.stateProvince = stateProvince;
        this.country = country;
    }

    public string StreetAddress { get { return streetAddress; } }
    public string City { get { return city; } }
    public string StateProvince { get { return stateProvince; } }
    public string Country { get { return country; } }

    public bool IsInUSA()
    {
        return country.ToUpper() == "USA";
    }

    public string GetFullAddress()
    {
        return $"{streetAddress}\n{city}, {stateProvince} {country}";
    }
}


