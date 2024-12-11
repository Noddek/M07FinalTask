using M07FinalTask.N01RawData.Enumerations;
using M07FinalTask.N05Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace M07FinalTask.N03Customers;

/// <summary>
/// The abstract customer class from which all customer classes are inherited
/// </summary>
public abstract class Customer
{
    // FIELDS & PROPERTIES

    public abstract uint CustomerId { get; protected set; }
    public abstract uint CartId { get; protected set; }

    // Task 4.2. Using properties override.
    public virtual string Login { get; set; } // ' protected set; ' is better
    public virtual string Password { get; set; } // ' protected set; ' is better

    public abstract Cart Cart { get; protected set; }
    public abstract Order[] Orders { get; protected set; }
    public CommonEnums.CustomerStatus Status { get; private set; }

    // CONSTRUCTORS

    public Customer(string login, string password, CommonEnums.CustomerStatus status)
    {
        Login = login;
        Password = password;
        Status = status;
    }

    // METHODS

    public abstract void DisplayFullInfo();
}