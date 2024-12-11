using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using M07FinalTask.N01RawData.Enumerations;
using M07FinalTask.N05Orders;
using M07FinalTask.N11Contacts;

namespace M07FinalTask.N03Customers;

/// <summary>
/// The Individual Customer class derived from the abstract Customer class
/// </summary>
public class IndividualCustomer : Customer
{
    // FIELDS & PROPERTIES

    private static uint IndividualCustomerIdCounter = 800000;
    public override uint CustomerId { get; protected set; }
    public override uint CartId { get; protected set; }

    // Task 4.2. An example of using properties override.
    // Task 14. Using properties with logic in get and/or set blocks.

    private string login;
    public override string Login
    {
        get { return login; }
        set // Why it doesn't work with 'private', only with 'protected'?
        {
            if (login == null)
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length <= 3)
                {
                    Console.WriteLine("\n\tTo make orders in the store, the customer should register: create a login (4 or more characters) and a password (8 or more characters).");
                }
                else
                {
                    login = value;
                }
            }
            else
            {
                Console.WriteLine("\n\tYou cannot rename a created login.\n");
            }
        }
    }

    private string password;
    public override string Password
    {
        get { return password; }
        set // Why it doesn't work with 'private', only with 'protected'?
        {
            if (password == null)
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length <= 7)
                {
                    Console.WriteLine("\n\tTo make orders in the store, the customer should register: create a login (4 or more characters) and a password (8 or more characters).");
                }
                else
                {
                    password = value;
                }
            }
            else
            {
                Console.WriteLine("\n\tA password change procedure is required.\n");
            }
        }
    }

    public override Cart Cart { get; protected set; }
    public override Order[] Orders { get; protected set; }
    public string Name { get; private set; } = "Unknown";
    public PhoneNumber PersonalPhoneNumber { get; private set; }
    public EMail PersonalEMail { get; private set; }


    // CONSTRUCTORS

    public IndividualCustomer
        (
            string login,
            string password,
            CommonEnums.CustomerStatus status,
            string name,
            PhoneNumber personalPhoneNumber,
            EMail personalEMail
        ) : base(login, password, status)
    {
        CustomerId = CartId = ++IndividualCustomerIdCounter;
        // Task 9. An example of using COMPOSITION:
        Cart = new Cart(CustomerId, CartId);
        Orders = new Order[1000];
        Name = name;
        PersonalPhoneNumber = personalPhoneNumber;
        PersonalEMail = personalEMail;
    }


    // METHODS

    public override void DisplayFullInfo()
    {
        Console.WriteLine($"\tCustomer Id: {CustomerId}");
        Console.WriteLine($"\tCart Id: {CartId}");
        Console.WriteLine($"\tCustomer name: {Name}");
        Console.WriteLine($"\tLogin: {Login}");
        Console.WriteLine($"\tPassword: {Password}");
        Console.WriteLine($"\tCustomer status: {Status}");
        Console.WriteLine($"\tPersonal phone number: {PersonalPhoneNumber.PhoneNumberToString()}");
        Console.WriteLine($"\tPersonal e-mail: {PersonalEMail.EMailToString()}");
    }
}