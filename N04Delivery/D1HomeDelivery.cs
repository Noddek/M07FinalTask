using M07FinalTask.N11Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace M07FinalTask.N04Delivery;

/// <summary>
/// The class for working with personalized delivery that implements the interface IDelivery
/// </summary>
public class HomeDelivery : IDelivery
{
    // FIELDS & PROPERTIES
    public string Type { get { return "Home delivery"; } }
    public DateTime? SendingDate { get; set; }
    public DateTime? FinishDate { get; set; }
    public string RecipientName { get; private set; }
    public Address Address { get; private set; }


    // CONSTRUCTOR
    public HomeDelivery(string name, Address address)
    {
        RecipientName = name;
        Address = address;
    }

    // METHODS

    // 1. Static
    public static HomeDelivery CreateHomeDelivery()
    {
        Console.WriteLine("\n\tPlease enter the recipient's name and address below.");
        string? recipientName = null, city = null, street = null, buildingNumber = null, apartment = null;
        do
        {
            Console.Write("\t\tRecipient's name: ");
            recipientName = Console.ReadLine();
        }
        while (string.IsNullOrWhiteSpace(recipientName));
        do
        {
            Console.Write("\t\tCity: ");
            city = Console.ReadLine();
        }
        while (string.IsNullOrWhiteSpace(city));
        do
        {
            Console.Write("\t\tStreet: ");
            street = Console.ReadLine();
        }
        while (string.IsNullOrWhiteSpace(street));
        do
        {
            Console.Write("\t\tBuilding number: ");
            buildingNumber = Console.ReadLine();
        }
        while (string.IsNullOrWhiteSpace(buildingNumber));
        do
        {
            Console.Write("\t\tApartment: ");
            apartment = Console.ReadLine();
        }
        while (string.IsNullOrWhiteSpace(apartment));

        return new HomeDelivery
            (
            recipientName,
            new Address(city, street, buildingNumber, apartment)
            );
    }

    // 2. Non-static
    public string InfoToString()
    {
        return $"{Address.AddressToString()} | Recipient: {RecipientName}.";
    }
}