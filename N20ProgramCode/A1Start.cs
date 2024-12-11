using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M07FinalTask.N20ProgramCode
{
    /// <summary>
    /// The static class for program start control
    /// </summary>
    public static class Start
    {
        // METHODS

        public static void StartTheProgram()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPlease select the role (enter the appropriate number): \n\n\t1. I'm the mentor. \n\t2. I'm a customer. \n\t3. I'm a store manager.\n");
            Console.ResetColor();

            byte startStep = 0;
            for (byte i = 0, j = 5; i <= j; ++i)
            {
                Console.Write("\t");
                if (byte.TryParse(Console.ReadLine(), out startStep) && (startStep == 1 || startStep == 2 || startStep == 3))
                {
                    switch (startStep)
                    {
                        case 1: CodeForMentor.HelloMentor(); break;
                        case 2: CodeForCustomer.ProductOrdering(); break;
                        case 3: CodeForManager.ManagerServiceMenu(); break;
                        default: Console.WriteLine($"Wrong number. The program is closed."); break;
                    }
                    break;
                }
                else if (i == j)
                {
                    Console.WriteLine($"\tToo many tries. The program is closed.");
                }
                else
                {
                    Console.WriteLine($"\tEnter a number between 1 and 3 ({j - i} more tries left).");
                }
            }
        }
    }
}
