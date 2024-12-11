using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using M07FinalTask.N01RawData.Enumerations;

namespace M07FinalTask.N02Products;

// Task 2.1. An example of using an ABSTRACT CLASS.
// Task 7. Using generics.
/// <summary>
/// This is an abstract class of products that are sold in our store
/// </summary>
public abstract class Product<TStruct> where TStruct : struct // The constraint is just to show the possibility, we can leave it without constraint.
{
    // FIELDS & PROPERTIES

    // Task 2.2. An example of using abstract class members: ABSTRACT PROPERTY.
    public abstract TStruct ItemNumber { get; protected set; }

    // Task 8.1. An example of using the AUTO-IMPLEMENTED PROPERTIES
    public CommonEnums.Brand Brand { get; private set; }
    public CommonEnums.ProductCategory Category { get; private set; }
    public string? ItemTitle { get; private set; } = "No title";
    public string? Description { get; private set; } = "No description";
    public CommonEnums.ReleaseYear ReleaseYear { get; private set; }
    public CommonEnums.UnitOfMeasurement UnitOfMeasurement { get; private set; }

    // CONSTRUCTORS

    // This base class and its derived classes will not have a constructor without parameters,
    // i.e. we will have to at least specify the brand and model when creating the object.
    
    // Task 6. An example of using a class CONSTRUCTORS WITH PARAMETERS
    
    // 1 parameter:
    public Product(CommonEnums.Brand brand)
    {
        Brand = brand;
    }

    // 2 parameters:
    public Product
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category
        ) : this(brand)
    {
        Category = category;
    }

    // 3 parameters:
    public Product
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle
        ) : this(brand, category)
    {
        ItemTitle = itemTitle;
    }

    // 4 parameters:
    public Product
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description
        ) : this(brand, category, itemTitle)
    {
        Description = description;
    }

    // 5 parameters:
    public Product
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear
        ) : this(brand, category, itemTitle, description)
    {
        ReleaseYear = releaseYear;
    }

    // 6 parameters:
    public Product
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            CommonEnums.UnitOfMeasurement unitOfMeasurement
        ) : this(brand, category, itemTitle, description, releaseYear)
    {
        UnitOfMeasurement = unitOfMeasurement;
    }



    // METHODS

    // Task 4.1. Using method override. (See the example of method override in derived classes.)
    public virtual void DisplayFullInfo()
    {
        Console.WriteLine($"Item number: {ItemNumber}");
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Category: {Category}");
        Console.WriteLine($"Title: {ItemTitle}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Release year: {(uint)ReleaseYear}");
        Console.WriteLine($"Unit of measurement: {UnitOfMeasurement}");
    }

    // Task 2.2. An example of using abstract class members: ABSTRACT METHOD.
    public abstract void DisplayShortInfo();
}