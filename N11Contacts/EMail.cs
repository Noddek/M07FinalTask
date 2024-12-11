using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace M07FinalTask.N11Contacts;

/// <summary>
/// The helper class for specifying the e-mail
/// </summary>
public class EMail
{
    // FIELDS & PROPERTIES:

    public string LocalPart { get; private set; }
    public string? Domain { get; private set; }
    public IPAddress? IPAddress { get; private set; }


    // CONSTRUCTORS

    public EMail(string localPart, string domain)
    {
        LocalPart = localPart;
        Domain = domain;
        IPAddress = null;
    }

    public EMail(string localPart, IPAddress IPAddress)
    {
        LocalPart = localPart;
        Domain = null;
        this.IPAddress = IPAddress;
    }

    public EMail(string localPart, string domain, IPAddress IPAddress)
    {
        LocalPart = localPart;
        Domain = domain;
        this.IPAddress = IPAddress;
    }


    // METHODS

    public void Display()
    {
        if (Domain != null && IPAddress == null) { Console.Write($" {LocalPart}@{Domain}"); }
        else if (Domain == null && IPAddress != null) { Console.Write($" {LocalPart}@{IPAddress.ToString()}"); }
        else if (Domain != null && IPAddress != null) { Console.Write($" {LocalPart}@{Domain}, {LocalPart}@{IPAddress.ToString()}"); }
    }

    public string EMailToString()
    {
        if (Domain != null && IPAddress == null) { return $" {LocalPart}@{Domain}"; }
        else if (Domain == null && IPAddress != null) { return $" {LocalPart}@{IPAddress.ToString()}"; }
        else if (Domain != null && IPAddress != null) { return $" {LocalPart}@{Domain}, {LocalPart}@{IPAddress.ToString()}"; }
        else { return "Not specified"; }
    }
}