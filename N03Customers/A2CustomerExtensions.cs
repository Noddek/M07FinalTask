using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using M07FinalTask.N01RawData.Enumerations;

namespace M07FinalTask.N03Customers;

// Task 15. Using extension methods.
/// <summary>
/// The static class for extension methods for the class IndividualCustomer
/// </summary>
public static class CustomerExtensions
{
    /// <summary>
    /// The method checks if there are any unpaid orders with an online payment method 
    /// </summary>
    public static bool AreUnpaidOrdersWithOnlinePaymentMethod(this Customer customer)
    {
        //Console.ForegroundColor = ConsoleColor.Magenta;
        //Console.WriteLine("\t[The extension method is called.]");
        //Console.ResetColor();
        for (uint i = 0; i <= customer.Orders.GetUpperBound(0); ++i)
        {
            if (customer.Orders[i]?.IsPaid == false && customer.Orders[i]?.PaymentMethod == CommonEnums.PaymentMethod.BankCard)
            {
                return true;
            }
        }
        return false;
    }
}
