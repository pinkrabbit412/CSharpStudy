using System;
using static System.Console;

namespace CSharpStudy {
    class HelloWorld {
        // Main function
        static void Main(string[] args) {

            // When program argument (string[] args) doesn't exist, Call this
            if(args.Length == 0 || args.Length > 1) {  // When given argument's number is 0 or bigger than 2 (2, 3, 4, ...)
                Console.WriteLine("How to use: ./helloWorld.exe <name>");
                // Program exit
                Console.WriteLine("\n[?] Press any key to exit... ");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Hello, world!");
            Console.WriteLine("And hello, {0}!", args[0]);
            // Program exit
            Console.WriteLine("\n[?] Press any key to exit... ");
            Console.ReadKey();
            return;
        }
    }
}