using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M07FinalTask.N20ProgramCode
{
    /// <summary>
    /// The helper class for general things in program code
    /// </summary>
    public class GeneralStuff
    {
        // Helper methods

        // 1. Method with overloading
        public static void Pause(byte tacts)
        {
            for (byte i = 1; i <= tacts; ++i)
            {
                Thread.Sleep(500);
                Console.Write(".");
            }
            Console.WriteLine();
        }
        public static void Pause(byte tacts, string sign)
        {
            for (byte i = 1; i <= tacts; ++i)
            {
                Thread.Sleep(500);
                Console.Write($"{sign}");
            }
            Console.WriteLine();
        }

        // 2.
        public static void PauseAndRestartTheProgram(byte tacts)
        {
            Pause(tacts);
            Start.StartTheProgram();
        }

        // 3.
        // Task 7. Using of generics
        public class Generics // it is possible to constrain the whole class instead of a method:
                              // <T> where T : class
        {
            // Task 11. Using of generic methods.
            public static bool IsArrayEmpty<T> (T[] someArray) where T : class
            {
                foreach (T i in someArray)
                // with
                // for (uint i = 0; i <= someArray.GetUpperBound(0); ++i) 
                // we have to be sure that the length of the array will not be greater than the uint range
                {
                    if (i != null) { return false; }
                }
                return true;
            }
        }
    }
}
