using System;

namespace CSharpStudy {
    class DataTypes {
        static void Main(String[] args) {
            // Do not store too low or too high value being out of range in variables, this will cause overflow
            // Skipping nint, nuint in here
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
            string M = "Hello!";            // 2n byte (1 character uses 2byte)
            bool N = true;

            object O = L;                   // Put decimal data to object O using "Boxing"
            object P = (float)O;            // Put Object O to Object P with float typecasting ("Unboxing")

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
            Console.WriteLine("string M \t= " + M);
            Console.WriteLine("bool N \t= " + N);

            // Program exit
            Console.WriteLine("\n[?] Press any key to exit... ");
            Console.ReadKey();
            return;
        }
    }
}
