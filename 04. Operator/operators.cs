using System;

namespace CSharpStudy {
    class Operators {
        public static void Main(string[] args) {
            /*
             * A. Skipping operator that is too easy
             * B. Operator priority =   #2(postfix) #6 > #2(prefix) > #1(*,/,%) > #1(+,-) > #7(<<,>>)
             *                          > #3(<,>,<=,>=,is,as) > #3(==,!=) > #7(&) > #7(^) > #7(|)
             *                          > #4(&&) > #4(||) > #9(??) > #6(?.) > #8
            */
            int rouble = 1, dollar = 126, euro = 144;  // ₽, $, € / Tarkov value

            // #1. Arithmetic operator (+, -, *, /, %)
            Console.WriteLine("[Tarkov] {0}EUR = {1}USD and {2}RUB", 1, euro/dollar, euro%dollar);

            // #2. Increment operator & Decrement operator (++, --)
            int temp1 = 10;
            Console.WriteLine("\n\n[?] temp1 = " + temp1);
            Console.WriteLine("  {0} (++temp1)", ++temp1);  // Increase 1, and print it
            Console.WriteLine("  {0} (temp1--)\n\n", temp1--);  // Print it, and decrease 1

            // #3. Relational operator (>, <, <=, >=, ==, !=)
            // #4. Logical operator (&&(and), ||(or), !(not))
            // #5. Conditional operator (Ternary operator)
            string temp2 = "";
            temp2 = euro > dollar ? "[Tarkov] 1EUR is more expensive than 1USD" : "[Tarkov] 1USD is more expensive than 1EUR";
            Console.WriteLine(temp2);

            // #6. Null-conditional operator (?.)
            string temp3 = null;
            Console.WriteLine("\n\n[?] temp3 = " + temp3 + " (NULL)");
            Console.WriteLine("  temp3?.IndexOf(\"?\") \t= {0}\n", temp3?.IndexOf("?"));
            temp3 = "Hello? Anybody here?";
            Console.WriteLine("[?] temp3 = " + temp3);
            Console.WriteLine("  temp3?.IndexOf(\"?\") \t= {0}\n\n", temp3?.IndexOf("?"));

            // #7. Bit operator (<<(Shift left), >>(Shift right), &(AND), |(OR), ^(XOR), ~(NOT))
            Console.WriteLine("  {0} & {1} = {2}", true, false, true & false);
            Console.WriteLine("  {0} | {1} = {2}", true, false, true | false);
            Console.WriteLine("  {0} ^ {1} = {2}", true, false, true ^ false);
            Console.WriteLine("  {0} >> {1} = {2}", 256, 2, 256 >> 2);
            Console.WriteLine("  ~({0} >> {1}) = {2}", 256, 2, ~(256 >> 2));

            // #8. Assignment operator (=, +=, -=, *=, /=, %=, &=, |=, ^=, <<=, >>=)
            // #9. Nullish coalescing operator (??)
            string temp4 = null;
            Console.WriteLine("\n\n[?] temp4 = " + temp4 + " (NULL)");
            Console.WriteLine("  temp4 ?? \"NULL VALUE\" \t= {0}", temp4 ?? "NULL VALUE");
            temp4 = "NURUNGJI";
            Console.WriteLine("\n[?] temp4 = " + temp4);
            Console.WriteLine("  temp4 ?? \"NULL VALUE\" \t= {0}", temp4 ?? "NULL VALUE");

            // Program exit
            Console.WriteLine("\n\n[?] Press any key to exit... ");
            Console.ReadKey();
            return;
        }
    }
}