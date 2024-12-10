using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using M07FinalTask.N01RawData.Enumerations;
using M07FinalTask.N02Products;
using M07FinalTask.N04Delivery;
using M07FinalTask.N20ProgramCode;

namespace M07FinalTask.N05Orders;

/// <summary>
/// The class for creating a customer shopping cart
/// </summary>
public class Cart
{
    // FILEDS & PROPERTIES
    public uint CartId { get; private set; }
    public uint CustomerId { get; private set; }
    public IDelivery Delivery { get; set; }
    public string? Comment { get; set; } = "Not specified";
    public CommonEnums.PromoCode PromoCode { get; set; }
    public ProductInOrder[] ProductsInCart { get; set; }
    public decimal TotalCostOfProducts { get; private set; }
    public decimal TotalDiscountsOfProducts { get; private set; }
    public decimal TotalCostOfProductsMinusTotalDiscountsOfProducts { get; private set; }
    public decimal TotalDiscountByPromoCode { get; private set; }
    public decimal TotalAmountPayable { get; private set; }
    public CommonEnums.PaymentMethod PaymentMethod { get; set; }



    // CONSTRUCTOR
    public Cart(uint customerId, uint cartId)
    {
        CartId = cartId;
        CustomerId = customerId;
        ProductsInCart = new ProductInOrder[SalesCatalog.GetAllProductsForSale().Length];
        // There is no need to add anything about delivery, as I understand it
    }


    // METHODS

    // 1. Static
    public static string GetCommentForOrder()
    {
        Console.WriteLine($"\n\tPlease provide any useful information to fulfill the order:");
        string orderComment = "";
        for (byte i = 0, k = 5; i <= k; ++i)
        {
            Console.Write($"\t\t");
            orderComment = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(orderComment))
            {
                break;
            }
            else if (string.IsNullOrWhiteSpace(orderComment) && i == k)
            {
                Console.WriteLine($"\t\tToo many tries. The comment step is skipped.");
                return "Not specified";
            }
            else if (string.IsNullOrWhiteSpace(orderComment))
            {
                Console.WriteLine($"\t\tPlease enter any comment or \"No comment\" ({k - i} more tries left).");
            }
        }
        return orderComment;
    }

    // 2. Non-static
    public void DisplayFullInfo()
    {
        Console.WriteLine($"Cart Id: {CartId}");
        Console.WriteLine($"Customer Id: {CustomerId}");
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
        Console.WriteLine($"\n#Products in cart:\n");
        foreach (ProductInOrder i in ProductsInCart)
        {
            i?.DisplayShortInfo();
        }
    }
    public void CalculateTotalAmountPayable()
    {
        if (GeneralStuff.Generics.IsArrayEmpty<ProductInOrder>(ProductsInCart) == false)
        {
            for (uint i = 0; i <= ProductsInCart.GetUpperBound(0); ++i)
            {
                // An example of using the null-coalescing operator ??
                TotalCostOfProducts +=
                    (ProductsInCart[i]?.Price ?? 0)
                    * 
                    (ProductsInCart[i]?.QuantityInOrder ?? 0)
                    ;
                TotalDiscountsOfProducts += 
                    (ProductsInCart[i]?.Price ?? 0)
                    * 
                    (ProductsInCart[i]?.QuantityInOrder ?? 0)
                    *
                    (ProductsInCart[i]?.DiscountPercentage ?? 0)
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
    public void ClearCart()
    {
        Delivery = null;
        PromoCode = CommonEnums.PromoCode.NotSpecified;
        Comment = "Not specified";
        ProductsInCart = new ProductInOrder[SalesCatalog.GetAllProductsForSale().Length];
        CalculateTotalAmountPayable();
        PaymentMethod = CommonEnums.PaymentMethod.NotSpecified;
    }
    
}