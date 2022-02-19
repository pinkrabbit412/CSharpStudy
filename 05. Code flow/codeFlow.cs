using System;

namespace CSharpStudy {
    class CodeFlow {
        public static void Main(string[] args) {

            // #1. if(), else if(), else()
            Console.Write("\n[?] Input any natural number as int... >>> ");
            int temp1 = Convert.ToInt32(Console.ReadLine());
 
            if(temp1 > 0) {
                Console.WriteLine("[!] {0} is positive number.", temp1);
            }
            else if(temp1 < 0) {
                Console.WriteLine("[!] {0} is negative number.", temp1);
            }
            else {
                Console.WriteLine("[!] {0} is 0.", temp1);
            }

            // #2. switch(), case() + goto
            question_to_end_program:
            Console.Write("\n\n[?] Stop the program? (Y/N) >>> ");
            string temp2 = Console.ReadLine();
            switch(temp2) {
                case "Y":
                case "y":
                    goto end_of_program;
                case "N":
                case "n":
                    break;
                default:
                    Console.Write("[!] Wrong input.");
                    goto question_to_end_program;
            }

            // #3. while()
            int temp3 = 1;
            Console.Write("\n\n[?] while(): ");
            while(++temp3 <= 5)
                Console.Write(temp3);
            Console.Write("\n[?] do while(): ");
            temp3 = 1;
            do {
                Console.Write(temp3);
            } while(++temp3 <= 5);

            // #4. for()
            Console.Write("\n[?] for(): ");
            for (int temp4 = 1; temp4 <= 5; temp4++)
                Console.Write(temp4);

            // #5. foreach()
            int[] temp5 = new int[]{ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.Write("\n[?] int[] temp5 with for(): ");
            foreach(int temp6 in temp5)
                Console.Write(temp6);

            // #6. continue
            Console.Write("\n[?] int[] temp5 with for(), only odd-numbers: ");
            foreach (int temp6 in temp5) {
                if (temp6 % 2 == 0)
                    continue;
                Console.Write(temp6);
            }

            // #7. try, catch(), throw, break
            Console.Write("\n[?] int[] temp5 with for(): ");
            for (int temp7 = 0;; temp7++) {
                try {
                    if (temp7 < 0 || temp7 > temp5.Length)
                        throw new IndexOutOfRangeException();
                    Console.Write(temp5[temp7]);
                }
                catch(IndexOutOfRangeException error) {
                    Console.WriteLine("\n[!] " + error);
                    break;
                }
            }

            // Program exit & return (End function and return some value)
            end_of_program:
            Console.WriteLine("\n\n[?] Press any key to exit... ");
            Console.ReadKey();
            return;
        }
    }
}