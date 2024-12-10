using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M07FinalTask.N01RawData;

namespace M07FinalTask.N02Products
{
    /// <summary>
    /// The class to accumulate in a single array all products in stock:
    /// Laptops and Monitors are in one array. 
    /// The Singleton pattern is used.
    /// </summary>
    public class ProductsInStock
    {
        // FIELD for Singleton pattern: class instance
        private static ProductsInStock? instance;

        // PROPERTY
        public ProductInStock[] AllProductsInStock { get; private set; }

        // CONSTRUCTOR
        // 1. Helper method for constructor from Singleton pattern
        public static ProductsInStock GetAllProductsInStock()
        {
            if (instance == null) { instance = new ProductsInStock(); }
            return instance;
        }
        // 2. Constructor
        private ProductsInStock()
        {
            AllProductsInStock = RawData.CreateProductsForProductsInStock();
        }

        // INDEXERS
        // Task 18. Using indexers.
        public ProductInStock this[uint index]
        {
            get
            {
                if (index >= 0 && index <= AllProductsInStock.GetUpperBound(0))
                {
                    return AllProductsInStock[index];
                }
                else
                {
                    return null;
                }
                
            }
            set
            {
                if (index >= 0 && index <= AllProductsInStock.GetUpperBound(0))
                {
                    AllProductsInStock[index] = value;
                }
            }
        }
    }
}
