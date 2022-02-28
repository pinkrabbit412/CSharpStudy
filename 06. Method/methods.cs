using System;

namespace CSharpStudy {
    class Calculator {
        int calcTemp1 = 999;
        public static int sum(int a, int b = 0) { return a + b; }  // b's default value is 0. (Optional arguments)
        public static double sum(double a, double b) { return a + b; }  // Method overlodaing
        public static int sumAll(params int[] a) {  // 'params' keyword
            int result = 0;
            foreach (int temp1 in a)
                result += temp1;
            return result;
        } 
        public static int diff(int a, int b) {
            int temp = a - b;
            if (temp < 0)
                temp *= (-1);
            return temp;
        }
        public static void divide(
            int a, int b, out int quotient, out int remainder) {
            quotient = a / b;
            remainder = a % b;
            return;
        }
        public ref int getTemp1() { return ref calcTemp1; }
    }
    class Methods {
        public static void Main(string[] args) {
            Console.Write("  [?] Sum of 5 and 9 = ");
            Console.Write(Calculator.sum(5, 9));
            Console.Write("\n  [?] Difference of 5 and 9 = ");
            Console.Write(Calculator.diff(5, 9));

            Calculator calc = new Calculator();
            ref int temp1 = ref calc.getTemp1();
            Console.WriteLine("\n\n<ref int temp1 = ref calc.getTemp1();>");
            Console.WriteLine("  [?] ref int temp1 = {0}, calc.getTemp1() = {1}", temp1, calc.getTemp1());
            Console.WriteLine("\n<Changing only temp1 to 999999>");
            temp1 = 999999;
            Console.WriteLine("  [?] ref int temp1 = {0}, calc.getTemp1() = {1}\n\n", temp1, calc.getTemp1());

            int temp2 = 19990412, temp3 = 7, temp4 = 0, temp5 = 0;
            Calculator.divide(a: temp2, b: temp3, remainder: out temp5, quotient: out temp4);  // Using named arguments
            Console.WriteLine("  [?] {0} / {1} = {2} and {3}", temp2, temp3, temp4, temp5);

            // Program exit
            Console.WriteLine("\n\n[?] Press any key to exit... ");
            Console.ReadKey();
            return;
        }
    }
}