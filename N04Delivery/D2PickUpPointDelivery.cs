using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using M07FinalTask.N01RawData;

namespace M07FinalTask.N04Delivery;

/// <summary>
/// The class for working with pick-up point delivery that implements the interface IDelivery
/// </summary>
public class PickUpPointDelivery : IDelivery
{
    // FIELDS

    /// <summary>
    /// The field contains an array of pick-up points that can be used for PickUpPointDelivery
    /// </summary>
    public static PickUpPoint[] pickUpPointsForPickUpPointDelivery = RawData.CreatePickUpPoints();

    // PROPERTIES
    public string Type { get { return "Pick-up point delivery"; } }
    public DateTime? SendingDate { get; set; }
    public DateTime? FinishDate { get; set; }
    public PickUpPoint PickUpPoint { get; private set; }

    // CONSTRUCTOR
    public PickUpPointDelivery(PickUpPoint pickUpPoint)
    {
        PickUpPoint = pickUpPoint;
    }

    // METHODS

    // 1. Static
    public static PickUpPointDelivery CreatePickUpPointDelivery()
    {
        Console.WriteLine("\n\tSelect the desired pick-up point from the list below (enter the appropriate number):");
        for (uint i = 0; i <= pickUpPointsForPickUpPointDelivery.GetUpperBound(0); ++i)
        {
            Console.WriteLine($"\t\t{i + 1}. {pickUpPointsForPickUpPointDelivery[i].PickUpPointAddressToString()}");
        }
        Console.WriteLine();
        int selectedPickUpPoint = -1;
        do
        {
            Console.Write($"\t\t");
            if (int.TryParse(Console.ReadLine(), out selectedPickUpPoint) && (1 <= selectedPickUpPoint) && (selectedPickUpPoint <= pickUpPointsForPickUpPointDelivery.Length))
            {
                break;
            }
            else
            {
                Console.WriteLine($"\t\tPlease enter the correct number.");
            }
        } while (true);
        return new PickUpPointDelivery(pickUpPointsForPickUpPointDelivery[selectedPickUpPoint - 1]);
    }

    // 2. Non-static
    public string InfoToString()
    {
        return PickUpPoint.PickUpPointAddressToString();
    }
}