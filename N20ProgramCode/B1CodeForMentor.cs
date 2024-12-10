using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace M07FinalTask.N20ProgramCode
{
    /// <summary>
    /// The static class with program code for mentor
    /// </summary>
    public static class CodeForMentor
    {
        public static void HelloMentor()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\nHello, Dmitry! \n\tBelow is an attempt to read from the text README file, hopefully it works on your side.\n");
            Console.ResetColor();

            // I don't know yet how reading from a file, etc. works.
            // I just copied the code from the page:
            // https://learn.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/read-write-text-file
            // and modified it a little bit.

            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("..\\..\\..\\README.md");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.Write($"\n...Press ENTER to continue...\n");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                GeneralStuff.Pause(5);
            }           
            Start.StartTheProgram();
        }
    }
}
