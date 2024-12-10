using M07FinalTask.N01RawData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M07FinalTask.N05Orders
{
    /// <summary>
    /// The class to collect and manage orders.
    /// The Singleton pattern is used.
    /// </summary>
    public class AllOrders
    {
        // FIELD for Singleton pattern: class instance
        private static AllOrders? instance;

        // PROPERTIES
        public Order[] AllOrdersCollection { get; private set; }



        // CONSTRUCTOR

        // 1. Helper method for constructor from Singleton pattern
        public static AllOrders GetAllOrdersCollection()
        {
            if (instance == null)
            {
                instance = new AllOrders();
            }
            return instance;
        }

        // 2. Constructor
        private AllOrders()
        { 
            AllOrdersCollection = new Order[100];
            Order[] ordersForTest = RawData.CreateOrdersForTest();
            for (byte i = 0; i <= ordersForTest.GetUpperBound(0); ++i)
            {
                AllOrdersCollection[i] = ordersForTest[i];
            }
        }



        // METHODS
        public static void SaveToAllOrdersCollection (Order order)
        {
            AllOrders allOrders = GetAllOrdersCollection();
            for (uint i = 0; i <= allOrders.AllOrdersCollection.GetUpperBound(0); ++i)
            {
                if (allOrders.AllOrdersCollection[i] == null)
                {
                    allOrders.AllOrdersCollection[i] = order;
                    break;
                }
            }
        }



        // INDEXERS
        // Task 18. Using indexers.
        // 1st indexer:
        public Order this[byte index]
        {
            get
            {
                if (index >= 0 && index <= AllOrdersCollection.GetUpperBound(0))
                {
                    return AllOrdersCollection[index];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (index >= 0 && index <= AllOrdersCollection.GetUpperBound(0))
                {
                    AllOrdersCollection[index] = value;
                }
            }
        }
        // 2nd indexer, overloading (returns the order by order number):
        public Order this[uint orderNumber]
        {
            get
            {
                foreach (Order order in AllOrdersCollection)
                {
                    if (order?.OrderNumber == orderNumber) // Without ? it will be the NullReferenceException
                    {
                        return order;
                    }
                }
                return null;
            }
        }
    }
}
