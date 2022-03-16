using System;
using System.Collections.Generic;

namespace CSharpStudy {
    public class GMethod {
        // #1. Generic Method
        public static string Print1DArray<T>(T[] array) {
            string result = "";
            ushort temp1 = 1;
            result += ("{ ");
            foreach (T item in array) {
                if (temp1 == array.Length)
                    result += ($"{item} }}");
                else
                    result += ($"{item}, ");
                temp1++;
            }
            return result;
        }
    }

    // #2. Generic Class & #3-1. Generic type Constraint (where T : struct - 'T' must be value type)
    public class RabbitArray<T> : GMethod, System.Collections.IEnumerable where T : struct {
        private T[] array_data;
        public RabbitArray() {  }
        public RabbitArray(T[] array) { this.array_data = array; }
        public void SetArray(T[] array) {
            this.array_data = array;
            return;
        }
        public T[] GetArray() {
            return array_data;
        }
        public System.Collections.IEnumerator GetEnumerator() {
            for (int i = 0; i < this.array_data.Length; i++)
                yield return this.array_data[i];
        }
        // #3-2. Generic type Constraint (where T : new() - class 'T' must have default initializer)
        public static Type CreateInstance<Type>() where Type : new() {
            return new Type();
        }
    }

    public class Generic {
        public static void Main(string[] args) {
            Console.WriteLine("[ #1. Generic Method ]");
            int[] temp1 = { 1, 2, 3, 4, 5, 6 };
            string[] temp2 = { "apple", "banana", "carrot", "dragonfruit" };
            Console.WriteLine("  - int[] temp1 \t\t= " + GMethod.Print1DArray<int>(temp1));
            Console.WriteLine("  - string[] temp2 \t\t= " + GMethod.Print1DArray<string>(temp2));

            RabbitArray<int> temp3 = new RabbitArray<int>();
            temp3.SetArray(temp1);

            Console.WriteLine("  - RabbitArray<int> temp3 \t= " + GMethod.Print1DArray<int>(temp3.GetArray()));

            // #4. Generic collections (List<T>, Queue<T>, Stack<T>, Dictionary<Tkey, Tvalue>)

            // Program exit
            Console.WriteLine("\n\n[?] Press any key to exit... ");
            Console.ReadKey();
            return;
        }
    }
}