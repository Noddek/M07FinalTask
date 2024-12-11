using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace M07FinalTask.N11Contacts;

/// <summary>
/// The helper class for specifying the postal address
/// </summary>
public class Address
{
    // FIELDS & PROPERTIES

    public string? Country { get; private set; }
    public string? PostalCode { get; private set; }
    public string? Region { get; private set; }
    public string? SubRegion { get; private set; }
    public string? City { get; private set; }
    public string? Street { get; private set; }
    public string? BuildingNumber { get; private set; }
    public string? Apartment { get; private set; }
    public string? NameOfAddressee { get; private set; }


    // CONSTRUCTORS

    // Only some constructors are implemented

    public Address() { }

    public Address(string city, string street, string buildingNumber)
    {
        City = city;
        Street = street;
        BuildingNumber = buildingNumber;
    }

    public Address(string city, string street, string buildingNumber, string apartment) : this(city, street, buildingNumber)
    {
        Apartment = apartment;
    }


    // METHODS

    // 1. Helper methods

    // 2. Target methods
    public string? AddressToString()
    {
        string?[] arrayOfProperties = { Country, PostalCode, Region, SubRegion, City, Street, BuildingNumber, Apartment, NameOfAddressee };
        string? addressString = "";
        for (uint i = 0; i <= arrayOfProperties.GetUpperBound(0); ++i)
        {
            if (!string.IsNullOrWhiteSpace(arrayOfProperties[i]))
            {
                addressString = addressString + arrayOfProperties[i] + ", ";
            }
        }
        if (string.IsNullOrWhiteSpace(addressString))
        {
            return "The address is not specified";
        }
        else
        {
            return addressString.Remove(addressString.Length - 2, 2);
        }
    }
}