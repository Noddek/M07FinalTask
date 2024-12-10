using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M07FinalTask.N02Products
{
    /// <summary>
    /// The class for creating special product packages for sale.
    /// So far it's done only for packages of 2 products - in general it's logical, 
    /// since there are only 2 categories of products in the store.
    /// </summary>
    public class Package
    {
        // STATIC FIELDS
        public static Package[] allPackages = new Package[100];

        // FIELDS & PROPERTIES
        public ProductInStock[] PackageOfProductsInStock { get; private set; }
        public byte SpecialDiscountPercentage { get; private set; } = 10; // Default package discount percentage


        // CONSTRUCTORS --- Start of the section
        public Package (ProductInStock firstProductInStock, ProductInStock secondProductInStock)
        {
            PackageOfProductsInStock = new ProductInStock[2] { firstProductInStock, secondProductInStock };
            // Immediately save to the packages array:
            for (byte i = 0; i <= allPackages.GetUpperBound(0); ++i)
            {
                if (allPackages[i] == null)
                {
                    allPackages[i] = this;
                    break;
                }
            }
        }
        public Package (ProductInStock firstProductInStock, ProductInStock secondProductInStock, byte specialDiscountPercentage)
            : this (firstProductInStock, secondProductInStock)
        {
            SpecialDiscountPercentage = specialDiscountPercentage;
        }
        // CONSTRUCTORS --- End of the section


        // METHODS

        public static void DisplayPackageInfo(Package package)
        {
            for (byte i = 0; i <= package.PackageOfProductsInStock.GetUpperBound(0); ++i)
            {
                Console.WriteLine($"\n---------- Product {i + 1}: ----------");
                package.PackageOfProductsInStock[i].DisplayShortInfo();
            }
            Console.WriteLine($"\n--------------------------------");
            Console.WriteLine($"\nPackage discount: {package.SpecialDiscountPercentage} %.");
        }
    }
}
