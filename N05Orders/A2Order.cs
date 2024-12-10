using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using M07FinalTask.N01RawData.Enumerations;
using M07FinalTask.N02Products;
using M07FinalTask.N04Delivery;
using M07FinalTask.N20ProgramCode;


namespace M07FinalTask.N05Orders;

// Is it worth using Order inheritance from Cart ?
// Maybe I should make a common interface for Cart and Order?

/// <summary>
/// The class for creating customer orders
/// </summary>
public class Order
{
    // FIELDS & PROPERTIES
    private static uint OrderNumberCounter = 20240000;
    public uint OrderNumber { get; private set; }
    public uint CustomerId { get; private set; }
    public bool IsAccepted { get; private set; }
    public uint ManagerId { get; private set; }
    public DateTime CreationDate { get; private set; } = new DateTime(1900, 1, 1);
    public DateTime FinishDate { get; private set; } = new DateTime(1900, 1, 1);
    public CommonEnums.OrderStatus OrderStatus { get; private set; }
    public IDelivery Delivery { get; private set; }
    public string? Comment { get; private set; }
    public CommonEnums.PromoCode PromoCode { get; private set; }
    public ProductInOrder[] ProductsInOrder { get; private set; }
    public decimal TotalCostOfProducts { get; private set; }
    public decimal TotalDiscountsOfProducts { get; private set; }
    public decimal TotalCostOfProductsMinusTotalDiscountsOfProducts { get; private set; }
    public decimal TotalDiscountByPromoCode { get; private set; }
    public decimal TotalAmountPayable { get; private set; }
    public CommonEnums.PaymentMethod PaymentMethod { get; private set; }
    public bool IsPaid { get; set; }
    public uint PaymentId { get; set; }

    // CONSTRUCTORS
    public Order(uint customerId, IDelivery delivery, CommonEnums.PromoCode promoCode, string? comment, CommonEnums.PaymentMethod paymentMethod, ProductInOrder[] productsInOrder)
    {
        OrderNumber = ++OrderNumberCounter;
        CustomerId = customerId;
        CreationDate = DateTime.Now;
        OrderStatus = CommonEnums.OrderStatus.Pending;
        Delivery = delivery;
        PromoCode = promoCode;
        Comment = comment;
        PaymentMethod = paymentMethod;
        ProductsInOrder = productsInOrder;
        CalculateTotalAmountPayable();
    }

    // METHODS

    // 1. Static

    // 2. Non-static
    // 2.1. Helper methods.
    private string IsAcceptedToString()
    {
        switch (IsAccepted)
        {
            case true: return "Accepted";
            default: return "Not accepted";
        }
    }
    private string ManagerIdToString()
    {
        switch (ManagerId)
        {
            case 0: return "The order isn't processed by the manager.";
            default: return $"{ManagerId}";
        }
    }
    private string CreationDateToString()
    {
        switch (CreationDate.Year)
        {
            case 1900: return "No date specified";
            default: return CreationDate.ToString();
        }

    }
    private string FinishDateToString()
    {
        switch (FinishDate.Year)
        {
            case 1900: return "No date specified";
            default: return FinishDate.ToString();
        }
    }
    private string IsPaidToString()
    {
        switch (IsPaid)
        {
            case true: return "The order is paid";
            default: return "The order is unpaid";
        }
    }
    private string PaymentIdToString()
    {
        switch (PaymentId)
        {
            case 0: return "No payment Id";
            default: return $"{PaymentId}";
        }
    }

    // 2.2. Target methods
    public void DisplayFullInfo()
    {
        Console.WriteLine($"\n/--------- Order number: {OrderNumber} ---------/\n");
        Console.WriteLine($"Customer Id: {CustomerId}");
        Console.WriteLine($"Accepted or not: {IsAcceptedToString()}");
        Console.WriteLine($"Manager Id: {ManagerIdToString()}");
        Console.WriteLine($"Creation date: {CreationDateToString()}");
        Console.WriteLine($"Finish date: {FinishDateToString()}");
        Console.WriteLine($"Order status: {CommonEnums.OrderStatusToString(OrderStatus)}");
        Console.WriteLine($"Delivery type: {Delivery.Type}");
        Console.WriteLine($"Delivery info: {Delivery.InfoToString()}");
        Console.WriteLine($"Comment: {Comment}");
        Console.WriteLine($"Promo code: {CommonEnums.PromoCodeToString(PromoCode)}");
        Console.WriteLine($"Total cost of products: {TotalCostOfProducts} RUB");
        Console.WriteLine($"Total discounts of products: {TotalDiscountsOfProducts} RUB");
        Console.WriteLine($"Total cost of products minus discounts: {TotalCostOfProductsMinusTotalDiscountsOfProducts} RUB");
        Console.WriteLine($"Total discount by promo code: {TotalDiscountByPromoCode} RUB");
        Console.WriteLine($"Total amount payable: {TotalAmountPayable} RUB");
        Console.WriteLine($"Payment method: {CommonEnums.PaymentMethodToString(PaymentMethod)}");
        Console.WriteLine($"Payment status: {IsPaidToString()}");
        Console.WriteLine($"Payment Id: {PaymentIdToString()}");
        Console.WriteLine($"\n#Products in the order:\n");
        foreach (ProductInOrder i in ProductsInOrder)
        {
            i?.DisplayShortInfo();
        }
        Console.WriteLine("/------------ End of the order ------------/\n");
    }

    public void CalculateTotalAmountPayable()
    {
        if (GeneralStuff.Generics.IsArrayEmpty<ProductInOrder>(ProductsInOrder) == false)
        {
            foreach (ProductInOrder i in ProductsInOrder)
            {
                TotalCostOfProducts +=
                    (i?.Price ?? 0)
                    *
                    (i?.QuantityInOrder ?? 0)
                    ;
                TotalDiscountsOfProducts +=
                    (i?.Price ?? 0)
                    *
                    (i?.QuantityInOrder ?? 0)
                    *
                    (i?.DiscountPercentage ?? 0)
                    /
                    100
                    ;
            }
        }
        else
        {
            TotalCostOfProducts = 0;
            TotalDiscountsOfProducts = 0;
        }
        TotalCostOfProductsMinusTotalDiscountsOfProducts = TotalCostOfProducts - TotalDiscountsOfProducts;
        TotalDiscountByPromoCode = TotalCostOfProductsMinusTotalDiscountsOfProducts * (byte)PromoCode / 100;
        TotalAmountPayable = TotalCostOfProductsMinusTotalDiscountsOfProducts - TotalDiscountByPromoCode;
    }
}