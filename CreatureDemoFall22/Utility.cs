using System;
using System.Collections.Generic;
using System.Text;

namespace CreatureDemoFall22
{
    class Utility
    {
        public delegate void PrintPlatform(string message);
        public static PrintPlatform Print = PrintConsole;

        public static void PrintConsole(string message)
        {
            Console.WriteLine(message);
        }

        public static void PrintWPF (string message)
        {
            //To be added - implement printing in WPF
        }

    }
}
