using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M07FinalTask.N11Contacts;

namespace M07FinalTask.N04Delivery;

/// <summary>
/// The class describes the pick-up points of the store
/// </summary>
public class PickUpPoint
{
    // FIELDS & PROPERTIES
    private string Name { get { return "Pick-up point"; } }
    public Address Address { get; private set; }

    // CONSTRUCTOR
    public PickUpPoint(Address address)
    {
        Address = address;
    }

    // METHODS
    public string PickUpPointInfoToString()
    {
        return $"{Name}: {Address.AddressToString()}";
    }
    public string PickUpPointAddressToString()
    {
        return $"{Address.AddressToString()}";
    }
}
