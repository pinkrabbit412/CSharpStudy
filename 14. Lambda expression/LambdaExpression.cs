using System;
using System.Linq.Expressions;

namespace CSharpStudy {
    delegate int Calculator(int a, int b);
    delegate string SingleStringDelegate(string a);

    public class LambdaExpression {
        public static void Main(string[] args) {

            // #1. Anonymous method with Lambda expression
            Calculator add = (int a, int b) => a + b;
            /* This code does same work with code below:
             * Calculator adder = delegate(int a, int b) {
             *     return a + b;
             * }
             */
            Console.WriteLine($"[?] 4 + 12 = {add(4, 12)}");

            Console.WriteLine();


            // #2. Statement Lambda
            string sample_string = "The brown fox jumps over the lazy dog";
            SingleStringDelegate noSpace = (string input) => {
                string result = "";
                foreach (char i in input) {
                    if (i == ' ')
                        result += '_';
                    else
                        result += i;
                }
                return result;
            };
            sample_string = noSpace(sample_string);
            Console.WriteLine("[?] " + sample_string);

            Console.WriteLine();


            // #3. 'Func', 'Action' Delegate
            Func<int, int, int> subtract = (input1, input2) => input1 - input2;  // The last one is 'out TResult'
            Console.WriteLine("[?] 4 - 12 = " + subtract(4, 12));
            Action<string> PrintUnderbarToStar = (input) => {
                string result = "";
                foreach (char i in input) {
                    if (i == '_')
                        result += '☆';
                    else
                        result += i;
                }
                Console.WriteLine(result);
            };
            Console.Write("[?] ");
            PrintUnderbarToStar(sample_string);

            Console.WriteLine();


            // #4. Expression Tree
            Expression constant_7 = Expression.Constant(7);
            Expression parameter1 = Expression.Parameter(typeof(int), "x");
            Expression parameter2 = Expression.Parameter(typeof(int), "y");

            Expression addi7 = Expression.Add(parameter1, constant_7);  // This means x + 7
            Expression multiply = Expression.Multiply(parameter1, parameter2);  // This means xy

            Expression expression3 = Expression.Add(addi7, multiply);

            Expression<Func<int, int, int>> sample_expression =
                Expression<Func<int, int, int>>.Lambda<Func<int, int, int>>(
                    expression3, new ParameterExpression[] {
                        (ParameterExpression)parameter1,
                        (ParameterExpression)parameter2
                    }
                );
            Expression<Func<int, int, int>> sample_expression_Lambda =
                (x, y) => (x * y) + x + 7;

            Func<int, int, int> compiledExpression1 = sample_expression.Compile();
            Func<int, int, int> compiledExpression2 = sample_expression_Lambda.Compile();
            Console.WriteLine("[?] xy + x + 7 where x = 3, y = 5 → {0}", compiledExpression1(3, 5));
            Console.WriteLine("[?] xy + x + 7 where x = 5, y = 3 → {0}", compiledExpression2(5, 3));


            // Program exit
            Console.WriteLine("\n\n[?] Press any key to exit... ");
            Console.ReadKey();
            return;
        }
    }
}