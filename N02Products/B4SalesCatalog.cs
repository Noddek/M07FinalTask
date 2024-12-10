using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace M07FinalTask.N02Products;

/// <summary>
/// The static class to get all the products available for sale.
/// We can make filters for selection.
/// The class is static, used to handle a single instance of the ProductsInStock class.
/// </summary>
public static class SalesCatalog
{
    // FIELDS
    // All products for sale can be accessed through a field or through a method.
    // Here through the field, through the method below.
    public static ProductInStock[] getAllProductsForSale = GetAllProductsForSale();


    // METHODS

    // Target methods

    /// <summary>
    /// Method to get all products available for sale
    /// </summary>
    /// <returns>An array of products available for sale</returns>
    public static ProductInStock[] GetAllProductsForSale()
    {
        // Getting all the products in stock:
        ProductsInStock allProductsInStock = ProductsInStock.GetAllProductsInStock();

        // Counting the amount of items available for sale:
        uint amountOfItemsAvailableForSale = 0;
        for (uint i = 0; i <= allProductsInStock.AllProductsInStock.GetUpperBound(0); ++i)
        {
            // Task 18. Using indexers.
            if (allProductsInStock[i] != null && allProductsInStock[i]?.IsAvaiableForSale != false)
            {
                ++amountOfItemsAvailableForSale;
            }
        }
        
        // Creating an array of all items available for sale with the correct array length:
        ProductInStock[] allProductsForSale = new ProductInStock[amountOfItemsAvailableForSale];
        uint indexCounter = 0;
        for (uint i = 0; i <= allProductsInStock.AllProductsInStock.GetUpperBound(0); ++i)
        {
            if (allProductsInStock[i] != null && allProductsInStock[i]?.IsAvaiableForSale != false)
            {
                allProductsForSale[indexCounter] = allProductsInStock[i];
                ++indexCounter;
            }
        }
        return allProductsForSale;
    }

    /// <summary>
    /// Example of a method to get all products available for sale, filtered by their maximum price
    /// </summary>
    /// <param name="maxPrice">Maximum price of the product</param>
    /// <returns>Array of products available for sale, costing no more than the given price</returns>
    public static ProductInStock[] GetProductsForSaleFilteredByMaxPrice(decimal maxPrice)
    {
        // Getting all the products in stock:
        ProductsInStock allProductsInStock = ProductsInStock.GetAllProductsInStock();

        // Counting the amount of items available for sale and at a price no higher the maxPrice (itemsCounter):
        uint itemsCounter = 0;
        for (uint i = 0; i <= allProductsInStock.AllProductsInStock.GetUpperBound(0); ++i)
        {
            if ( allProductsInStock[i] != null && allProductsInStock[i]?.IsAvaiableForSale != false && allProductsInStock[i]?.Price <= maxPrice )
            {
                ++itemsCounter;
            }
        }

        // Creating an array of all items available for sale and at a price no higher the maxPrice with the correct array length:
        ProductInStock[] productsForSaleFilteredByMaxPrice = new ProductInStock[itemsCounter];
        uint indexCounter = 0;
        for (uint i = 0; i <= allProductsInStock.AllProductsInStock.GetUpperBound(0); ++i)
        {
            if (allProductsInStock[i]?.IsAvaiableForSale != false && allProductsInStock[i]?.Price <= maxPrice)
            {
                productsForSaleFilteredByMaxPrice[indexCounter] = allProductsInStock[i];
                ++indexCounter;
            }
        }
        return productsForSaleFilteredByMaxPrice;
    }
}