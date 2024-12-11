using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using M07FinalTask.N01RawData.Enumerations;
using static M07FinalTask.N01RawData.Enumerations.CommonEnums;

namespace M07FinalTask.N02Products;

/// <summary>
/// The class to create instances of products that are accounted for in the store's stock. 
/// Different instances can have the same nomenclature number (Item Number) of the Product class (and its derived ones).
/// </summary>
public class ProductInStock
{
    // FIELDS & PROPERTIES

    public Product<uint> Product { get; private set; }
        /*
        THE PROBLEM:
        If instead of Product<uint> I try to make the type more generic,
        there are problems with the logic in the constructor,
        and I don't see how to solve this problem.
        */
    public ProductCondition ProductCondition { get; private set; }
    public decimal Price { get; private set; }
    public byte DiscountPercentage { get; private set; }
    public VATPercentage VATPercentage { get; private set; }
    public uint QuantityInStock { get; set; }
    public bool IsAvaiableForSale { get; private set; }

    // CONSTRUCTOR --- Beginning of the section

    // 1. Helper method for constructor

    /// <summary>
    /// The method checks the parameter of Item Number, if number is correct it creates 
    /// and returns a new instance of ProductInStock class, otherwise it returns null
    /// </summary>
    /// <returns>New instance of ProductInStock class or null</returns>
    public static ProductInStock? CheckAndCreateNewProductInStock
        (
            uint itemNumber,
            ProductCondition productCondition,
            decimal price,
            byte discountPercentage,
            VATPercentage VATPercentage,
            uint quantityInStock,
            bool isAvaiableForSale
        )
    {
        ProductNomenclature productNomenclature = ProductNomenclature.GetProductNomenclature();
        ProductInStock? instance = null;
        for (byte j = 0; j < 5; ++j)
        {
            for (uint i = 0; i <= productNomenclature.LaptopNomenclature.GetUpperBound(0); ++i)
            {
                if (itemNumber == productNomenclature.LaptopNomenclature[i]?.ItemNumber)
                {
                    instance = new ProductInStock(itemNumber, productCondition, price, discountPercentage, VATPercentage, quantityInStock, isAvaiableForSale);
                    return instance;
                }
            }
            for (uint i = 0; i <= productNomenclature.MonitorNomenclature.GetUpperBound(0); ++i)
            {
                if (itemNumber == productNomenclature.MonitorNomenclature[i]?.ItemNumber)
                {
                    instance = new ProductInStock(itemNumber, productCondition, price, discountPercentage, VATPercentage, quantityInStock, isAvaiableForSale);
                    return instance;
                }
            }
            if (instance == null)
            {
                Console.WriteLine($"The item number must be the same as the number in the product nomenclature. Enter the correct number. Attempts left: {5 - j}");
            }
        }
        return null; //or return instance;
    }

    // 2. Constructor

    // It's forbidden to create an object if Item Number is specified incorrectly, so the constructor is private.
    // To check Item Number and call the constructor we use the method above.
    private ProductInStock
        (
            uint itemNumber,
            ProductCondition productCondition,
            decimal price,
            byte discountPercentage,
            VATPercentage VATPercentage,
            uint quantityInStock,
            bool isAvaiableForSale
        )
    {
        ProductNomenclature productNomenclature = ProductNomenclature.GetProductNomenclature();
        for (uint i = 0; i <= productNomenclature.LaptopNomenclature.GetUpperBound(0); ++i)
        {
            if (itemNumber == productNomenclature.LaptopNomenclature[i]?.ItemNumber)
            {
                // Task 17. An example of using AGGREGATION:
                // field of an instance of class ProductInStock will get a reference
                // to an instance of class Laptop or Monitor created externally                    
                Product = productNomenclature.LaptopNomenclature[i]; break;
            }
        }
        if (Product == null)
        {
            for (uint i = 0; i <= productNomenclature.MonitorNomenclature.GetUpperBound(0); ++i)
            {
                if (itemNumber == productNomenclature.MonitorNomenclature[i]?.ItemNumber)
                {
                    Product = productNomenclature.MonitorNomenclature[i]; break;
                }
            }
        }
        ProductCondition = productCondition;
        Price = price;
        DiscountPercentage = discountPercentage;
        this.VATPercentage = VATPercentage;
        QuantityInStock = quantityInStock;
        IsAvaiableForSale = isAvaiableForSale;
    }

    // CONSTRUCTOR --- End of the section






    // METHODS --- Beginning of the section

    // 1. Helper local methods
    private string IsAvaiableForSaleToString()
    {
        if (IsAvaiableForSale == true) return "Available for sale";
        else return "Not available for sale";
    }

    // 2. Target methods
    public void DisplayFullInfo()
    {
        Product?.DisplayFullInfo();
        Console.WriteLine($"Product condition: {ProductConditionToString(ProductCondition)}");
        Console.WriteLine($"Price: {Price} RUB");
        Console.WriteLine($"Discount: {DiscountPercentage} %");
        Console.WriteLine($"VAT: {VATPercentageToString(VATPercentage)}");
        Console.WriteLine($"Quantity in stock: {QuantityInStock}");
        Console.WriteLine($"Availability: {IsAvaiableForSaleToString()}");
    }

    public void DisplayShortInfo()
    {
        Product?.DisplayShortInfo();
        Console.WriteLine($", {ProductConditionToString(ProductCondition)}, {Price} RUB, {DiscountPercentage} % discount, {QuantityInStock} pieces in stock, {IsAvaiableForSaleToString()}");
    }

    // 3. Helper static methods for working with different instances of ProductInStock[] arrays
    public static void DisplayFullInfo(ProductInStock[] array)
    {
        for (uint i = 0; i <= array.GetUpperBound(0); ++i)
        {
            if (array[i] != null)
            {
                Console.WriteLine($"\n---------- Product N{i + 1}: ----------\n");
                array[i].DisplayFullInfo();
            }
        }
    }

    public static void DisplayShortInfo(ProductInStock[] array)
    {
        Console.WriteLine("\n-----------------------------------------------");
        for (uint i = 0; i <= array.GetUpperBound(0); ++i)
        {
            if (array[i] != null)
            {
                Console.Write($"\n[{i + 1}] ");
                array[i].DisplayShortInfo();
            }
        }
        Console.WriteLine("\n-----------------------------------------------");
    }

    // METHODS --- End of the section






    // OPERATORS

    // Task 19. Using of overloaded operators.
    /// <summary>
    /// This operator overloading allows us to create a package of two products
    /// </summary>
    /// <param name="firstProductInStock">The first product we want to add to the package</param>
    /// <param name="secondProductInStock">The second product we want to add to the package</param>
    /// <returns></returns>
    public static Package operator + (ProductInStock firstProductInStock, ProductInStock secondProductInStock)
    {
        return new Package (firstProductInStock, secondProductInStock);
    }

    /// <summary>
    /// This operator overloading allows us to create a package for buying of one product starting at two units with a special discount different from the default package discount
    /// </summary>
    /// <param name="productInStock">The product, for buying of which from 2 units the customer will get a special discount</param>
    /// <param name="specialDiscountPercentage">Discount in percent</param>
    /// <returns></returns>
    public static Package operator + (ProductInStock productInStock, byte specialDiscountPercentage)
    {
        return new Package(productInStock, productInStock, specialDiscountPercentage);
    }
}