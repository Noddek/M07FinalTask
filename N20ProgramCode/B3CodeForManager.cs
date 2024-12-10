using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M07FinalTask.N05Orders;

namespace M07FinalTask.N20ProgramCode
{
    /// <summary>
    /// The static class with program code for manager
    /// </summary>
    public static class CodeForManager
    {
        // FIELDS & PROPERTIES
        // Creating a test manager profile

        // METHODS
        public static void ManagerServiceMenu()
        {
            // GREETING THE MANAGER
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nDear manager, please select a menu option from the list: \n\t1. View all orders. \n\t2. [NOT IMPLEMENTED]\n");
            Console.ResetColor();

            for (byte i = 0, k = 5; i <= k; ++i)
            {
                Console.Write("\t");
                byte managerMenuChoice = 0;
                if (byte.TryParse(Console.ReadLine(), out managerMenuChoice) && (managerMenuChoice == 1))
                {
                    foreach (Order order in AllOrders.GetAllOrdersCollection().AllOrdersCollection)
                    {
                        order?.DisplayFullInfo();
                    }
                    break;
                }
                else if (i == k)
                {
                    Console.WriteLine($"\tToo many tries. The program closes and will be restarted.\n");
                    GeneralStuff.PauseAndRestartTheProgram(10);
                }
                else
                {
                    Console.WriteLine($"\tPlease enter the correct number ({k - i} more tries left).");
                }
            }
        }
    }
}
