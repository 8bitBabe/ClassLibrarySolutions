using System;
using UtilityLibraries;

namespace ShowCase
{
    //note: this has a reference to the StringLibrary
    class Program
    {
        static void Main(string[] args)
        {
            int row = 0;

            do
            {
                if (row == 0 || row >= 25)
                    ResetConsole();
                /*the row variable maintains a count of the number of rows of data
                 written to the console window. Whenever is gets to 25, it clears 
                 the console window and displays a prompt to the user to enter a string.
                 Then it indicates wether or not the string starts with an uppercase. If
                 the user hits enter w.out writing anything, the program terminates. */

                string input = Console.ReadLine();
                if (String.IsNullOrEmpty(input)) break;
                Console.WriteLine($"Input: {input} {"Begins with uppercase? ",30}: " +
                                  $"{(input.StartsWithUpper() ? "Yes" : "No")}\n");
                row += 3;
            } while (true);
            return;

            // Declare a ResetConsole local method
            void ResetConsole()
            {
                if (row > 0)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                Console.Clear();
                Console.WriteLine("\nPress <Enter> only to exit; otherwise, enter a string and press <Enter>:\n");
                row = 3;
            }
        }
    }
}
