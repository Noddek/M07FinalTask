using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M07FinalTask.N01RawData;
using M07FinalTask.N01RawData.Enumerations;
using M07FinalTask.N02Products;
using M07FinalTask.N03Customers;
using M07FinalTask.N04Delivery;
using M07FinalTask.N05Orders;
using System.Globalization;


namespace M07FinalTask.N20ProgramCode
{
    /// <summary>
    /// The static class with program code for customer
    /// </summary>
    public static class CodeForCustomer
    {
        // FIELDS & PROPERTIES
        
        // Creating a test customer profile:
        private static IndividualCustomer testIndividualCustomer = RawData.CreateIndividualCustomerForTest();

        // Creating a sales catalog:
        private static ProductInStock[] allProductsForSale = SalesCatalog.GetAllProductsForSale();

        
        // METHODS
        
        public static void ProductOrdering()
        {
            // GREETING THE CUSTOMER

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n\nHello, {testIndividualCustomer.Name}! \n\nThat's your customer profile:\n");
            testIndividualCustomer.DisplayFullInfo();
            Console.ResetColor();

            bool productOrdering = true;
            while (productOrdering)
            {
                productOrdering = false;
                Console.WriteLine($"\n{testIndividualCustomer.Name}, press ENTER to check our sales catalog and start making your order.");
                Console.Write($"\t");
                Console.ReadLine();
                GeneralStuff.Pause(5);

                // Step 1. DISPLAYING THE SALES CATALOG TO SELECT A PRODUCT

                Console.WriteLine("\nThis is our sales catalog:");
                ProductInStock.DisplayShortInfo(allProductsForSale);
                //ProductInStock.DisplayFullInfo(allProductsForSale);

                Console.WriteLine($"\n[Step 1]");
                ushort nextIndexForProductInCart = 0;
                bool continueSelectProductsChoice = true;
                while (continueSelectProductsChoice)
                {
                    Console.Write($"{testIndividualCustomer.Name}, please enter the row number with the product you want to add to your cart: ");
                    ushort productRowChoice = 0;
                    for (byte i = 0, j = 10; i <= j; ++i)
                    {
                        Console.Write("\t");
                        if (
                            ushort.TryParse(Console.ReadLine(), out productRowChoice) 
                            && 1 <= productRowChoice 
                            && productRowChoice <= allProductsForSale.Length 
                            && allProductsForSale[productRowChoice - 1].QuantityInStock > 0
                            )
                        {
                            Console.Write($"\n\tPlease enter the quantity of the selected product:");
                            ushort productQuantityChoice = 0;
                            for (byte l = 0, m = 5; l <= m; ++l)
                            {
                                Console.Write("\t");
                                if (
                                    ushort.TryParse(Console.ReadLine(), out productQuantityChoice) 
                                    && 1 <= productQuantityChoice 
                                    && productQuantityChoice <= allProductsForSale[productRowChoice - 1].QuantityInStock
                                    )
                                {
                                    testIndividualCustomer.Cart.ProductsInCart[nextIndexForProductInCart] = new ProductInOrder(allProductsForSale[productRowChoice - 1], productQuantityChoice);
                                    ++nextIndexForProductInCart;

                                    // Reducing the quantity of the chosen product in the sales catalog:
                                    allProductsForSale[productRowChoice - 1].QuantityInStock -= productQuantityChoice;

                                    break;
                                }
                                else if (l == m)
                                {
                                    Console.WriteLine($"\tToo many tries. The program is closed.");
                                    GeneralStuff.PauseAndRestartTheProgram(10);
                                    return; // In such places we should remember to write return; to exit the void-method.
                                }
                                else
                                {
                                    Console.WriteLine($"\tPlease enter the correct number ({m - l} more tries left). Available quantity in stock: {allProductsForSale[productRowChoice - 1].QuantityInStock}");
                                }
                            }
                            break;
                        }
                        else if (i == j)
                        {
                            Console.WriteLine($"\tToo many tries. The program is closed.");
                            GeneralStuff.PauseAndRestartTheProgram(10);
                            return;
                        }
                        else if (
                                1 <= productRowChoice
                                && productRowChoice <= allProductsForSale.Length
                                && allProductsForSale[productRowChoice - 1].QuantityInStock == 0
                                )
                        {
                            Console.WriteLine($"\n\tSorry, this product is no longer available for sale today. You may try to select another product, {j - i} more tries left.");
                        }
                        else
                        {
                            Console.WriteLine($"\tPlease enter the correct number ({j - i} more tries left).");
                        }
                    }
                    Console.WriteLine($"\n\tProduct [{productRowChoice}] has been added to your cart. \n\n\tDo you want to continue to select products for ordering (enter the appropriate number)? \n\t\t1. Yes. \n\t\t2. No.\n");
                    for (byte i = 0, k = 5; i <= k; ++i)
                    {
                        Console.Write("\t\t");
                        byte continueChoiceNumeric = 0;
                        if (byte.TryParse(Console.ReadLine(), out continueChoiceNumeric) && continueChoiceNumeric == 1)
                        {
                            continueSelectProductsChoice = true;
                            break;
                        }
                        else if (continueChoiceNumeric == 2)
                        {
                            continueSelectProductsChoice = false;
                            break;
                        }
                        else if (i == k)
                        {
                            Console.WriteLine($"\tToo many tries. The program is closed.");
                            GeneralStuff.PauseAndRestartTheProgram(10);
                            return;
                        }
                        else
                        {
                            Console.WriteLine($"\tPlease enter the correct number ({k - i} more tries left).");
                        }
                    }
                }
                GeneralStuff.Pause(5);

                // Step 2. PROMO CODE

                Console.WriteLine($"\n[Step 2]\n{testIndividualCustomer.Name}, if you have a promo code, please enter it (NOCODE, DISC5, DISC10, DISC15, DISC20 codes are available):");
                for (byte i = 0, k = 5; i <= k; ++i)
                {
                    Console.Write("\t");
                    string promoCode = Console.ReadLine();
                    if (promoCode == "DISC5" || promoCode == "DISC10" || promoCode == "DISC15" || promoCode == "DISC20")
                    {
                        testIndividualCustomer.Cart.PromoCode = CommonEnums.StringToPromoCode(promoCode);
                        Console.WriteLine("\n\tYour promo code has been accepted, thank you!");
                        break;
                    }
                    else if (promoCode == "NOCODE")
                    {
                        testIndividualCustomer.Cart.PromoCode = CommonEnums.StringToPromoCode(promoCode);
                        Console.WriteLine("\n\tNo promo code? To find out how to get a promo code, you can visit the related page on our website.");
                        break;
                    }
                    else if (i == k)
                    {
                        Console.WriteLine($"\n\tThe promo code is incorrect, no more tries. Next step.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"\tThe promo code is incorrect, please try again ({k - i} more tries left).");
                    }
                }
                GeneralStuff.Pause(5);

                // Step 3. DELIVERY

                Console.WriteLine($"\n[Step 3]\n{testIndividualCustomer.Name}, choose the delivery method:\n" +
                    $"\t1. Directly to you or another person at a specified address.\n" +
                    $"\t2. Delivery to one of our pick-up points.\n" +
                    $"\t3. Self-pickup from one of our shops.\n");
                for (byte i = 0, k = 5; i <= k; ++i)
                {
                    Console.Write("\t");
                    byte deliveryType = 0;
                    if (byte.TryParse(Console.ReadLine(), out deliveryType) && deliveryType == 1)
                    {
                        // Home delivery
                        testIndividualCustomer.Cart.Delivery = HomeDelivery.CreateHomeDelivery();
                        break;
                    }
                    else if (deliveryType == 2)
                    {
                        // Pick-up point delivery
                        testIndividualCustomer.Cart.Delivery = PickUpPointDelivery.CreatePickUpPointDelivery();
                        break;
                    }
                    else if (deliveryType == 3)
                    {
                        // Shop delivery
                        testIndividualCustomer.Cart.Delivery = ShopDelivery.CreateShopDelivery();
                        break;
                    }
                    else if (i == k)
                    {
                        Console.WriteLine($"\tToo many tries. The program is closed.");
                        GeneralStuff.PauseAndRestartTheProgram(10);
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"Please enter the correct number ({k - i} more tries left).");
                    }
                }
                GeneralStuff.Pause(5);

                // Step 4. COMMENT TO ORDER

                Console.WriteLine($"\n[Step 4]\n{testIndividualCustomer.Name}, would you like to add a comment to your order? \n\t1. Yes. \n\t2. No.\n");
                for (byte i = 0, k = 5; i <= k; ++i)
                {
                    Console.Write("\t");
                    byte orderComment = 0;
                    if (byte.TryParse(Console.ReadLine(), out orderComment) && (orderComment == 1))
                    {
                        testIndividualCustomer.Cart.Comment = Cart.GetCommentForOrder();
                        break;
                    }
                    else if (orderComment == 2)
                    {
                        break;
                    }
                    else if (i == k)
                    {
                        Console.WriteLine($"\tToo many tries. The comment step is skipped.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"\tPlease enter the correct number ({k - i} more tries left).");
                    }
                }
                GeneralStuff.Pause(5);

                // Step 5. THE DATA COLLECTED IN THE CART

                Console.WriteLine($"\n[Step 5]\n{testIndividualCustomer.Name}, this is your cart with the selected products:\n");
                testIndividualCustomer.Cart.CalculateTotalAmountPayable();
                testIndividualCustomer.Cart.DisplayFullInfo();
                Console.Write($"\n...Press ENTER to continue...\n");
                Console.ReadLine();
                GeneralStuff.Pause(5);

                // Step 6. PAYMENT METHOD

                Console.WriteLine($"\n[Step 6]\n{testIndividualCustomer.Name}, please specify the payment method: \n\t1. Cash. \n\t2. Bank card.\n");
                for (byte i = 0, k = 5; i <= k; ++i)
                {
                    Console.Write("\t");
                    byte paymentMethod = 0;
                    if (byte.TryParse(Console.ReadLine(), out paymentMethod) && (paymentMethod == 1))
                    {
                        testIndividualCustomer.Cart.PaymentMethod = CommonEnums.PaymentMethod.Cash;
                        break;
                    }
                    else if (paymentMethod == 2)
                    {
                        testIndividualCustomer.Cart.PaymentMethod = CommonEnums.PaymentMethod.BankCard;
                        break;
                    }
                    else if (i == k)
                    {
                        Console.WriteLine($"\tToo many tries. The payment method is not specified.");
                        testIndividualCustomer.Cart.PaymentMethod = CommonEnums.PaymentMethod.NotSpecified;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"\tPlease enter the correct number ({k - i} more tries left).");
                    }
                }
                GeneralStuff.Pause(5);

                // Step 7. ORDER CONFIRMATION

                Console.WriteLine($"\n[Step 7]\n{testIndividualCustomer.Name}, do you confirm the order? \n\t1. Yes. \n\t2. No (reset and restart the program).\n");
                for (byte i = 0, k = 5; i <= k; ++i)
                {
                    Console.Write("\t");
                    byte orderConfirmation = 0;
                    if (byte.TryParse(Console.ReadLine(), out orderConfirmation) && (orderConfirmation == 1))
                    {
                        // Creating an order with сopying data from cart to order
                        Order newOrder = new Order
                                (
                                    testIndividualCustomer.Cart.CustomerId,
                                    testIndividualCustomer.Cart.Delivery,
                                    testIndividualCustomer.Cart.PromoCode,
                                    testIndividualCustomer.Cart.Comment,
                                    testIndividualCustomer.Cart.PaymentMethod,
                                    testIndividualCustomer.Cart.ProductsInCart
                                );
                        // Saving new order in the customer order array, to the first null-element
                        for (uint j = 0; j <= testIndividualCustomer.Orders.GetUpperBound(0); ++j)
                        {
                            if (testIndividualCustomer.Orders[j] == null)
                            {
                                testIndividualCustomer.Orders[j] = newOrder;
                                break;
                            }
                        }
                        // Saving new order to the global collection of orders
                        AllOrders.SaveToAllOrdersCollection(newOrder);

                        // Clearing the cart after creating an order:
                        testIndividualCustomer.Cart.ClearCart();

                        Console.WriteLine("\tOk, your order has been created and is pending. The cart has been cleared.");
                        break;
                    }
                    else if (orderConfirmation == 2)
                    {
                        Console.WriteLine("\n\tThe program closes and will be restarted.\n");
                        GeneralStuff.PauseAndRestartTheProgram(10);
                        return;
                    }
                    else if (i == k)
                    {
                        Console.WriteLine($"\tToo many tries. The program closes and will be restarted.\n");
                        GeneralStuff.PauseAndRestartTheProgram(10);
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"\tPlease enter the correct number ({k - i} more tries left).");
                    }
                }
                GeneralStuff.Pause(5);

                // Step 8. PAYMENT

                Console.WriteLine("[Step 8]");
                if (testIndividualCustomer.AreUnpaidOrdersWithOnlinePaymentMethod())
                {
                    Console.WriteLine($"{testIndividualCustomer.Name}, enter the word \"Online\" if you would like to pay for unpaid order(s) online now, or press any other key to skip this step.");
                    Console.Write("\t");
                    string onlinePaymentChoice = Console.ReadLine();
                    if (onlinePaymentChoice.ToLower(CultureInfo.InvariantCulture) == "online")
                    {
                        // Let's say a customer pays for all orders that can be paid for online:
                        for (uint i = 0; i <= testIndividualCustomer.Orders.GetUpperBound(0); ++i)
                        {
                            if (testIndividualCustomer.Orders[i]?.IsPaid == false && testIndividualCustomer.Orders[i]?.PaymentMethod == CommonEnums.PaymentMethod.BankCard)
                            {
                                testIndividualCustomer.Orders[i].IsPaid = true; // Changing that the order has been paid for
                                testIndividualCustomer.Orders[i].PaymentId = (uint)Random.Shared.Next(1000000, 10000000); // Set a random payment identifier
                            }
                        }
                        Console.Write("\n\t>>> Payment processing procedure <<<\n\t\t");
                        GeneralStuff.Pause(15, "$");
                        Console.WriteLine("\t>>> Your payment(s) has been accepted <<<");
                        Console.Write($"\n\t...Press ENTER to continue...\n\t");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("\tTo pay for your order, please make sure you will have the proper amount of money when you receive your order.");
                        Console.Write($"\n\t...Press ENTER to continue...\n\t");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Payment: To pay for your order, please make sure you will have the proper amount of money when you receive your order.");
                    Console.Write($"\n...Press ENTER to continue...\n");
                    Console.ReadLine();
                }
                GeneralStuff.Pause(5);

                // Step 9. FULL INFO ABOUT THE CUSTOMER ORDERS AT THE MOMENT

                Console.WriteLine($"\n[Step 9]\n{testIndividualCustomer.Name}, this is the full information about your order(s) to this moment:");
                for (uint i = 0; i <= testIndividualCustomer.Orders.GetUpperBound(0); ++i)
                {
                    testIndividualCustomer.Orders[i]?.DisplayFullInfo();
                }
                Console.Write($"\n...Press ENTER to continue...\n");
                Console.ReadLine();
                GeneralStuff.Pause(5);

                // Step 10. QUESTION ABOUT CREATING A NEW ORDER

                Console.WriteLine($"\n[Step 10]\n{testIndividualCustomer.Name}, do you want to create another order? \n\t1. Yes. \n\t2. No.\n");
                for (byte i = 0, k = 5; i <= k; ++i)
                {
                    Console.Write("\t");
                    byte newOrderChoice = 0;
                    if (byte.TryParse(Console.ReadLine(), out newOrderChoice) && (newOrderChoice == 1))
                    {
                        productOrdering = true;
                        break;
                    }
                    else if (newOrderChoice == 2)
                    {
                        productOrdering = false;
                        Console.WriteLine("\n\tTrack order(s) status in your personal account.");
                        Console.WriteLine("\n\tThe program closes and will be restarted.\n");
                        GeneralStuff.PauseAndRestartTheProgram(15);
                        return;
                    }
                    else if (i == k)
                    {
                        Console.WriteLine($"\tToo many tries. The program closes and will be restarted.\n");
                        GeneralStuff.PauseAndRestartTheProgram(15);
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"\tPlease enter the correct number ({k - i} more tries left).");
                    }
                }
                GeneralStuff.Pause(15);
            }
        }
    }
}
