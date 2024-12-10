using System.Security.Cryptography.X509Certificates;
using M07FinalTask.N01RawData;
using M07FinalTask.N01RawData.Enumerations;
using M07FinalTask.N02Products;
using M07FinalTask.N03Customers;
using M07FinalTask.N05Orders;
using M07FinalTask.N11Contacts;
using M07FinalTask.N20ProgramCode;
using Microsoft.VisualBasic;
using static M07FinalTask.N01RawData.Enumerations.CommonEnums;



namespace M07FinalTask;

internal class Program
{
    static void Main(string[] args)
    {
        
        /// -------- Block for testing properties with logic and extension method: --------

        //Console.ForegroundColor = ConsoleColor.Green;
        //Console.WriteLine("\n------ START: Block for testing properties with logic and extension method ------\n");
        //Console.ResetColor();
        //IndividualCustomer testCustomer = new IndividualCustomer
        //    (
        //        "Alexey", // Login
        //        "1stPassword", // Password
        //        CustomerStatus.New,
        //        "Alexey", // Name
        //        new PhoneNumber(7, 8, 936, 9345621),
        //        new EMail("alexey", "testnetwork.com")
        //    );
        //testCustomer.DisplayFullInfo();
        //testCustomer.Login = "Alexey2000";
        //testCustomer.DisplayFullInfo();
        //testCustomer.Password = "1stPassword";
        //testCustomer.DisplayFullInfo();
        //Console.ForegroundColor = ConsoleColor.Cyan;
        //Console.WriteLine("\n\tTesting the extension method:");
        //Console.WriteLine($"\tThe method returns: {testCustomer.AreUnpaidOrdersWithOnlinePaymentMethod()}");
        //Console.ForegroundColor = ConsoleColor.Green;
        //Console.WriteLine("\n------ END: Block for testing properties with logic and extension method --------\n");
        //Console.ResetColor();

        /// -------------------------------------------------------------------------------



        /// -------- Block for testing indexers: --------

        //Console.ForegroundColor = ConsoleColor.Red;
        //Console.WriteLine("\n------ START: Block for testing indexers ------\n");
        //Console.ResetColor();
        //AllOrders testAllOrders = AllOrders.GetAllOrdersCollection();
        //// Access by array index:
        //testAllOrders[0]?.DisplayFullInfo();
        //testAllOrders[1]?.DisplayFullInfo();
        //testAllOrders[2]?.DisplayFullInfo(); // Initially there's null, no order
        //// Access by order number: 20240000
        //testAllOrders[20240001]?.DisplayFullInfo();
        //testAllOrders[20240002]?.DisplayFullInfo();
        //testAllOrders[20240003]?.DisplayFullInfo(); // Initially there's null, no order
        //Console.ForegroundColor = ConsoleColor.Red;
        //Console.WriteLine("\n------ END: Block for testing indexers --------\n");
        //Console.ResetColor();
        
        /// ---------------------------------------------



        /// -------- Block for testing operator overloading: --------

        //Console.ForegroundColor = ConsoleColor.Blue;
        //Console.WriteLine("\n------ START: Block for testing operator overloading ------\n");
        //Console.ResetColor();
        //ProductsInStock allProductsInStock = ProductsInStock.GetAllProductsInStock();
        //Package myPackage1 = allProductsInStock[0] + allProductsInStock[70];
        //Package myPackage2 = allProductsInStock[0] + 16;
        //Package.DisplayPackageInfo(myPackage1);
        //Console.ForegroundColor = ConsoleColor.Blue;
        //Console.WriteLine("\n------ END: Block for testing operator overloading --------\n");
        //Console.ResetColor();

        /// ----------------------------------------------------------



        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n---------------------- Main program: ----------------------\n");
        Console.ResetColor();
        Start.StartTheProgram();
        

    }





}

