using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace M07FinalTask.N06Payment;

/// <summary>
/// DRAFT class of incoming bank card payments.
/// Not implemented.
/// </summary>
public class BankCardPayment : Payment
{
    // FIELDS & PROPERTIES

    private static uint BankCardPaymentCounter = 2000000;
    public override uint PaymentId { get; protected set; }
    public string? BankCardInfo { get; protected set; }


    // CONSTRUCTORS --- Beginning of the section

    // 1. For main base constructor:
    public BankCardPayment
        (
            DateTime? paymentDate,
            decimal totalPayable,
            ulong cashRegisterMachineNumber,
            uint cashRegisterReceiptNumber,
            uint orderNumber,
            string? bankCardInfo
        )
        : base(paymentDate, totalPayable, cashRegisterMachineNumber, cashRegisterReceiptNumber, orderNumber)
    {
        PaymentId = ++BankCardPaymentCounter;
        BankCardInfo = bankCardInfo;
    }
    // 2. PurchaseReceiptNumber property is specified in addition to the 1st constructor parameters:
    public BankCardPayment
        (
            DateTime? paymentDate,
            decimal totalPayable,
            ulong cashRegisterMachineNumber,
            uint cashRegisterReceiptNumber,
            uint orderNumber,
            int purchaseReceiptNumber,
            string? bankCardInfo
        )
        : base(paymentDate, totalPayable, cashRegisterMachineNumber, cashRegisterReceiptNumber, orderNumber, purchaseReceiptNumber)
    {
        PaymentId = ++BankCardPaymentCounter;
        BankCardInfo = bankCardInfo;
    }
    // 3. TransactionDetails property is specified in addition to the 1st constructor parameters:
    public BankCardPayment
        (
            DateTime? paymentDate,
            decimal totalPayable,
            ulong cashRegisterMachineNumber,
            uint cashRegisterReceiptNumber,
            uint orderNumber,
            string? transactionDetails,
            string? bankCardInfo
        ) : base(paymentDate, totalPayable, cashRegisterMachineNumber, cashRegisterReceiptNumber, orderNumber, transactionDetails)
    {
        PaymentId = ++BankCardPaymentCounter;
        BankCardInfo = bankCardInfo;
    }
    // 4. PurchaseReceiptNumber & TransactionDetails properties are specified in addition to the 1st constructor parameters:
    public BankCardPayment
        (
            DateTime? paymentDate,
            decimal totalPayable,
            ulong cashRegisterMachineNumber,
            uint cashRegisterReceiptNumber,
            uint orderNumber,
            int purchaseReceiptNumber,
            string? transactionDetails,
            string? bankCardInfo
        ) : base(paymentDate, totalPayable, cashRegisterMachineNumber, cashRegisterReceiptNumber, orderNumber, purchaseReceiptNumber, transactionDetails)
    {
        PaymentId = ++BankCardPaymentCounter;
        BankCardInfo = bankCardInfo;
    }

    // CONSTRUCTORS --- End of the section
}