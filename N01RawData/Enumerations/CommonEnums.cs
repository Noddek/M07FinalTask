using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace M07FinalTask.N01RawData.Enumerations;

// Task 10.1. An example of using a STATIC CLASS
public static class CommonEnums
{
    // Maybe it would be better to use some dictionaries instead of enums, but we haven't studied dictionaries yet, so I don't use them.
    public enum Brand : byte
    {
        NotSpecified = 0,
        Acer,
        Alienware,
        AOC,
        AORUS,
        Apple,
        ASUS,
        BenQ,
        Dell,
        GIGABYTE,
        Hitachi,
        HP,
        Huawei,
        IBM,
        iiyama,
        Lenovo,
        LG,
        Microsoft,
        Mitsubishi,
        MSI,
        NEC,
        Panasonic,
        Razer,
        Philips,
        Samsung,
        Sharp,
        Sony,
        Toshiba,
        ViewSonic,
        Xiaomi
    }
    public enum ProductCategory : byte
    {
        NotSpecified = 0,
        Laptop,
        Monitor
    }
    public enum ReleaseYear : uint
    {
        NotSpecified = 0,
        _2024 = 2024,
        _2023 = 2023,
        _2022 = 2022,
        _2021 = 2021,
        _2020 = 2020,
        _2019 = 2019
    }

    // --------------------------------------

    public enum ProductCondition : byte
    {
        NotSpecified = 0,
        New,
        NewPackageWasOpened,
        Used,
        Refurbished,
        ForRepacking,
        ForRefurbishment
    }
    public static string ProductConditionToString(ProductCondition productCondition)
    {
        switch (productCondition)
        {
            case ProductCondition.New: return "New";
            case ProductCondition.NewPackageWasOpened: return "New, the package was opened";
            case ProductCondition.Used: return "Used";
            case ProductCondition.Refurbished: return "Refurbished";
            case ProductCondition.ForRepacking: return "Repackaging is required";
            case ProductCondition.ForRefurbishment: return "Refurbishment is required";
            default: return "Not specified";
        }
    }

    // --------------------------------------

    public enum UnitOfMeasurement : byte
    {
        NotSpecified = 0,
        Pieces
    }

    // --------------------------------------

    public enum VATPercentage : uint
    {
        NotSpecified = 0,
        _20,
        _16_67,
        _10,
        _0
    }
    public static string VATPercentageToString(VATPercentage VATPercentage)
    {
        switch (VATPercentage)
        {
            case VATPercentage._20: return "20 %";
            case VATPercentage._16_67: return "16.67 %";
            case VATPercentage._10: return "10 %";
            case VATPercentage._0: return "0 %";
            default: return "Not specified";
        }
    }

    // --------------------------------------

    public enum CustomerStatus : byte
    {
        NotSpecified = 0,
        New,
        Normal,
        Blocked,
        Banned
    }

    // --------------------------------------

    public enum OrderStatus : byte
    {
        NotSpecified = 0,
        Pending,
        AwaitingPayment,
        AwaitingShipment,
        Shipped,
        AwaitingPickup,
        Completed,
        Declined,
        Cancelled,
        Refunded
    }
    public static string OrderStatusToString (OrderStatus orderStatus)
    {
        switch (orderStatus)
        {
            case OrderStatus.Pending: return "Pending";
            case OrderStatus.AwaitingPayment: return "Awaiting payment";
            case OrderStatus.AwaitingShipment: return "Awaiting shipment";
            case OrderStatus.Shipped: return "Shipped";
            case OrderStatus.AwaitingPickup: return "Awaiting pickup";
            case OrderStatus.Completed: return "Completed";
            case OrderStatus.Declined: return "Declined";
            case OrderStatus.Cancelled: return "Cancelled";
            case OrderStatus.Refunded: return "Refunded";
            default: return "Not specified";
        }
    }

    // --------------------------------------

    public enum PromoCode : byte
    {
        NotSpecified = 0,
        NOCODE = 0,
        DISC5 = 5,
        DISC10 = 10,
        DISC15 = 15,
        DISC20 = 20
    }
    public static string PromoCodeToString(PromoCode promoCode)
    {
        switch (promoCode)
        {
            case PromoCode.NOCODE: return "No promo code";
            case PromoCode.DISC5: return "5 % discount on the entire order";
            case PromoCode.DISC10: return "10 % discount on the entire order";
            case PromoCode.DISC15: return "15 % discount on the entire order";
            case PromoCode.DISC20: return "20 % discount on the entire order";
            default: return "Not specified";
        }
    }

    public static PromoCode StringToPromoCode(string promoCode)
    {
        switch (promoCode)
        {
            case "NOCODE": return PromoCode.NOCODE;
            case "DISC5": return PromoCode.DISC5;
            case "DISC10": return PromoCode.DISC10;
            case "DISC15": return PromoCode.DISC15;
            case "DISC20": return PromoCode.DISC20;
            default: return PromoCode.NotSpecified;
        }
    }

    // --------------------------------------

    public enum PaymentMethod : byte
    {
        NotSpecified = 0,
        BankCard,
        Cash
    }
    public static string PaymentMethodToString(PaymentMethod paymentMethod)
    {
        switch (paymentMethod)
        {
            case PaymentMethod.BankCard: return "Bank card";
            case PaymentMethod.Cash: return "Cash";
            default: return "Not specified";
        }
    }
}

