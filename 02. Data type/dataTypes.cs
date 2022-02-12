using System;

namespace CSharpStudy {
    class DataTypes {
        enum U { UA, UB, UC = 10, UD, UE } // Enumerator, {UA, UB, UC, UD, UE} = {0, 1, 10, 11, 12}
        static void Main(String[] args) {
            // Do not store too low or too high value being out of range in variables, this will cause overflow
            // Skipping nint, nuint in here
            // [*Ref. type] Reference type. Locates at heap memory, deep copy recommended.
            byte A = 1;                     // 1byte, 0 ~ 255
            sbyte B = -2;                   // 1byte, -128 ~ 127 (Signed byte) / Be aware of Two's Complement
            short C = -32132;               // 2byte, -32768 ~ 32767
            char D = 'S';                   // 2byte, '\0'((char)0) ~ '￿'((char)65535) (Single Character, almost same as Unsigned short)
            ushort E = 25565;               // 2byte, 0 ~ 65535 (Unsigned short)
            int F = -2146990412;            // 4byte, -2147483648 ~ -2147483647 (Integer)
            uint G = 4242424242;            // 4byte, 0 ~ 4294967295 (Unsigned Integer)
            float H = 3.1415926535897932f;  // 4byte, Ends with 'f', Approximates ±1.5 x 10^−45 ~ ±3.4 x 10^38 for 7 digits max
            long I = -921012921012921012;   // 8byte, -922337203685477508 ~ 922337203685477507
            ulong J = 18181818181818181818; // 8byte, 0 ~ 18446744073709551615
            double K = 3.1415926535897932;  // 8byte, Approximates 	±5.0 × 10^−324 ~ ±1.7 × 10^308 for 15 digits max

            decimal L = 3.14159265358979323846264338327m;  // 16byte, Ends with 'm', Approximates 	±1.0 x 10^-28 ~ ±7.9228 x 10^28 for 29 digits max
            string M = "Bye!";            // 2n byte (1 character uses 2byte)
            bool N = true;

            object O = L;                   // [*Ref. type] Put decimal data to object O using "Boxing"
            object P = (float)H;            // [*Ref. type] Put Object O to Object P with float typecasting ("Unboxing")

            int Q = int.Parse("1234");      // Parse string format to int
            float R = float.Parse("12.34"); // Parse string to float
            string S = Q.ToString();        // [*Ref. type] Parse int to string

            const int T = 999;              // Constants (Can't change value)
            // Enumerator at outside of Main function
            int? V = null;                  // Nullable 

            var W = I;                      // Only for local variable

            System.Int32 X = 990412;        // CTS standard

            string Y = M; M = "Hello!";     // This line shows deep copy of string.

            Console.WriteLine("byte A \t\t= " + A);
            Console.WriteLine("sbyte B \t= " + B);
            Console.WriteLine("short C \t= " + C);
            Console.WriteLine("char D \t\t= " + D + " (Integer value = " + (int)D + ")");
            Console.WriteLine("ushort E \t= " + E);
            Console.WriteLine("int F \t\t= " + F);
            Console.WriteLine("uint G \t\t= " + G);
            Console.WriteLine("float H \t= " + H + " (Rounded at 8th digit)");
            Console.WriteLine("long I \t\t= " + I);
            Console.WriteLine("ulong J \t= " + J);
            Console.WriteLine("double K \t= " + K + " (Rounded at 16th digit)");
            Console.WriteLine("decimal L \t= " + L + " (Rounded at 30th digit)");
            Console.WriteLine("string M \t= " + M + " (Value has been changed to \"Hello!\" before deep copy)");
            Console.WriteLine("bool N \t\t= " + N);
            Console.WriteLine("object O \t= " + O + " (Original data: L)");
            Console.WriteLine("object P \t= " + P + " (Original data: (float)O)");
            Console.WriteLine("int Q \t\t= " + Q + " (Original data: int.Parse(\"1234\"))");
            Console.WriteLine("float R \t= " + R + " (Original data: float.Parse(\"12.34\"))");
            Console.WriteLine("string S \t= " + S + " (Original data: Q.ToString())");
            Console.WriteLine("const int t \t= " + T);
            Console.WriteLine("enum U \t\t= { " + U.UA + ", " + U.UB + ", " + U.UC + ", " + U.UD + ", " + U.UE + " }");
            Console.WriteLine("int? V \t\t= " + V);
            Console.WriteLine("var W \t\t= " + W + " (" + W.GetType() + ")");
            Console.WriteLine("System.Int32 X \t= " + X + " (" + X.GetType() + ")");
            Console.WriteLine("string Y \t= " + Y + " (Deep-copied: M)");

            // Program exit
            Console.WriteLine("\n[?] Press any key to exit... ");
            Console.ReadKey();
            return;
        }
    }
}
