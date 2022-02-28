using System;

namespace CSharpStudy {
    public class Class1 {
        public int a = 1, b = 2, c = 3;
    }
    public struct Structure1 {
        // You must use 10.0 or upper version to compile this
        public int a, b, c;
        public Structure1(int a, int b, int c) {
            this.a = a; this.b = b; this.c = c;
        }
    }
    public class ClassAndStructure {
        public static void Main (string[] args) {
            Class1 c1 = new Class1();
            Class1 c2 = c1;  // Shallow copy for default

            Structure1 s1 = new Structure1(1, 2, 3);
            Structure1 s2 = s1;  // Deep copy for default

            Console.WriteLine($"[?] {c1.a}, {c1.b}, {c1.c}");
            Console.WriteLine($"[?] {c2.a}, {c2.b}, {c2.c}");
            Console.WriteLine($"[?] {s1.a}, {s1.b}, {s1.c}");
            Console.WriteLine($"[?] {s2.a}, {s2.b}, {s2.c}");

            Console.WriteLine("\n<Changing c2.b and s2.b to 999>\n");

            c2.b = 999;
            s2.b = 999;

            Console.WriteLine($"[?] {c1.a}, {c1.b}, {c1.c}");
            Console.WriteLine($"[?] {c2.a}, {c2.b}, {c2.c}");
            Console.WriteLine($"[?] {s1.a}, {s1.b}, {s1.c}");
            Console.WriteLine($"[?] {s2.a}, {s2.b}, {s2.c}");

            // Program exit
            Console.WriteLine("\n\n[?] Press any key to exit... ");
            Console.ReadKey();
            return;
        }
    }
}