using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace M07FinalTask.N06Payment;

/// <summary>
/// DRAFT abstract class of incoming payments. 
/// Not implemented.
/// </summary>
public abstract class Payment
{
    // FIELDS & PROPERTIES

    public abstract uint PaymentId { get; protected set; }
    public DateTime? PaymentDate { get; protected set; }
    public decimal TotalPayable { get; protected set; }
    public ulong CashRegisterMachineNumber { get; protected set; }
    public uint CashRegisterReceiptNumber { get; protected set; }
    public uint OrderNumber { get; protected set; }
    public int PurchaseReceiptNumber { get; protected set; } = -1; // Товарный чек, т. е. по умолчанию не используется
    public string? TransactionDetails { get; protected set; }
        

    // CONSTRUCTORS

    // 1. Main constructor
    public Payment(DateTime? paymentDate, decimal totalPayable, ulong cashRegisterMachineNumber, uint cashRegisterReceiptNumber, uint orderNumber)
    {
        PaymentDate = paymentDate;
        TotalPayable = totalPayable;
        CashRegisterMachineNumber = cashRegisterMachineNumber;
        CashRegisterReceiptNumber = cashRegisterReceiptNumber;
        OrderNumber = orderNumber;
    }

    // 2. PurchaseReceiptNumber property is specified in addition to the main constructor parameters:
    public Payment (DateTime? paymentDate, decimal totalPayable, ulong cashRegisterMachineNumber, uint cashRegisterReceiptNumber, uint orderNumber, int purchaseReceiptNumber)
        : this (paymentDate, totalPayable, cashRegisterMachineNumber, cashRegisterReceiptNumber, orderNumber)
    {
        PurchaseReceiptNumber = purchaseReceiptNumber;
    }

    // 3. TransactionDetails property is specified in addition to the main constructor parameters:
    public Payment(DateTime? paymentDate, decimal totalPayable, ulong cashRegisterMachineNumber, uint cashRegisterReceiptNumber, uint orderNumber, string? transactionDetails)
        : this(paymentDate, totalPayable, cashRegisterMachineNumber, cashRegisterReceiptNumber, orderNumber)
    {
        TransactionDetails = transactionDetails;
    }

    // 4. PurchaseReceiptNumber & TransactionDetails properties are specified in addition to the main constructor parameters:
    public Payment(DateTime? paymentDate, decimal totalPayable, ulong cashRegisterMachineNumber, uint cashRegisterReceiptNumber, uint orderNumber, int purchaseReceiptNumber, string? transactionDetails)
        : this(paymentDate, totalPayable, cashRegisterMachineNumber, cashRegisterReceiptNumber, orderNumber)
    {
        PurchaseReceiptNumber = purchaseReceiptNumber;
        TransactionDetails = transactionDetails;
    }
}