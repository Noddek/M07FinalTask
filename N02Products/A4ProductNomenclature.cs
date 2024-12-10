using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M07FinalTask.N01RawData;

namespace M07FinalTask.N02Products
{
    /// <summary>
    /// This class contains the full nomenclature of products that the shop has sold, sells, or will sell.
    /// Laptops and monitors are in separate arrays.
    /// The Singleton pattern is used.
    /// </summary>
    public class ProductNomenclature
    {
        // FIELD for Singleton pattern: class instance
        // Task 10.2. An example of using a static element
        private static ProductNomenclature? instance;

        // PROPERTIES
        // Product nomenclature:
        public Laptop[] LaptopNomenclature { get; private set; }
        public Monitor[] MonitorNomenclature { get; private set; }


        // CONSTRUCTOR
        
        // 1. Helper method for constructor from Singleton pattern
        // Task 10.3. An example of using a static method
        public static ProductNomenclature GetProductNomenclature()
        {
            if (instance == null) { instance = new ProductNomenclature(); }
            return instance;
        }
        
        // 2. Constructor
        private ProductNomenclature()
        {
            LaptopNomenclature = RawData.CreateLaptopsForProductNomenclature();
            MonitorNomenclature = RawData.CreateMonitorsForProductNomenclature();
        }

        // METHODS

        // Target methods for product nomenclature
        // 1. For laptops
        public void DisplayLaptopNomenclatureFullInfo()
        {
            for (uint i = 0; i <= LaptopNomenclature.GetUpperBound(0); i++)
            {
                if (LaptopNomenclature[i] != null)
                {
                    Console.WriteLine($"\n --------- LAPTOP N{i + 1}: --------- \n");
                    LaptopNomenclature[i].DisplayFullInfo();
                }
            }
        }
        public void DisplayLaptopNomenclatureShortInfo()
        {
            Console.WriteLine();
            foreach (Laptop laptop in LaptopNomenclature)
            {
                if (laptop != null)
                {
                    // An example of using the NULL-CONDITIONAL OPERATOR:
                    // It's not needed after being placed in if-condition, but I left it in anyway
                    laptop?.DisplayShortInfo();
                    Console.WriteLine();
                }
            }
        }

        // 2. For monitors
        public void DisplayMonitorNomenclatureFullInfo()
        {
            for (uint i = 0; i <= MonitorNomenclature.GetUpperBound(0); i++)
            {
                if (MonitorNomenclature[i] != null)
                {
                    Console.WriteLine($"\n --------- MONITOR N{i + 1}: --------- \n");
                    MonitorNomenclature[i].DisplayFullInfo();
                }
            }
        }
        public void DisplayMonitorNomenclatureShortInfo()
        {
            Console.WriteLine();
            foreach (Monitor monitor in MonitorNomenclature)
            {
                if (monitor != null)
                {
                    monitor?.DisplayShortInfo();
                    Console.WriteLine();
                }
            }
        }
    }
}
