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
    public delegate int IntegerDelegateExample<T>(T a, T b);
    public delegate void VoidDelegateExample(int a);
    public delegate void EventHandler(string message);
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
        public static int Comparer_Ascend<T>(T a, T b) where T : IComparable<T> => a.CompareTo(b);
        public static int Comparer_Descend<T>(T a, T b) where T : IComparable<T> => -a.CompareTo(b);
        public static void BubbleSort(int[] data, IntegerDelegateExample Comparer) {
            int temp = 0;
            for (int i = 0; i < (data.Length - 1); i++) {
                for (int j = 0; j < data.Length - (i + 1); j++) {
                    if (Comparer(data[j], data[j + 1]) > 0) {
                        temp = data[j + 1];
                        data[j + 1] = data[j];
                        data[j] = temp;
                    }
                }
            }
        }
        public static void BubbleSortGeneric<T>(T[] data, IntegerDelegateExample<T> Comparer) {
            T temp;
            for (int i = 0; i < (data.Length - 1); i++) {
                for (int j = 0; j < data.Length - (i + 1); j++) {
                    if (Comparer(data[j], data[j + 1]) > 0) {
                        temp = data[j + 1];
                        data[j + 1] = data[j];
                        data[j] = temp;
                    }
                }
            }
        }
    }
    public class ExampleClass2 {
        public static void First(int a) => Console.WriteLine($"[?] Integer input = {a}");
        public static void Second(int a) => Console.WriteLine($"  - {a} × {a} = {a*a},");
        public static void Third(int a) => Console.WriteLine($"  - sqrt({a}) ≒ {Math.Sqrt(a)}");
    }
    public class ExampleClass3 {
        public event EventHandler Event1;
        public void SearchForMultipleOf7(int from, int until) {
            for (int i = from; i < until; i++) {
                if ((i % 7) == 0)
                    Event1(String.Format("  - [!] Multiple of seven found! (Number: {0})", i));
            }
        }
    }
    public class DelegateAndEvent {
        public static void EventHandler1(string message) => Console.WriteLine(message);
        public static void Main(string[] args) {
            // #1. Easy delegate example
            IntegerDelegateExample callback1;
            callback1 = new IntegerDelegateExample(ExampleClass.Plus);
            Console.WriteLine("[?] callback(5, 7) = {0}", callback1(5, 7));

            // #2. Passing delegate to function as parameter
            int[] array = { 1, 7, 2, 5, 3, 9, 6, 8, 0, 4};
            Console.WriteLine("Before Sorting = " + RabbitArray.PrintArrayAsOneDimensional(array));
            ExampleClass.BubbleSort(array, ExampleClass.Comparer_Ascend);
            Console.WriteLine("Sorted as Ascending order = " + RabbitArray.PrintArrayAsOneDimensional(array));
            ExampleClass.BubbleSort(array, ExampleClass.Comparer_Descend);
            Console.WriteLine("Sorted as Descending order = " + RabbitArray.PrintArrayAsOneDimensional(array));

            // #3. Passing generic delegate to function as parameter
            double[] array2 = { 1.1, 7.7, 2.2, 5.5, 3.3, 9.9, 6.6, 8.8, 0.0, 4.4 };
            Console.WriteLine("\n\nBefore Sorting = " + RabbitArray.PrintArrayAsOneDimensional(array2));
            ExampleClass.BubbleSortGeneric<double>(array2, ExampleClass.Comparer_Ascend<double>);
            Console.WriteLine("Sorted as Ascending order = " + RabbitArray.PrintArrayAsOneDimensional(array2));
            ExampleClass.BubbleSortGeneric<double>(array2, ExampleClass.Comparer_Descend<double>);
            Console.WriteLine("Sorted as Descending order = " + RabbitArray.PrintArrayAsOneDimensional(array2));

            // #4. Delegate Chain
            VoidDelegateExample IntegerInformation  = new VoidDelegateExample(ExampleClass2.First)
                                                    + new VoidDelegateExample(ExampleClass2.Second)
                                                    + new VoidDelegateExample(ExampleClass2.Third);
            Console.WriteLine("\n");
            IntegerInformation(412);

            // #5. Anonymous method
            IntegerDelegateExample AnonymousMethodExample = delegate (int a, int b) {
                return a + b;
            };
            Console.WriteLine("\n\n[?] AnonymousMethodExample(7, 9) = " + AnonymousMethodExample(7, 9));

            // #6. Event
            Console.WriteLine("\n");
            ExampleClass3 exampleClass3 = new ExampleClass3();
            exampleClass3.Event1 += new EventHandler(EventHandler1);
            Console.WriteLine("[?] Range input = 1 ~ 25");
            exampleClass3.SearchForMultipleOf7(1, 25);



            // Program exit
            Console.WriteLine("\n\n[?] Press any key to exit... ");
            Console.ReadKey();
            return;
        }
    }
}