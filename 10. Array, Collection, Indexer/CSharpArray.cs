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
        public static string PrintArrayAsOneDimensional(RabbitArray array) {
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
        public static string Print2DIntegerArray(int[,] array) {
            string result = "\n";
            for (int i = 0; i < array.GetLength(0); i++) {
                for (int j = 0; j < array.GetLength(1); j++)
                    result += ( Convert.ToString(array[i, j]) + " " );
                result += "\n";
            }
            return result;
        }
        public static string Print3DIntegerArray(int[,,] array) {
            string result = "\n";
            for (int i = 0; i < array.GetLength(0); i++) {
                int j = 0;
                for (; j < array.GetLength(1); j++) {
                    for (int k = 0; k < array.GetLength(2); k++)
                        result += ( Convert.ToString(array[i, j, k]) + " " );
                    if (i + 1 == array.GetLength(0) && j + 1 == array.GetLength(1))
                        continue;
                    else
                        result += ", ";
                }     
                result += "\n";
            }
            return result;
        }
        public static void Print(int value) {
            Console.Write(value + " ");   
        }
        public static bool BiggerThan3(int number) {
            return number > 3; 
        }
    }
    public class CSharpArray {
        public static void Main(string[] args) {
            // #1. Declare and Initialize Array
            int[] arr1 = new int[5] { 5, 3, 1, 2, 4 };  // #1-1.
            int[] arr2 = new int[] { 6, 7, 8, 9, 10 };  // #1-2. Normal way
            int[] arr3 = { 11, 12, 13, 14, 15 };  // #1-3. Simplest way

            // #2. Using System.Array
            Console.WriteLine("[?] int[] arr1 = " + RabbitArray.PrintArrayAsOneDimensional(arr1));
            Console.WriteLine("[?] int[] arr1 = " + RabbitArray.PrintArrayAsOneDimensional(arr2));
            Console.WriteLine("[?] int[] arr1 = " + RabbitArray.PrintArrayAsOneDimensional(arr3));
            Array.Sort(arr1);
            Console.WriteLine("\n<Sorting arr1[]...>\n");
            Console.WriteLine("    - int[] arr1 = " + RabbitArray.PrintArrayAsOneDimensional(arr1));
            Console.WriteLine("    - Array.IndexOf(arr1, 4) = {0}", Array.IndexOf(arr1, 4));
            Console.WriteLine("    - Array.TrueForAll<int>(arr1, RabbitArray.BiggerThan3) = {0}", Array.TrueForAll<int>(arr1, RabbitArray.BiggerThan3));
            Console.WriteLine("    - Array.FindIndex<int>(arr1, RabbitArray.BiggerThan3) = {0}", Array.FindIndex<int>(arr1, RabbitArray.BiggerThan3));
            Console.Write("    - Array.ForEach<int>(arr1, new Action<int>(RabbitArray.Print)) = ");
            Array.ForEach<int>(arr1, new Action<int>(RabbitArray.Print));
            Console.WriteLine("\n    - arr1.Length() = {0}", arr1.Length);
            Console.WriteLine("    - arr1.Rank() = {0} (Dimension)", arr1.Rank);

            // #3. 2nd Dimension Array
            /*
             *  arr4 == arr5 == arr6 =  │ 1 │ 2 │ 3 │
             *                          │ 4 │ 5 │ 6 │
             */
            int[,] arr4 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };  // #1-1.
            int[,] arr5 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };  // #1-2. Normal way
            int[,] arr6 = { { 1, 2, 3 }, { 4, 5, 6 } };  // #1-3. Simplest way
            Console.WriteLine("\n[?] int[] arr1 = " + RabbitArray.Print2DIntegerArray(arr4));
            Console.WriteLine("    - arr4.Length() = {0}", arr4.Length);
            Console.WriteLine("    - arr4.Rank() = {0} (Dimension)", arr4.Rank);

            // #4. N-th Dimension Array
            int[,,] arr7 = new int[2, 2, 2] {
                { { 1, 2 }, { 3, 4 } },
                { { 5, 6 }, { 7, 8 } }
            };
            Console.WriteLine("\n[?] int[] arr1 = " + RabbitArray.Print3DIntegerArray(arr7));

            // #5. Jagged Array
            int[][] arr8 = new int[][] {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 }
            };
            int temp1 = 0;
            foreach (int[] arr in arr8) {
                Console.WriteLine("[?] int[][{0}] arr8 = {1}", temp1, RabbitArray.PrintArrayAsOneDimensional(arr));
                temp1++;
            }

            // #6-1. ArrayList (NEED: using System.Collections;)
            ArrayList list1 = new ArrayList();
            list1.Add(10);
            list1.Add(11);
            list1.Add(12);
            list1.RemoveAt(1); //Deletes 11
            list1.Insert(1, 11);

            // #6-2. Queue
            Queue que1 = new Queue();
            que1.Enqueue(10);
            que1.Enqueue(11);   
            que1.Enqueue(12);
            que1.Dequeue();  // Returns 10, and delete 10
            que1.Dequeue();  // Returns 11, and delete 11
            que1.Dequeue();  // Returns 12, and delete 12

            // #6-3. Stack
            Stack stack1 = new Stack();
            stack1.Push(10);
            stack1.Push(11);
            stack1.Push(12);
            stack1.Pop();  // Returns 12, and delete 12
            stack1.Pop();  // Returns 11, and delete 11
            stack1.Pop();  // Returns 10, and delete 10

            // #6-4. Hashtable (Same as Python's Dictionary type)
            Hashtable hashtable1 = new Hashtable();
            hashtable1["First"] = 10;
            hashtable1["Second"] = 11;
            hashtable1["Third"] = 12;
            /* or,
                Hashtable hashtable1 = new Hashtable() {
                    ["First"] = 10,
                    ["Second"] = 11,
                    ["Third"] = 12,
            };
             */

            // #7. Create Collection(ArrayList, Stack, Queue) from Array
            int[] arr9 = { 10, 11, 12 };
            ArrayList list2 = new ArrayList(arr9);
            Queue que2 = new Queue(arr9);
            Stack stack2 = new Stack(arr9);

            // #8. Indexer
            RabbitArray rarr1 = new RabbitArray();
            rarr1[0] = 1;
            rarr1[1] = 2;
            rarr1[2] = 3;
            Console.WriteLine("\n[?] RabbitArray rarr1 = " + RabbitArray.PrintArrayAsOneDimensional(rarr1));
            Console.WriteLine("    - arr4.Length() = {0}", rarr1.Length);
            rarr1[3] = 4;
            Console.WriteLine("\n<Added '4' to rarr[3]...>");
            Console.WriteLine("\n[?] RabbitArray rarr1 = " + RabbitArray.PrintArrayAsOneDimensional(rarr1));
            Console.WriteLine("    - arr4.Length() = {0}", rarr1.Length);


            // Program exit
            Console.WriteLine("\n\n[?] Press any key to exit... ");
            Console.ReadKey();
            return;
        }
    }
}