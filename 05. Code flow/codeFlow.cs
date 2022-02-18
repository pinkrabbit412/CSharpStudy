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
            while (temp3 <= 5) {
                Console.Write(temp3);
                temp3++;
            }
            temp3 = 1;
            do {
                Console.Write(temp3);
                temp3++;
            } while (temp3 <= 5);

            // Program exit
        end_of_program:
            Console.WriteLine("\n\n[?] Press any key to exit... ");
            Console.ReadKey();
            return;
        }
    }
}