using System;

namespace CSharpStudy {
    delegate int DelegateExample1(int a, int b);
    public class ExampleClass {
        public static int Plus(int a, int b) { return a + b; }
        public static int Minus(int a, int b) { return a - b;  }
    }
    public class DelegateAndEvent {
        public static void Main(string[] args) {
            // #1. Easy delegate example
            DelegateExample1 callback;
            callback = new DelegateExample1(ExampleClass.Plus);
            Console.WriteLine("[?] callback(5, 7) = {0}", callback(5, 7));

            // Program exit
            Console.WriteLine("\n\n[?] Press any key to exit... ");
            Console.ReadKey();
            return;
        }
    }
}