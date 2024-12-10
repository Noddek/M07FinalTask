using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using M07FinalTask.N01RawData;

namespace M07FinalTask.N04Delivery;

/// <summary>
/// The class for working with shop delivery that implements the interface IDelivery
/// </summary>
public class ShopDelivery : IDelivery
{
    // FIELDS

    /// <summary>
    /// The field contains an array of shops that can be used for ShopDelivery
    /// </summary>
    public static Shop[] shopsForShopDelivery = RawData.CreateShops();

    // PROPERTIES
    public string Type { get { return "Shop delivery"; } }
    public DateTime? SendingDate { get; set; }
    public DateTime? FinishDate { get; set; }
    public Shop Shop { get; private set; }

    // CONSTRUCTOR
    public ShopDelivery (Shop shop)
    {
        Shop = shop;
    }

    // METHODS

    // 1. Static
    public static ShopDelivery CreateShopDelivery()
    {
        Console.WriteLine("\n\tSelect the desired shop from the list below (enter the appropriate number):");
        for (uint i = 0; i <= shopsForShopDelivery.GetUpperBound(0); ++i)
        {
            Console.WriteLine($"\t\t{i + 1}. {shopsForShopDelivery[i].ShopInfoToString()}");
        }
        Console.WriteLine();
        int selectedShop = -1;
        do
        {
            Console.Write("\t\t");
            if (int.TryParse(Console.ReadLine(), out selectedShop) && (1 <= selectedShop) && (selectedShop <= shopsForShopDelivery.Length))
            {
                break;
            }
            else
            {
                Console.WriteLine($"\t\tPlease enter the correct number.");
            }
        } while (true);
        return new ShopDelivery(shopsForShopDelivery[selectedShop - 1]);
    }

    // 2. Non-static
    public string InfoToString()
    {
        return Shop.ShopInfoToString();
    }
}