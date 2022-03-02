using System;

// Time limit was 15 min.
namespace RabbitPractice {
    class AkdongRabbit {
        public static void GooGooDan(int a) {
            for (int i = 1; i <= 9; i++) {
                Console.WriteLine("    - {0} × {1} = {2}", a, i, (a * i));
            }
            return;
        }
        public static void factorial(int a) {
            int result = 1; // Can replace this as 'long'
            Console.Write("    > ");
            for (int i = a; a >= 1; a--) {
                if (a == 1) {
                    Console.Write("{0} = ", a);
                    break;
                }
                Console.Write("{0} * ", a);
                result *= a;
            }
            Console.WriteLine(result);
            return;
        }
    }
    struct StudentScore {
        public string student_name;
        private int student_score;
        public StudentScore(string name, int score) {
            student_name = name;
            student_score = score;
        }
        public void PrintStudentInfo() {
            Console.WriteLine("[?] 조회하신 학생의 정보는 다음과 같습니다.");
            Console.WriteLine("  - 이름: {0}, 점수: {1}", this.student_name, this.student_score);
            return;
        }
    }
    class Program {
        static void Main(string[] args) {
            // #1. 함수 이용해, 구구단 작성하기
            Console.WriteLine("#1. 함수를 이용해, 구구단 작성하기");
            Console.Write("[!] 1~9 사이의 정수를 입력해주세요 >> ");
            string temp1 = Console.ReadLine();
            int temp2 = int.Parse(temp1);
            AkdongRabbit.GooGooDan(temp2);

            // #2. 팩토리얼 계산하기
            Console.WriteLine("\n#2. 팩토리얼 계산하기");
            Console.Write("[!] 과도하게 크지 않은 정수를 입력해주세요 >> ");
            temp1 = Console.ReadLine();
            temp2 = int.Parse(temp1);
            AkdongRabbit.factorial(temp2);

            //3. 성적을 나타내는 구조체 작성
            Console.WriteLine("\n#3. 성적을 나타내는 구조체 작성");
            StudentScore Rabbit = new StudentScore("악동분홍토끼", 100);
            Rabbit.PrintStudentInfo();

            // Program exit
            Console.WriteLine("\n\n[?] Press any key to exit... ");
            Console.ReadKey();
            return;
        }
    }
}