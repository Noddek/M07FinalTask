using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace M07FinalTask.N06Payment;

/// <summary>
/// DRAFT class of incoming cash payments.
/// Not implemented.
/// </summary>
public class CashPayment : Payment
{
    // FIELDS & PROPERTIES

    private static uint CashPaymentCounter = 1000000;
    public override uint PaymentId { get ; protected set; }


    // CONSTRUCTORS --- Beginning of the section

    // 1. For main base constructor:
    /// <summary>
    /// Main constructor
    /// </summary>
    /// <param name="paymentDate">Payment date</param>
    /// <param name="totalPayable">Total amount payable for the order</param>
    /// <param name="cashRegisterMachineNumber">Cash register machine number - 16 digits</param>
    /// <param name="cashRegisterReceiptNumber">Cash register receipt number</param>
    /// <param name="orderNumber">Paid order number</param>
    public CashPayment 
        (
            DateTime? paymentDate, 
            decimal totalPayable, 
            ulong cashRegisterMachineNumber, 
            uint cashRegisterReceiptNumber, 
            uint orderNumber
        )
        : base (paymentDate, totalPayable, cashRegisterMachineNumber, cashRegisterReceiptNumber, orderNumber)
    {
        PaymentId = ++CashPaymentCounter;
    }

    // 2. PurchaseReceiptNumber property is specified in addition to the 1st constructor parameters:
    /// <summary>
    /// The constructor additionally accepts a value for property PurchaseReceiptNumber
    /// </summary>
    /// <param name="paymentDate">Payment date</param>
    /// <param name="totalPayable">Total amount payable for the order</param>
    /// <param name="cashRegisterMachineNumber">Cash register machine number - 16 digits</param>
    /// <param name="cashRegisterReceiptNumber">Cash register receipt number</param>
    /// <param name="orderNumber">Paid order number</param>
    /// <param name="purchaseReceiptNumber">Purchase receipt number</param>
    public CashPayment
        (
            DateTime? paymentDate,
            decimal totalPayable,
            ulong cashRegisterMachineNumber,
            uint cashRegisterReceiptNumber,
            uint orderNumber,
            int purchaseReceiptNumber
        )
        : base(paymentDate, totalPayable, cashRegisterMachineNumber, cashRegisterReceiptNumber, orderNumber, purchaseReceiptNumber)
    {
        PaymentId = ++CashPaymentCounter;
    }

    // 3. TransactionDetails property is specified in addition to the 1st constructor parameters:
    /// <summary>
    /// The constructor additionally accepts a value for property TransactionDetails
    /// </summary>
    /// <param name="paymentDate">Payment date</param>
    /// <param name="totalPayable">Total amount payable for the order</param>
    /// <param name="cashRegisterMachineNumber">Cash register machine number - 16 digits</param>
    /// <param name="cashRegisterReceiptNumber">Cash register receipt number</param>
    /// <param name="orderNumber">Paid order number</param>
    /// <param name="transactionDetails">Any transaction details</param>
    public CashPayment
        (
            DateTime? paymentDate,
            decimal totalPayable,
            ulong cashRegisterMachineNumber,
            uint cashRegisterReceiptNumber,
            uint orderNumber,
            string? transactionDetails
        ) : base(paymentDate, totalPayable, cashRegisterMachineNumber, cashRegisterReceiptNumber, orderNumber, transactionDetails)
    {
        PaymentId = ++CashPaymentCounter;
    }

    // 4. PurchaseReceiptNumber & TransactionDetails properties are specified in addition to the 1st constructor parameters:
    /// <summary>
    /// The constructor additionally accepts a value for properties PurchaseReceiptNumber and TransactionDetails
    /// </summary>
    /// <param name="paymentDate">Payment date</param>
    /// <param name="totalPayable">Total amount payable for the order</param>
    /// <param name="cashRegisterMachineNumber">Cash register machine number - 16 digits</param>
    /// <param name="cashRegisterReceiptNumber">Cash register receipt number</param>
    /// <param name="orderNumber">Paid order number</param>
    /// <param name="purchaseReceiptNumber">Purchase receipt number</param>
    /// <param name="transactionDetails">Any transaction details</param>
    public CashPayment
        (
            DateTime? paymentDate,
            decimal totalPayable,
            ulong cashRegisterMachineNumber,
            uint cashRegisterReceiptNumber,
            uint orderNumber,
            int purchaseReceiptNumber,
            string? transactionDetails
        ) : base(paymentDate, totalPayable, cashRegisterMachineNumber, cashRegisterReceiptNumber, orderNumber, purchaseReceiptNumber, transactionDetails)
    {
        PaymentId = ++CashPaymentCounter;
    }

    // CONSTRUCTORS --- End of the section



}