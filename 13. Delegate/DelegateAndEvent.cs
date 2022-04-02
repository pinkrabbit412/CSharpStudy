using System;
using System.Collections;

namespace CSharpStudy {
    public class RabbitArray : IEnumerable {
        private int[] array;
        public int this[int index] {
            get { return array[index]; }
            set {
                Array.Resize<int>(ref array, index + 1);
                array[index] = value;
            }
        }
        // Skipping boolean MoveNext(), void Reset(), Object Current { get; }
        public IEnumerator GetEnumerator() {
            for (int i = 0; i < array.Length; i++)
                yield return array[i];
        }
        public int Length {
            get { return array.Length; }
        }
        public static string PrintArrayAsOneDimensional(Array array) {
            int temp1 = 1;
            string result = "{ ";
            foreach (var temp2 in array) {
                if (temp1 == array.Length)
                    result += (temp2 + " }");
                else
                    result += (temp2 + ", ");
                temp1++;
            }
            return result;
        }
    }
    public delegate int IntegerDelegateExample(int a, int b);
    public class ExampleClass {
        public static int Plus(int a, int b) { return a + b; }
        public static int Minus(int a, int b) { return a - b;  }
        public static int Comparer_Ascend(int a, int b) {
            if (a > b)
                return 1;
            else if (a < b)
                return -1;
            else
                return 0;
        }
        public static int Comparer_Descend(int a, int b) {
            if (a > b)
                return -1;
            else if (a < b)
                return 1;
            else
                return 0;
        }
        public static void BubbleSort(int[] data, IntegerDelegateExample Comparer) {
            int temp = 0;
            for(int i = 0; i < (data.Length - 1); i++) {
                for(int j = 0; j < data.Length - (i + 1); j++) {
                    if (Comparer(data[j], data[j + 1]) > 0) {
                        temp = data[j + 1];
                        data[j + 1] = data[j];
                        data[j] = temp;
                    }
                }
            }
        }
    }
    public class DelegateAndEvent {
        public static void Main(string[] args) {
            // #1. Easy delegate example
            IntegerDelegateExample callback1;
            callback1 = new IntegerDelegateExample(ExampleClass.Plus);
            Console.WriteLine("[?] callback(5, 7) = {0}", callback1(5, 7));

            // #2. Passing delegate to function as parameter
            int[] array = { 1, 7, 2, 5, 3, 9, 6, 8, 0, 4};
            Console.WriteLine("정렬 전 = " + RabbitArray.PrintArrayAsOneDimensional(array));
            ExampleClass.BubbleSort(array, ExampleClass.Comparer_Ascend);
            Console.WriteLine("정렬 후 (오름차순) = " + RabbitArray.PrintArrayAsOneDimensional(array));
            ExampleClass.BubbleSort(array, ExampleClass.Comparer_Descend);
            Console.WriteLine("정렬 후 (내림차순) = " + RabbitArray.PrintArrayAsOneDimensional(array));

            // Program exit
            Console.WriteLine("\n\n[?] Press any key to exit... ");
            Console.ReadKey();
            return;
        }
    }
}