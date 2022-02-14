using System;

namespace CSharpStudy {
    class handlingString {
        static void Main(String[] args) {

            // #1. Search (Be aware that index number starts from 0. Case-sensitive.)
            string str1 = "Hello! This is 악동분홍토끼(@pinkrabbit412).";
            Console.WriteLine("[?] str1 = " + str1 + "\n");
            Console.WriteLine("  [ #1. Search ]");
            Console.WriteLine("  str1.IndexOf(\"@\")\t\t= " + str1.IndexOf("@"));  // Search from the beginning of string
            Console.WriteLine("  str1.LastIndexOf(\"s\")\t\t= " + str1.LastIndexOf("s"));  // Search from the end of string
            Console.WriteLine("  str1.StartsWith(\"Hello\")\t= " + str1.StartsWith("Hello"));
            Console.WriteLine("  str1.EndsWith(\"?\")\t\t= " + str1.EndsWith("?"));
            Console.WriteLine("  str1.Contains(\"rabbit\")\t= " + str1.Contains("rabbit"));
            Console.WriteLine("  str1.Replace(\"s\", \"?\")\t= " + str1.Replace("s", "?"));  // Return result that all matching case has been replaced

            // #2. Modify
            string str2 = "  Nice to meet you here!  ";
            Console.WriteLine("\n\n[?] str2 = " + str2 + "\n");
            Console.WriteLine("  [ #2. Modify ]");
            Console.WriteLine("  str2.ToLower() \t\t= \"" + str2.ToLower() + "\"");
            Console.WriteLine("  str2.ToUpper() \t\t= \"" + str2.ToUpper() + "\"");
            Console.WriteLine("  str2.Insert(24, \":)\") \t= \"" + str2.Insert(25, ":)") + "\"");
            Console.WriteLine("  str2.Remove(18, 5) \t\t= \"" + str2.Remove(18, 5) + "\"");  // Remove some characters from specified location
            Console.WriteLine("  str2.Trim() \t\t\t= \"" + str2.Trim() + "\"");
            Console.WriteLine("  str2.TrimStart() \t\t= \"" + str2.TrimStart() + "\"");
            Console.WriteLine("  str2.TrimEnd() \t\t= \"" + str2.TrimEnd() + "\"");

            // #3. Split
            string str3 = "악동분홍토끼;pinkrabbit412;https://github.com/pinkrabbit412";
            string str4 = "AkdongRabbit";
            Console.WriteLine("\n\n[?] str3 = " + str3);
            Console.WriteLine("[?] str4 = " + str4 + "\n");
            Console.WriteLine("  [ #3. Split ]");
            Console.Write    ("  str3.Split(';') \t\t= "); string[] arr = str3.Split(';');
            int temp1 = 1;
            foreach(string splitResult in arr) {
                string returnValue = (arr.Length == temp1) ? splitResult + "\n": splitResult + ", ";
                Console.Write(returnValue);
                temp1++;
            }
            Console.WriteLine("  str4.SubString(0, 2) \t\t= " + str4.Substring(0, 6));
            Console.WriteLine("  str4.SubString(6) \t\t= " + str4.Substring(6));

            // #4. Formatting (More format specifier at MSDN)
            string str5 = "★★★★★";
            Console.WriteLine("\n\n[?] str5 = " + str5 + "\n");
            Console.WriteLine("  [ #4. string.Format() ]");
            Console.WriteLine("  string.Format(\"{{0, 10}}STAR\", str5) \t= \" {0}", string.Format("{0, 10}STAR", str5) + "\"");  // {_____★★★★★}STAR
            Console.WriteLine("  string.Format(\"{{0, -10}}STAR\", str5) \t= \" {0}", string.Format("{0, -10}STAR", str5) + "\"");  // {★★★★★_____}STAR
            Console.WriteLine("  0xFF to Decimal \t\t\t= {0:d4}", 0x000000FF);
            Console.WriteLine("  255 to Hexadecimal \t\t\t= 0x{0:x4}", 255);
            Console.WriteLine("  1847960, Comma-separated \t\t= {0:n0}", 1847960);
            Console.WriteLine("  3.141592, Float format \t\t= {0:f6}", 3.141592f);
            Console.WriteLine("  3.141592, Percent format \t\t= {0:p3}", 3.141592f);

            DateTime now_datetime = DateTime.Now;
            Console.WriteLine("  DateTime.Now \t\t\t\t= {0:yyyy년 M월 d일 (ddd), tt hh시 mm분 ss초}", now_datetime);


            // #5. Interpolation
            Console.WriteLine();
            int hour_data = now_datetime.Hour, minute_data = now_datetime.Minute, second_data = now_datetime.Second;
            Console.WriteLine($"  [?] Time : {hour_data}시 {minute_data}분 {second_data}초");

            // Program exit
            Console.WriteLine("\n\n[?] Press any key to exit... ");
            Console.ReadKey();
            return;
        }
    }
}