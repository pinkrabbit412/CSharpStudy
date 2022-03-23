using System;

namespace CSharpStudy {
    public class RabbitException : Exception {}

    public class Exceptions {
        public static void Main(string[] args) {
            // #1. try - catch(for all exceptions)
            Console.WriteLine("[ #1. Try to divide by 0 ]");
            try {
                int temp1 = 5;
                temp1 /= 0;
            }
            catch (Exception exception) {  // This 'catch' catches DivideByZeroException
                Console.WriteLine("  [!] Error has been occured.\n  - Error message: " + exception);
            }

            // #2. try - catch(for targeted exceptions)
            Console.WriteLine("\n\n[ #2. Try to access outer range of array ]");
            try {
                int[] temp1 = new int[0] { };
                temp1[1] = 0;
            }
            catch (IndexOutOfRangeException exception) {
                Console.WriteLine("  [!] Error has been occured.\n  - Error message: " + exception);
            }

            // #3. try(throw) - catch
            Console.WriteLine("\n\n[ #3. Throw a new exception ]");
            try {
                throw new Exception("This is a new exception for code testing. ");
            }
            catch (Exception exception) {
                Console.WriteLine("  [!] Error has been occured.\n  - Error message: " + exception);
            }

            // #4. try - catch - finally
            Console.WriteLine("\n\n[ #4. Throw a new exception, and print end message. ]");
            try {
                throw new Exception("This is a new exception for code testing. ");
            }
            catch (Exception exception) {
                Console.WriteLine("  [!] Error has been occured.\n  - Error message: " + exception);
            }
            finally {  // This will be always executed when #4's try executes.
                Console.WriteLine("  - Part #4 has been ended.");
            }

            // #5. try - catch(for custom exceptions)
            Console.WriteLine("\n\n[ #5. Throw a new custom exception. ]");
            try {
                throw new RabbitException();
            }
            catch (RabbitException exception) {
                Console.WriteLine("  [!] Error has been occured.\n  - Error message: " + exception);
            }

            // #6. try - catch(includes 'when' conditions)
            Console.WriteLine("\n\n[ #6. Catch exceptions with conditions (catch-when). ]");
            int input_int = 0;
            try {
                Console.Write("  Input 1 natural number. (1~10) >> ");
                input_int = int.Parse(Console.ReadLine());
                if (input_int > 10 || input_int < 0)
                    throw new RabbitException();
                Console.WriteLine("  - Natural number: {0}", input_int);
            }
            catch (RabbitException) when (input_int > 10) {
                Console.WriteLine("  [!] Error has been occured. Value is too high. (> 10).");
            }
            catch (RabbitException) when (input_int < 0) {
                Console.WriteLine("  [!] Error has been occured. Value is too low. (< 0)");
            }
            catch {
                Console.WriteLine("  [!] Input value is invalid. Try 1~10 (Natural number only)");
            }

            // Program exit
            Console.WriteLine("\n\n[?] Press any key to exit... ");
            Console.ReadKey();
            return;
        }
    }
}