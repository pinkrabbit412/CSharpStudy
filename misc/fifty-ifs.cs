using System;

namespace Assignment_AppSW_1 {
    public class GetInput {
        //This is class that makes value input easily.
        public static int GetInt32() {
            int result = 0;
            while (true) {
                Console.Write("  ▶ 정수 꼴의 값을 입력하세요 >> ");
                try {
                    result = Convert.ToInt32(Console.ReadLine());
                }
                catch {
                    Console.WriteLine("  [!] 입력이 올바르지 않습니다. 다시 입력하세요.\n");
                    continue;
                }
                break;
            }
            return result;
        }
        public static int GetInt32AsPositiveOnly() {
            int result = 0;
            while (true) {
                Console.Write("  ▶ 자연수 꼴의 값을 입력하세요 >> ");
                try {
                    result = Convert.ToInt32(Console.ReadLine());
                    if (result < 0) {
                        Console.WriteLine("  [!] 입력이 올바르지 않습니다. 다시 입력하세요.\n");
                        continue;
                    }
                }
                catch {
                    Console.WriteLine("  [!] 입력이 올바르지 않습니다. 다시 입력하세요.\n");
                    continue;
                }
                break;
            }
            return result;
        }
        public static double GetDouble() {
            double result = 0;
            while (true) {
                Console.Write("  ▶ 실수 꼴의 값을 입력하세요 >> ");
                try {
                    result = Convert.ToDouble(Console.ReadLine());
                }
                catch {
                    Console.WriteLine("  [!] 입력이 올바르지 않습니다. 다시 입력하세요.\n");
                    continue;
                }
                break;
            }
            return result;
        }
        public static string GetString() {
            string result = "";
            Console.Write("  ▶ 문자열 값을 입력하세요 >> ");
            result = Console.ReadLine();
            return result;
        }
    }
    public class FiftyIfs {
        public static void Main(string[] args) {
            START_OF_PROGRAM:
            // Common variable initialize
            int input_int = 0, input_int2 = 0, input_int3 = 0;
            double input_double = 0.0d, input_double2 = 0.0d;
            string input_string = "", input_string2 = "";
            
            // #01. 값을 입력받아, 0~100 사이의 값인지 확인
            Console.WriteLine("[ #1. 입력한 정수값이 0 이상 100 이하의 값인지를 알려줍니다. ]");
            input_int = GetInput.GetInt32();
            if (input_int > 100 || input_int < 0)
                Console.WriteLine("  입력한 값은 {0}이며, 이는 지정된 범위 안의 값이 아닙니다.", input_int);
            else
                Console.WriteLine("  입력한 값은 {0}이며, 이는 지정된 범위 안의 값입니다!", input_int);

            // #02. 값을 입력받아, 3의 배수인지를 확인
            Console.WriteLine("\n\n[ #2. 입력한 정수값이 3의 배수인지의 여부를 알려줍니다. ]");
            input_int = GetInput.GetInt32AsPositiveOnly();
            if ((input_int % 3) == 0)
                Console.WriteLine("  입력한 값은 {0}이며, 이는 3의 배수입니다.", input_int);  // 0도 n의 배수이기 때문.
            else
                Console.WriteLine("  입력한 값은 {0}이며, 이는 3의 배수가 아닙니다!", input_int);
            
            // #03. 현재 시간을 확인하고, 정오 이후인지를 확인
            Console.WriteLine("\n\n[ #3. 현재 컴퓨터 시간이 정오 이후인지를 알려줍니다. ]");
            if (DateTime.Now.Hour >= 12)
                Console.WriteLine("  정오 이후입니다. (현재 시간: {0})", DateTime.Now.ToString("H시 mm분 ss초"));
            else
                Console.WriteLine("  정오 이전입니다. (현재 시간: {0})", DateTime.Now.ToString("H시 mm분 ss초"));
            
            // #04. 주어진 임의의 혈중알코올농도가 음주단속 대상인지 판단 (자료 출처: https://www.koroad.or.kr/kp_web/drunkDriveInfo4.do)
            Console.WriteLine("\n\n[ #4. 주어진 임의의 혈중알코올농도(0.05%)가 음주단속 대상인지 알려줍니다. ]");
            input_double = 0.05;
            if (input_double >= 0.08)
                Console.WriteLine("  [!] 혈중알코올농도가 매우 높습니다({0}%). 면허가 취소되며, 결격기간은 1년입니다.", input_double);
            else if (input_double >= 0.03)
                Console.WriteLine("  [!] 혈중알코올농도가 높습니다({0}%). 벌점 100점이 부과됩니다(면허정지 100일).", input_double);
            else
                Console.WriteLine("  [!] 혈중알코올농도 기준 이하입니다. 안전운전하세요.");
            
            // #05. 입력한 정수값이 412와 정확히 일치하는지 확인
            Console.WriteLine("\n\n[ #5. 입력한 정수값이 412와 정확히 일치하는지 알려줍니다. ]");
            input_int = GetInput.GetInt32AsPositiveOnly();
            if (input_int == 412)
                Console.WriteLine("  입력하신 값 {0} 은(는) 412와 정확히 일치합니다.", input_int);
            else
                Console.WriteLine("  입력하신 값 {0} 은(는) 412와 일치하지 않습니다.", input_int);
            
            // #06. 입력한 체온이 정상 범위인지 확인
            Console.WriteLine("\n\n[ #6. 입력한 체온이 정상 범위인지 확인해줍니다. ]");
            input_double = GetInput.GetDouble();
            if (input_double >= 38.5)
                Console.WriteLine("  [!] 체온이 매우 높습니다({0}℃).", input_double);
            else if (input_double >= 37.5)
                Console.WriteLine("  [!] 체온이 높습니다({0}℃).", input_double);
            else if (input_double >= 35.5)
                Console.WriteLine("  [!] 체온이 정상 범위입니다({0}℃).", input_double);
            else
                Console.WriteLine("  [!] 체온이 제대로 측정되지 않았거나 너무 낮습니다.", input_double);
            
            // #07. 입력한 ID가 목록에 있는지 확인 (다른 변수를 선언하게 되므로 메모리 최적화를 위해 블럭으로 묶음)
            Console.WriteLine("\n\n[ #7. 입력한 ID가 목록에 있는지 확인합니다. ]"); {
                string[] temp = { "pinkrabbit7", "pinkrabbit412", "YT_AkdongRabbit"};
                input_string = GetInput.GetString();
                if (Array.IndexOf(temp, input_string) == -1) // 배열에 값이 없는 경우
                    Console.WriteLine("  [!] 입력하신 ID는 존재하지 않습니다.");
                else
                    Console.WriteLine("  {0}님, 환영합니다.", input_string);
            }

            // #08. 정수값 두 개를 입력받아, 대소 비교하기 (다른 변수를 선언하게 되므로 메모리 최적화를 위해 블럭으로 묶음)
            Console.WriteLine("\n\n[ #8. 두 개의 정수값 대소관계를 비교합니다. ]");
            input_int = GetInput.GetInt32();
            input_int2 = GetInput.GetInt32();
            if (input_int > input_int2)
                Console.WriteLine("  - 처음에 입력한 수가 나중에 입력한 수보다 큽니다. ({0} > {1})", input_int, input_int2);
            else if (input_int < input_int2)
                Console.WriteLine("  - 처음에 입력한 수가 나중에 입력한 수보다 작습니다. ({0} < {1})", input_int, input_int2);
            else if (input_int == input_int2)
                Console.WriteLine("  - 처음에 입력한 수가 나중에 입력한 수와 같습니다. ({0} = {1})", input_int, input_int2);
            else
                Console.WriteLine("  [!] 예기치 못한 결과입니다. 대소 비교를 하지 못했습니다.");

            // #09. 특정 문자열 입력에 대해서만 반응하기
            Console.WriteLine("\n\n[ #9. (트위터/유튜브/깃허브) 중 하나의 값을 입력해보세요. ]");
            input_string = GetInput.GetString();
            if (input_string == "트위터")
                Console.WriteLine("  Twitter: @pinkrabbit412 - https://twitter.com/pinkrabbit412");
            else if (input_string == "유튜브")
                Console.WriteLine("  YouTube: 악동분홍토끼 AkdongRabbit - https://www.youtube.com/channel/UCO8cYD3Gpey5SfpDZ70nWeQ");
            else if (input_string == "깃허브")
                Console.WriteLine("  GitHub: @pinkrabbit412 - https://github.com/pinkrabbit412");
            else
                Console.WriteLine("  [!] 목록에 없는 값입니다.");

            // #10. 입력받은 값을 412로 나누어 나온 나머지를 계산하고, 동시에 이 수가 7의 배수인지 확인
            Console.WriteLine("\n\n[ #10. 입력한 값을 412로 나눈 나머지를 계산하고, 동시에 이 나머지가 7의 배수인지 확인합니다. ]");
            input_int = GetInput.GetInt32();
            if ((input_int % 412) % 7 == 0)
                Console.WriteLine("  - {0} = {1} × 412 + {2}이며, {2}은(는) 7의 배수입니다!", input_int, (input_int/412), (input_int % 412));
            else
                Console.WriteLine("  - {0} = {1} × 412 + {2}이며, {2}은(는) 7의 배수가 아닙니다.", input_int, (input_int / 412), (input_int % 412));

            // #11. 두 수의 차 구하기
            Console.WriteLine("\n\n[ #11. 두 정수값의 차를 구합니다. ]");
            input_int = GetInput.GetInt32();
            input_int2 = GetInput.GetInt32();
            if (input_int >= input_int2)
                Console.WriteLine("  - {0}와(과) {1}의 차는 {2}입니다.", input_int, input_int2, (input_int - input_int2));
            else if (input_int < input_int2)
                Console.WriteLine("  - {0}와(과) {1}의 차는 {2}입니다.", input_int, input_int2, (input_int2 - input_int));

            // #12. 실수 꼴의 점수를 입력받고, 합격 및 불합격 판정하기
            Console.WriteLine("\n\n[ #12. 점수를 실수꼴로 입력받아, 합격 및 불합격을 판정합니다. (합격: 60.0점 이상)]");
            input_double = GetInput.GetDouble();
            if (input_double >= 60)
                Console.WriteLine("  - 축하합니다, {0}점으로 '합격'하셨습니다.", input_double);
            else
                Console.WriteLine("  - 안타깝습니다. {0}점으로 '불합격'하셨습니다.", input_double);

            // #13. 하나의 정수를 입력받고, 홀수인지 짝수인지 판정하기
            Console.WriteLine("\n\n[ #13. 입력한 정수값이 홀수인지, 짝수인지를 알려줍니다. ]");
            input_int = GetInput.GetInt32();
            if ((input_int % 2) == 0)
                Console.WriteLine("  입력한 값은 {0}이며, 짝수입니다.", input_int);
            else
                Console.WriteLine("  입력한 값은 {0}이며, 홀수입니다.", input_int);

            // #14. 퀴즈 두 개 연속으로 맞추게 하기
            Console.WriteLine("\n\n[ #14. 퀴즈 2개를 연속으로 맞춰봅시다! (다른 값 입력 시, 넘어가집니다) ]");
            Console.WriteLine("  [?] Q1) 2 + 4는 6이다. (O/X)");
            input_string = GetInput.GetString();
            if(input_string == "O" || input_string == "o") {
                Console.WriteLine("  [!] 정답입니다.");
                Console.WriteLine("  \n[?] Q2) 대한민국 형법 제111조에 따르면, 사전죄의 기수범은 1년 이상의 징역에 처한다. (O/X)");
                input_string = GetInput.GetString();
                if (input_string == "X" || input_string == "x") {
                    Console.WriteLine("  [!] 2문제 모두 정답입니다. 축하드립니다!");
                }
                else if (input_string == "O" || input_string == "o")
                    Console.WriteLine("  [!] 틀렸습니다. 사전죄의 법정형량은 '1년 이상의 유기금고'입니다.");
                else
                    Console.WriteLine("  [!] 올바른 입력이 아닙니다. 오답으로 처리합니다.");
            }
            else if (input_string == "X" || input_string == "x")
                Console.WriteLine("  [!] 틀렸습니다. 2 + 4 = 6입니다.");
            else
                Console.WriteLine("  [!] 올바른 입력이 아닙니다. 오답으로 처리합니다.");

            // #15. 실수의 절댓값 계산하기
            Console.WriteLine("\n\n[ #15. 실수의 절댓값 계산해보기! ]");
            input_double = GetInput.GetDouble();
            if (input_double < 0)
                Console.WriteLine("  - 입력한 수({0})의 절댓값 계산 결과는 다음과 같음: {1}", input_double, (input_double * (-1)));
            else
                Console.WriteLine("  - 입력한 수({0})의 절댓값 계산 결과는 다음과 같음: {0}", input_double);

            // #16. 이세돌 멤버 맞추기
            Console.WriteLine("\n\n[ #16. 이세돌(이세계 아이돌) 멤버 중 한 명만 입력해보세요! (다른 값 입력 시, 넘어가집니다) ]");
            input_string = GetInput.GetString();
            if (input_string == "주르르")
                Console.WriteLine("  - \"어딜 입력하시는거에욧! 참을 수 없어욧!!\"");
            else if (input_string == "징버거")
                Console.WriteLine("  - \"띠용띠용 워익워익~\"");
            else if (input_string == "비챤")
                Console.WriteLine("  - \"(대충 고라니 우는 소리)\"");
            else if (input_string == "고세구")
                Console.WriteLine("  - \"고양이가 세상을 구한다!\"");
            else if (input_string == "릴파")
                Console.WriteLine("  - \"700\"");
            else if (input_string == "아이네")
                Console.WriteLine("  - \"반갑따네~\"");

            // #17. 원단위 절사하기
            Console.WriteLine("\n\n[ #17. 입력받은 정수꼴 형태의 액수에서, 원단위를 절사합니다! (음수값 입력 불가능) ]");
            input_int = GetInput.GetInt32AsPositiveOnly();
            if (input_int % 10 != 0)
                Console.WriteLine("  - 입력받은 금액에서 원단위 절사한 결과는 다음과 같음: {0:#,0}KRW", (input_int - (input_int % 10)));
            else
                Console.WriteLine("  - 입력받은 금액에서 원단위 절사한 결과는 다음과 같음: {0:#,0}KRW", input_int);

            // #18. 종료할때까지 값 계속 더하기
            Console.WriteLine("\n\n[ #18. 0을 입력할때까지, 입력한 정수를 모두 더합니다! ]");
            input_int2 = 0;
            while (true) {
                input_int = GetInput.GetInt32();
                if (input_int == 0)
                    break;
                input_int2 += input_int;
            }
            Console.WriteLine("  - 입력하신 정수를 모두 더한 결과는 다음과 같습니다: {0}", input_int2);

            // #19. 입력한 자연수를 그대로 출력하지만, 100 미만의 수는 출력하지 않음
            Console.WriteLine("\n\n[ #19. 자연수를 입력해보세요! (단, 100 미만인 수는 출력되지 않습니다) ]");
            input_int = GetInput.GetInt32AsPositiveOnly();
            if (input_int < 100)
                Console.WriteLine("  [!] 값을 정상적으로 입력받았습니다.");
            else
                Console.WriteLine("  [!] 값 {0}을(를) 정상적으로 입력받았습니다.", input_int);

            // #20. 에~ 오~
            Console.WriteLine("\n\n[ #20. 에~ 오~ ]");
            input_string = GetInput.GetString();
            if (input_string == "에~ 오~")
                Console.WriteLine("  - ALL RIGHT!");

            // #21. 몬스터 에너지 울트라(355ml) 는 몇 kcal일까요?
            Console.WriteLine("\n\n[ #21. 몬스터 에너지 울트라(355ml) 는 몇 kcal일까요? ]");
            input_int = GetInput.GetInt32AsPositiveOnly();
            if (input_int == 14)
                Console.WriteLine("  [!] 정답입니다.");
            else
                Console.WriteLine("  [!] 틀렸습니다. 몬스터 에너지 울트라(355ml) 는 14kcal입니다.");

            // #22. 시공의 폭풍은?
            Console.WriteLine("\n\n[ #22. 다음 문장의 빈 칸을 채워주세요. (띄어쓰기 포함) ]");
            Console.WriteLine("  - 시공의 폭풍은 □□ □□□!");
            input_string = GetInput.GetString();
            if (input_string == "정말 최고야")
                Console.WriteLine("  - 어후... 그건 좀......;");
            else
                Console.WriteLine("  [!] 틀렸습니다.");

            // #23. 문자열 길이가 일정 길이 이하면 꼬리말을 붙임
            Console.WriteLine("\n\n[ #23. 문자열의 Length가 10 미만인 문자열에 \", Arrr...\" 를 붙입니다! ]");
            input_string = GetInput.GetString();
            if (input_string.Length < 10)
                Console.WriteLine("  [?] {0}, Arrr...", input_string);
            else
                Console.WriteLine("  [?] {0}", input_string);

            // #24. 섭씨-화씨 변환하기
            Console.WriteLine("\n\n[ #24. 섭씨-화씨 변경하기 ]");
            Console.WriteLine("  1. 변환할 온도값을 입력해주세요.");
            input_int = GetInput.GetInt32();
            while (true) {
                Console.WriteLine("  2. 어떤 단위로 변환할지를 입력해주세요. (섭씨로 변환: C, 화씨로 변환: F)");
                input_string = GetInput.GetString();
                if (input_string == "C" || input_string == "c") {
                    Console.WriteLine("  - 변환 결과: {0}℉ → {1}℃", input_int, ((input_int - 32) / 1.8));
                    break;
                }
                else if (input_string == "F" || input_string == "f") {
                    Console.WriteLine("  - 변환 결과: {0}℃ → {1}℉", input_int, ((input_int * 1.8) + 32));
                    break;
                }
                else
                    Console.WriteLine("  [!] 입력이 올바르지 않습니다. 다시 입력하세요.\n");
                }

            // #25. 더 크게!
            Console.WriteLine("\n\n[ #25. 아무 문장이나 입력해보세요! ]");
            input_string = GetInput.GetString();
            if (input_string.EndsWith("!!!!!")) {
                Console.WriteLine("  - 아이고 귀때거라; 소리 좀 줄여드렸습니다...^^");
                Console.WriteLine("  - {0}", input_string.Remove(input_string.Length - 6, 5));
            }
            else
                Console.WriteLine("  - 더 크게!\n  - {0}", (input_string + "!!!!!!!!!!"));
            
            // #26. 혹시... 민트초코 좋아하시나요?
            Console.WriteLine("\n\n[ #26. 혹시... 민트초코 좋아하시나요? (Y/N) ]");
            input_string = GetInput.GetString();
            if (input_string == "Y" || input_string == "y")
                Console.WriteLine("  - 으엑ㄱ 차라리 치약을 물에 풀어먹겠다; (농담입니다");
            else
                Console.WriteLine("  - 역시ㅋㅋ 민트초코는 좀 아니죠^^7");

            // #27. 아 언제끝나 이거;
            Console.WriteLine("\n\n[ #27. 솔직히 지금 채점 힘드시죠...? ㅋㅋㅋㅋㅋㅋㅋ ]");
            if (true)
                Console.WriteLine("  - 저도 이해합니다...^^ 다음에는 교수님이 25개 정도만 내주시기를ㄹ......");

            // #28. 이메일 만들기
            Console.WriteLine("\n\n[ #28. ID와 사이트를 선택하면 메일주소를 알 수 있습니다! ]");
            Console.WriteLine("  1. ID를 입력해주세요!");
            input_string = GetInput.GetString();
            while (true) {
                Console.WriteLine("  2. 사이트를 선택해주세요! (1: 구글, 2: 네이버, 3. 다음)");
                input_int = GetInput.GetInt32();
                if (input_int == 1) {
                    Console.WriteLine("  - 이메일 주소: {0}@{1}", input_string, "gmail.com");
                    break;
                }
                else if (input_int == 2) {
                    Console.WriteLine("  - 이메일 주소: {0}@{1}", input_string, "naver.com");
                    break;
                }
                else if (input_int == 3) {
                    Console.WriteLine("  - 이메일 주소: {0}@{1}", input_string, "daum.net");
                    break;
                }
                else
                    Console.WriteLine("  [!] 입력이 올바르지 않습니다. 다시 입력하세요.\n");
            }

            // #29. 있었는데요, 없었습니다
            Console.WriteLine("\n\n[ #29. 있었는데요, 없었습니다 ]");
            if (false)
                Console.WriteLine("여기 줄은 (윗 줄을 변경하지 않는 이상) 절대 실행 안되거든요 ^^*");

            // #30. 입력한 수의 모든 자릿수 더하기 (다른 변수를 선언하게 되므로 메모리 최적화를 위해 블럭으로 묶음)
                Console.WriteLine("\n\n[ #30. 입력한 수의 모든 자릿수 더하기! (int 범위 내에서만 입력할 수 있음에 유의)]");
                input_int = GetInput.GetInt32();
                input_int2 = 0;
                while (input_int > 0.9) {
                    input_int2 += (input_int % 10);
                    input_int /= 10;
                }
                Console.WriteLine("  [?] 계산 결과: {0}", input_int2);

            // #31. 택시비 계산하기! (https://news.seoul.go.kr/traffic/archives/1659, 2022-03-21 기준)
            Console.WriteLine("\n\n[ #31. 택시비 계산하기! (단, 주행시간은 고려하지 않습니다) ]");
            Console.WriteLine("  1. 주행거리를 입력해주세요! (단위: m)");
            input_int = GetInput.GetInt32AsPositiveOnly();
            if (input_int <= 2000)
                Console.WriteLine("  - 택시비 계산 결과: 3,800KRW");
            else {
                input_int2 = 3800 + (((input_int - 2000) / 132) * 100);
                if ((input_int - 2000) % 132 != 0)
                    input_int2 += 100;
                Console.WriteLine("  - 택시비 계산 결과: {0}KRW", input_int2);
            }

            // #32. 노래 추천하기!
            Console.WriteLine("\n\n[ #32. 노래 추천 (1: 고전 명곡 팝송 / 2: 이세돌 노래 / 3: 한국 가곡) ]");
            while (true) {
                input_int = GetInput.GetInt32AsPositiveOnly();
                if (input_int == 1) {
                    Console.WriteLine("  - 다음 노래를 재생합니다: Sting - Shape of My Heart");
                    System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=NlwIDxCjL-8");
                    break;
                }
                else if (input_int == 2) {
                    Console.WriteLine("  - 다음 노래를 재생합니다: 이세계 아이돌 (ISEGYE IDOL) - RE : WIND");
                    System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=jelNkU4mPuA");
                    break;
                }
                else if (input_int == 3) {
                    Console.WriteLine("  - 다음 노래를 재생합니다: 김효근 - 눈 (by 박흥우 바리톤)");
                    System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=El07N59fTD8");
                    break;
                }
                else
                    Console.WriteLine("  [!] 입력이 올바르지 않습니다. 다시 입력하세요.\n");
            }

            // #33. 배터리 수준을 실수로 입력받아, 경고문 출력하기
            Console.WriteLine("\n\n[ #33. 실수값으로 입력받은 배터리 수준(0~100)에 따라, 알맞은 경고문 출력하기 ]");
            input_double = GetInput.GetDouble();
            if (input_double > 100)
                Console.WriteLine("  [!] 배터리 과충전 상태입니다! ({0:0.00}%)", input_double);
            else if (input_double > 15)
                Console.WriteLine("  - 배터리가 충분합니다. 현재 잔여량은 {0:0.00}%입니다.", input_double);
            else if (input_double > 5)
                Console.WriteLine("  [!] 충전이 필요합니다. 현재 잔여량은 {0:0.00}%입니다.", input_double);
            else if (input_double > 0)
                Console.WriteLine("  [!] 기기가 곧 꺼집니다! 현재 잔여량은 {0:0.00}%입니다.", input_double);
            else
                Console.WriteLine("  [!] 기기의 배터리가 없습니다.");

            // #34. 교통카드 결제 시스템
            Console.WriteLine("\n\n[ #34. 교통카드로 10,000KRW 결제하기 ]");
            Console.WriteLine("  - 새 교통카드에 충전할 금액을 입력해주세요.");
            input_int = GetInput.GetInt32AsPositiveOnly();
            if ((input_int - 10000) < 0)
                Console.WriteLine("  [!] 잔액이 부족합니다. 결제에 실패했습니다.");
            else {
                input_int -= 10000;
                Console.WriteLine("  [!] 결제에 성공했습니다! 잔액은 {0}원 입니다.", input_int);
            }

            // #35. 월요일에 실행하면, 스펀지밥의 월요송을 재생해줍니다.
            Console.WriteLine("\n\n[ #35. 월요일에 실행하면, 스펀지밥의 월요송을 재생해줍니다. ]");
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday) {
                Console.WriteLine("  - 다음 노래를 재생합니다: 스폰지밥 - 월요송");
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=41AJA6Rrwjg");
            }
            else
                Console.WriteLine("  - 월요일이 아니네요, 건너뛰겠습니다.");

            // #36. 수축기/이완기 혈압 입력받아 저혈압/정상/고혈압 판정하기
            Console.WriteLine("\n\n[ #36. 수축기/이완기 혈압 입력받아 저혈압/정상/고혈압 판정하기! ]");
            Console.WriteLine("  1. 수축기 혈압(더 높은 수치)을 입력하세요. (단위: mmHg)");
            input_int = GetInput.GetInt32AsPositiveOnly();
            Console.WriteLine("  2. 이완기 혈압(더 낮은 수치)을 입력하세요. (단위: mmHg)");
            input_int2 = GetInput.GetInt32AsPositiveOnly();
            if (input_int >= 160 || input_int2 >= 100)
                Console.WriteLine("  [!] 2기 고혈압(160mmHg/100mmHg 이상)에 해당됩니다. 의사와 상담하세요.");
            else if (input_int >= 140 || input_int2 >= 90)
                Console.WriteLine("  [!] 1기 고혈압(140~159mmHg/90~99mmHg)에 해당됩니다. 건강관리에 각별히 유의해주세요.");
            else if (input_int >= 120 || input_int2 >= 80)
                Console.WriteLine("  [!] 고혈압 전단계(120~139mmHg/80~89mmHg)에 해당됩니다. 건강관리에 유의해주세요.");
            else if (input_int >= 90 || input_int2 >= 60)
                Console.WriteLine("  [!] 정상 혈압(90~119mmHg/60~79mmHg)입니다.");
            else
                Console.WriteLine("  [!] 저혈압(90mmHg/60mmHg 미만)입니다. 의사와 상담하세요.");

            // #37. 정수를 입력받고, 그 값이 100 이상인지 확인
            Console.WriteLine("\n\n[ #37. 정수를 입력받고, 그 값이 100 이상인지 확인 ]");
            input_int = GetInput.GetInt32();
            if (input_int >= 100)
                Console.WriteLine("  - 입력하신 수 {0}은(는) 100보다 크거나 같습니다.", input_int);
            else
                Console.WriteLine("  - 입력하신 수 {0}은(는) 100보다 작습니다.", input_int);

            // #38. 두 실수를 입력받아, 더 큰 수 구하기
            Console.WriteLine("\n\n[ #38. 두 실수를 입력받아, 대소를 비교합니다. ]");
            input_double = GetInput.GetDouble();
            input_double2 = GetInput.GetDouble();
            if (input_double > input_double2)
                Console.WriteLine("  - 처음에 입력한 수 {0}이(가) {1}보다 큽니다.", input_double, input_double2);
            else if (input_double < input_double2)
                Console.WriteLine("  - 처음에 입력한 수 {0}이(가) {1}보다 작습니다.", input_double, input_double2);
            else if (input_double == input_double2)
                Console.WriteLine("  -  처음에 입력한 수 {0}이(가) {1}와(과) 같습니다.", input_double, input_double2);
            else
                Console.WriteLine("  [!] 예기치 못한 결과입니다. 대소 비교를 하지 못했습니다.");

            // #39. CPU 온도를 실수 형태로 입력받아, 온도가 정상 범위인지 판정하기
            Console.WriteLine("\n\n[ #39. CPU 온도를 실수 형태로 입력받아, 온도가 정상 범위인지 판정합니다. (단위: ℃) ]");
            input_double = GetInput.GetDouble();
            if (input_double >= 90)
                Console.WriteLine("  [!] CPU 온도가 높습니다! (현재 온도: {0}℃)", input_double);
            else
                Console.WriteLine("  - CPU 온도가 정상 범위입니다. (현재 온도: {0}℃)", input_double);

            // #40. 긴급전화 전화번호 띄우기
            Console.WriteLine("\n\n[ #40. 긴급신고 전화번호 띄우기 (경찰/소방/간첩) ]");
            while (true) {
                input_string = GetInput.GetString();
                if (input_string == "경찰") {
                    Console.WriteLine("  - 경찰서 긴급신고 전화번호는 국번없이 112 입니다.");
                    break;
                }
                else if (input_string == "소방") {
                    Console.WriteLine("  - 소방서 긴급신고 전화번호는 국번없이 119 입니다.");
                    break;
                }
                else if (input_string == "간첩") {
                    Console.WriteLine("  - 국정원 간첩신고 전화번호는 국번없이 111 입니다.");
                    break;
                }
                else
                    Console.WriteLine("  [!] 입력이 올바르지 않습니다. ");
            }

            // #41. 입력한 글자가 5자 이하면, 해당 글자를 5번 반복해 출력
            Console.WriteLine("\n\n[ #41. 입력한 글자가 5자 이하면, 해당 글자를 3번 반복해 출력합니다. ]");
            input_string = GetInput.GetString();
            if (input_string.Length <= 5) {
                Console.Write(input_string);
                Console.Write(input_string);
                Console.Write(input_string);
            }
            else
                Console.Write(input_string);

            // #42. 정수 세 개 입력받아, 가장 큰 값 출력하기
            Console.WriteLine("\n\n[ #42. 정수 세 개를 입력받아, 가장 큰 값을 출력합니다. ]");
            input_int = GetInput.GetInt32();
            input_int2 = GetInput.GetInt32();
            input_int3 = GetInput.GetInt32();
            if (input_int >= input_int2) {
                if (input_int >= input_int3)
                    Console.WriteLine("  - 입력받은 정수({0}, {1}, {2}) 셋 중 가장 큰 값은 {0} 입니다.", input_int, input_int2, input_int3);
                else
                    Console.WriteLine("  - 입력받은 정수({0}, {1}, {2}) 셋 중 가장 큰 값은 {2} 입니다.", input_int, input_int2, input_int3);
            }
            else {
                if (input_int2 >= input_int3)
                    Console.WriteLine("  - 입력받은 정수({0}, {1}, {2}) 셋 중 가장 큰 값은 {1} 입니다.", input_int, input_int2, input_int3);
                else
                    Console.WriteLine("  - 입력받은 정수({0}, {1}, {2}) 셋 중 가장 큰 값은 {2} 입니다.", input_int, input_int2, input_int3);
            }

            // #43. 입력한 값에서 5를 빼되, 0 미만의 값이 되지 않게 하기
            Console.WriteLine("\n\n[ #43. 입력한 값에서 5를 빼되, 0 미만의 값이 되지 않게 합니다. ]");
            input_int = GetInput.GetInt32AsPositiveOnly();
            for (int i = 0; i < 5; i++) {
                if (input_int == 0)
                    break;
                input_int--;
            }
            Console.WriteLine("  - 계산 결과는 다음과 같습니다: {0}", input_int);

            // #44. n의 n승을 구하되, n을 5 이하의 자연수로 제한
            Console.WriteLine("\n\n[ #44. 입력한 값을 n이라 할 때, n^n을 계산합니다. (단, n은 5 이하의 자연수) ]");
            input_int = GetInput.GetInt32AsPositiveOnly();
            if (input_int > 5) {
                Console.WriteLine("  [!] 계산량이 많습니다. 계산할 수 없습니다...");
            }
            else
                Console.WriteLine("  - 계산 결과: {0}", Math.Pow(input_int, input_int));

            // #45. 문장 뒤집기! (단, 한 글자 이하의 문장은 무시)
            Console.WriteLine("\n\n[ #45. 문장 뒤집기! (단, 한 글자 이하의 문장은 무시합니다.) ]");
            input_string = GetInput.GetString();
            if(input_string.Length >= 2) {
                char[] temp_array = input_string.ToCharArray();
                Array.Reverse(temp_array);
                input_string = new string(temp_array);
            }
            Console.WriteLine("  - 결과: {0}", input_string);
            

            // #46. 양의 실수는 음의 실수로, 음의 실수는 10으로 나눈 값으로 출력하기
            Console.WriteLine("\n\n[ #46. 양의 실수는 음의 실수로, 음의 실수는 10으로 나눈 값으로 출력하기 ]");
            input_double = GetInput.GetDouble();
            if (input_double >= 0)
                Console.WriteLine("  - 결과: {0}", (input_double * (-1)));
            else
                Console.WriteLine("  - 결과: {0}", input_double / 10);

            // #47. 음의 정수만 입력받기
            Console.WriteLine("\n\n[ #47. 음의 정수만 입력받기 ]");
            while (true) {
                input_int = GetInput.GetInt32();
                if (input_int >= 0)
                    Console.WriteLine("  [!] 0보다 작은 수로 다시 입력하세요.\n");
                else {
                    Console.WriteLine("  - 값을 정상적으로 입력받았습니다. 입력한 값: {0}", input_int);
                    break;
                }
            }

            // #48. 분 단위의 값을 입력하면, 몇시간 몇분꼴로 바꿔 표시하기
            Console.WriteLine("\n\n[ #48. 분 단위의 값을 입력하면, 몇시간 몇분꼴로 바꿔 표시하기 ]");
            input_int = GetInput.GetInt32AsPositiveOnly();
            input_int2 = 0;
            while (true) {
                if ((input_int / 60) > 0) {
                    input_int2++;
                    input_int -= 60;
                }
                else
                    break;
            }
            Console.WriteLine("  - 변환 결과: {0}시간 {1}분", input_int2, input_int);

            // #49. 으악 드디어 거의 끝났다ㅠㅠ
            Console.WriteLine("\n\n[ #49. 거의 끝났습니다! ]");
            Console.WriteLine("[?] 채점자분 고생하셨습니다! 응원 메세지를 받고 싶으신가요? (Y/N)");
            input_string = GetInput.GetString();
            if (input_string == "Y" || input_string == "y")
                Console.WriteLine("  - 여태까지 채점하느라 고생 많이 하셨습니다, 좋은 하루 보내세요!!");
            else if (input_string == "N" || input_string == "n")
                Console.WriteLine("  - ...");
            else
                Console.WriteLine("  [!] 올바르지 않은 입력입니다! 따로 결과를 출력하지 않겠습니다.");

            // #50. Program exit
            Console.WriteLine("\n\n[ #50. 프로그램을 종료하시겠습니까? (Y: 종료 / N: 처음부터 재실행) ]");
            while (true) {
                Console.Write("키 누르기 (Y/N) >> ");
                ConsoleKeyInfo input_key = Console.ReadKey();
                if (input_key.KeyChar == 'Y' || input_key.KeyChar == 'y') {
                    Console.WriteLine("\n\n[?] Press any key to exit... ");
                    Console.ReadKey();
                    return;
                }
                else if (input_key.KeyChar == 'N' || input_key.KeyChar == 'n') {
                    Console.Clear();
                    goto START_OF_PROGRAM;
                }
                else
                    Console.WriteLine("\n\n[!] 입력이 올바르지 않습니다. 다시 입력하세요.");
            }
        }
    }
}