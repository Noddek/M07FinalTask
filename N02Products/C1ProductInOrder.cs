using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using M07FinalTask.N01RawData.Enumerations;

namespace M07FinalTask.N02Products;

/// <summary>
/// The class to create product instances that will be accounted for directly in orders.
/// This separates the existence of products in the stock and in orders.
/// </summary>
public class ProductInOrder
{
    // FIELDS & PROPERTIES
    public Product<uint> Product { get; private set; }
    public CommonEnums.ProductCondition ProductCondition { get; private set; }
    public decimal Price { get; private set; }
    public byte DiscountPercentage { get; private set; }
    public CommonEnums.VATPercentage VATPercentage { get; private set; }
    public ushort QuantityInOrder { get; private set; } = 0;

    // CONSTRUCTOR 
    public ProductInOrder(ProductInStock productFromSalesCatalog)
    {
        Product = productFromSalesCatalog.Product;
        ProductCondition = productFromSalesCatalog.ProductCondition;
        Price = productFromSalesCatalog.Price;
        DiscountPercentage = productFromSalesCatalog.DiscountPercentage;
        VATPercentage = productFromSalesCatalog.VATPercentage;
    }
    public ProductInOrder(ProductInStock productFromSalesCatalog, ushort quantityInOrder) : this(productFromSalesCatalog)
    {
        QuantityInOrder = quantityInOrder;
    }

    // METHODS
    public void DisplayFullInfo()
    {
        Product?.DisplayFullInfo();
        Console.WriteLine($"Product condition: {CommonEnums.ProductConditionToString(ProductCondition)}");
        Console.WriteLine($"Price: {Price} RUB");
        Console.WriteLine($"Discount: {DiscountPercentage} %");
        Console.WriteLine($"VAT: {CommonEnums.VATPercentageToString(VATPercentage)}");
        Console.WriteLine($"Quantity in order: {QuantityInOrder}");
    }
    public void DisplayShortInfo()
    {
        Product?.DisplayShortInfo();
        Console.WriteLine($", {CommonEnums.ProductConditionToString(ProductCondition)}, {Price} RUB, {DiscountPercentage} % discount, {QuantityInOrder} pieces in order\n");
    }

}