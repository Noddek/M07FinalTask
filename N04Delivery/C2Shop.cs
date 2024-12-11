using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M07FinalTask.N11Contacts;

namespace M07FinalTask.N04Delivery;

/// <summary>
/// The class describes physical shops of the store
/// </summary>
public class Shop
{
    // FIELDS & PROPERTIES

    public string Name { get; private set; }
    public Address Address { get; private set; }
    public string OperatingSchedule { get; private set; }

    // CONSTRUCTOR

    public Shop(string name, Address address, string operatingSchedule)
    {
        Name = name; Address = address; OperatingSchedule = operatingSchedule;
    }

    // METHODS

    public string ShopInfoToString()
    {
        return $"\"{Name}\" | {Address.AddressToString()} | {OperatingSchedule}";
    }
}
