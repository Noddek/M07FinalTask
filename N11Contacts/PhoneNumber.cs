using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace M07FinalTask.N11Contacts;

/// <summary>
/// The helper class for specifying the phone number
/// </summary>
public class PhoneNumber
{
    // FIELDS & PROPERTIES
    public ushort CountryCode { get; private set; }
    public byte TrunkPrefix { get; private set; }
    public ushort AreaCode { get; private set; }
    public uint SubscriberNumber { get; private set; }

    // CONSTRUCTOR
    public PhoneNumber
        (
            ushort countryCode,
            byte trunkPrefix,
            ushort areaCode,
            uint subscriberNumber
        )
    {
        CountryCode = countryCode;
        TrunkPrefix = trunkPrefix;
        AreaCode = areaCode;
        SubscriberNumber = subscriberNumber;
    }

    // METHODS
    // 1. Helper methods
    private string SubscriberNumberToString()
    {
        string originalString = Convert.ToString(SubscriberNumber);
        if (originalString.Length == 7)
        {
            return $"{originalString.Substring(0, 3)}-{originalString.Substring(3, 2)}-{originalString.Substring(5, 2)}";
        }
        else
        {
            return originalString;
        }
    }

    // 2. Target methods
    public void Display()
    {
        if (CountryCode != 0 && AreaCode != 0 && SubscriberNumber != 0)
        {
            Console.Write($" +{CountryCode} ({AreaCode}) {SubscriberNumberToString()}");
        }
        else
        {
            Console.Write("Not specified");
        }

    }
    public string PhoneNumberToString()
    {
        if (CountryCode != 0 && AreaCode != 0 && SubscriberNumber != 0)
        {
            return $" +{CountryCode} ({AreaCode}) {SubscriberNumberToString()}";
        }
        else
        {
            return "Not specified";
        }
    }
}